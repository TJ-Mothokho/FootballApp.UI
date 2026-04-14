using FootballApp.UI.Models;
namespace FootballApp.UI.Services;

public class MockFootballDataService : IFootballDataService
{
    private readonly List<Team> _teams;
    private readonly List<Player> _players;
    private readonly List<Match> _matches;
    private readonly List<MatchStats> _matchStats;
    private readonly List<MatchEvent> _matchEvents;
    private readonly List<LineupPlayer> _lineupPlayers;
    private readonly List<NewsArticle> _news;
    private readonly List<Transfer> _transfers;
    private readonly List<Standing> _pslStandings;
    private readonly List<Standing> _nfdStandings;
    private readonly List<BettingOdds> _odds;

    public MockFootballDataService()
    {
        _teams = InitTeams();
        _players = InitPlayers();
        _matches = InitMatches();
        _matchStats = InitMatchStats();
        _matchEvents = InitMatchEvents();
        _lineupPlayers = InitLineups();
        _news = InitNews();
        _transfers = InitTransfers();
        _pslStandings = InitPSLStandings();
        _nfdStandings = InitNFDStandings();
        _odds = InitOdds();
    }

    private List<Team> InitTeams() => new()
    {
        new Team { Id = 1, Name = "Mamelodi Sundowns", ShortName = "Sundowns", Stadium = "Loftus Versfeld", City = "Pretoria", League = "PSL", Coach = "Miguel Cardoso", Founded = 1970, Colors = "Yellow & Green" },
        new Team { Id = 2, Name = "Kaizer Chiefs", ShortName = "Chiefs", Stadium = "FNB Stadium", City = "Johannesburg", League = "PSL", Coach = "Nasreddine Nabi", Founded = 1970, Colors = "Gold & Black" },
        new Team { Id = 3, Name = "Orlando Pirates", ShortName = "Pirates", Stadium = "Orlando Stadium", City = "Soweto", League = "PSL", Coach = "José Riveiro", Founded = 1937, Colors = "Black & White" },
        new Team { Id = 4, Name = "SuperSport United", ShortName = "SuperSport", Stadium = "Lucas Moripe Stadium", City = "Pretoria", League = "PSL", Coach = "Gavin Hunt", Founded = 1994, Colors = "Blue & White" },
        new Team { Id = 5, Name = "Cape Town City", ShortName = "CTC", Stadium = "DHL Newlands Stadium", City = "Cape Town", League = "PSL", Coach = "Eric Tinkler", Founded = 2016, Colors = "Navy & White" },
        new Team { Id = 6, Name = "AmaZulu FC", ShortName = "AmaZulu", Stadium = "Moses Mabhida Stadium", City = "Durban", League = "PSL", Coach = "Pablo Franco Martin", Founded = 1932, Colors = "Green & Black" },
        new Team { Id = 7, Name = "Stellenbosch FC", ShortName = "Stellies", Stadium = "Danie Craven Stadium", City = "Stellenbosch", League = "PSL", Coach = "Steve Barker", Founded = 1994, Colors = "Maroon & White" },
        new Team { Id = 8, Name = "TS Galaxy", ShortName = "Galaxy", Stadium = "Mbombela Stadium", City = "Mbombela", League = "PSL", Coach = "Sead Ramovic", Founded = 1999, Colors = "Purple & White" },
        new Team { Id = 9, Name = "Chippa United", ShortName = "Chippa", Stadium = "Nelson Mandela Bay Stadium", City = "Gqeberha", League = "PSL", Coach = "Morgan Mammila", Founded = 2010, Colors = "Orange & Black" },
        new Team { Id = 10, Name = "Sekhukhune United", ShortName = "Sekhukhune", Stadium = "Peter Mokaba Stadium", City = "Polokwane", League = "PSL", Coach = "Brandon Truter", Founded = 2014, Colors = "Red & White" },
        new Team { Id = 11, Name = "Polokwane City", ShortName = "Polokwane", Stadium = "Peter Mokaba Stadium", City = "Polokwane", League = "PSL", Coach = "Kaitano Tembo", Founded = 1978, Colors = "Green & White" },
        new Team { Id = 12, Name = "Golden Arrows", ShortName = "Arrows", Stadium = "Sugar Ray Xulu Stadium", City = "Durban", League = "PSL", Coach = "Lehlohonolo Seema", Founded = 1943, Colors = "Gold & Black" },
        new Team { Id = 13, Name = "Cape Town All Stars", ShortName = "All Stars", Stadium = "Athlone Stadium", City = "Cape Town", League = "NFD", Coach = "David Kannemeyer", Founded = 2008, Colors = "Blue & White" },
        new Team { Id = 14, Name = "Hungry Lions", ShortName = "Lions", Stadium = "Dr Petrus Molemela Stadium", City = "Bloemfontein", League = "NFD", Coach = "Teboho Moloi", Founded = 2000, Colors = "Orange & Black" },
        new Team { Id = 15, Name = "Uthongathi FC", ShortName = "Uthongathi", Stadium = "King Zwelithini Stadium", City = "Durban", League = "NFD", Coach = "Siboniso Zuma", Founded = 2012, Colors = "Purple & White" },
        new Team { Id = 16, Name = "Royal AM", ShortName = "Royal AM", Stadium = "Chatsworth Stadium", City = "Durban", League = "NFD", Coach = "John Maduka", Founded = 2016, Colors = "Purple & Gold" },
    };

    private List<Player> InitPlayers() => new()
    {
        new Player { Id = 1, Name = "Themba Zwane", Position = "Midfielder", TeamId = 1, TeamName = "Mamelodi Sundowns", Nationality = "South African", Age = 34, Goals = 12, Assists = 8, Appearances = 28, YellowCards = 3, RedCards = 0, Number = "10" },
        new Player { Id = 2, Name = "Peter Shalulile", Position = "Forward", TeamId = 1, TeamName = "Mamelodi Sundowns", Nationality = "Namibian", Age = 30, Goals = 18, Assists = 5, Appearances = 26, YellowCards = 2, RedCards = 0, Number = "9" },
        new Player { Id = 3, Name = "Rushine De Reuck", Position = "Defender", TeamId = 1, TeamName = "Mamelodi Sundowns", Nationality = "South African", Age = 29, Goals = 2, Assists = 1, Appearances = 27, YellowCards = 5, RedCards = 0, Number = "4" },
        new Player { Id = 4, Name = "Khama Billiat", Position = "Forward", TeamId = 2, TeamName = "Kaizer Chiefs", Nationality = "Zimbabwean", Age = 33, Goals = 8, Assists = 6, Appearances = 22, YellowCards = 1, RedCards = 0, Number = "11" },
        new Player { Id = 5, Name = "Yusuf Maart", Position = "Midfielder", TeamId = 2, TeamName = "Kaizer Chiefs", Nationality = "South African", Age = 28, Goals = 4, Assists = 3, Appearances = 25, YellowCards = 6, RedCards = 1, Number = "8" },
        new Player { Id = 6, Name = "Itumeleng Khune", Position = "Goalkeeper", TeamId = 2, TeamName = "Kaizer Chiefs", Nationality = "South African", Age = 37, Goals = 0, Assists = 0, Appearances = 15, YellowCards = 1, RedCards = 0, Number = "1" },
        new Player { Id = 7, Name = "Evidence Makgopa", Position = "Forward", TeamId = 3, TeamName = "Orlando Pirates", Nationality = "South African", Age = 24, Goals = 14, Assists = 3, Appearances = 24, YellowCards = 2, RedCards = 0, Number = "9" },
        new Player { Id = 8, Name = "Thalente Mbatha", Position = "Midfielder", TeamId = 3, TeamName = "Orlando Pirates", Nationality = "South African", Age = 26, Goals = 3, Assists = 7, Appearances = 26, YellowCards = 4, RedCards = 0, Number = "6" },
        new Player { Id = 9, Name = "Deano van Rooyen", Position = "Defender", TeamId = 3, TeamName = "Orlando Pirates", Nationality = "South African", Age = 28, Goals = 1, Assists = 2, Appearances = 23, YellowCards = 3, RedCards = 0, Number = "3" },
        new Player { Id = 10, Name = "Bradley Grobler", Position = "Forward", TeamId = 4, TeamName = "SuperSport United", Nationality = "South African", Age = 35, Goals = 10, Assists = 4, Appearances = 20, YellowCards = 1, RedCards = 0, Number = "10" },
        new Player { Id = 11, Name = "Sipho Mbule", Position = "Midfielder", TeamId = 4, TeamName = "SuperSport United", Nationality = "South African", Age = 25, Goals = 5, Assists = 9, Appearances = 27, YellowCards = 3, RedCards = 0, Number = "8" },
        new Player { Id = 12, Name = "Fagrie Lakay", Position = "Forward", TeamId = 5, TeamName = "Cape Town City", Nationality = "South African", Age = 30, Goals = 9, Assists = 5, Appearances = 25, YellowCards = 2, RedCards = 0, Number = "7" },
        new Player { Id = 13, Name = "George Matlou", Position = "Midfielder", TeamId = 6, TeamName = "AmaZulu FC", Nationality = "South African", Age = 32, Goals = 3, Assists = 6, Appearances = 24, YellowCards = 4, RedCards = 0, Number = "8" },
        new Player { Id = 14, Name = "Siphiwe Tshabalala", Position = "Midfielder", TeamId = 7, TeamName = "Stellenbosch FC", Nationality = "South African", Age = 40, Goals = 2, Assists = 4, Appearances = 18, YellowCards = 1, RedCards = 0, Number = "22" },
        new Player { Id = 15, Name = "Lyle Foster", Position = "Forward", TeamId = 8, TeamName = "TS Galaxy", Nationality = "South African", Age = 23, Goals = 11, Assists = 2, Appearances = 22, YellowCards = 2, RedCards = 0, Number = "9" },
    };

    private List<Match> InitMatches()
    {
        var now = DateTime.Now;
        return new()
        {
            new Match { Id = 1, HomeTeamId = 1, HomeTeamName = "Mamelodi Sundowns", AwayTeamId = 3, AwayTeamName = "Orlando Pirates", HomeScore = 2, AwayScore = 1, KickoffTime = now.AddHours(-1), Status = "Live", Minute = "67", League = "PSL", Stadium = "Loftus Versfeld", Round = "Round 24" },
            new Match { Id = 2, HomeTeamId = 2, HomeTeamName = "Kaizer Chiefs", AwayTeamId = 4, AwayTeamName = "SuperSport United", HomeScore = 0, AwayScore = 0, KickoffTime = now.AddHours(2), Status = "Upcoming", Minute = "", League = "PSL", Stadium = "FNB Stadium", Round = "Round 24" },
            new Match { Id = 3, HomeTeamId = 5, HomeTeamName = "Cape Town City", AwayTeamId = 6, AwayTeamName = "AmaZulu FC", HomeScore = 1, AwayScore = 1, KickoffTime = now.AddDays(-1), Status = "Finished", Minute = "90", League = "PSL", Stadium = "DHL Newlands Stadium", Round = "Round 23" },
            new Match { Id = 4, HomeTeamId = 7, HomeTeamName = "Stellenbosch FC", AwayTeamId = 8, AwayTeamName = "TS Galaxy", HomeScore = 3, AwayScore = 0, KickoffTime = now.AddDays(-2), Status = "Finished", Minute = "90", League = "PSL", Stadium = "Danie Craven Stadium", Round = "Round 23" },
            new Match { Id = 5, HomeTeamId = 9, HomeTeamName = "Chippa United", AwayTeamId = 10, AwayTeamName = "Sekhukhune United", HomeScore = 0, AwayScore = 0, KickoffTime = now.AddDays(1), Status = "Upcoming", Minute = "", League = "PSL", Stadium = "Nelson Mandela Bay Stadium", Round = "Round 24" },
            new Match { Id = 6, HomeTeamId = 3, HomeTeamName = "Orlando Pirates", AwayTeamId = 2, AwayTeamName = "Kaizer Chiefs", HomeScore = 0, AwayScore = 0, KickoffTime = now.AddDays(3), Status = "Upcoming", Minute = "", League = "PSL", Stadium = "Orlando Stadium", Round = "Round 25" },
            new Match { Id = 7, HomeTeamId = 13, HomeTeamName = "Cape Town All Stars", AwayTeamId = 14, AwayTeamName = "Hungry Lions", HomeScore = 2, AwayScore = 0, KickoffTime = now.AddDays(-1), Status = "Finished", Minute = "90", League = "NFD", Stadium = "Athlone Stadium", Round = "Round 18" },
            new Match { Id = 8, HomeTeamId = 15, HomeTeamName = "Uthongathi FC", AwayTeamId = 16, AwayTeamName = "Royal AM", HomeScore = 1, AwayScore = 2, KickoffTime = now.AddDays(-3), Status = "Finished", Minute = "90", League = "NFD", Stadium = "King Zwelithini Stadium", Round = "Round 17" },
            new Match { Id = 9, HomeTeamId = 11, HomeTeamName = "Polokwane City", AwayTeamId = 12, AwayTeamName = "Golden Arrows", HomeScore = 0, AwayScore = 0, KickoffTime = now.AddHours(4), Status = "Upcoming", Minute = "", League = "PSL", Stadium = "Peter Mokaba Stadium", Round = "Round 24" },
            new Match { Id = 10, HomeTeamId = 1, HomeTeamName = "Mamelodi Sundowns", AwayTeamId = 2, AwayTeamName = "Kaizer Chiefs", HomeScore = 4, AwayScore = 1, KickoffTime = now.AddDays(-7), Status = "Finished", Minute = "90", League = "PSL", Stadium = "Loftus Versfeld", Round = "Round 22" },
        };
    }

    private List<MatchStats> InitMatchStats() => new()
    {
        new MatchStats { MatchId = 1, HomePossession = 58, AwayPossession = 42, HomeShotsOnTarget = 7, AwayShotsOnTarget = 4, HomeShotsOffTarget = 5, AwayShotsOffTarget = 6, HomeCorners = 6, AwayCorners = 3, HomeFouls = 8, AwayFouls = 12, HomeYellowCards = 1, AwayYellowCards = 2, HomeRedCards = 0, AwayRedCards = 0, HomeOffsides = 2, AwayOffsides = 3 },
        new MatchStats { MatchId = 3, HomePossession = 45, AwayPossession = 55, HomeShotsOnTarget = 5, AwayShotsOnTarget = 6, HomeShotsOffTarget = 4, AwayShotsOffTarget = 5, HomeCorners = 4, AwayCorners = 7, HomeFouls = 11, AwayFouls = 9, HomeYellowCards = 2, AwayYellowCards = 1, HomeRedCards = 0, AwayRedCards = 0, HomeOffsides = 1, AwayOffsides = 4 },
        new MatchStats { MatchId = 10, HomePossession = 62, AwayPossession = 38, HomeShotsOnTarget = 9, AwayShotsOnTarget = 3, HomeShotsOffTarget = 6, AwayShotsOffTarget = 8, HomeCorners = 8, AwayCorners = 2, HomeFouls = 7, AwayFouls = 14, HomeYellowCards = 1, AwayYellowCards = 3, HomeRedCards = 0, AwayRedCards = 1, HomeOffsides = 3, AwayOffsides = 2 },
    };

    private List<MatchEvent> InitMatchEvents() => new()
    {
        new MatchEvent { Id = 1, MatchId = 1, Minute = 23, Type = "Goal", PlayerName = "Peter Shalulile", AssistPlayerName = "Themba Zwane", Team = "Home" },
        new MatchEvent { Id = 2, MatchId = 1, Minute = 38, Type = "YellowCard", PlayerName = "Thalente Mbatha", Team = "Away" },
        new MatchEvent { Id = 3, MatchId = 1, Minute = 55, Type = "Goal", PlayerName = "Evidence Makgopa", Team = "Away" },
        new MatchEvent { Id = 4, MatchId = 1, Minute = 61, Type = "Goal", PlayerName = "Themba Zwane", AssistPlayerName = "Peter Shalulile", Team = "Home" },
        new MatchEvent { Id = 5, MatchId = 1, Minute = 65, Type = "YellowCard", PlayerName = "Rushine De Reuck", Team = "Home" },
        new MatchEvent { Id = 6, MatchId = 3, Minute = 17, Type = "Goal", PlayerName = "Fagrie Lakay", Team = "Home" },
        new MatchEvent { Id = 7, MatchId = 3, Minute = 44, Type = "YellowCard", PlayerName = "George Matlou", Team = "Away" },
        new MatchEvent { Id = 8, MatchId = 3, Minute = 78, Type = "Goal", PlayerName = "George Matlou", Team = "Away" },
        new MatchEvent { Id = 9, MatchId = 3, Minute = 85, Type = "Substitution", PlayerName = "Substitution In", SecondPlayerName = "Substitution Out", Team = "Home" },
        new MatchEvent { Id = 10, MatchId = 10, Minute = 12, Type = "Goal", PlayerName = "Peter Shalulile", Team = "Home" },
        new MatchEvent { Id = 11, MatchId = 10, Minute = 28, Type = "Goal", PlayerName = "Themba Zwane", Team = "Home" },
        new MatchEvent { Id = 12, MatchId = 10, Minute = 35, Type = "YellowCard", PlayerName = "Yusuf Maart", Team = "Away" },
        new MatchEvent { Id = 13, MatchId = 10, Minute = 52, Type = "Goal", PlayerName = "Khama Billiat", Team = "Away" },
        new MatchEvent { Id = 14, MatchId = 10, Minute = 67, Type = "Goal", PlayerName = "Rushine De Reuck", Team = "Home" },
        new MatchEvent { Id = 15, MatchId = 10, Minute = 80, Type = "RedCard", PlayerName = "Yusuf Maart", Team = "Away" },
        new MatchEvent { Id = 16, MatchId = 10, Minute = 88, Type = "Goal", PlayerName = "Peter Shalulile", Team = "Home" },
    };

    private List<LineupPlayer> InitLineups() => new()
    {
        new LineupPlayer { Id = 1, Name = "Denis Onyango", Number = "1", Position = "GK", IsStarter = true, Team = "Home", Rating = 7.2 },
        new LineupPlayer { Id = 2, Name = "Rushine De Reuck", Number = "4", Position = "CB", IsStarter = true, Team = "Home", Rating = 7.1 },
        new LineupPlayer { Id = 3, Name = "Mothobi Mvala", Number = "5", Position = "CB", IsStarter = true, Team = "Home", Rating = 6.9 },
        new LineupPlayer { Id = 4, Name = "Thapelo Morena", Number = "2", Position = "RB", IsStarter = true, Team = "Home", Rating = 7.0 },
        new LineupPlayer { Id = 5, Name = "Sifiso Hlanti", Number = "3", Position = "LB", IsStarter = true, Team = "Home", Rating = 6.8 },
        new LineupPlayer { Id = 6, Name = "Andile Jali", Number = "23", Position = "CDM", IsStarter = true, Team = "Home", Rating = 7.3 },
        new LineupPlayer { Id = 10, Name = "Neo Maema", Number = "11", Position = "CDM", IsStarter = true, Team = "Home", Rating = 7.0 },
        new LineupPlayer { Id = 8, Name = "Lebohang Maboe", Number = "7", Position = "LW", IsStarter = true, Team = "Home", Rating = 7.4 },
        new LineupPlayer { Id = 7, Name = "Themba Zwane", Number = "10", Position = "CAM", IsStarter = true, Team = "Home", Rating = 8.1 },
        new LineupPlayer { Id = 9, Name = "Gaston Sirino", Number = "8", Position = "RW", IsStarter = true, Team = "Home", Rating = 7.2 },
        new LineupPlayer { Id = 11, Name = "Peter Shalulile", Number = "9", Position = "ST", IsStarter = true, Team = "Home", Rating = 8.5 },
        new LineupPlayer { Id = 12, Name = "Kennedy Mweene", Number = "16", Position = "GK", IsStarter = false, Team = "Home" },
        new LineupPlayer { Id = 13, Name = "Grant Kekana", Number = "15", Position = "CB", IsStarter = false, Team = "Home" },
        new LineupPlayer { Id = 14, Name = "Divine Lunga", Number = "18", Position = "LB", IsStarter = false, Team = "Home" },
        new LineupPlayer { Id = 15, Name = "Bathusi Aubaas", Number = "20", Position = "MF", IsStarter = false, Team = "Home" },
        new LineupPlayer { Id = 16, Name = "Kermit Erasmus", Number = "14", Position = "FW", IsStarter = false, Team = "Home" },
        new LineupPlayer { Id = 17, Name = "Richard Ofori", Number = "1", Position = "GK", IsStarter = true, Team = "Away", Rating = 7.5 },
        new LineupPlayer { Id = 18, Name = "Nkosinathi Sibisi", Number = "5", Position = "CB", IsStarter = true, Team = "Away", Rating = 7.0 },
        new LineupPlayer { Id = 19, Name = "Olisa Ndah", Number = "4", Position = "CB", IsStarter = true, Team = "Away", Rating = 7.1 },
        new LineupPlayer { Id = 20, Name = "Deano van Rooyen", Number = "3", Position = "LB", IsStarter = true, Team = "Away", Rating = 7.2 },
        new LineupPlayer { Id = 21, Name = "Paseka Mako", Number = "2", Position = "RB", IsStarter = true, Team = "Away", Rating = 6.8 },
        new LineupPlayer { Id = 22, Name = "Thalente Mbatha", Number = "6", Position = "CM", IsStarter = true, Team = "Away", Rating = 7.3 },
        new LineupPlayer { Id = 23, Name = "Goodman Mosele", Number = "8", Position = "CM", IsStarter = true, Team = "Away", Rating = 7.0 },
        new LineupPlayer { Id = 24, Name = "Deon Hotto", Number = "11", Position = "LW", IsStarter = true, Team = "Away", Rating = 7.1 },
        new LineupPlayer { Id = 25, Name = "Monnapule Saleng", Number = "7", Position = "RW", IsStarter = true, Team = "Away", Rating = 7.8 },
        new LineupPlayer { Id = 26, Name = "Zakhele Lepasa", Number = "10", Position = "CAM", IsStarter = true, Team = "Away", Rating = 7.6 },
        new LineupPlayer { Id = 27, Name = "Evidence Makgopa", Number = "9", Position = "ST", IsStarter = true, Team = "Away", Rating = 7.9 },
        new LineupPlayer { Id = 28, Name = "Siyabonga Mpontshane", Number = "16", Position = "GK", IsStarter = false, Team = "Away" },
        new LineupPlayer { Id = 29, Name = "Bandile Shandu", Number = "17", Position = "MF", IsStarter = false, Team = "Away" },
        new LineupPlayer { Id = 30, Name = "Kwame Peprah", Number = "22", Position = "FW", IsStarter = false, Team = "Away" },
        new LineupPlayer { Id = 31, Name = "Fortune Makaringe", Number = "14", Position = "MF", IsStarter = false, Team = "Away" },
        new LineupPlayer { Id = 32, Name = "Innocent Maela", Number = "15", Position = "DF", IsStarter = false, Team = "Away" },
    };

    private List<NewsArticle> InitNews() => new()
    {
        new NewsArticle { Id = 1, Title = "Sundowns Dominate Premiership Race with Clinical Display", Summary = "Mamelodi Sundowns continue their march toward another PSL title after a commanding performance.", Content = "Mamelodi Sundowns put in another commanding performance to extend their lead at the top of the DStv Premiership table. The Brazilians, marshalled by the ever-impressive Peter Shalulile, produced a masterclass in attacking football that left their opponents shellshocked.\n\nShalulile, who leads the scoring charts with 18 goals, was at his predatory best, grabbing a brace to take his tally to 18 for the season. Themba Zwane also impressed, dictating play from the midfield and contributing with a goal and two assists.\n\nCoach Miguel Cardoso praised his side's discipline and clinical finishing, saying: 'The players have been exceptional this season. We are focused on our goals and believe we can win this title.'\n\nWith the title race seemingly wrapped up, attention turns to the CAF Champions League, where Sundowns remain firm favorites to lift the continent's premier club trophy.", ImageUrl = "https://via.placeholder.com/800x400/FFD700/000000?text=Sundowns+Dominate", Author = "Sipho Dlamini", PublishedAt = DateTime.Now.AddHours(-3), Category = "General", TeamName = "Mamelodi Sundowns", League = "PSL" },
        new NewsArticle { Id = 2, Title = "Kaizer Chiefs Set to Sign Brazilian Striker This January", Summary = "Kaizer Chiefs are close to completing the signing of a Brazilian striker to bolster their attack.", Content = "Kaizer Chiefs are understood to be in advanced negotiations with a Brazilian club for the services of a striker who has caught the eye of coach Nasreddine Nabi. The player, whose name is being kept under wraps, is reported to be a goal machine with an impressive record in South American football.\n\nChiefs sporting director Kaizer Motaung Jr confirmed that the club is active in the transfer market, saying: 'We are always looking to strengthen the squad. The coach has identified areas where we need to improve, and we are working hard to bring in the right players.'\n\nThe Glamour Boys have struggled for consistency this season and the new arrival is expected to solve their attacking woes. Several South American scouts have been dispatched to finalize the deal, with an announcement expected in the coming days.", ImageUrl = "https://via.placeholder.com/800x400/FFD700/000000?text=Chiefs+Signing", Author = "Thabo Nkosi", PublishedAt = DateTime.Now.AddHours(-8), Category = "Transfers", TeamName = "Kaizer Chiefs", League = "PSL" },
        new NewsArticle { Id = 3, Title = "Soweto Derby Preview: Pirates vs Chiefs — Who Has the Edge?", Summary = "The big Soweto Derby is just days away. We analyze both sides ahead of this massive clash.", Content = "The Soweto Derby is upon us once again, and football fans across South Africa are gearing up for one of the most anticipated fixtures in the domestic calendar. Orlando Pirates host Kaizer Chiefs at Orlando Stadium in what promises to be a fiercely contested affair.\n\nPirates come into the match in fine form, with José Riveiro's side unbeaten in their last six matches. The Buccaneers have been devastating on the counter-attack, with Evidence Makgopa and Monnapule Saleng causing havoc for opposing defenses.\n\nKaizer Chiefs, meanwhile, have shown improvement under Nasreddine Nabi but will need to be at their very best to get a result at Orlando Stadium. Khama Billiat's creativity will be crucial if the Glamour Boys are to unlock a stubborn Pirates defense.\n\nKey battles to watch: Thalente Mbatha vs Yusuf Maart in the midfield battle, and the defensive duel between Nkosinathi Sibisi and Khama Billiat. This one promises to be a classic.", ImageUrl = "https://via.placeholder.com/800x400/000000/FFFFFF?text=Soweto+Derby", Author = "Lungelo Mthembu", PublishedAt = DateTime.Now.AddHours(-15), Category = "MatchReport", TeamName = "Orlando Pirates", League = "PSL" },
        new NewsArticle { Id = 4, Title = "NFD: Cape Town All Stars Eye Promotion with Convincing Win", Summary = "Cape Town All Stars boosted their promotion hopes with an impressive victory in the NFD.", Content = "Cape Town All Stars took a giant step toward PSL promotion with a dominant victory in the National First Division. The Cape-based side showed why they are considered one of the frontrunners for promotion, with a disciplined defensive performance and clinical finishing on the break.\n\nCoach David Kannemeyer was delighted with the result but kept his feet firmly on the ground: 'It's a long season and there are many games to play. We take it one match at a time. The players executed the game plan perfectly today.'\n\nThe win puts All Stars at the top of the NFD standings, with a five-point cushion over their nearest rivals. If they can maintain this form, top-flight football beckons for the club next season.", ImageUrl = "https://via.placeholder.com/800x400/1E90FF/FFFFFF?text=All+Stars+Win", Author = "Warrick Adams", PublishedAt = DateTime.Now.AddDays(-1), Category = "General", TeamName = "Cape Town All Stars", League = "NFD" },
        new NewsArticle { Id = 5, Title = "Bafana Bafana Stars Shine in AFCON Qualifiers", Summary = "Several PSL stars impressed for Bafana Bafana in the latest AFCON qualification campaign.", Content = "South Africa's national football team, Bafana Bafana, received a massive boost as several PSL stars put in outstanding performances during the latest round of AFCON qualifiers. Players from across the domestic league stepped up on the international stage, showcasing the quality of football being produced in the DStv Premiership.\n\nStrike partnership between Evidence Makgopa and Lyle Foster proved lethal, combining for three goals as Bafana cruised to victory. Midfielders Thalente Mbatha and Sipho Mbule provided the engine room, while the defense was resolute throughout.\n\nBafana coach Hugo Broos was effusive in his praise: 'These players are developing into world-class talents. The level of the PSL is improving, and our national team is benefiting.' South Africa are on course to qualify for the AFCON tournament.", ImageUrl = "https://via.placeholder.com/800x400/007A4D/FFD700?text=Bafana+Bafana", Author = "Mpho Sithole", PublishedAt = DateTime.Now.AddDays(-2), Category = "General", League = "PSL" },
        new NewsArticle { Id = 6, Title = "Stellenbosch FC's Remarkable Rise Continues in the PSL", Summary = "Stellenbosch FC are defying expectations with another strong season in the top flight.", Content = "When Stellenbosch FC won promotion to the DStv Premiership a few years ago, few would have predicted they would become such a fixture in the top half of the table. Yet here they are, competing with the big boys and punching well above their weight.\n\nCoach Steve Barker has built a team that plays attractive, disciplined football, and the results speak for themselves. Their 3-0 victory over TS Galaxy was their fifth clean sheet in six games, a testament to the defensive organization Barker has instilled.\n\nThe Cape winelands club have built smartly on limited resources, developing local talent and bringing in shrewd recruits. Their story is one of the feel-good tales of South African football and they show no signs of slowing down.", ImageUrl = "https://via.placeholder.com/800x400/8B0000/FFFFFF?text=Stellenbosch+Rise", Author = "Chris van der Berg", PublishedAt = DateTime.Now.AddDays(-3), Category = "General", TeamName = "Stellenbosch FC", League = "PSL" },
    };

    private List<Transfer> InitTransfers() => new()
    {
        new Transfer { Id = 1, PlayerName = "Kermit Erasmus", FromTeam = "Cape Town City", ToTeam = "Mamelodi Sundowns", Fee = "R3.2M", Date = DateTime.Now.AddDays(-30), League = "PSL", PlayerPosition = "Forward" },
        new Transfer { Id = 2, PlayerName = "Bathusi Aubaas", FromTeam = "TS Galaxy", ToTeam = "Mamelodi Sundowns", Fee = "R1.5M", Date = DateTime.Now.AddDays(-45), League = "PSL", PlayerPosition = "Midfielder" },
        new Transfer { Id = 3, PlayerName = "Yusuf Maart", FromTeam = "Sekhukhune United", ToTeam = "Kaizer Chiefs", Fee = "R4.8M", Date = DateTime.Now.AddDays(-60), League = "PSL", PlayerPosition = "Midfielder" },
        new Transfer { Id = 4, PlayerName = "Dillan Solomons", FromTeam = "SuperSport United", ToTeam = "Kaizer Chiefs", Fee = "Free", Date = DateTime.Now.AddDays(-20), League = "PSL", PlayerPosition = "Defender" },
        new Transfer { Id = 5, PlayerName = "Evidence Makgopa", FromTeam = "Baroka FC", ToTeam = "Orlando Pirates", Fee = "R2.1M", Date = DateTime.Now.AddDays(-90), League = "PSL", PlayerPosition = "Forward" },
        new Transfer { Id = 6, PlayerName = "Deano van Rooyen", FromTeam = "Cape Town City", ToTeam = "Orlando Pirates", Fee = "R1.8M", Date = DateTime.Now.AddDays(-75), League = "PSL", PlayerPosition = "Defender" },
        new Transfer { Id = 7, PlayerName = "Sipho Mbule", FromTeam = "Kaizer Chiefs", ToTeam = "SuperSport United", Fee = "R3.5M", Date = DateTime.Now.AddDays(-50), League = "PSL", PlayerPosition = "Midfielder" },
        new Transfer { Id = 8, PlayerName = "Bradley Grobler", FromTeam = "Mamelodi Sundowns", ToTeam = "SuperSport United", Fee = "Free", Date = DateTime.Now.AddDays(-100), League = "PSL", PlayerPosition = "Forward" },
        new Transfer { Id = 9, PlayerName = "George Matlou", FromTeam = "Polokwane City", ToTeam = "AmaZulu FC", Fee = "R0.9M", Date = DateTime.Now.AddDays(-40), League = "PSL", PlayerPosition = "Midfielder" },
        new Transfer { Id = 10, PlayerName = "Fagrie Lakay", FromTeam = "AmaZulu FC", ToTeam = "Cape Town City", Fee = "R1.2M", Date = DateTime.Now.AddDays(-55), League = "PSL", PlayerPosition = "Forward" },
        new Transfer { Id = 11, PlayerName = "Siphiwe Tshabalala", FromTeam = "Kaizer Chiefs", ToTeam = "Stellenbosch FC", Fee = "Free", Date = DateTime.Now.AddDays(-180), League = "PSL", PlayerPosition = "Midfielder" },
        new Transfer { Id = 12, PlayerName = "Lyle Foster", FromTeam = "Wigan Athletic", ToTeam = "TS Galaxy", Fee = "Loan", Date = DateTime.Now.AddDays(-85), League = "PSL", PlayerPosition = "Forward" },
    };

    private List<Standing> InitPSLStandings() => new()
    {
        new Standing { Position = 1, TeamId = 1, TeamName = "Mamelodi Sundowns", Played = 24, Won = 17, Drawn = 5, Lost = 2, GoalsFor = 54, GoalsAgainst = 21, GoalDifference = 33, Points = 56, Form = "WWWDW" },
        new Standing { Position = 2, TeamId = 3, TeamName = "Orlando Pirates", Played = 24, Won = 14, Drawn = 6, Lost = 4, GoalsFor = 42, GoalsAgainst = 28, GoalDifference = 14, Points = 48, Form = "WWDWL" },
        new Standing { Position = 3, TeamId = 7, TeamName = "Stellenbosch FC", Played = 24, Won = 13, Drawn = 4, Lost = 7, GoalsFor = 38, GoalsAgainst = 27, GoalDifference = 11, Points = 43, Form = "WWWWD" },
        new Standing { Position = 4, TeamId = 2, TeamName = "Kaizer Chiefs", Played = 24, Won = 11, Drawn = 7, Lost = 6, GoalsFor = 35, GoalsAgainst = 30, GoalDifference = 5, Points = 40, Form = "WLDWW" },
        new Standing { Position = 5, TeamId = 5, TeamName = "Cape Town City", Played = 24, Won = 10, Drawn = 8, Lost = 6, GoalsFor = 33, GoalsAgainst = 28, GoalDifference = 5, Points = 38, Form = "DDWLD" },
        new Standing { Position = 6, TeamId = 4, TeamName = "SuperSport United", Played = 24, Won = 10, Drawn = 5, Lost = 9, GoalsFor = 30, GoalsAgainst = 29, GoalDifference = 1, Points = 35, Form = "LWWDL" },
        new Standing { Position = 7, TeamId = 11, TeamName = "Polokwane City", Played = 24, Won = 8, Drawn = 8, Lost = 8, GoalsFor = 28, GoalsAgainst = 31, GoalDifference = -3, Points = 32, Form = "LDWDW" },
        new Standing { Position = 8, TeamId = 6, TeamName = "AmaZulu FC", Played = 24, Won = 8, Drawn = 7, Lost = 9, GoalsFor = 27, GoalsAgainst = 32, GoalDifference = -5, Points = 31, Form = "WDLLD" },
        new Standing { Position = 9, TeamId = 12, TeamName = "Golden Arrows", Played = 24, Won = 6, Drawn = 9, Lost = 9, GoalsFor = 24, GoalsAgainst = 33, GoalDifference = -9, Points = 27, Form = "DLDWL" },
        new Standing { Position = 10, TeamId = 8, TeamName = "TS Galaxy", Played = 24, Won = 6, Drawn = 7, Lost = 11, GoalsFor = 22, GoalsAgainst = 35, GoalDifference = -13, Points = 25, Form = "LWLLD" },
        new Standing { Position = 11, TeamId = 10, TeamName = "Sekhukhune United", Played = 24, Won = 5, Drawn = 8, Lost = 11, GoalsFor = 20, GoalsAgainst = 36, GoalDifference = -16, Points = 23, Form = "DDLLW" },
        new Standing { Position = 12, TeamId = 9, TeamName = "Chippa United", Played = 24, Won = 4, Drawn = 7, Lost = 13, GoalsFor = 18, GoalsAgainst = 41, GoalDifference = -23, Points = 19, Form = "LLLDD" },
    };

    private List<Standing> InitNFDStandings() => new()
    {
        new Standing { Position = 1, TeamId = 13, TeamName = "Cape Town All Stars", Played = 18, Won = 13, Drawn = 2, Lost = 3, GoalsFor = 38, GoalsAgainst = 15, GoalDifference = 23, Points = 41, Form = "WWWWW" },
        new Standing { Position = 2, TeamId = 16, TeamName = "Royal AM", Played = 18, Won = 11, Drawn = 4, Lost = 3, GoalsFor = 32, GoalsAgainst = 18, GoalDifference = 14, Points = 37, Form = "WWDWW" },
        new Standing { Position = 3, TeamId = 14, TeamName = "Hungry Lions", Played = 18, Won = 10, Drawn = 3, Lost = 5, GoalsFor = 28, GoalsAgainst = 20, GoalDifference = 8, Points = 33, Form = "WDLWW" },
        new Standing { Position = 4, TeamId = 15, TeamName = "Uthongathi FC", Played = 18, Won = 8, Drawn = 4, Lost = 6, GoalsFor = 25, GoalsAgainst = 22, GoalDifference = 3, Points = 28, Form = "LWWDL" },
    };

    private List<BettingOdds> InitOdds() => new()
    {
        new BettingOdds { MatchId = 1, HomeWin = "1.75", Draw = "3.50", AwayWin = "4.20", Provider = "SuperBet" },
        new BettingOdds { MatchId = 2, HomeWin = "2.80", Draw = "3.20", AwayWin = "2.50", Provider = "SuperBet" },
        new BettingOdds { MatchId = 5, HomeWin = "2.10", Draw = "3.10", AwayWin = "3.40", Provider = "SuperBet" },
        new BettingOdds { MatchId = 6, HomeWin = "2.40", Draw = "3.30", AwayWin = "2.90", Provider = "SuperBet" },
        new BettingOdds { MatchId = 9, HomeWin = "2.20", Draw = "3.00", AwayWin = "3.20", Provider = "SuperBet" },
    };

    public Task<List<Team>> GetTeamsAsync(string? league = null)
    {
        var result = league == null ? _teams : _teams.Where(t => t.League == league).ToList();
        return Task.FromResult(result);
    }
    public Task<Team?> GetTeamByIdAsync(int id) => Task.FromResult(_teams.FirstOrDefault(t => t.Id == id));
    public Task<List<Player>> GetPlayersAsync(int? teamId = null)
    {
        var result = teamId == null ? _players : _players.Where(p => p.TeamId == teamId).ToList();
        return Task.FromResult(result);
    }
    public Task<Player?> GetPlayerByIdAsync(int id) => Task.FromResult(_players.FirstOrDefault(p => p.Id == id));
    public Task<List<Match>> GetMatchesAsync(string? league = null, string? status = null)
    {
        var result = _matches.AsEnumerable();
        if (league != null) result = result.Where(m => m.League == league);
        if (status != null) result = result.Where(m => m.Status == status);
        return Task.FromResult(result.OrderBy(m => m.KickoffTime).ToList());
    }
    public Task<Match?> GetMatchByIdAsync(int id) => Task.FromResult(_matches.FirstOrDefault(m => m.Id == id));
    public Task<MatchStats?> GetMatchStatsAsync(int matchId) => Task.FromResult(_matchStats.FirstOrDefault(s => s.MatchId == matchId));
    public Task<List<MatchEvent>> GetMatchEventsAsync(int matchId) => Task.FromResult(_matchEvents.Where(e => e.MatchId == matchId).OrderBy(e => e.Minute).ToList());
    public Task<List<LineupPlayer>> GetMatchLineupAsync(int matchId) => Task.FromResult(_lineupPlayers);
    public Task<List<NewsArticle>> GetNewsAsync(string? category = null, string? league = null)
    {
        var result = _news.AsEnumerable();
        if (category != null) result = result.Where(n => n.Category == category);
        if (league != null) result = result.Where(n => n.League == league);
        return Task.FromResult(result.OrderByDescending(n => n.PublishedAt).ToList());
    }
    public Task<NewsArticle?> GetNewsArticleByIdAsync(int id) => Task.FromResult(_news.FirstOrDefault(n => n.Id == id));
    public Task<List<Transfer>> GetTransfersAsync(string? league = null, int? teamId = null)
    {
        var result = _transfers.AsEnumerable();
        if (league != null) result = result.Where(t => t.League == league);
        return Task.FromResult(result.OrderByDescending(t => t.Date).ToList());
    }
    public Task<List<Standing>> GetStandingsAsync(string league)
    {
        var result = league == "PSL" ? _pslStandings : _nfdStandings;
        return Task.FromResult(result.OrderBy(s => s.Position).ToList());
    }
    public Task<BettingOdds?> GetBettingOddsAsync(int matchId) => Task.FromResult(_odds.FirstOrDefault(o => o.MatchId == matchId));
    public Task<List<Player>> GetTopScorersAsync(string league)
    {
        var leagueTeamIds = _teams.Where(t => t.League == league).Select(t => t.Id).ToHashSet();
        return Task.FromResult(_players.Where(p => leagueTeamIds.Contains(p.TeamId)).OrderByDescending(p => p.Goals).Take(10).ToList());
    }
    public Task<List<Match>> SearchMatchesAsync(string query)
    {
        query = query.ToLower();
        return Task.FromResult(_matches.Where(m => m.HomeTeamName.ToLower().Contains(query) || m.AwayTeamName.ToLower().Contains(query)).ToList());
    }
    public Task<List<Team>> SearchTeamsAsync(string query)
    {
        query = query.ToLower();
        return Task.FromResult(_teams.Where(t => t.Name.ToLower().Contains(query) || t.ShortName.ToLower().Contains(query)).ToList());
    }
    public Task<List<Player>> SearchPlayersAsync(string query)
    {
        query = query.ToLower();
        return Task.FromResult(_players.Where(p => p.Name.ToLower().Contains(query) || p.TeamName.ToLower().Contains(query)).ToList());
    }
    public Task<List<NewsArticle>> SearchNewsAsync(string query)
    {
        query = query.ToLower();
        return Task.FromResult(_news.Where(n => n.Title.ToLower().Contains(query) || n.Summary.ToLower().Contains(query)).ToList());
    }
}
