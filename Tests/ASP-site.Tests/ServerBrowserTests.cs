using System.Net;
using ASP_site.Helpers;
using ASP_site.Models;
using ASP_site.Models.ServerBrowser;
using ASP_site.Pages.Servers;

namespace ASP_site.Tests
{
    public class ServerBrowserTests
    {
        private static Game SteamGame() => new()
        {
            GameID = "css",
            Name = "Counter-Strike: Source",
            EngineID = "source",
            SteamID = 240,
            ServerConfig = new ServerBrowserConfig { GameDirectory = "cstrike" }
        };

        private static Game UnrealGame() => new()
        {
            GameID = "ut",
            Name = "Unreal Tournament 99",
            EngineID = "unreal",
            ServerConfig = new ServerBrowserConfig
            {
                MasterServerKey = "333networks",
                QueryProtocol = "GameSpy"
            }
        };

        [Fact]
        public void SteamMapping_DoesNotTreatDedicatedAsPassword()
        {
            var api = new SteamApiServer
            {
                Address = "1.2.3.4:27015",
                GamePort = 27015,
                Name = "Test",
                Map = "de_dust",
                Players = 4,
                MaxPlayers = 16,
                Dedicated = true,
                Secure = true,
                OS = "l",
                GameType = "dust"
            };

            var mapped = api.MapToGameServerItem(SteamGame());

            Assert.Null(mapped.PasswordProtected);
            Assert.True(mapped.RequiresVAC);
            Assert.Equal(ASP_site.Models.ServerBrowser.ServerType.Dedicated, mapped.ServerType);
            Assert.Equal("dust", mapped.GameType);
        }

        [Fact]
        public void ThreeNetworksParse_MapsGametypeCountryAndTotal()
        {
            const string json = """
                [[{"hostname":"Green's Lair","mapname":"AS-LavaFort","maptitle":"Lava Fort","hostport":7777,"numplayers":2,"maxplayers":8,"gametype":"Assault","gamename":"ut","ip":"::ffff:82.165.208.134","country":"US"}],{"total":798,"players":2}]
                """;

            var parsed = ThreeNetworksQuery.ParseResponse(json, UnrealGame());

            Assert.Equal(798, parsed.Total);
            var server = Assert.Single(parsed.Servers);
            Assert.Equal("Green's Lair", server.Name);
            Assert.Equal("AS-LavaFort (Lava Fort)", server.Map);
            Assert.Equal("Assault", server.GameType);
            Assert.Equal("US", server.Country);
            Assert.Equal(IPAddress.Parse("82.165.208.134"), server.Address);
            Assert.Equal(2, server.Players);
        }

        [Fact]
        public void ApplyFiltersAndSort_HidesEmptyAndNullVacDoesNotMatchYes()
        {
            var game = SteamGame();
            var servers = new[]
            {
                new GameServerItem(IPAddress.Loopback, 27015, game) { Name = "Empty", Players = 0, MaxPlayers = 16, RequiresVAC = true },
                new GameServerItem(IPAddress.Loopback, 27016, game) { Name = "Busy", Players = 8, MaxPlayers = 16, RequiresVAC = null },
                new GameServerItem(IPAddress.Loopback, 27017, game) { Name = "Secure", Players = 3, MaxPlayers = 16, RequiresVAC = true }
            };

            var hiddenEmpty = ServerBrowserUi.ApplyFiltersAndSort(servers, "all", "all", hideEmpty: true, hideFull: false, "players", null);
            Assert.Equal(2, hiddenEmpty.Count);
            Assert.Equal("Busy", hiddenEmpty[0].Name);

            var vacYes = ServerBrowserUi.ApplyFiltersAndSort(servers, "yes", "all", hideEmpty: false, hideFull: false, "name", null);
            Assert.Equal(2, vacYes.Count);
            Assert.DoesNotContain(vacYes, s => s.Name == "Busy");
        }

        [Fact]
        public void ConnectCommand_UsesOpenForUnrealAndConnectForSteam()
        {
            Assert.Equal("open 1.2.3.4:7777", ServerBrowserUi.ConnectCommand(UnrealGame(), "1.2.3.4:7777"));
            Assert.Equal("connect 1.2.3.4:27015", ServerBrowserUi.ConnectCommand(SteamGame(), "1.2.3.4:27015"));
            Assert.Null(ServerBrowserUi.SteamConnectUrl(UnrealGame(), "1.2.3.4:7777"));
            Assert.Equal("steam://connect/1.2.3.4:27015", ServerBrowserUi.SteamConnectUrl(SteamGame(), "1.2.3.4:27015"));
        }

        [Fact]
        public void GameSelectItems_AreAlphabeticalWithBackendInLabel()
        {
            var items = IndexModel.BuildGameSelectItems([UnrealGame(), SteamGame()]);
            Assert.Equal(2, items.Count);
            Assert.Equal("css", items[0].Value);
            Assert.Equal("Counter-Strike: Source (source mod)", items[0].Text);
            Assert.Null(items[0].Group);
            Assert.Equal("ut", items[1].Value);
            Assert.Equal("Unreal Tournament 99 (333networks)", items[1].Text);
        }

        [Fact]
        public void MasterGameName_OverridesGameIdForSlug()
        {
            var config = new ServerBrowserConfig
            {
                MasterServerKey = "333networks",
                MasterGameName = "nerf"
            };
            Assert.Equal("nerf", config.GetMasterGameName("nerfarena"));
            Assert.Equal("ut", new ServerBrowserConfig().GetMasterGameName("ut"));
        }
    }
}
