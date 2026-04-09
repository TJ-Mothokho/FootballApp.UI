namespace FootballApp.UI.Models;
public class LineupPlayer
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public string Number { get; set; } = "";
    public string Position { get; set; } = "";
    public bool IsStarter { get; set; }
    public string Team { get; set; } = ""; // "Home" or "Away"
}
