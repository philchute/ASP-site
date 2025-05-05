namespace ASP_site.GameServerListCommon.Model.A2S;

public class PlayerInfo
{
  public string Name { get; set; }

  public int Score { get; set; }

  public float Duration { get; set; }

  public PlayerInfo(string name, int score, float duration)
  {
    Name = name;
    Score = score;
    Duration = duration;
  }

  public override string ToString()
  {
    return $"Name: {Name}, Score: {Score}, Duration: {Duration}";
  }
} 