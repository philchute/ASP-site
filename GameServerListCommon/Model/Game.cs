using System.Text.Json.Serialization;

namespace ASP_site.GameServerListCommon.Model;

[JsonConverter(typeof(JsonStringEnumConverter<MasterServerType>))]
public enum MasterServerType
{
  GoldSource = 0,
  Source = 1,
  DarkMessiah = 2
}

public class Game
{
  [JsonIgnore]
  public int Index { get; set; }

  public string Name { get; set; } = string.Empty;

  public string Icon { get; set; } = string.Empty;

  public string? Gamedir { get; set; }

  public int? AppId { get; set; }

  public MasterServerType? MasterServer { get; set; }

  // Properties likely added/used by the App layer
  public bool? NoBackgroundService { get; set; } // From games.json
  public bool? UseDefinedServerList { get; set; } // Set based on loading logic?
  public string? Filters { get; set; } // Where does this come from? Add as placeholder.

  [JsonIgnore] // State managed by GameDataService / GameServerWorker
  public List<string>? Servers { get; set; }
  [JsonIgnore] // State managed by GameDataService / GameServerWorker
  public List<GameServerItem>? GameServers { get; set; }

  [JsonIgnore]
  public string GameId => AppId?.ToString() ?? Gamedir ?? string.Empty;

  [JsonIgnore]
  public string Folder => AppId?.ToString() ?? Gamedir ?? string.Empty;

  // Method used by GameServerWorker / Service logic
  public bool UsesBackgroundService() => !(NoBackgroundService ?? false);
} 