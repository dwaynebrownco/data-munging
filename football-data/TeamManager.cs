public class TeamManager
{
    public TeamManager()
    { }

    public Team ProcessFile(string filePath)
    {
        // Create models based on file data
        var repository = new TeamRepository();
        var result = repository.ReadDataFromFile(filePath);
        
        // Return query results with smallest scoring difference
        return result.OrderBy(w => w.Spread).ToList().First();
    }
}