// Determine file path
var currentDirectory = Directory.GetCurrentDirectory();
var filePath = currentDirectory + "/data/weather.dat";

// Create models based on file data
var manager = new WeatherManager();
var result = manager.ProcessFile(filePath);

// Display results
Console.WriteLine(result);