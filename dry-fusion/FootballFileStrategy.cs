using System.Text.RegularExpressions;

public class FootballFileStrategy : FileProcessorStrategy
{
    public override string GetRegEx() => @".*\. (\w+) +\d+ +\d+ +\d+ +\d+ +(\d+) +- +(\d+)";
    public override string GetFileName() => "football.dat";

    public override void Process(MatchCollection matches)
    {
        var teamData = new List<Team>();
        foreach (Match match in matches)
        {
            if (match.Groups.Count >= 3)
            {
                var team = new Team(match.Groups[1].Value, match.Groups[2].Value, match.Groups[3].Value);
                teamData.Add(team);
            }
        }
        var teamWithSmallestSpread = teamData.OrderBy(w => w.Spread).ToList().First();
        
        Console.WriteLine(teamWithSmallestSpread.ToString());
    }
}