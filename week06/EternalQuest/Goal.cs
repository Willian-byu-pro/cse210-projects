public abstract class Goal
{
    private string _shortName;
    private string _description;
    private string _points;

    public Goal(string name, string description, string points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public string Name => _shortName;
    public string Description => _description;
    public int Points => int.Parse(_points);

    public abstract bool IsComplete();
    public abstract string GetDetailsString();
    public abstract string getStringRepresentation();
    public abstract void RecordEvent();
}
