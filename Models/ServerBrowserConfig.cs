using ASP_site.Models; // For MasterServerType enum

namespace ASP_site.Models
{
    public class ServerBrowserConfig
    {
        // Corresponds to 'icon' in games.json
        public string? IconPath { get; set; }

        // Corresponds to 'gamedir' in games.json
        public string? GameDirectory { get; set; }

        // Corresponds to 'masterServer' in games.json
        public MasterServerType? MasterServer { get; set; }

        // Corresponds to 'noBackgroundService' in games.json
        public bool? NoBackgroundService { get; set; }

        // Corresponds to 'useDefinedServerList' logic, if you want to store it from games.json
        public bool? UseDefinedServerList { get; set; } = false;

        // Corresponds to 'filters' in games.json for Steam API
        public string? ApiFilters { get; set; }
    }
} 