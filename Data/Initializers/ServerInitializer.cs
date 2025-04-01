using ASP_site.Models;

namespace ASP_site.Data.Initializers {
  public static class ServerInitializer {
    public static Server[] GetServers() {
      return new Server[] {
        new Server {
          IPAddress = "149.28.56.141:27015",
          Name = "TFPugs NYC",
          ServerType = ServerType.Pickup,
          Description = "TFPugs NYC pickup server",
          GameID = "TFC"
        },
        new Server {
          IPAddress = "149.28.56.141:27016",
          Name = "TFPugs Ricochet",
          ServerType = ServerType.Pickup,
          Description = "TFPugs Ricochet pickup server",
          GameID = "Ricochet"
        },
        new Server {
          IPAddress = "104.207.129.123:27015",
          Name = "TFPugs East 2",
          ServerType = ServerType.Pickup,
          Description = "TFPugs NYC pickup server",
          GameID = "TFC"
        },
        new Server {
          IPAddress = "45.77.162.42:27015",
          Name = "TFPugs South East",
          ServerType = ServerType.Pickup,
          Description = "TFPugs Miami pickup server",
          GameID = "TFC"
        },
        new Server {
          IPAddress = "149.28.241.217:27015",
          Name = "TFPugs Central",
          ServerType = ServerType.Pickup,
          Description = "TFPugs Dallas pickup server",
          GameID = "TFC"
        },
        new Server {
          IPAddress = "192.248.163.247:27015",
          Name = "TFPugs London",
          ServerType = ServerType.Pickup,
          Description = "TFPugs London pickup server",
          GameID = "TFC"
        },
        new Server {
          IPAddress = "13.58.188.77:27015",
          Name = "FF server",
          ServerType = ServerType.Pickup,
          Description = "Fortress Forever server",
          GameID = "FF"
        }
      };
    }
  }
}