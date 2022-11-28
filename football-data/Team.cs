public class Team
{
    public Team(string name, string scoresFor, string scoresAgainst)
    { 
        Name = name;
        ScoresFor = Int32.Parse(scoresFor);
        ScoresAgainst = Int32.Parse(scoresAgainst);
    }

    public string Name { get; }
    public int ScoresFor { get; }
    public int ScoresAgainst { get; }

    public int Spread { get { return Math.Abs(ScoresFor - ScoresAgainst); } }

    public override string ToString()
    {
        return $"Team: {Name} For: {ScoresFor} Against: {ScoresAgainst} Spread: {Spread}";
    }
}