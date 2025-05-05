using Newtonsoft.Json; // Use Newtonsoft.Json for attributes if needed
using System.Net; // For IPAddress

namespace ASP_site.GameServerListCommon.Model.Steam; // New namespace

// Represents the structure of a server object returned by
// the IGameServersService/GetServerList/v1 Steam Web API endpoint.
public class SteamApiServer
{
    [JsonProperty("addr")] // Maps JSON field "addr" to this property
    public string Address { get; set; } = string.Empty;

    [JsonProperty("gameport")]
    public ushort GamePort { get; set; }

    [JsonProperty("steamid")]
    public string SteamId { get; set; } = string.Empty;

    [JsonProperty("name")]
    public string Name { get; set; } = string.Empty;

    [JsonProperty("appid")]
    public int AppId { get; set; }

    [JsonProperty("gamedir")]
    public string GameDir { get; set; } = string.Empty;

    [JsonProperty("version")]
    public string Version { get; set; } = string.Empty;

    [JsonProperty("product")]
    public string Product { get; set; } = string.Empty;

    [JsonProperty("region")]
    public int Region { get; set; } = -1;

    [JsonProperty("players")]
    public byte Players { get; set; }

    [JsonProperty("max_players")]
    public byte MaxPlayers { get; set; }

    [JsonProperty("bots")]
    public byte Bots { get; set; }

    [JsonProperty("map")]
    public string Map { get; set; } = string.Empty;

    [JsonProperty("secure")]
    public bool Secure { get; set; } // VAC enabled

    [JsonProperty("dedicated")]
    public bool Dedicated { get; set; } // d/l server type

    [JsonProperty("os")]
    public string OS { get; set; } = string.Empty; // w/l/m

    [JsonProperty("gametype")]
    public string GameType { get; set; } = string.Empty; // Tags?

    // Helper method to get IPAddress object
    public IPAddress? GetIPAddress()
    {
        if (string.IsNullOrWhiteSpace(Address) || !Address.Contains(':'))
            return null;
        var ipPart = Address.Split(':')[0];
        IPAddress.TryParse(ipPart, out var ip);
        return ip;
    }
}

// Helper class to represent the overall API response structure
public class SteamApiServerListResponse
{
    [JsonProperty("response")]
    public SteamApiResponseContent Response { get; set; } = new(); // Initialize
}

public class SteamApiResponseContent
{
     // Success flag isn't always present in GetServerList, rely on server list presence
     // [JsonProperty("success")]
     // public bool Success { get; set; }

     [JsonProperty("servers")]
     public List<SteamApiServer>? Servers { get; set; } = new(); // Initialize
} 