using ASP_site.Data;
using ASP_site.Helpers;
using ASP_site.Models;
using ASP_site.Pages.Genres;
using ASP_site.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.Extensions.FileProviders;

namespace ASP_site.Tests
{
    public class GenreHubTests : IClassFixture<SeedFixture>
    {
        private readonly GameContext _context;

        public GenreHubTests(SeedFixture fixture)
        {
            _context = fixture.Context;
        }

        [Fact]
        public void HasEssay_IsTrueForFighting()
        {
            Assert.True(GenreHub.HasEssay(Genre.Fighting));
            Assert.False(GenreHub.HasEssay(Genre.FPS));
            Assert.False(GenreHub.HasEssay(null));
        }

        [Fact]
        public async Task GenrePage_LoadsFightingEssayAndCatalog()
        {
            var page = CreatePage();
            var result = await page.OnGetAsync("Fighting");

            Assert.IsType<PageResult>(result);
            Assert.Equal(Genre.Fighting, page.Genre);
            Assert.Equal("Fighting Games", page.DisplayName);
            Assert.False(string.IsNullOrWhiteSpace(page.MarkdownHtml));
            Assert.Contains("/Games/sf2ww", page.MarkdownHtml);
            Assert.Contains(page.Games, g => g.GameID == "sf2ww");
            Assert.Contains(page.Games, g => g.GameID == "jojo");
            Assert.True(page.Games.Count >= 20, $"Expected a fighting catalog, found {page.Games.Count}");
        }

        [Fact]
        public async Task GenrePage_UnknownGenre_ReturnsNotFound()
        {
            var page = CreatePage();
            var result = await page.OnGetAsync("NotAGenre");
            Assert.IsType<NotFoundResult>(result);
        }

        private GenreModel CreatePage()
        {
            return new GenreModel(_context, TestWebHost.FromRepo(), new MarkdownService())
            {
                PageContext = new PageContext
                {
                    ViewData = new ViewDataDictionary(new EmptyModelMetadataProvider(), new ModelStateDictionary())
                }
            };
        }

        private sealed class TestWebHost : IWebHostEnvironment
        {
            public static TestWebHost FromRepo()
            {
                var dir = new DirectoryInfo(AppContext.BaseDirectory);
                while (dir != null)
                {
                    var wwwroot = Path.Combine(dir.FullName, "wwwroot");
                    if (Directory.Exists(wwwroot) && File.Exists(Path.Combine(dir.FullName, "ASP-site.csproj")))
                    {
                        return new TestWebHost(wwwroot, dir.FullName);
                    }
                    dir = dir.Parent;
                }

                throw new DirectoryNotFoundException("Could not locate wwwroot from " + AppContext.BaseDirectory);
            }

            private TestWebHost(string webRootPath, string contentRootPath)
            {
                WebRootPath = webRootPath;
                ContentRootPath = contentRootPath;
                EnvironmentName = "Test";
                ApplicationName = "ASP-site";
                WebRootFileProvider = new NullFileProvider();
                ContentRootFileProvider = new NullFileProvider();
            }

            public string WebRootPath { get; set; }
            public IFileProvider WebRootFileProvider { get; set; }
            public string EnvironmentName { get; set; }
            public string ApplicationName { get; set; }
            public string ContentRootPath { get; set; }
            public IFileProvider ContentRootFileProvider { get; set; }
        }
    }
}
