namespace FootballApp.UI.Utils;

public static class LogoHelper
{
    public static string GetTeamLogo(string teamName)
    {
        if (string.IsNullOrWhiteSpace(teamName))
            return "/logos/default.png";

        var formattedName = teamName.Replace(" ", "");
        return $"/logos/{formattedName}.png";
    }
}
