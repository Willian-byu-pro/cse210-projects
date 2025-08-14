public class Cycling : Activity
{
    private double speed; // km/h

    public Cycling(DateTime date, double duration, double speed)
        : base(date, duration)
    {
        this.speed = speed;
    }

    public override double GetDistance() => (speed * GetDuration()) / 60;
    public override double GetSpeed() => speed;
    public override double GetPace() => 60 / speed;

    public override string GetSummary()
    {
        return $"{GetDate():dd MMMM yyyy} cycling ({GetDuration()} min) - Distance {GetDistance():0.0} km, Velocity {GetSpeed():0.0} km/h, rhythm: {GetPace():0.00} min/km";
    }
}