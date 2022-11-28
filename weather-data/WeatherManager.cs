public class WeatherManager
{
    public WeatherManager()
    { }

    public Weather ProcessFile(string filePath)
    {
        // Create models based on file data
        var repository = new WeatherRepository();
        var result = repository.ReadDataFromFile(filePath);
        
        // Return query results with smallest temperature spread
        return result.OrderBy(w => w.Spread).ToList().First();
    }
}