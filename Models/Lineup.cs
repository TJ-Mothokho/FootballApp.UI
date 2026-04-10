namespace FootballApp.UI.Models;

public class Lineup
{
    public string Formation { get; set; } = "4-2-3-1";
    public List<LineupPlayer> StartingPlayers { get; set; } = new();
    public List<LineupPlayer> Substitutes { get; set; } = new();
    public string Team { get; set; } = "";
    public string TeamName { get; set; } = "";
}
