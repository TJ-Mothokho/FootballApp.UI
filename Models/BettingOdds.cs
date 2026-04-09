namespace FootballApp.UI.Models;
public class BettingOdds
{
    public int MatchId { get; set; }
    public string HomeWin { get; set; } = "";
    public string Draw { get; set; } = "";
    public string AwayWin { get; set; } = "";
    public string Provider { get; set; } = "SuperBet";
}
