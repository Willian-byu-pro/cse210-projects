public class Swimming : Activity
{
    private int laps;

    public Swimming(DateTime date, double duration, int laps)
        : base(date, duration)
    {
        this.laps = laps;
    }

    public override double GetDistance() => laps * 50 / 1000.0; // km
    public override double GetSpeed() => (GetDistance() / GetDuration()) * 60;
    public override double GetPace() => GetDuration() / GetDistance();

    public override string GetSummary()
    {
        return $"{GetDate():dd MMMM yyyy} Swimming ({GetDuration()} min) - Distance {GetDistance():0.0} km, Velocity {GetSpeed():0.0} km/h, rhythm: {GetPace():0.00} min/km";
    }
}