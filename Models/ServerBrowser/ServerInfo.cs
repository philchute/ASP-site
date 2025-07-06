using System.Net;
using ASP_site.Models;

namespace ASP_site.Models.ServerBrowser
{
    /// <summary>
    /// The type of server.
    /// </summary>
    public enum ServerType : byte
    {
        /// <summary>
        /// Dedicated server.
        /// </summary>
        Dedicated = (byte)'d',

        /// <summary>
        /// Non-dedicated server.
        /// </summary>
        Listen = (byte)'l',

        /// <summary>
        /// SourceTV relay (proxy).
        /// </summary>
        SourceTV = (byte)'p'
    }

    /// <summary>
    /// The operating system of the server.
    /// </summary>
    public enum Environment : byte
    {
        /// <summary>
        /// Linux server.
        /// </summary>
        Linux = (byte)'l',

        /// <summary>
        /// Windows server.
        /// </summary>
        Windows = (byte)'w',

        /// <summary>
        /// Mac server.
        /// </summary>
        Mac = (byte)'m' // or (byte)'o'
    }

    /// <summary>
    /// Indicates whether the server requires password protection.
    /// </summary>
    public enum Visibility : byte
    {
        /// <summary>
        /// Public server.
        /// </summary>
        Public = 0,

        /// <summary>
        /// Private server.
        /// </summary>
        Private = 1
    }

    /// <summary>
    /// Specifies whether the server uses VAC.
    /// </summary>
    public enum VAC : byte
    {
        /// <summary>
        /// Unsecured server.
        /// </summary>
        Unsecured = 0,

        /// <summary>
        /// Secured server.
        /// </summary>
        Secured = 1
    }

    public class ServerInfo
    {
        /// <summary>
        /// Protocol version used by the server.
        /// </summary>
        public byte Protocol { get; set; }

        /// <summary>
        /// Name of the server.
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Map the server has currently loaded.
        /// </summary>
        public string Map { get; set; } = string.Empty;

        /// <summary>
        /// Name of the folder containing the game files.
        /// </summary>
        public string Folder { get; set; } = string.Empty;

        /// <summary>
        /// Full name of the game.
        /// </summary>
        public string Game { get; set; } = string.Empty;

        /// <summary>
        /// Steam Application ID of the game.
        /// </summary>
        public short ID { get; set; }

        /// <summary>
        /// Number of players on the server.
        /// </summary>
        public byte Players { get; set; }

        /// <summary>
        /// Maximum number of players the server reports it can hold.
        /// </summary>
        public byte MaxPlayers { get; set; }

        /// <summary>
        /// Number of bots on the server.
        /// </summary>
        public byte Bots { get; set; }

        /// <summary>
        /// Indicates the type of server.
        /// </summary>
        public ServerType ServerType { get; set; }

        /// <summary>
        /// Indicates the operating system of the server.
        /// </summary>
        public Environment Environment { get; set; }

        /// <summary>
        /// Indicates whether the server requires a password for entry.
        /// </summary>
        public Visibility Visibility { get; set; }

        /// <summary>
        /// Specifies whether the server uses VAC.
        /// </summary>
        public VAC VAC { get; set; }

        /// <summary>
        /// Version of the game installed on the server.
        /// </summary>
        public string Version { get; set; } = string.Empty;

        /// <summary>
        /// Extra Data Flag (EDF).
        /// </summary>
        public byte EDF { get; set; }

        /// <summary>
        /// Server's game port number.
        /// </summary>
        public short? Port { get; set; }

        /// <summary>
        /// Server's SteamID.
        /// </summary>
        public long? SteamID { get; set; }

        /// <summary>
        /// Spectator port number for SourceTV.
        /// </summary>
        public short? SpectatorPort { get; set; }

        /// <summary>
        /// Name of the spectator server for SourceTV.
        /// </summary>
        public string? SpectatorName { get; set; }

        /// <summary>
        /// Tags that describe the game according to the server.
        /// </summary>
        public string? Keywords { get; set; }

        /// <summary>
        /// The server's 64-bit GameID.
        /// </summary>
        public long? GameID { get; set; }

        public GameServerItem MapToGameServerItem(Game game, IPAddress address, ushort port)
        {
            return new GameServerItem(address, port, game)
            {
                Name = this.Name ?? string.Empty,
                Players = this.Players,
                MaxPlayers = this.MaxPlayers,
                Map = this.Map ?? string.Empty,
                Bots = this.Bots,
                Version = this.Version ?? string.Empty,
                PasswordProtected = (this.Visibility == Visibility.Private),
                RequiresVAC = (this.VAC == VAC.Secured),
                ServerType = this.ServerType,
                Environment = this.Environment
            };
        }
    }
} 