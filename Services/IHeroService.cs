using FootballApp.UI.Models;

namespace FootballApp.UI.Services;

public interface IHeroService
{
    Task<HeroContent> GetHeroContentAsync();
}
