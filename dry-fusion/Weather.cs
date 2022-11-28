public class Weather
{
    public Weather(string day, string minTemperature, string maxTemperature)
    { 
        Day = day;
        Low = Int32.Parse(minTemperature);
        High = Int32.Parse(maxTemperature);
    }

    public string Day { get; }
    public int Low { get; }
    public int High { get; }
    public int Spread { get { return Math.Abs(High - Low); } }

    public override string ToString()
    {
        return $"Day: {Day} Low: {Low} High: {High} Spread: {Spread}";
    }
}