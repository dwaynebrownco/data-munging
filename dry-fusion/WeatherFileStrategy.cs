using System.Text.RegularExpressions;

public class WeatherFileStrategy : FileProcessorStrategy
{
    public override string GetRegEx() => @".*  (\d{1,2})  (\d{1,3}) +(\d{1,3})";
    public override string GetFileName() => "weather.dat";

    public override void Process(MatchCollection matches)
    {
        var weatherData = new List<Weather>();
        foreach (Match match in matches)
        {
            if (match.Groups.Count >= 3)
            {
                var weather = new Weather(match.Groups[1].Value, match.Groups[2].Value, match.Groups[3].Value);
                weatherData.Add(weather);
            }
        }
        var weatherWithSmallestSpread = weatherData.OrderBy(w => w.Spread).ToList().First();
        
        Console.WriteLine(weatherWithSmallestSpread.ToString());
    }
}