namespace ASP_site.Models; 
public class Engine {
  public required string EngineID { get; set; }
  public required string Name { get; set; }
  public int? Year { get; set; }
  public string? Description { get; set; }
  public string ParentID { get; set; } = "";
  public List<Engine> Children { get; set; } = []; // needed for seeing this on Engine page?
  public List<Game> Games { get; set; } = []; // needed for seeing this on Engine page?
  public static Engine AddChildren(Engine e, List<Engine> allEngines) {
    e.Children = allEngines.Where(x => x.ParentID == e.EngineID).ToList();
    return e;
  }
  public static Engine AddGames(Engine e, List<Game> allGames) {
    e.Games = allGames.Where(x => x.EngineID == e.EngineID).ToList();
    return e;
  }
}