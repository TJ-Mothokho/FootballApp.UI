using FootballApp.UI.Models;
namespace FootballApp.UI.Services;
public interface IFootballDataService
{
    Task<List<Team>> GetTeamsAsync(string? league = null);
    Task<Team?> GetTeamByIdAsync(int id);
    Task<List<Player>> GetPlayersAsync(int? teamId = null);
    Task<Player?> GetPlayerByIdAsync(int id);
    Task<List<Match>> GetMatchesAsync(string? league = null, string? status = null);
    Task<Match?> GetMatchByIdAsync(int id);
    Task<MatchStats?> GetMatchStatsAsync(int matchId);
    Task<List<MatchEvent>> GetMatchEventsAsync(int matchId);
    Task<List<LineupPlayer>> GetMatchLineupAsync(int matchId);
    Task<List<NewsArticle>> GetNewsAsync(string? category = null, string? league = null);
    Task<NewsArticle?> GetNewsArticleByIdAsync(int id);
    Task<List<Transfer>> GetTransfersAsync(string? league = null, int? teamId = null);
    Task<List<Standing>> GetStandingsAsync(string league);
    Task<BettingOdds?> GetBettingOddsAsync(int matchId);
    Task<List<Player>> GetTopScorersAsync(string league);
    Task<List<Match>> SearchMatchesAsync(string query);
    Task<List<Team>> SearchTeamsAsync(string query);
    Task<List<Player>> SearchPlayersAsync(string query);
    Task<List<NewsArticle>> SearchNewsAsync(string query);
}
