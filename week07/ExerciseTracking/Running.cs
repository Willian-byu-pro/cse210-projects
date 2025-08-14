public class Running : Activity
{
    private double distance; // km ou milhas

    public Running(DateTime date, double duration, double distance) 
        : base(date, duration)
    {
        this.distance = distance;
    }

    public override double GetDistance() => distance;
    public override double GetSpeed() => (distance / GetDuration()) * 60;
    public override double GetPace() => GetDuration() / distance;

    public override string GetSummary()
    {
        return $"{GetDate():dd MMMM yyyy} Running ({GetDuration()} min) - Distance {GetDistance():0.0} km, Velocity {GetSpeed():0.0} km/h, rhythm: {GetPace():0.00} min/km";
    }
}