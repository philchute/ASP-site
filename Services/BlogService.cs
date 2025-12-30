using ASP_site.Models;
using Microsoft.Extensions.Caching.Memory;
using System.Text.RegularExpressions;

namespace ASP_site.Services
{
    public class BlogService
    {
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly IMemoryCache _cache;
        private const string CacheKey = "BlogPosts";

        public BlogService(IWebHostEnvironment webHostEnvironment, IMemoryCache cache)
        {
            _webHostEnvironment = webHostEnvironment;
            _cache = cache;
        }

        public async Task<List<BlogPost>> GetPostsAsync()
        {
            if (!_cache.TryGetValue(CacheKey, out List<BlogPost>? posts))
            {
                posts = await LoadPostsFromDiskAsync();
                
                // Cache the results so we don't hit the disk on every request.
                // Expires after 1 hour, or you can restart the app to clear it.
                var cacheOptions = new MemoryCacheEntryOptions()
                    .SetAbsoluteExpiration(TimeSpan.FromHours(1));

                _cache.Set(CacheKey, posts, cacheOptions);
            }

            return posts ?? new List<BlogPost>();
        }

        public async Task<BlogPost?> GetPostAsync(string slug)
        {
            var posts = await GetPostsAsync();
            return posts.FirstOrDefault(p => p.Slug.Equals(slug, StringComparison.OrdinalIgnoreCase));
        }

        private async Task<List<BlogPost>> LoadPostsFromDiskAsync()
        {
            var blogPath = Path.Combine(_webHostEnvironment.WebRootPath, "markdown", "blog");
            if (!Directory.Exists(blogPath))
            {
                return new List<BlogPost>();
            }

            var posts = new List<BlogPost>();
            var files = Directory.GetFiles(blogPath, "*.md");

            foreach (var file in files)
            {
                var filename = Path.GetFileNameWithoutExtension(file);
                var content = await File.ReadAllTextAsync(file);
                
                var post = ParsePost(filename, content);
                if (post != null)
                {
                    posts.Add(post);
                }
            }

            return posts.OrderByDescending(p => p.Date).ToList();
        }

        private BlogPost? ParsePost(string filename, string rawContent)
        {
            // Simple Front Matter parser
            // Expects format:
            // ---
            // title: My Title
            // date: 2025-01-01
            // ---
            // Content...

            var match = Regex.Match(rawContent, @"^---\s*\r?\n(.*?)\r?\n---\s*\r?\n(.*)$", RegexOptions.Singleline);
            
            if (!match.Success)
            {
                // Fallback if no frontmatter: use filename as title, file creation time as date
                return new BlogPost
                {
                    Slug = filename,
                    Title = filename,
                    Date = DateTime.Now, 
                    Content = rawContent,
                };
            }

            var metadataBlock = match.Groups[1].Value;
            var body = match.Groups[2].Value;
            
            var title = ExtractValue(metadataBlock, "title") ?? filename;
            var dateString = ExtractValue(metadataBlock, "date");
            DateTime.TryParse(dateString, out var date);

            return new BlogPost
            {
                Slug = filename,
                Title = title,
                Date = date,
                Content = body,
            };
        }

        private string? ExtractValue(string metadata, string key)
        {
            var match = Regex.Match(metadata, $@"{key}:\s*(.*)", RegexOptions.IgnoreCase);
            return match.Success ? match.Groups[1].Value.Trim() : null;
        }

    }
}

