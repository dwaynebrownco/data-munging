using System.Text.RegularExpressions;

public class WeatherRepository
{
    private const string weatherRegex = @".*  (\d{1,2})  (\d{1,3}) +(\d{1,3})";

    public WeatherRepository()
    { }

    public List<Weather> ReadDataFromFile(string filePath) 
    {
        var weatherData = new List<Weather>();
        var text = File.ReadAllText(filePath);

        var regEx = new Regex(weatherRegex, RegexOptions.IgnoreCase);
        var matches = regEx.Matches(text);

        foreach (Match match in matches)
        {
            if (match.Groups.Count >= 3)
            {
                var weather = new Weather(match.Groups[1].Value, match.Groups[2].Value, match.Groups[3].Value);
                weatherData.Add(weather);
            }
        }

        return weatherData;
    }
}