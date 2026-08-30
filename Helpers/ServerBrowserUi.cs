using ASP_site.Models;
using ASP_site.Models.ServerBrowser;

namespace ASP_site.Helpers;

public class ServerBrowserColumns
{
    public bool Vac { get; init; }
    public bool Password { get; init; }
    public bool Os { get; init; }
    public bool Type { get; init; }
    public bool GameType { get; init; }
    public bool Country { get; init; }
    public bool PunkBuster { get; init; }
    public bool ColorNames { get; init; }
}

public static class ServerBrowserUi
{
    public const string GroupSteam = "Steam";
    public const string GroupGoldSrcMod = "goldsrc mod";
    public const string GroupSourceMod = "source mod";
    public const string GroupA2S = "A2S";
    public const string GroupGameSpy = "333networks";
    public const string GroupIdTech3 = "idtech3";
    public const string GroupDefined = "Known";

    public static string GroupName(Game game)
    {
        var config = game.ServerConfig;
        if (config == null) return SteamEngineLabel(game);
        if (config.UsesThreeNetworks) return GroupGameSpy;
        if (config.UsesIdTech3) return GroupIdTech3;
        if (config.UsesDefinedServerList) return GroupDefined;
        if (config.UsesA2SMaster) return GroupA2S;
        return SteamEngineLabel(game);
    }

    public static bool IsStandaloneSteamApp(Game game) =>
        game.ServerConfig?.UsesSteamApi == true && game.SteamID is > 0 and not 10 and not 70;

    private static string SteamEngineLabel(Game game)
    {
        if (IsStandaloneSteamApp(game))
            return GroupSteam;

        var engine = game.EngineID ?? "";
        if (engine.Equals("goldsrc", StringComparison.OrdinalIgnoreCase) ||
            engine.Equals("goldsource", StringComparison.OrdinalIgnoreCase))
            return GroupGoldSrcMod;
        if (engine.Equals("source", StringComparison.OrdinalIgnoreCase))
            return GroupSourceMod;
        return GroupSteam;
    }

    public static string SelectLabel(Game game) => $"{game.Name} ({GroupName(game)})";

    public static ServerBrowserColumns Columns(Game game)
    {
        var config = game.ServerConfig;
        if (config == null || config.UsesSteamApi)
        {
            return new ServerBrowserColumns
            {
                Vac = true,
                Os = true,
                Type = true,
                GameType = true
            };
        }

        if (config.UsesThreeNetworks)
        {
            return new ServerBrowserColumns
            {
                GameType = true,
                Country = true
            };
        }

        if (config.UsesIdTech3)
        {
            return new ServerBrowserColumns
            {
                Password = true,
                GameType = true,
                PunkBuster = true,
                ColorNames = true
            };
        }

        return new ServerBrowserColumns
        {
            Vac = true,
            Password = true,
            Os = true,
            Type = true
        };
    }

    public static string ConnectCommand(Game game, string ipPort)
    {
        if (game.ServerConfig?.UsesThreeNetworks == true)
        {
            var engine = game.EngineID ?? "";
            if (engine.StartsWith("unreal", StringComparison.OrdinalIgnoreCase))
                return $"open {ipPort}";
        }

        return $"connect {ipPort}";
    }

    public static string? SteamConnectUrl(Game game, string ipPort)
    {
        if (game.ServerConfig?.UsesThreeNetworks == true || game.ServerConfig?.UsesIdTech3 == true)
            return null;
        return $"steam://connect/{ipPort}";
    }

    public static List<GameServerItem> ApplyFiltersAndSort(
        IEnumerable<GameServerItem> servers,
        string? vacFilter,
        string? passwordFilter,
        bool hideEmpty,
        bool hideFull,
        string? sortBy,
        string? search,
        string? punkBusterFilter = null)
    {
        IEnumerable<GameServerItem> filtered = servers;

        if (vacFilter == "yes")
            filtered = filtered.Where(s => s.RequiresVAC == true);
        else if (vacFilter == "no")
            filtered = filtered.Where(s => s.RequiresVAC == false);

        if (passwordFilter == "yes")
            filtered = filtered.Where(s => s.PasswordProtected == true);
        else if (passwordFilter == "no")
            filtered = filtered.Where(s => s.PasswordProtected == false);

        if (punkBusterFilter == "yes")
            filtered = filtered.Where(s => s.RequiresPunkBuster == true);
        else if (punkBusterFilter == "no")
            filtered = filtered.Where(s => s.RequiresPunkBuster == false);

        if (hideEmpty)
            filtered = filtered.Where(s => s.Players > 0);
        if (hideFull)
            filtered = filtered.Where(s => s.Players < s.MaxPlayers);

        if (!string.IsNullOrWhiteSpace(search))
        {
            var q = search.Trim();
            filtered = filtered.Where(s =>
                (StringUtils.StripQuake3Colors(s.Name).Contains(q, StringComparison.OrdinalIgnoreCase)) ||
                (s.Map?.Contains(q, StringComparison.OrdinalIgnoreCase) ?? false) ||
                (s.GameType?.Contains(q, StringComparison.OrdinalIgnoreCase) ?? false));
        }

        filtered = sortBy?.ToLowerInvariant() switch
        {
            "name" => filtered.OrderBy(s => StringUtils.StripQuake3Colors(s.Name)),
            "map" => filtered.OrderBy(s => s.Map).ThenByDescending(s => s.Players),
            _ => filtered.OrderByDescending(s => s.Players).ThenBy(s => StringUtils.StripQuake3Colors(s.Name))
        };

        return filtered.ToList();
    }
}
