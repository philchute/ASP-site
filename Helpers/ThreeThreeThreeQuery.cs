using ASP_site.Models;
using ASP_site.Models.ServerBrowser;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ASP_site.Helpers
{
    public class ThreeThreeThreeQuery
    {
        public async Task<List<GameServerItem>> QueryServerListByAddress(IPEndPoint masterServer, Game game, ILogger logger)
        {
            var serverList = new List<GameServerItem>();
            var gameName = game.GameID;
            var secretKey = game.ServerConfig?.SecretKey;

            try
            {
                using (var tcpClient = new TcpClient())
                {
                    // Increased timeouts for robustness
                    tcpClient.SendTimeout = 10000;
                    tcpClient.ReceiveTimeout = 10000;

                    await tcpClient.ConnectAsync(masterServer.Address, masterServer.Port);
                    logger.LogInformation($"Successfully connected via TCP to {masterServer.Address}:{masterServer.Port}.");

                    using (var networkStream = tcpClient.GetStream())
                    {
                        // 1. Initial Handshake - does not send validate, just gets the challenge
                        var initialRequest = $"\\gamename\\{gameName}\\gamever\\469\\location\\0\\final\\";
                        logger.LogInformation($"Sent initial TCP handshake for {gameName}: {initialRequest}");
                        var requestBytes = Encoding.UTF8.GetBytes(initialRequest);
                        await networkStream.WriteAsync(requestBytes, 0, requestBytes.Length);

                        var buffer = new byte[8192];
                        var bytesRead = await networkStream.ReadAsync(buffer, 0, buffer.Length);
                        var response = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                        logger.LogInformation($"Received response from server: {response}");

                        // 2. Respond to Challenge and Request List
                        var challengeMatch = Regex.Match(response, @"\\secure\\(\\S+)");
                        if (challengeMatch.Success)
                        {
                            var challengeKey = challengeMatch.Groups[1].Value;
                            var validationKey = CreateValidationKey(challengeKey, secretKey);
                            var listRequest = $"\\validate\\{validationKey}\\list\\\\final\\";
                            
                            logger.LogInformation($"Sending validation and list request: {listRequest}");
                            requestBytes = Encoding.UTF8.GetBytes(listRequest);
                            await networkStream.WriteAsync(requestBytes, 0, requestBytes.Length);

                            // 3. Receive Server List (can be chunked)
                            var fullResponse = new StringBuilder();
                            while (true)
                            {
                                bytesRead = await networkStream.ReadAsync(buffer, 0, buffer.Length);
                                if (bytesRead == 0) break; // Connection closed
                                
                                var chunk = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                                fullResponse.Append(chunk);

                                if (chunk.Contains("\\final\\")) break;
                            }
                            
                            var serverListResponse = fullResponse.ToString();
                            logger.LogInformation($"Received {serverListResponse.Length} bytes for server list. Raw response snippet: {serverListResponse.Substring(0, Math.Min(serverListResponse.Length, 200))}");
                            serverList.AddRange(ParseServerList(serverListResponse, game, logger));
                        }
                        else
                        {
                            logger.LogWarning("Did not receive a valid challenge string from the server.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                logger.LogError(ex, $"An error occurred while querying {masterServer.Address}:{masterServer.Port}");
            }

            return serverList;
        }

        private string CreateValidationKey(string challenge, string? secretKey)
        {
            if (string.IsNullOrEmpty(secretKey))
            {
                return "";
            }
            using (var md5 = MD5.Create())
            {
                var input = challenge + secretKey;
                var inputBytes = Encoding.ASCII.GetBytes(input);
                var hashBytes = md5.ComputeHash(inputBytes);
                
                var sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("x2"));
                }
                return sb.ToString();
            }
        }
        
        private IEnumerable<GameServerItem> ParseServerList(string response, Game game, ILogger logger)
        {
            var servers = new List<GameServerItem>();
            // Use regex to find all \ip\ip:port patterns
            var ipMatches = Regex.Matches(response, @"\\ip\\([^\\:]+:\d+)");

            foreach (Match match in ipMatches)
            {
                var ipPort = match.Groups[1].Value;
                var ipPortParts = ipPort.Split(':');
                var ip = ipPortParts[0];
                if (int.TryParse(ipPortParts[1], out int port))
                {
                    servers.Add(new GameServerItem(IPAddress.Parse(ip), (ushort)port, game));
                }
            }
            
            logger.LogInformation($"Parsed {servers.Count} servers from response.");
            return servers;
        }
    }
} 