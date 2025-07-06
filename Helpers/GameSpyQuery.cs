using ASP_site.Models.ServerBrowser;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Net.NetworkInformation;

namespace ASP_site.Helpers
{
    public static class GameSpyQuery
    {
        public static async Task<ServerInfo?> QueryServerInfo(string address, int timeout = 2000, ILogger? logger = null)
        {
            var parts = address.Split(':');
            if (parts.Length != 2 || !ushort.TryParse(parts[1], out var port))
            {
                logger?.LogWarning($"Invalid server address format (missing or invalid port): {address}");
                return null;
            }

            IPAddress? ip;
            try
            {
                ip = IPAddress.Parse(parts[0]);
            }
            catch (FormatException)
            {
                try
                {
                    var addresses = await Dns.GetHostAddressesAsync(parts[0]);
                    ip = addresses.FirstOrDefault(a => a.AddressFamily == AddressFamily.InterNetwork);
                    if (ip == null)
                    {
                        logger?.LogWarning($"Could not resolve hostname to an IPv4 address: {parts[0]}");
                        return null;
                    }
                }
                catch (Exception e)
                {
                    logger?.LogError(e, $"DNS resolution failed for hostname: {parts[0]}");
                    return null;
                }
            }

            using var udpClient = new UdpClient();
            try
            {
                udpClient.Client.ReceiveTimeout = timeout;
                udpClient.Client.SendTimeout = timeout;
                var endpoint = new IPEndPoint(ip, port);

                var request = Encoding.ASCII.GetBytes("\\status\\");
                logger?.LogDebug($"GameSpy Individual Query to {address}: Sent {request.Length} bytes.");
                await udpClient.SendAsync(request, request.Length, endpoint);

                var allBytes = new List<byte>();
                while (true)
                {
                    try
                    {
                        var result = await udpClient.ReceiveAsync();
                        allBytes.AddRange(result.Buffer);
                    }
                    catch (SocketException e)
                    {
                        // A timeout is the expected way to end the loop
                        if (e.SocketErrorCode == SocketError.TimedOut)
                        {
                            break;
                        }
                        logger?.LogError(e, $"SocketException while querying {address}.");
                        throw; // Re-throw other socket exceptions
                    }
                }

                if (allBytes.Count == 0)
                {
                    logger?.LogWarning($"No response from server {address}.");
                    return null; // No response
                }
                
                logger?.LogDebug($"Received {allBytes.Count} bytes from {address}.");
                return ParseInfoResponse(allBytes.ToArray());
            }
            catch (Exception ex)
            {
                logger?.LogError(ex, $"Failed to query server {address}.");
                return null;
            }
        }

        private static ServerInfo? ParseInfoResponse(byte[] buffer)
        {
            var responseString = Encoding.ASCII.GetString(buffer).Trim();
            var parts = responseString.Split('\\');
            if (parts.Length < 2)
            {
                return null;
            }

            var data = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
            // Start at 1 to skip the initial empty string from the leading '\'
            for (int i = 1; i < parts.Length - 1; i += 2)
            {
                var key = parts[i];
                var value = parts[i + 1];
                if (!string.IsNullOrEmpty(key))
                {
                    data[key] = value;
                }
            }

            var serverInfo = new ServerInfo
            {
                Name = data.GetValueOrDefault("hostname", "N/A"),
                Map = data.GetValueOrDefault("mapname", "N/A"),
                Players = byte.TryParse(data.GetValueOrDefault("numplayers"), out var players) ? players : (byte)0,
                MaxPlayers = byte.TryParse(data.GetValueOrDefault("maxplayers"), out var maxPlayers) ? maxPlayers : (byte)0,
                // GameSpy password is '1' for true, '0' for false.
                Visibility = data.GetValueOrDefault("password", "0") == "1" ? Visibility.Private : Visibility.Public,
                // Most GameSpy games are older and don't report VAC status in this query. Default to unsecured.
                VAC = VAC.Unsecured,
                // Similarly, bot count isn't a standard key.
                Bots = 0,
                // Server type and environment are not standard GameSpy keys, default them.
                ServerType = ServerType.Dedicated,
                Environment = ASP_site.Models.ServerBrowser.Environment.Windows, // A sensible default
                // Game version can sometimes be in 'gamever'
                Version = data.GetValueOrDefault("gamever", string.Empty)
            };

            return serverInfo;
        }

        public static async Task<List<string>> QueryMasterServerAsync(string masterServerAddress, string gameName, ILogger? logger = null, int timeout = 5000)
        {
            var serverList = new List<string>();
            var parts = masterServerAddress.Split(':');
            if (parts.Length != 2 || !ushort.TryParse(parts[1], out var port))
            {
                logger?.LogError($"Invalid master server address format: {masterServerAddress}");
                return serverList;
            }

            IPAddress? ip;
            try
            {
                ip = IPAddress.Parse(parts[0]);
            }
            catch (FormatException)
            {
                try
                {
                    var addresses = await Dns.GetHostAddressesAsync(parts[0]);
                    ip = addresses.FirstOrDefault(a => a.AddressFamily == AddressFamily.InterNetwork);
                    if (ip == null)
                    {
                        logger?.LogWarning($"Could not resolve hostname to an IPv4 address: {parts[0]}");
                        return serverList;
                    }
                }
                catch (Exception e)
                {
                    logger?.LogError(e, $"DNS resolution failed for hostname: {parts[0]}");
                    return serverList;
                }
            }

            using var udpClient = new UdpClient();
            var endpoint = new IPEndPoint(ip, port);
            udpClient.Client.ReceiveTimeout = timeout;
            
            // The request format is: [RequestType] [GameName] \\0 [Region] [Filter] \\0
            var requestData = new List<byte>();
            requestData.Add(0x01); // Request Type: Server List
            requestData.AddRange(Encoding.ASCII.GetBytes(gameName));
            requestData.Add(0x00); // Null terminator for GameName
            requestData.Add(0xFF); // Region Code: All
            requestData.AddRange(Encoding.ASCII.GetBytes("\\\\gametype\\\\all"));
            requestData.Add(0x00); // Null terminator for Filter

            var request = requestData.ToArray();
            logger?.LogInformation($"Querying GameSpy Master {masterServerAddress} for game '{gameName}'. Packet: {BitConverter.ToString(request).Replace("-", " ")}");
            await udpClient.SendAsync(request, request.Length, endpoint);

            var receivedData = new List<byte>();
            while (true)
            {
                try
                {
                    var result = await udpClient.ReceiveAsync();
                    receivedData.AddRange(result.Buffer);
                }
                catch (SocketException e)
                {
                    if (e.SocketErrorCode == SocketError.TimedOut)
                    {
                        break; // End of data
                    }
                    logger?.LogError(e, $"SocketException while querying master server {masterServerAddress}.");
                    throw;
                }
            }
            
            if (receivedData.Count == 0)
            {
                logger?.LogWarning($"No data received from master server {masterServerAddress} for game '{gameName}'.");
            }
            else
            {
                logger?.LogInformation($"Received {receivedData.Count} bytes from master server {masterServerAddress}. Response: {BitConverter.ToString(receivedData.ToArray()).Replace("-", " ")}");
            }
            
            return ParseMasterServerResponse(receivedData.ToArray());
        }

        private static List<string> ParseMasterServerResponse(byte[] buffer)
        {
            var servers = new List<string>();
            // A server entry is 6 bytes: 4 for IP, 2 for port.
            // We iterate through the buffer in 6-byte chunks.
            for (int i = 0; i <= buffer.Length - 6; i += 6)
            {
                var ipBytes = new byte[4];
                Array.Copy(buffer, i, ipBytes, 0, 4);

                var ip = new IPAddress(ipBytes);

                // Port is big-endian (network byte order)
                var port = (ushort)((buffer[i+4] << 8) | buffer[i+5]);

                if (port > 0)
                {
                    servers.Add($"{ip}:{port}");
                }
            }
            return servers;
        }
    }
} 