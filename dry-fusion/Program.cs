var strategies = new List<FileProcessorStrategy>
{
    new WeatherFileStrategy(),
    new FootballFileStrategy()
};

foreach(var strategy in strategies) 
{
    strategy.ProcessFile();
}