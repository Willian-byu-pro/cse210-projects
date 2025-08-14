public abstract class Activity
{
    private DateTime date;
    private double duration; // minutos

    public Activity(DateTime date, double duration)
    {
        this.date = date;
        this.duration = duration;
    }

    // Encapsulamento: getters
    public DateTime GetDate() => date;
    public double GetDuration() => duration;

    // Métodos abstratos que cada atividade deve implementar
    public abstract double GetDistance();   // km ou milhas
    public abstract double GetSpeed();      // km/h ou mph
    public abstract double GetPace();       // min/km ou min/milha

    // Método que retorna o resumo da atividade
    public virtual string GetSummary()
    {
        return $"{date:dd MMMM yyyy} ({duration} min) - Distance {GetDistance():0.0}, Velocity {GetSpeed():0.0}, rhythm: {GetPace():0.00} min/unidade";
    }
}