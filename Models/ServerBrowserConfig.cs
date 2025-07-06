using ASP_site.Models; // For MasterServerType enum

namespace ASP_site.Models
{
    public class ServerBrowserConfig
    {
        // Corresponds to 'icon' in games.json
        public string? IconPath { get; set; }

        // Corresponds to 'gamedir' in games.json
        public string? GameDirectory { get; set; }

        // Key to look up the master server in appsettings.json
        public string? MasterServerKey { get; set; }

        // Corresponds to 'noBackgroundService' in games.json
        public bool? NoBackgroundService { get; set; }

        // Corresponds to 'useDefinedServerList' logic, if you want to store it from games.json
        public bool? UseDefinedServerList { get; set; } = false;

        // Corresponds to 'filters' in games.json for Steam API
        public string? ApiFilters { get; set; }

        // Protocol to use for querying individual servers (e.g., "A2S", "GameSpy")
        public string QueryProtocol { get; set; } = "A2S";

        // URL for a custom master server, used for non-Steam games
        public string? MasterServerUrl { get; set; }

        // Secret key for some master servers
        public string? SecretKey { get; set; }
    }
} 