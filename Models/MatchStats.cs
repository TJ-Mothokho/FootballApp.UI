namespace FootballApp.UI.Models;
public class MatchStats
{
    public int MatchId { get; set; }
    public int HomePossession { get; set; }
    public int AwayPossession { get; set; }
    public int HomeShotsOnTarget { get; set; }
    public int AwayShotsOnTarget { get; set; }
    public int HomeShotsOffTarget { get; set; }
    public int AwayShotsOffTarget { get; set; }
    public int HomeCorners { get; set; }
    public int AwayCorners { get; set; }
    public int HomeFouls { get; set; }
    public int AwayFouls { get; set; }
    public int HomeYellowCards { get; set; }
    public int AwayYellowCards { get; set; }
    public int HomeRedCards { get; set; }
    public int AwayRedCards { get; set; }
    public int HomeOffsides { get; set; }
    public int AwayOffsides { get; set; }
}
