namespace FootballApp.UI.Models;
public class Player
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public string Position { get; set; } = "";
    public int TeamId { get; set; }
    public string TeamName { get; set; } = "";
    public string Nationality { get; set; } = "";
    public int Age { get; set; }
    public string PhotoUrl { get; set; } = "";
    public int Goals { get; set; }
    public int Assists { get; set; }
    public int Appearances { get; set; }
    public int YellowCards { get; set; }
    public int RedCards { get; set; }
    public string Number { get; set; } = "";
    public int ShirtNumber { get; set; }
    public string ImageUrl { get; set; } = "";
    public double Rating { get; set; }
    public bool IsSubstitute { get; set; }
}
