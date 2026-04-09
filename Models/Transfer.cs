namespace FootballApp.UI.Models;
public class Transfer
{
    public int Id { get; set; }
    public string PlayerName { get; set; } = "";
    public string FromTeam { get; set; } = "";
    public string ToTeam { get; set; } = "";
    public string Fee { get; set; } = ""; // e.g. "R5M", "Free", "Loan"
    public DateTime Date { get; set; }
    public string League { get; set; } = "";
    public string PlayerPosition { get; set; } = "";
    public string? PlayerPhotoUrl { get; set; }
}
