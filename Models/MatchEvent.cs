namespace FootballApp.UI.Models;
public class MatchEvent
{
    public int Id { get; set; }
    public int MatchId { get; set; }
    public int Minute { get; set; }
    public string Type { get; set; } = ""; // Goal, YellowCard, RedCard, Substitution
    public string PlayerName { get; set; } = "";
    public string? SecondPlayerName { get; set; } // For substitutions (player off)
    public string Team { get; set; } = ""; // "Home" or "Away"
    public string? AssistPlayerName { get; set; }
}
