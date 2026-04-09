namespace FootballApp.UI.Models;
public class Standing
{
    public int Position { get; set; }
    public int TeamId { get; set; }
    public string TeamName { get; set; } = "";
    public string TeamLogo { get; set; } = "";
    public int Played { get; set; }
    public int Won { get; set; }
    public int Drawn { get; set; }
    public int Lost { get; set; }
    public int GoalsFor { get; set; }
    public int GoalsAgainst { get; set; }
    public int GoalDifference { get; set; }
    public int Points { get; set; }
    public string Form { get; set; } = ""; // e.g. "WWDLW"
}
