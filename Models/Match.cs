namespace FootballApp.UI.Models;
public class Match
{
    public int Id { get; set; }
    public int HomeTeamId { get; set; }
    public string HomeTeamName { get; set; } = "";
    public string HomeTeamLogo { get; set; } = "";
    public int AwayTeamId { get; set; }
    public string AwayTeamName { get; set; } = "";
    public string AwayTeamLogo { get; set; } = "";
    public int HomeScore { get; set; }
    public int AwayScore { get; set; }
    public DateTime KickoffTime { get; set; }
    public string Status { get; set; } = "Upcoming"; // Upcoming, Live, Finished
    public string Minute { get; set; } = "";
    public string League { get; set; } = "";
    public string Stadium { get; set; } = "";
    public string Round { get; set; } = "";
}
