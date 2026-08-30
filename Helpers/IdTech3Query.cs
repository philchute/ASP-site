using System.Collections.Concurrent;
using System.Net;
using System.Net.Sockets;
using System.Text;
using ASP_site.Models;
using ASP_site.Models.ServerBrowser;
using Microsoft.Extensions.Logging;

namespace ASP_site.Helpers;

public static class IdTech3Query
{
    private static readonly byte[] Magic = [0xFF, 0xFF, 0xFF, 0xFF];
    private static readonly HashSet<string> BaseMods = new(StringComparer.OrdinalIgnoreCase)
    {
        "baseq3", "missionpack", "etmain", "main", "base", "basejk", "basejka",
        "basejk2", "war", "cod", "codmp", "iw3mp", "mainq3"
    };

    public static byte[] BuildMasterQuery(string protocolQuery)
    {
        var command = $"getservers {protocolQuery} empty full";
        var payload = new byte[Magic.Length + Encoding.ASCII.GetByteCount(command)];
        Magic.CopyTo(payload, 0);
        Encoding.ASCII.GetBytes(command, payload.AsSpan(Magic.Length));
        return payload;
    }

    public static byte[] BuildInfoQuery() => BuildOob("getinfo xxx");

    public static byte[] BuildStatusQuery() => BuildOob("getstatus");

    private static byte[] BuildOob(string command)
    {
        var payload = new byte[Magic.Length + Encoding.ASCII.GetByteCount(command)];
        Magic.CopyTo(payload, 0);
        Encoding.ASCII.GetBytes(command, payload.AsSpan(Magic.Length));
        return payload;
    }

    public static async Task<List<IPEndPoint>> QueryMaster(IPEndPoint master, Game game, int timeoutMs = 4000)
    {
        var unique = new Dictionary<string, IPEndPoint>();
        foreach (var query in game.ServerConfig?.GetMasterProtocolQueries() ?? [])
        {
            foreach (var endpoint in await QueryMasterOnce(master, query, timeoutMs))
            {
                unique[$"{endpoint.Address}:{endpoint.Port}"] = endpoint;
            }
        }

        return unique.Values.ToList();
    }

    public static List<IPEndPoint> ParseMasterResponse(byte[] buffer)
    {
        var servers = new List<IPEndPoint>();
        if (buffer.Length < 20)
            return servers;

        var ascii = Encoding.ASCII.GetString(buffer);
        var marker = "getserversExtResponse";
        var idx = ascii.IndexOf(marker, StringComparison.Ordinal);
        if (idx < 0)
        {
            marker = "getserversResponse";
            idx = ascii.IndexOf(marker, StringComparison.Ordinal);
        }
        if (idx < 0)
            return servers;

        var pos = idx + marker.Length;
        while (pos < buffer.Length)
        {
            var sep = buffer[pos];
            if (sep is not (byte)'\\' and not (byte)'/')
            {
                pos++;
                continue;
            }

            pos++;
            if (IsEot(buffer, pos))
                break;

            if (sep == (byte)'/')
            {
                if (pos + 18 > buffer.Length)
                    break;
                pos += 18;
                continue;
            }

            if (pos + 6 > buffer.Length)
                break;

            var ip = new IPAddress(buffer.AsSpan(pos, 4).ToArray());
            var port = (ushort)((buffer[pos + 4] << 8) | buffer[pos + 5]);
            pos += 6;

            if (port == 0 || IPAddress.IsLoopback(ip) || ip.Equals(IPAddress.Any) || ip.Equals(IPAddress.None))
                continue;

            servers.Add(new IPEndPoint(ip, port));
        }

        return servers;
    }

    public static Dictionary<string, string> ParseInfoString(string body)
    {
        var dict = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        if (string.IsNullOrEmpty(body))
            return dict;

        // Real servers send "infoResponse\n\\key\\value". Taking Split('\n')[0]
        // would keep only the empty line after the command token.
        var start = body.IndexOf('\\');
        if (start < 0)
            return dict;

        var end = body.IndexOf('\n', start);
        var infoLine = end < 0 ? body[start..] : body[start..end];
        var parts = infoLine.Split('\\');
        for (var i = 1; i + 1 < parts.Length; i += 2)
        {
            var key = parts[i];
            if (string.IsNullOrEmpty(key))
                continue;
            dict[key] = parts[i + 1];
        }

        return dict;
    }

    public static GameServerItem? MapInfoResponse(byte[] buffer, Game game, IPAddress ip, ushort port)
    {
        var text = Encoding.Latin1.GetString(buffer);
        var marker = "infoResponse";
        var idx = text.IndexOf(marker, StringComparison.OrdinalIgnoreCase);
        if (idx < 0)
        {
            marker = "statusResponse";
            idx = text.IndexOf(marker, StringComparison.OrdinalIgnoreCase);
        }
        if (idx < 0)
            return null;

        var body = text[(idx + marker.Length)..];
        var info = ParseInfoString(body);
        if (info.Count == 0)
            return null;

        var hostname = FirstValue(info, "sv_hostname", "hostname") ?? "Unknown Server";
        var map = FirstValue(info, "mapname") ?? "Unknown Map";
        var players = ParseInt(FirstValue(info, "clients", "g_humanplayers", "g_players", "players"));
        var maxPlayers = ParseInt(FirstValue(info, "sv_maxclients", "maxclients"));
        if (maxPlayers <= 0)
            maxPlayers = Math.Max(players, 1);

        var bots = ParseInt(FirstValue(info, "bots", "g_bots"));
        if (bots > 0 && players >= bots)
            players -= bots;

        return new GameServerItem(ip, port, game)
        {
            Name = StringUtils.CleanString(hostname, removeColors: false),
            Map = StringUtils.CleanString(map),
            Players = Math.Max(0, players),
            MaxPlayers = maxPlayers,
            Version = FirstValue(info, "version", "shortversion", "gameversion") ?? "",
            GameType = FormatGameType(info),
            PasswordProtected = ParseBool(FirstValue(info, "g_needpass", "needpass", "g_password")),
            RequiresPunkBuster = ParseBool(FirstValue(info, "sv_punkbuster", "g_punkbuster", "punkbuster", "pb"))
        };
    }

    public static async Task<GameServerItem?> QueryServerInfo(string address, Game game, int timeout = 1500)
    {
        if (!TryParseAddress(address, out var endpoint))
            return null;
        return await QueryServerInfo(endpoint, game, timeout);
    }

    public static async Task<GameServerItem?> QueryServerInfo(IPEndPoint endpoint, Game game, int timeout = 1500)
    {
        var target = ToIPv4(endpoint);
        if (target is null)
            return null;

        var buffer = await QueryOob(target, BuildInfoQuery(), timeout)
            ?? await QueryOob(target, BuildStatusQuery(), timeout);
        if (buffer is null)
            return null;
        return MapInfoResponse(buffer, game, target.Address, (ushort)target.Port);
    }

    public static async Task<List<GameServerItem>> QueryServers(Game game, IReadOnlyList<IPEndPoint> endpoints, int timeout = 2000, ILogger? logger = null)
    {
        var items = new ConcurrentBag<GameServerItem>();
        var sampleErrors = new ConcurrentBag<string>();
        var receivedUnmapped = 0;
        var options = new ParallelOptions { MaxDegreeOfParallelism = 8 };
        await Parallel.ForEachAsync(endpoints, options, async (endpoint, _) =>
        {
            try
            {
                var target = ToIPv4(endpoint);
                if (target is null)
                    return;

                var buffer = await QueryOob(target, BuildInfoQuery(), timeout)
                    ?? await QueryOob(target, BuildStatusQuery(), timeout);
                if (buffer is null)
                    return;

                var item = MapInfoResponse(buffer, game, target.Address, (ushort)target.Port);
                if (item != null)
                {
                    items.Add(item);
                    return;
                }

                if (Interlocked.Increment(ref receivedUnmapped) == 1)
                {
                    var ascii = Encoding.Latin1.GetString(buffer, 0, Math.Min(buffer.Length, 120))
                        .Replace('\n', ' ')
                        .Replace('\0', ' ');
                    sampleErrors.Add($"unmapped packet from {target} ({buffer.Length} bytes): {ascii}");
                }
            }
            catch (Exception ex)
            {
                sampleErrors.Add($"{endpoint}: {ex.GetType().Name} {ex.Message}");
            }
        });

        if (items.IsEmpty && endpoints.Count > 0)
        {
            var probe = ToIPv4(endpoints[0]);
            var error = sampleErrors.FirstOrDefault() ?? await DiagnoseOob(probe, timeout);
            logger?.LogWarning("IdTech3 getinfo mapped 0/{Total} ({Unmapped} packets unparsed). Probe {Endpoint}: {Error}",
                endpoints.Count, receivedUnmapped, probe, error);
        }

        return items.ToList();
    }

    private static async Task<byte[]?> QueryOob(IPEndPoint endpoint, byte[] payload, int timeout)
    {
        try
        {
            return await Task.Run(() =>
            {
                using var udp = CreateUdpClient(endpoint.AddressFamily);
                udp.Client.ReceiveTimeout = timeout;
                udp.Client.SendTimeout = timeout;
                udp.Send(payload, payload.Length, endpoint);
                var remote = new IPEndPoint(IPAddress.Any, 0);
                return udp.Receive(ref remote);
            });
        }
        catch
        {
            return null;
        }
    }

    private static async Task<string> DiagnoseOob(IPEndPoint? endpoint, int timeout)
    {
        if (endpoint is null)
            return "no IPv4 endpoint";
        try
        {
            await Task.Run(() =>
            {
                using var udp = CreateUdpClient(endpoint.AddressFamily);
                udp.Client.ReceiveTimeout = timeout;
                var payload = BuildInfoQuery();
                udp.Send(payload, payload.Length, endpoint);
                var remote = new IPEndPoint(IPAddress.Any, 0);
                _ = udp.Receive(ref remote);
            });
            return "probe succeeded";
        }
        catch (Exception ex)
        {
            return $"{ex.GetType().Name}: {ex.Message}";
        }
    }

    private static UdpClient CreateUdpClient(AddressFamily family)
    {
        var udp = new UdpClient(family);
        try
        {
            // Windows reports ICMP port-unreachable as connection reset on the next receive.
            const int SioUdpConnreset = -1744830452;
            udp.Client.IOControl(SioUdpConnreset, [0x00, 0x00, 0x00, 0x00], null);
        }
        catch
        {
            // Non-Windows or unsupported.
        }
        return udp;
    }

    private static IPEndPoint? ToIPv4(IPEndPoint endpoint)
    {
        if (endpoint.AddressFamily == AddressFamily.InterNetwork)
            return endpoint;
        if (endpoint.Address.IsIPv4MappedToIPv6)
            return new IPEndPoint(endpoint.Address.MapToIPv4(), endpoint.Port);
        return null;
    }

    private static async Task<List<IPEndPoint>> QueryMasterOnce(IPEndPoint master, string protocolQuery, int timeoutMs)
    {
        var servers = new List<IPEndPoint>();
        try
        {
            using var udp = new UdpClient();
            var payload = BuildMasterQuery(protocolQuery);
            await udp.SendAsync(payload, payload.Length, master);

            var received = false;
            while (true)
            {
                var waitMs = received ? 400 : timeoutMs;
                using var cts = new CancellationTokenSource(waitMs);
                try
                {
                    var result = await udp.ReceiveAsync(cts.Token);
                    received = true;
                    servers.AddRange(ParseMasterResponse(result.Buffer));
                    var ascii = Encoding.ASCII.GetString(result.Buffer);
                    if (ascii.Contains("EOT", StringComparison.Ordinal))
                        break;
                }
                catch (OperationCanceledException)
                {
                    break;
                }
            }
        }
        catch
        {
            // Master unreachable; caller logs the empty result.
        }

        return servers;
    }

    private static bool TryParseAddress(string address, out IPEndPoint endpoint)
    {
        endpoint = new IPEndPoint(IPAddress.Any, 0);
        var lastColon = address.LastIndexOf(':');
        if (lastColon <= 0 || lastColon == address.Length - 1)
            return false;
        var host = address[..lastColon].Trim('[', ']');
        if (!IPAddress.TryParse(host, out var ip) || !ushort.TryParse(address[(lastColon + 1)..], out var port))
            return false;
        endpoint = new IPEndPoint(ip, port);
        return true;
    }

    private static bool IsEot(byte[] buffer, int pos) =>
        pos + 3 <= buffer.Length &&
        buffer[pos] == (byte)'E' &&
        buffer[pos + 1] == (byte)'O' &&
        buffer[pos + 2] == (byte)'T';

    private static string? FirstValue(Dictionary<string, string> info, params string[] keys)
    {
        foreach (var key in keys)
        {
            if (info.TryGetValue(key, out var value) && !string.IsNullOrWhiteSpace(value))
                return value;
        }
        return null;
    }

    private static int ParseInt(string? value) =>
        int.TryParse(value, out var n) ? n : 0;

    private static bool? ParseBool(string? value)
    {
        if (string.IsNullOrWhiteSpace(value))
            return null;
        if (value is "1" or "true" or "yes")
            return true;
        if (value is "0" or "false" or "no")
            return false;
        return null;
    }

    private static string? FormatGameType(Dictionary<string, string> info)
    {
        var gametype = FirstValue(info, "g_gametype", "gametype", "g_gt");
        var mod = FirstValue(info, "fs_game", "game");
        if (string.IsNullOrEmpty(mod) || BaseMods.Contains(mod))
            return gametype;

        return string.IsNullOrEmpty(gametype) ? mod : $"{mod} {gametype}";
    }
}
