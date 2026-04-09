namespace FootballApp.UI.Models;
public class NewsArticle
{
    public int Id { get; set; }
    public string Title { get; set; } = "";
    public string Summary { get; set; } = "";
    public string Content { get; set; } = "";
    public string ImageUrl { get; set; } = "";
    public string Author { get; set; } = "";
    public DateTime PublishedAt { get; set; }
    public string Category { get; set; } = ""; // General, Transfers, MatchReport
    public string? TeamName { get; set; }
    public string? League { get; set; }
}
