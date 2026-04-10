using FootballApp.UI.Models;

namespace FootballApp.UI.Services;

/// <summary>
/// Standalone mock service providing structured lineup data with formation information.
/// Designed to be swapped for a real API client in the future.
/// </summary>
public class MockLineupService
{
    private readonly Dictionary<int, (Lineup Home, Lineup Away)> _lineups;

    public MockLineupService()
    {
        _lineups = new Dictionary<int, (Lineup, Lineup)>
        {
            [1] = (BuildSundDownsLineup(), BuildPiratesLineup()),
            [2] = (BuildChiefsLineup(), BuildSuperSportLineup()),
        };
    }

    public Lineup? GetHomeLineup(int matchId) =>
        _lineups.TryGetValue(matchId, out var pair) ? pair.Home : null;

    public Lineup? GetAwayLineup(int matchId) =>
        _lineups.TryGetValue(matchId, out var pair) ? pair.Away : null;

    public (Lineup? Home, Lineup? Away) GetMatchLineup(int matchId)
    {
        if (_lineups.TryGetValue(matchId, out var pair))
            return (pair.Home, pair.Away);
        return (null, null);
    }

    // ─── Mamelodi Sundowns – 4-2-3-1 ────────────────────────────────────────

    private static Lineup BuildSundDownsLineup() => new()
    {
        Formation = "4-2-3-1",
        Team = "Home",
        TeamName = "Mamelodi Sundowns",
        StartingPlayers = new List<LineupPlayer>
        {
            new() { Id = 1,  Name = "Denis Onyango",    Number = "1",  Position = "GK",  IsStarter = true, Team = "Home", Rating = 7.2 },
            new() { Id = 4,  Name = "Thapelo Morena",   Number = "2",  Position = "RB",  IsStarter = true, Team = "Home", Rating = 7.0 },
            new() { Id = 2,  Name = "Rushine De Reuck", Number = "4",  Position = "CB",  IsStarter = true, Team = "Home", Rating = 7.1 },
            new() { Id = 3,  Name = "Mothobi Mvala",    Number = "5",  Position = "CB",  IsStarter = true, Team = "Home", Rating = 6.9 },
            new() { Id = 5,  Name = "Sifiso Hlanti",    Number = "3",  Position = "LB",  IsStarter = true, Team = "Home", Rating = 6.8 },
            new() { Id = 6,  Name = "Andile Jali",      Number = "23", Position = "CDM", IsStarter = true, Team = "Home", Rating = 7.3 },
            new() { Id = 10, Name = "Neo Maema",        Number = "11", Position = "CDM", IsStarter = true, Team = "Home", Rating = 7.0 },
            new() { Id = 8,  Name = "Lebohang Maboe",   Number = "7",  Position = "LW",  IsStarter = true, Team = "Home", Rating = 7.4 },
            new() { Id = 7,  Name = "Themba Zwane",     Number = "10", Position = "CAM", IsStarter = true, Team = "Home", Rating = 8.1 },
            new() { Id = 9,  Name = "Gaston Sirino",    Number = "8",  Position = "RW",  IsStarter = true, Team = "Home", Rating = 7.2 },
            new() { Id = 11, Name = "Peter Shalulile",  Number = "9",  Position = "ST",  IsStarter = true, Team = "Home", Rating = 8.5 },
        },
        Substitutes = new List<LineupPlayer>
        {
            new() { Id = 12, Name = "Kennedy Mweene",  Number = "16", Position = "GK", IsStarter = false, Team = "Home" },
            new() { Id = 13, Name = "Grant Kekana",    Number = "15", Position = "CB", IsStarter = false, Team = "Home" },
            new() { Id = 14, Name = "Divine Lunga",    Number = "18", Position = "LB", IsStarter = false, Team = "Home" },
            new() { Id = 15, Name = "Bathusi Aubaas",  Number = "20", Position = "MF", IsStarter = false, Team = "Home" },
            new() { Id = 16, Name = "Kermit Erasmus",  Number = "14", Position = "FW", IsStarter = false, Team = "Home" },
        }
    };

    // ─── Orlando Pirates – 4-2-3-1 ───────────────────────────────────────────

    private static Lineup BuildPiratesLineup() => new()
    {
        Formation = "4-2-3-1",
        Team = "Away",
        TeamName = "Orlando Pirates",
        StartingPlayers = new List<LineupPlayer>
        {
            new() { Id = 17, Name = "Richard Ofori",       Number = "1",  Position = "GK",  IsStarter = true, Team = "Away", Rating = 7.5 },
            new() { Id = 21, Name = "Paseka Mako",         Number = "2",  Position = "RB",  IsStarter = true, Team = "Away", Rating = 6.8 },
            new() { Id = 18, Name = "Nkosinathi Sibisi",   Number = "5",  Position = "CB",  IsStarter = true, Team = "Away", Rating = 7.0 },
            new() { Id = 19, Name = "Olisa Ndah",          Number = "4",  Position = "CB",  IsStarter = true, Team = "Away", Rating = 7.1 },
            new() { Id = 20, Name = "Deano van Rooyen",    Number = "3",  Position = "LB",  IsStarter = true, Team = "Away", Rating = 7.2 },
            new() { Id = 22, Name = "Thalente Mbatha",     Number = "6",  Position = "CM",  IsStarter = true, Team = "Away", Rating = 7.3 },
            new() { Id = 23, Name = "Goodman Mosele",      Number = "8",  Position = "CM",  IsStarter = true, Team = "Away", Rating = 7.0 },
            new() { Id = 24, Name = "Deon Hotto",          Number = "11", Position = "LW",  IsStarter = true, Team = "Away", Rating = 7.1 },
            new() { Id = 26, Name = "Zakhele Lepasa",      Number = "10", Position = "CAM", IsStarter = true, Team = "Away", Rating = 7.6 },
            new() { Id = 25, Name = "Monnapule Saleng",    Number = "7",  Position = "RW",  IsStarter = true, Team = "Away", Rating = 7.8 },
            new() { Id = 27, Name = "Evidence Makgopa",    Number = "9",  Position = "ST",  IsStarter = true, Team = "Away", Rating = 7.9 },
        },
        Substitutes = new List<LineupPlayer>
        {
            new() { Id = 28, Name = "Siyabonga Mpontshane", Number = "16", Position = "GK", IsStarter = false, Team = "Away" },
            new() { Id = 29, Name = "Bandile Shandu",       Number = "17", Position = "MF", IsStarter = false, Team = "Away" },
            new() { Id = 30, Name = "Kwame Peprah",         Number = "22", Position = "FW", IsStarter = false, Team = "Away" },
            new() { Id = 31, Name = "Fortune Makaringe",    Number = "14", Position = "MF", IsStarter = false, Team = "Away" },
            new() { Id = 32, Name = "Innocent Maela",       Number = "15", Position = "DF", IsStarter = false, Team = "Away" },
        }
    };

    // ─── Kaizer Chiefs – 4-3-3 ───────────────────────────────────────────────

    private static Lineup BuildChiefsLineup() => new()
    {
        Formation = "4-3-3",
        Team = "Home",
        TeamName = "Kaizer Chiefs",
        StartingPlayers = new List<LineupPlayer>
        {
            new() { Id = 50, Name = "Itumeleng Khune",  Number = "1",  Position = "GK",  IsStarter = true, Team = "Home", Rating = 6.8 },
            new() { Id = 51, Name = "Reeve Frosler",    Number = "2",  Position = "RB",  IsStarter = true, Team = "Home", Rating = 6.9 },
            new() { Id = 52, Name = "Edmilson Dove",    Number = "5",  Position = "CB",  IsStarter = true, Team = "Home", Rating = 7.0 },
            new() { Id = 53, Name = "Inacio Miguel",    Number = "4",  Position = "CB",  IsStarter = true, Team = "Home", Rating = 6.8 },
            new() { Id = 54, Name = "Dillan Solomons",  Number = "3",  Position = "LB",  IsStarter = true, Team = "Home", Rating = 6.7 },
            new() { Id = 55, Name = "Yusuf Maart",      Number = "8",  Position = "CM",  IsStarter = true, Team = "Home", Rating = 7.1 },
            new() { Id = 56, Name = "Samkelo Zwane",    Number = "6",  Position = "CM",  IsStarter = true, Team = "Home", Rating = 6.9 },
            new() { Id = 57, Name = "Siyethemba Sithebe", Number = "17", Position = "CM", IsStarter = true, Team = "Home", Rating = 6.8 },
            new() { Id = 58, Name = "Khama Billiat",    Number = "11", Position = "LW",  IsStarter = true, Team = "Home", Rating = 7.4 },
            new() { Id = 59, Name = "Christian Saile",  Number = "7",  Position = "RW",  IsStarter = true, Team = "Home", Rating = 7.0 },
            new() { Id = 60, Name = "Ashley du Preez",  Number = "9",  Position = "ST",  IsStarter = true, Team = "Home", Rating = 7.2 },
        },
        Substitutes = new List<LineupPlayer>
        {
            new() { Id = 61, Name = "Brandon Petersen", Number = "16", Position = "GK", IsStarter = false, Team = "Home" },
            new() { Id = 62, Name = "Zitha Kwinika",    Number = "15", Position = "CB", IsStarter = false, Team = "Home" },
            new() { Id = 63, Name = "Mduduzi Shabalala", Number = "22", Position = "MF", IsStarter = false, Team = "Home" },
            new() { Id = 64, Name = "Tashreeq Morris",  Number = "14", Position = "FW", IsStarter = false, Team = "Home" },
        }
    };

    // ─── SuperSport United – 4-4-2 ───────────────────────────────────────────

    private static Lineup BuildSuperSportLineup() => new()
    {
        Formation = "4-4-2",
        Team = "Away",
        TeamName = "SuperSport United",
        StartingPlayers = new List<LineupPlayer>
        {
            new() { Id = 70, Name = "Ronwen Williams",  Number = "1",  Position = "GK",  IsStarter = true, Team = "Away", Rating = 7.6 },
            new() { Id = 71, Name = "Onismor Bhasera",  Number = "2",  Position = "RB",  IsStarter = true, Team = "Away", Rating = 6.9 },
            new() { Id = 72, Name = "Bevan Fransman",   Number = "5",  Position = "CB",  IsStarter = true, Team = "Away", Rating = 7.0 },
            new() { Id = 73, Name = "Luke Fleurs",      Number = "4",  Position = "CB",  IsStarter = true, Team = "Away", Rating = 7.1 },
            new() { Id = 74, Name = "Keenan Philips",   Number = "3",  Position = "LB",  IsStarter = true, Team = "Away", Rating = 6.8 },
            new() { Id = 75, Name = "Sipho Mbule",      Number = "8",  Position = "CM",  IsStarter = true, Team = "Away", Rating = 7.4 },
            new() { Id = 76, Name = "Teboho Mokoena",   Number = "6",  Position = "CM",  IsStarter = true, Team = "Away", Rating = 7.2 },
            new() { Id = 77, Name = "Jayden Adams",     Number = "7",  Position = "LW",  IsStarter = true, Team = "Away", Rating = 7.0 },
            new() { Id = 78, Name = "Ghampani Lungu",   Number = "11", Position = "RW",  IsStarter = true, Team = "Away", Rating = 7.1 },
            new() { Id = 79, Name = "Bradley Grobler",  Number = "10", Position = "ST",  IsStarter = true, Team = "Away", Rating = 7.3 },
            new() { Id = 80, Name = "Iqraam Rayners",   Number = "9",  Position = "ST",  IsStarter = true, Team = "Away", Rating = 7.5 },
        },
        Substitutes = new List<LineupPlayer>
        {
            new() { Id = 81, Name = "Joris Delle",      Number = "22", Position = "GK", IsStarter = false, Team = "Away" },
            new() { Id = 82, Name = "Clayton Daniels",  Number = "15", Position = "CB", IsStarter = false, Team = "Away" },
            new() { Id = 83, Name = "Thamsanqa Gabuza", Number = "18", Position = "FW", IsStarter = false, Team = "Away" },
            new() { Id = 84, Name = "Kudakwashe Mahachi", Number = "14", Position = "MF", IsStarter = false, Team = "Away" },
        }
    };
}
