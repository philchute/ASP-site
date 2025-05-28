using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using System; // Required for TimeSpan, HashSet

namespace ASP_site.GameServerListCommon.Services
{
    // Models for deserializing the blacklist JSON
    // These can be moved to a separate file if desired, e.g., BlacklistModels.cs
    internal class BlacklistEntry
    {
        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("reason")]
        public string? Reason { get; set; }

        [JsonProperty("ip")]
        public List<string>? IpAddresses { get; set; }
    }

    internal class BlacklistRoot
    {
        [JsonProperty("list")]
        public List<BlacklistEntry>? List { get; set; }
    }

    public interface IServerBlacklistService
    {
        Task<HashSet<string>> GetBlacklistedIpsAsync();
    }

    public class ServerBlacklistService : IServerBlacklistService
    {
        private readonly HttpClient _httpClient;
        private readonly IMemoryCache _cache;
        private readonly ILogger<ServerBlacklistService> _logger;
        private const string BlacklistCacheKey = "ServerIpBlacklist";
        private const string BlacklistUrl = "https://raw.githubusercontent.com/Ch0wW/goldsrc-fake-servers-firewall/main/blacklisted_iplist.json";
        private readonly TimeSpan _cacheDuration = TimeSpan.FromHours(6); // How long to cache the blacklist
        private readonly TimeSpan _failedFetchRetryDelay = TimeSpan.FromMinutes(15); // How long to wait before retrying after a failed fetch

        public ServerBlacklistService(IHttpClientFactory httpClientFactory, IMemoryCache memoryCache, ILogger<ServerBlacklistService> logger)
        {
            _httpClient = httpClientFactory.CreateClient("BlacklistFetcher");
            _cache = memoryCache;
            _logger = logger;
        }

        public async Task<HashSet<string>> GetBlacklistedIpsAsync()
        {
            return await _cache.GetOrCreateAsync(BlacklistCacheKey, async entry =>
            {
                _logger.LogInformation("Fetching updated server IP blacklist from {BlacklistUrl}", BlacklistUrl);
                var blacklistedIps = new HashSet<string>();
                try
                {
                    var responseString = await _httpClient.GetStringAsync(BlacklistUrl);
                    var blacklistData = JsonConvert.DeserializeObject<BlacklistRoot>(responseString);

                    if (blacklistData?.List != null)
                    {
                        foreach (var item in blacklistData.List)
                        {
                            if (item.IpAddresses != null)
                            {
                                foreach (var ip in item.IpAddresses)
                                {
                                    if (!string.IsNullOrWhiteSpace(ip))
                                    {
                                        blacklistedIps.Add(ip.Trim());
                                    }
                                }
                            }
                        }
                        _logger.LogInformation("Successfully fetched and parsed blacklist. Found {Count} unique IPs.", blacklistedIps.Count);
                        entry.AbsoluteExpirationRelativeToNow = _cacheDuration;
                    }
                    else
                    {
                        _logger.LogWarning("Parsed blacklist data from {BlacklistUrl} was null or empty. Blacklist will be empty.", BlacklistUrl);
                        entry.AbsoluteExpirationRelativeToNow = _failedFetchRetryDelay; // Retry sooner
                    }
                }
                catch (HttpRequestException ex)
                {
                    _logger.LogError(ex, "HTTP error fetching blacklist from {BlacklistUrl}. Blacklist will be empty.", BlacklistUrl);
                    entry.AbsoluteExpirationRelativeToNow = _failedFetchRetryDelay; // Retry sooner
                }
                catch (JsonException ex)
                {
                    _logger.LogError(ex, "JSON error parsing blacklist from {BlacklistUrl}. Blacklist will be empty.", BlacklistUrl);
                    entry.AbsoluteExpirationRelativeToNow = _failedFetchRetryDelay; // Retry sooner
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "Unexpected error fetching/parsing blacklist from {BlacklistUrl}. Blacklist will be empty.", BlacklistUrl);
                    entry.AbsoluteExpirationRelativeToNow = _failedFetchRetryDelay; // Retry sooner
                }
                return blacklistedIps;
            }) ?? new HashSet<string>(); // Ensure non-null return if GetOrCreateAsync returns null (though unlikely for non-nullable reference types)
        }
    }
} 