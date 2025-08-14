public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        bool running = true;
        while (running)
        {
            Console.WriteLine("\n=== Eternal Quest ===");
            DisplayPlayerInfo();
            Console.WriteLine("1 - Create Goal");
            Console.WriteLine("2 - List Goals");
            Console.WriteLine("3 - Record Event");
            Console.WriteLine("4 - Salvar Metas");
            Console.WriteLine("5 - Load Goals");
            Console.WriteLine("0 - Quit");
            Console.Write("Choose: ");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1": CreateGoal(); break;
                case "2": ListGoalDetails(); break;
                case "3":
                    ListGoalNames();
                    Console.Write("Which goal to complete? ");
                    int index = int.Parse(Console.ReadLine()) - 1;
                    if (index >= 0 && index < _goals.Count)
                    {
                        _goals[index].RecordEvent();
                        _score += _goals[index].Points;
                        Console.WriteLine("Event recorded! Points earned: " + _goals[index].Points);
                    }
                    break;
                case "4": SaveGoals(); break;
                case "5": LoadGoals(); break;
                case "0": running = false; break;
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Current score: {_score}");
    }

    public void ListGoalNames()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].Name}");
        }
    }

    public void ListGoalDetails()
    {
        foreach (Goal g in _goals)
        {
            Console.WriteLine(g.GetDetailsString());
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("Goal type: 1 - Simple | 2 - Eternal | 3 - Checklist");
        string type = Console.ReadLine();

        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write("Description: ");
        string desc = Console.ReadLine();
        Console.Write("Points: ");
        string points = Console.ReadLine();

        switch (type)
        {
            case "1":
                _goals.Add(new SimpleGoal(name, desc, points));
                break;
            case "2":
                _goals.Add(new EternalGoal(name, desc, points));
                break;
            case "3":
                Console.Write("Target: ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Bônus: ");
                int bonus = int.Parse(Console.ReadLine());
                _goals.Add(new ChecklistGoal(name, desc, points, target, bonus));
                break;
        }
    }

    public void SaveGoals()
    {
        using (StreamWriter sw = new StreamWriter("goals.txt"))
        {
            sw.WriteLine(_score);
            foreach (Goal g in _goals)
            {
                sw.WriteLine(g.getStringRepresentation());
            }
        }
        Console.WriteLine("Goals saved!");
    }

    public void LoadGoals()
    {
        if (!File.Exists("goals.txt"))
        {
            Console.WriteLine("File not found!");
            return;
        }

        string[] lines = File.ReadAllLines("goals.txt");
        _score = int.Parse(lines[0]);
        _goals.Clear();

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split('|');
            if (parts[0] == "SimpleGoal")
                _goals.Add(new SimpleGoal(parts[1], parts[2], parts[3]));
            else if (parts[0] == "EternalGoal")
                _goals.Add(new EternalGoal(parts[1], parts[2], parts[3]));
            else if (parts[0] == "ChecklistGoal")
                _goals.Add(new ChecklistGoal(parts[1], parts[2], parts[3], int.Parse(parts[5]), int.Parse(parts[6])));
        }
        Console.WriteLine("Goals loaded!");
    }
}
