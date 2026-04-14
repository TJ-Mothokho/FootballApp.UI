using FootballApp.UI.Utils;

namespace FootballApp.UI.Models;
public class Match
{
    public int Id { get; set; }
    public int HomeTeamId { get; set; }
    public string HomeTeamName { get; set; } = "";
    public string HomeTeamLogo => LogoHelper.GetTeamLogo(HomeTeamName);
    public int AwayTeamId { get; set; }
    public string AwayTeamName { get; set; } = "";
    public string AwayTeamLogo => LogoHelper.GetTeamLogo(AwayTeamName);
    public int HomeScore { get; set; }
    public int AwayScore { get; set; }
    public DateTime KickoffTime { get; set; }
    public string Status { get; set; } = "Upcoming"; // Upcoming, Live, Finished
    public string Minute { get; set; } = "";
    public string League { get; set; } = "";
    public string Stadium { get; set; } = "";
    public string Round { get; set; } = "";
}
