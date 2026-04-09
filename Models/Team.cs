namespace FootballApp.UI.Models;
public class Team
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public string ShortName { get; set; } = "";
    public string LogoUrl { get; set; } = "";
    public string Stadium { get; set; } = "";
    public string City { get; set; } = "";
    public string League { get; set; } = "";  // "PSL" or "NFD"
    public string Coach { get; set; } = "";
    public int Founded { get; set; }
    public string Colors { get; set; } = "";
}
