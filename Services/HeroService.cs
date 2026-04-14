using FootballApp.UI.Models;

namespace FootballApp.UI.Services;

public class HeroService : IHeroService
{
    private readonly IFootballDataService _dataService;

    public HeroService(IFootballDataService dataService)
    {
        _dataService = dataService;
    }

    public async Task<HeroContent> GetHeroContentAsync()
    {
        var allMatches = await _dataService.GetMatchesAsync();
        var todayMatches = allMatches.Where(m => m.KickoffTime.Date == DateTime.Today);

        // 1. Live match takes highest priority
        var liveMatch = todayMatches.FirstOrDefault(m => m.Status == "Live");
        if (liveMatch != null)
        {
            return new HeroContent { Type = "Match", Match = liveMatch };
        }

        // 2. Next upcoming match (closest kickoff)
        var nextMatch = todayMatches
            .Where(m => m.Status == "Upcoming")
            .OrderBy(m => m.KickoffTime)
            .FirstOrDefault();
        if (nextMatch != null)
        {
            return new HeroContent { Type = "Match", Match = nextMatch };
        }

        // 3. Most recent finished match today
        var lastMatch = todayMatches
            .Where(m => m.Status == "Finished")
            .OrderByDescending(m => m.KickoffTime)
            .FirstOrDefault();
        if (lastMatch != null)
        {
            return new HeroContent { Type = "Match", Match = lastMatch };
        }

        // 4. Fallback to latest news
        var allNews = await _dataService.GetNewsAsync();
        var latestNews = allNews
            .OrderByDescending(n => n.PublishedAt)
            .FirstOrDefault();

        return new HeroContent { Type = "News", News = latestNews };
    }
}
