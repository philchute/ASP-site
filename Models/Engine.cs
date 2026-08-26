namespace ASP_site.Models;
public class Engine {
  public required string EngineID { get; set; }
  public required string Name { get; set; }
  public int? Year { get; set; }
  public string? Description { get; set; }
  public string? Developer { get; set; }
  public string? License { get; set; }
  public string? DebutGameID { get; set; }
  public string ParentID { get; set; } = "";
  public List<Engine> Children { get; set; } = new List<Engine>();
  public List<Game> Games { get; set; } = new List<Game>();
  public static List<Engine> AddChildren(Engine e, List<Engine> allEngines) {
    e.Children = allEngines.Where(x => x.ParentID == e.EngineID).ToList();
    return e.Children;
  }
  public static List<Game> AddGames(Engine e, List<Game> allGames) {
    e.Games = allGames.Where(x => x.EngineID == e.EngineID).ToList();
    return e.Games;
  }

  public static List<Engine> GetAncestry(Engine e, IReadOnlyDictionary<string, Engine> allEngines) {
    var ancestry = new List<Engine>();
    var seen = new HashSet<string> { e.EngineID };
    var currentId = e.ParentID;
    while (!string.IsNullOrEmpty(currentId) && allEngines.TryGetValue(currentId, out var parent) && seen.Add(parent.EngineID)) {
      ancestry.Add(parent);
      currentId = parent.ParentID;
    }
    ancestry.Reverse();
    return ancestry;
  }
}
