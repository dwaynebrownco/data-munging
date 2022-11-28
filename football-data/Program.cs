// Determine file path
var currentDirectory = Directory.GetCurrentDirectory();
var filePath = currentDirectory + "/data/football.dat";

// Create models based on file data
var manager = new TeamManager();
var result = manager.ProcessFile(filePath);

// Display results
Console.WriteLine(result);