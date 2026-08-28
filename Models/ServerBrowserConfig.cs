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

        // Protocol to use for querying individual servers (e.g., "A2S", "GameSpy", "IdTech3")
        public string QueryProtocol { get; set; } = "A2S";

        // Comma-separated getservers query bodies: "84", "50,57,60", "0", or "Warsow 15".
        public string? MasterProtocols { get; set; }

        // Override when GameID does not match the master-server slug (prefer renaming GameID instead).
        public string? MasterGameName { get; set; }

        // URL for a custom master server, used for non-Steam games
        public string? MasterServerUrl { get; set; }

        // Secret key for some master servers
        public string? SecretKey { get; set; }

        public string GetMasterGameName(string gameId) =>
            string.IsNullOrWhiteSpace(MasterGameName) ? gameId : MasterGameName;

        public IEnumerable<string> GetMasterProtocolQueries()
        {
            if (string.IsNullOrWhiteSpace(MasterProtocols))
                return [];
            return MasterProtocols.Split(',', StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries);
        }

        public bool UsesThreeNetworks =>
            string.Equals(MasterServerKey, "333networks", StringComparison.OrdinalIgnoreCase);

        public bool UsesIdTech3 =>
            string.Equals(QueryProtocol, "IdTech3", StringComparison.OrdinalIgnoreCase);

        public bool UsesDefinedServerList => UseDefinedServerList == true;

        public bool UsesA2SMaster =>
            !UsesThreeNetworks && !UsesDefinedServerList && !UsesIdTech3 && !string.IsNullOrEmpty(MasterServerKey);

        public bool UsesSteamApi =>
            !UsesThreeNetworks && !UsesDefinedServerList && !UsesIdTech3 && string.IsNullOrEmpty(MasterServerKey);
    }
} 