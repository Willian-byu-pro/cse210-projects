public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, string points) 
        : base(name, description, points)
    {
    }

    public override void RecordEvent()
    {
        // Sempre dá pontos, nunca completa
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetDetailsString()
    {
        return $"[∞] {Name} - {Description}";
    }

    public override string getStringRepresentation()
    {
        return $"EternalGoal|{Name}|{Description}|{Points}";
    }
}
