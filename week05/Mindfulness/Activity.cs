public class Activity
{
    private string _name;
    private string _description;
    protected int _duration;

    public Activity(string name, string description) {
        _name = name;
        _description = description;
    }

    public void DisplayMessage() {
        Console.Clear();
        Console.WriteLine($"---{_name}---");
        Console.WriteLine($"{_description}");
        Console.Write("How many seconds would you like to perform this activity?");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine($"Lets start...");
        Spinner(3);
    }
    public void DisplayMessageEnd() {
        Console.WriteLine("\nCongratulations!");
        Console.WriteLine($"You completed {_duration} seconds  {_name}.");
        Spinner(3);
    }
    

    protected void Spinner(int time) {

        string[] sequence = { "|", "/", "-", "\\" };
        DateTime endTime = DateTime.Now.AddSeconds(time);

        while (DateTime.Now < endTime)
        {
            foreach (string symbol in sequence)
            {
                Console.Write(symbol);
                Thread.Sleep(200);
                Console.Write("\b \b");
            }
        }
    }

    protected void Counter(int  time) {
        for (int i = time   ; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}