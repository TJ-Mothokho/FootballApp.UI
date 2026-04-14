namespace FootballApp.UI.Models;

public class HeroContent
{
    public string Type { get; set; } = ""; // "Match" or "News"
    public Match? Match { get; set; }
    public NewsArticle? News { get; set; }
}
