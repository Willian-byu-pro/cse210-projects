public class ListingActivity : Activity
{
    private List<string> _promptList;
    private Random _random;

    public ListingActivity()
        : base("Listing Activity", 
               "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        _promptList = new List<string>
        {
            "Who are people that you appreciate?",
            "What are your personal strengths?",
            "Who are people you have helped this week?",
            "When have you felt the Holy Spirit this month?",
            "Who are some of your personal heroes?"
        };

        _random = new Random();
    }

    public void Run()
    {
        DisplayMessage();

        Console.WriteLine($"\n--- {RandomPrompt()} ---");
        Console.WriteLine("You will have a few seconds to think before starting...");
        Counter(5); // Tempo para pensar

        Console.WriteLine("Start listing items now:");
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        int counter = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            counter++;
        }

        Console.WriteLine($"\nYou listed {counter} items!");
        DisplayMessageEnd();
    }

    private string RandomPrompt()
    {
        return _promptList[_random.Next(_promptList.Count)];
    }
}