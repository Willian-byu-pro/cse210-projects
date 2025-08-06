public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by slowly inhaling and exhaling. Clear your mind and focus on your breathing."){}

    public void Run()
    {
        DisplayMessage();

        int cycleTime = 6; // 3s inspirar + 3s expirar
        int cycles = _duration / cycleTime;

        for (int i = 0; i < cycles; i++)
        {
            Console.Write("\nInspire...");
            Counter(3);
            Console.Write("\nExpire...");
            Counter(3);
            Console.WriteLine();
        }

        DisplayMessageEnd();
    }
}