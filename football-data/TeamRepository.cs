using System.Text.RegularExpressions;

public class TeamRepository
{
    private const string teamRegex = @".*\. (\w+) +\d+ +\d+ +\d+ +\d+ +(\d+) +- +(\d+)";
    
    public TeamRepository()
    { }

    public List<Team> ReadDataFromFile(string filePath)
    {
        var teamData = new List<Team>();
        var text = File.ReadAllText(filePath);

        var regEx = new Regex(teamRegex, RegexOptions.IgnoreCase);
        var matches = regEx.Matches(text);

        foreach (Match match in matches)
        {
            if (match.Groups.Count >= 3)
            {
                var team = new Team(match.Groups[1].Value, match.Groups[2].Value, match.Groups[3].Value);
                teamData.Add(team);
            }
        }

        return teamData;
    }
}