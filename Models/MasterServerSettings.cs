using System.Collections.Generic;

namespace ASP_site.Models
{
    public class MasterServerSettings
    {
        public Dictionary<string, MasterServerEntry> Servers { get; set; } = new Dictionary<string, MasterServerEntry>();
    }

    public class MasterServerEntry
    {
        public string Address { get; set; } = string.Empty;
        public string Protocol { get; set; } = "A2S"; // Default to A2S
    }
} 