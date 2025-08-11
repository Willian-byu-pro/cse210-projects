public class ReflectionActivity : Activity
{
    private List<string> _promptList;
    private List<string> _questionList;
    private Random _random;

    public ReflectionActivity() 
        : base("Reflection Activity", 
               "This activity will help you reflect on moments in your life when you have shown strength and resilience. " +
               "This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
        _promptList = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        _questionList = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };

        _random = new Random();
    }

    public void Run()
    {
        DisplayMessage();

        // Mostrar prompt aleatório
        Console.WriteLine($"\n--- {RandomPrompt()} ---");
        Console.WriteLine("When you have something in mind, press Enter to continue.");
        Console.ReadLine();

        Console.WriteLine("Now ponder on the following questions:");
        Spinner(3);

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write($"\n> {RandomQuestion()} ");
            Spinner(5); // Pausa para pensar
        }

        DisplayMessageEnd();
    }

    private string RandomPrompt()
    {
        return _promptList[_random.Next(_promptList.Count)];
    }

    private string RandomQuestion()
    {
        return _questionList[_random.Next(_questionList.Count)];
    }
}