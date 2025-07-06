using ASP_site.Models;
using System.Net.Sockets;
using System.Net;
using System.Text;
using ASP_site.Helpers;
using ASP_site.Models.ServerBrowser;

namespace ASP_site.Helpers; // Adjusted namespace

public static class A2SQuery
{
    private static readonly byte[] ServerRequest = { 0xFF, 0xFF, 0xFF, 0xFF, 0x54, 0x53, 0x6F, 0x75, 0x72, 0x63, 0x65, 0x20, 0x45, 0x6E, 0x67, 0x69, 0x6E, 0x65, 0x20, 0x51, 0x75, 0x65, 0x72, 0x79, 0x00 };
    private static readonly byte[] PlayerRequest = { 0xFF, 0xFF, 0xFF, 0xFF, 0x55, 0xFF, 0xFF, 0xFF, 0xFF };

    public static async Task<List<IPEndPoint>> QueryServerList(IPEndPoint masterServer, Game game)
    {
        var serverList = new List<IPEndPoint>();

        using var udpClient = new UdpClient();
        using var cancellationToken = new CancellationTokenSource(15000);

        try
        {
            string currentSeed = "0.0.0.0:0"; // Start with the initial seed
            bool isLastBatch = false;

            do
            {
                var bytes = GetMasterQueryRequest(currentSeed, game);
                var buffer = await SendAndReceiveAsync(udpClient, masterServer, bytes, cancellationToken.Token);

                using var ms = new MemoryStream(buffer);
                using var br = new BinaryReader(ms, Encoding.UTF8);
                ms.Seek(6, SeekOrigin.Begin); // Skip header

                while (ms.Position < ms.Length)
                {
                    var info = ParseSingleMasterServer(br);
                    currentSeed = $"{info.Address}:{info.Port}"; // Update seed for next request

                    if (currentSeed == "0.0.0.0:0") // Check if it's the last batch signal
                    {
                       isLastBatch = true;
                       break;
                    }
                    serverList.Add(new IPEndPoint(info.Address, info.Port));
                }
            } while (!isLastBatch);

            return serverList;
        }
        catch (Exception ex) // Catch specific exceptions
        {
             Console.WriteLine($"Error querying master server {masterServer}: {ex.Message}");
             return serverList; // Return potentially empty list
        }
        finally
        {
            udpClient.Close(); // Close needed?
        }
    }

    // NOTE: QueryServerInfo needs the parsing logic from ServerInfo constructor
    public static async Task<ServerInfo?> QueryServerInfo(string address, int timeout = 2000)
    {
        using var udpClient = new UdpClient();
        using var cancellationToken = new CancellationTokenSource(timeout);

        try
        {
            var endpoint = GetIPEndPoint(address);
            var buffer = await SendAndReceiveAsync(udpClient, endpoint, ServerRequest, cancellationToken.Token);

            // Check for challenge response from server and resend if necessary
            if (buffer.Length > 4 && buffer[4] == 0x41) // 'A' for challenge
            {
                var challengeBytes = new byte[4];
                Buffer.BlockCopy(buffer, 5, challengeBytes, 0, 4);

                var payloadWithChallenge = new List<byte>(ServerRequest);
                payloadWithChallenge.AddRange(challengeBytes);
                
                buffer = await SendAndReceiveAsync(udpClient, endpoint, payloadWithChallenge.ToArray(), cancellationToken.Token);
            }

            using var ms = new MemoryStream(buffer);
            using var br = new BinaryReader(ms, Encoding.UTF8);
            
            // The first 4 bytes of the response are always -1 (0xFF).
            // The 5th byte is the actual response header. We must seek past the first 4 bytes.
            if (ms.Length > 4)
            {
                ms.Seek(4, SeekOrigin.Begin);
            }
            else
            {
                // If the response is too short, it's invalid.
                throw new InvalidDataException("Received an invalid or incomplete server response.");
            }

            return ParseInfoResponse(address, br);
        }
        catch (Exception ex)
        {
            if (!(ex is OperationCanceledException || ex is InvalidDataException))
            {
                Console.WriteLine($"Error querying server info for {address}: {ex.Message}");
            }
            return null;
        }
    }

     // NOTE: QueryPlayerInfo needs the parsing logic from PlayerInfo constructor
    public static async Task<List<PlayerInfo>> QueryPlayerInfo(string address, int timeout = 2500)
    {
        using var udpClient = new UdpClient();
        using var cancellationToken = new CancellationTokenSource(timeout);
        var players = new List<PlayerInfo>();

        try
        {
            var endpoint = GetIPEndPoint(address);
            // QueryServerAsync extension method is missing, call SendAndReceive directly
            // buffer = await udpClient.QueryServerAsync(endpoint, PlayerRequest, cancellationToken.Token);

            // Need the challenge/response flow from the old A2S.cs
            var challengePayload = BuildChallengeRequestPayload();
            var challengeResponse = await SendAndReceiveAsync(udpClient, endpoint, challengePayload, cancellationToken.Token);
            var challengeNumber = ParseChallengeResponse(challengeResponse); // Need ParseChallengeResponse implementation
            var playerRequestPayload = BuildPlayerRequestPayload(challengeNumber); // Need BuildPlayerRequestPayload

            var buffer = await SendAndReceiveAsync(udpClient, endpoint, playerRequestPayload, cancellationToken.Token);


            using var ms = new MemoryStream(buffer);
            using var br = new BinaryReader(ms, Encoding.UTF8);
            ms.Seek(5, SeekOrigin.Begin); // Skip header and player count byte?

            var numPlayers = br.ReadByte();
            for (var i = 0; i < numPlayers; i++)
            {
                 // PlayerInfo constructor needs BinaryReader argument - Add this constructor
                 // players.Add(new PlayerInfo(br));
                 players.Add(ParseSinglePlayer(br)); // Replace with call to parsing logic
            }

            return players;
        }
        catch (Exception ex) // Catch specific exceptions
        {
            Console.WriteLine($"Error querying player info for {address}: {ex.Message}");
            return players; // Return potentially empty list
        }
        finally
        {
            udpClient.Close(); // Close needed?
        }
    }

    // Helper to parse IP:Port string
    private static IPEndPoint GetIPEndPoint(string address)
    {
        var items = address.Split(':');
        if (items.Length != 2)
            throw new FormatException($"Invalid address format: {address}");

        if (!IPAddress.TryParse(items[0], out var ip))
             throw new FormatException($"Invalid IP address: {items[0]}");
        if(!ushort.TryParse(items[1], out var port))
             throw new FormatException($"Invalid port: {items[1]}");

        return new IPEndPoint(ip, port);
    }

    // Builds the request payload for querying master server
    private static byte[] GetMasterQueryRequest(string seedAddress, Game game)
    {
        var bytes = new List<byte>
        {
            0x31, // Header for Master Server query
            0xFF // Region: World
        };

        // Add seed address (null-terminated)
        bytes.AddRange(Encoding.UTF8.GetBytes(seedAddress));
        bytes.Add(0x00);

        // Add filters (null-terminated)
        bytes.AddRange(GetMasterQueryFilters(game));
        bytes.Add(0x00);

        return [.. bytes];
    }

    // Builds the filter string for master server query
    private static byte[] GetMasterQueryFilters(Game game)
    {
        if (game?.ServerConfig is null)
            return []; // Return empty byte array if no game or config provided

        var bldr = new StringBuilder();

        // Required: AppId
        bldr.Append($"\\appid\\{game.SteamID}");

        // Optional: Gamedir
        if (!string.IsNullOrEmpty(game.ServerConfig.GameDirectory))
            bldr.Append($"\\gamedir\\{game.ServerConfig.GameDirectory}");

        // Optional: ApiFilters
        if (!string.IsNullOrEmpty(game.ServerConfig.ApiFilters))
           bldr.Append(game.ServerConfig.ApiFilters);

        return Encoding.UTF8.GetBytes(bldr.ToString());
    }

    // --- Missing Helper/Parsing Methods (Need implementations) ---

    // Basic UDP send/receive (replace missing extension methods)
    // Add multi-packet handling
    private static async Task<byte[]> SendAndReceiveAsync(UdpClient client, IPEndPoint endpoint, byte[] payload, CancellationToken token)
    {
        await client.SendAsync(payload, payload.Length, endpoint);
        var initialResult = await client.ReceiveAsync(token);
        var initialBuffer = initialResult.Buffer;

        // Check for multi-packet response header (-2)
        using var initialReader = new BinaryReader(new MemoryStream(initialBuffer));
        int header = PacketUtils.ReadInt(initialReader);
        initialReader.BaseStream.Position = 0; // Reset position

        if (header == -1) // Single packet
        {
            return initialBuffer;
        }
        else if (header == -2) // Multi-packet
        {
             Console.WriteLine($"Multi-packet response detected from {endpoint}...");
             var packets = new Dictionary<int, byte[]>();
             MultiPacketInfo packetInfo = ParseMultiPacketHeader(initialReader); // Parse first packet
             packets[packetInfo.Number] = packetInfo.Payload.ToArray();

             // Read subsequent packets
             while (packets.Count < packetInfo.Total)
             {
                 token.ThrowIfCancellationRequested(); // Check cancellation
                 var subsequentResult = await client.ReceiveAsync(token);
                 using var subsequentReader = new BinaryReader(new MemoryStream(subsequentResult.Buffer));
                 int subsequentHeader = PacketUtils.ReadInt(subsequentReader);
                 subsequentReader.BaseStream.Position = 0; // Reset position

                 if (subsequentHeader == -2)
                 {
                      MultiPacketInfo subsequentPacketInfo = ParseMultiPacketHeader(subsequentReader);
                      // Check if it belongs to the same response sequence
                      if (subsequentPacketInfo.ID == packetInfo.ID && !packets.ContainsKey(subsequentPacketInfo.Number))
                      {
                          packets[subsequentPacketInfo.Number] = subsequentPacketInfo.Payload.ToArray();
                          Console.WriteLine($"Received packet {subsequentPacketInfo.Number + 1}/{packetInfo.Total} for ID {packetInfo.ID}");
                      }
                      else
                      {
                         Console.WriteLine($"Received out-of-order or duplicate packet {subsequentPacketInfo.Number + 1}, ID {subsequentPacketInfo.ID}. Ignoring.");
                      }
                 }
                 else
                 {
                     Console.WriteLine($"Received non-multi-packet header ({subsequentHeader}) while expecting more packets. Aborting.");
                     throw new InvalidDataException("Unexpected packet header during multi-packet receive.");
                 }
             }

             // Combine payloads in order
             var combinedPayload = packets.OrderBy(kvp => kvp.Key)
                                      .SelectMany(kvp => kvp.Value)
                                      .ToArray();

            Console.WriteLine($"Successfully received {packets.Count} packets for ID {packetInfo.ID}.");

             // Decompress if necessary (check the flag from the first packet)
             if (packetInfo.Compressed)
             {
                  Console.WriteLine("Decompressing BZip2 payload...");
                 // Need to handle the uncompressed size prefix if present (GoldSource doesn't have it)
                 if (combinedPayload.Length > 4) // Basic check, might need refinement
                 {
                     // Assuming Source format: skip 4-byte uncompressed size
                     // TODO: Verify BZip2 decompression logic and size prefix handling for different engine versions
                     // return PacketUtils.DecompressBZip2(combinedPayload.Skip(4).ToArray());
                 }
                 // Fallback or GoldSource assumption: No size prefix
                 return PacketUtils.DecompressBZip2(combinedPayload);
             }
             else
             {
                 return combinedPayload;
             }
        }
        else // Unexpected header
        {
            throw new InvalidDataException($"Unexpected A2S response header value: {header}");
        }
    }

    // Helper method to parse the multi-packet header (adapted from old A2S.cs)
    private static MultiPacketInfo ParseMultiPacketHeader(BinaryReader reader)
    {
        var info = new MultiPacketInfo
        {
            ID = PacketUtils.ReadInt(reader) // Read ID (first int after -2 header)
        };

        // Check if it's compressed format (GoldSource/Older Source)
        if ((info.ID & 0x80000000) != 0)
        {
            info.Compressed = true;
            info.ID &= 0x7FFFFFFF; // Remove the compression flag bit
            info.Total = PacketUtils.ReadByte(reader);
            info.Number = PacketUtils.ReadByte(reader);
            // GoldSource doesn't send packet size in header, payload is rest of packet
            info.Payload = reader.ReadBytes((int)(reader.BaseStream.Length - reader.BaseStream.Position)).ToList();

        }
        else // Standard Source engine format
        {
            info.Compressed = false; // Assuming standard source is not compressed this way
            info.Total = PacketUtils.ReadByte(reader);
            info.Number = PacketUtils.ReadByte(reader);
            info.Size = PacketUtils.ReadShort(reader); // Size of this packet's payload
            // Ensure we don't read past the end of the stream
            int bytesAvailable = (int)(reader.BaseStream.Length - reader.BaseStream.Position);
            int bytesToRead = Math.Min(info.Size, bytesAvailable);
            if (bytesToRead < info.Size) {
                Console.WriteLine($"Warning: Packet size mismatch. Expected {info.Size}, but only {bytesAvailable} available.");
            }
            info.Payload = reader.ReadBytes(bytesToRead).ToList();
        }

        return info;
    }

    // Payloads for Player challenge/response (from old A2S.cs)
    private static byte[] BuildChallengeRequestPayload() => new byte[] { 0xFF, 0xFF, 0xFF, 0xFF, 0x55, 0xFF, 0xFF, 0xFF, 0xFF };
    private static byte[] BuildPlayerRequestPayload(int challenge) => new byte[] { 0xFF, 0xFF, 0xFF, 0xFF, 0x55 }.Concat(BitConverter.GetBytes(challenge)).ToArray();

    // Parsing Logic placeholders - NEED IMPLEMENTATION based on A2S protocol spec
    private static ServerInfo ParseInfoResponse(string address, BinaryReader br)
    {
        // At this point, the response should have a valid header.
        byte header = PacketUtils.ReadByte(br);
        
        if (header != 0x49 && header != 0x6D) // 'I' or 'm' for info
        {
            throw new InvalidDataException($"Unexpected A2S_INFO response header: {header:X}");
        }

        var serverInfo = new ServerInfo
        {
            Protocol = PacketUtils.ReadByte(br),
            Name = PacketUtils.ReadString(br),
            Map = PacketUtils.ReadString(br),
            Folder = PacketUtils.ReadString(br),
            Game = PacketUtils.ReadString(br),
            ID = PacketUtils.ReadShort(br),
            Players = PacketUtils.ReadByte(br),
            MaxPlayers = PacketUtils.ReadByte(br),
            Bots = PacketUtils.ReadByte(br),
            ServerType = (ASP_site.Models.ServerBrowser.ServerType)PacketUtils.ReadByte(br),
            Environment = (ASP_site.Models.ServerBrowser.Environment)PacketUtils.ReadByte(br),
            Visibility = (Visibility)PacketUtils.ReadByte(br),
            VAC = (VAC)PacketUtils.ReadByte(br),
            Version = PacketUtils.ReadString(br)
        };

        // Check for Extra Data Flag (EDF)
        if (br.BaseStream.Position < br.BaseStream.Length)
        {
             serverInfo.EDF = PacketUtils.ReadByte(br);

             if ((serverInfo.EDF & 0x80) != 0) // Port
                serverInfo.Port = PacketUtils.ReadShort(br);
             if ((serverInfo.EDF & 0x10) != 0) // SteamID
                serverInfo.SteamID = PacketUtils.ReadLong(br);
             if ((serverInfo.EDF & 0x40) != 0) // SourceTV Info
             {
                serverInfo.SpectatorPort = PacketUtils.ReadShort(br);
                serverInfo.SpectatorName = PacketUtils.ReadString(br);
             }
             if ((serverInfo.EDF & 0x20) != 0) // Keywords/Tags
                serverInfo.Keywords = PacketUtils.ReadString(br);
             if ((serverInfo.EDF & 0x01) != 0) // GameID
                serverInfo.GameID = PacketUtils.ReadLong(br);
        }
        
        return serverInfo;
    }

    private static int ParseChallengeResponse(byte[] data)
    {
        using var ms = new MemoryStream(data);
        using var br = new BinaryReader(ms);

        byte header = PacketUtils.ReadByte(br);
        // Simple challenge response check (Header should be 0x41)
        if (header != 0x41)
           throw new InvalidDataException($"Unexpected A2S_CHALLENGE response header: {header:X}");
        
        // Skip the rest of the header (should be 0xFFFFFFFF 0x41)
        ms.Seek(4, SeekOrigin.Current); // Move 4 bytes forward from current position

        return PacketUtils.ReadInt(br); // Read the 32-bit challenge number
    }

    private static PlayerInfo ParseSinglePlayer(BinaryReader br)
    {
        // A2S_PLAYER response format for each player:
        // byte: Index (starting from 0)
        // string: Name
        // long: Score (32-bit integer)
        // float: Duration (seconds connected)

        byte index = PacketUtils.ReadByte(br); // Read and discard index
        string name = PacketUtils.ReadString(br);
        int score = PacketUtils.ReadInt(br); // Read score as Int32
        float duration = PacketUtils.ReadFloat(br);

        return new PlayerInfo(name, score, duration);
    }

    private static MasterInfo ParseSingleMasterServer(BinaryReader br)
    {
        // Master server response format: 6 bytes per server (IP:Port)
        // byte[4]: IP Address
        // short: Port (network byte order)

        byte[] ipBytes = br.ReadBytes(4);
        // Read port as short and convert from network to host byte order
        ushort port = (ushort)IPAddress.NetworkToHostOrder(br.ReadInt16());
        var ipAddress = new IPAddress(ipBytes);

        return new MasterInfo(ipAddress, port);
    }

} 