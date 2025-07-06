using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using ASP_site.Models.ServerBrowser;
using Microsoft.Extensions.Logging;

namespace ASP_site.Helpers
{
    public class GameSpyQuery
    {
        private readonly ILogger<GameSpyQuery> _logger;

        public GameSpyQuery(ILogger<GameSpyQuery> logger)
        {
            _logger = logger;
        }

        public async Task<List<string>> QueryMasterServerAsync(string masterServerAddress, string gameName)
        {
            var serverAddresses = new List<string>();
            try
            {
                using var client = new UdpClient();
                var masterServerParts = masterServerAddress.Split(':');
                if (masterServerParts.Length != 2 || !int.TryParse(masterServerParts[1], out var port))
                {
                    _logger.LogError($"Invalid master server address format: {masterServerAddress}");
                    return serverAddresses;
                }

                // The request format is: [RequestType] [GameName] \\0 [Region] [Filter] \\0
                var requestData = new List<byte>();
                requestData.Add(0x01); // Request Type: Server List
                requestData.AddRange(Encoding.ASCII.GetBytes(gameName));
                requestData.Add(0x00); // Null terminator for GameName
                requestData.Add(0xFF); // Region Code: All
                requestData.AddRange(Encoding.ASCII.GetBytes("\\gametype\\all"));
                requestData.Add(0x00); // Null terminator for Filter
                
                var request = requestData.ToArray();

                _logger.LogInformation($"Querying GameSpy Master {masterServerAddress} for game '{gameName}'. Packet: {BitConverter.ToString(request).Replace("-", " ")}");

                await client.SendAsync(request, request.Length, masterServerParts[0], port);

                var timeoutTask = Task.Delay(TimeSpan.FromSeconds(5));
                var receiveTask = client.ReceiveAsync();

                if (await Task.WhenAny(receiveTask, timeoutTask) == timeoutTask)
                {
                    _logger.LogWarning($"Timeout while querying master server {masterServerAddress} for {gameName}.");
                    return new List<string>();
                }

                var result = await receiveTask;
                var buffer = result.Buffer;

                _logger.LogInformation($"Received {buffer.Length} bytes from master server {masterServerAddress}.");

                // Check for the expected header for a server list response
                if (buffer.Length <= 6 || !buffer.Take(6).SequenceEqual(new byte[] { 0xfe, 0xfd, 0x01, 0x66, 0x0a, 0x00 }))
                {
                    _logger.LogWarning("Invalid or unexpected response from master server.");
                    return serverAddresses;
                }

                int offset = 6;
                while (offset + 6 <= buffer.Length)
                {
                    var ipBytes = buffer.Skip(offset).Take(4).ToArray();
                    var portBytes = buffer.Skip(offset + 4).Take(2).ToArray();
                    
                    // GameSpy sends port in Big Endian (Network Byte Order)
                    if (BitConverter.IsLittleEndian)
                    {
                        Array.Reverse(portBytes);
                    }
                    
                    var ip = new IPAddress(ipBytes);
                    var serverPort = BitConverter.ToUInt16(portBytes, 0);

                    if (ip.ToString() == "0.0.0.0" && serverPort == 0)
                    {
                        // End of list marker
                        break;
                    }

                    serverAddresses.Add($"{ip}:{serverPort}");
                    offset += 6;
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error querying GameSpy master server");
            }

            return serverAddresses;
        }

        public Task<GameServerItem> QueryServerInfoAsync(string serverAddress)
        {
            // This method is not part of the current task
            throw new NotImplementedException();
        }
    }
}