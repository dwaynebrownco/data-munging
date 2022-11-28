using System.Text.RegularExpressions;

public abstract class FileProcessorStrategy
{
    public abstract string GetRegEx();
    public abstract string GetFileName();
    public abstract void Process(MatchCollection matches);

    public void ProcessFile()
    {
        var text = File.ReadAllText(Directory.GetCurrentDirectory() + "/Data/" + GetFileName());

        var regEx = new Regex(GetRegEx(), RegexOptions.IgnoreCase);
        var matches = regEx.Matches(text);

        Process(matches);
    }
}