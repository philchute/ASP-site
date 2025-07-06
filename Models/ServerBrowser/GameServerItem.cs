using System.Net;
using ASP_site.Models.ServerBrowser;
using ASP_site.Models;

namespace ASP_site.Models.ServerBrowser
{
    public class GameServerItem
    {
        public IPAddress Address { get; set; }

        public ushort Port { get; set; }

        public Game Game { get; set; }

        public string Name { get; set; }

        public string Map { get; set; }

        public int Ping { get; set; } = -1;

        public bool PasswordProtected { get; set; }

        public bool RequiresVAC { get; set; }

        public byte Players { get; set; }

        public byte MaxPlayers { get; set; }

        public byte Bots { get; set; }

        public ServerType ServerType { get; set; }

        public Environment Environment { get; set; }

        public string Version { get; set; }

        public string PlayersStr => Players + " / " + MaxPlayers;

        public GameServerItem(IPAddress address, ushort port, Game game)
        {
            Address = address;
            Port = port;
            Game = game;
            Name = string.Empty;
            Map = string.Empty;
            Version = string.Empty;
        }
    }
} 