using System;

class Program
{
    static void Main(string[] args)
    {
       {
        Journal journal = new();
        PromptGenerator promptGen = new();
        string choice = "";

        while (choice != "5")
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");
            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    string prompt = promptGen.GetRandomPrompt();
                    Console.WriteLine($"\n{prompt}");
                    Console.Write("Your answer: ");
                    string response = Console.ReadLine();
                    string date = DateTime.Now.ToString("dd/MM/yyyy");
                    journal.AddEntry(new Entry(date, prompt, response));
                    break;

                case "2":
                    Console.WriteLine("\nJournal entries:");
                    journal.DisplayEntries();
                    break;

                case "3":
                    Console.Write("\nDType the file name: ");
                    string saveFile = Console.ReadLine();
                    journal.SaveToFile(saveFile);
                    Console.WriteLine("Journal saved successfully!");
                    break;

                case "4":
                    Console.Write("\nEnter the file name: ");
                    string loadFile = Console.ReadLine();
                    journal.LoadFromFile(loadFile);
                    Console.WriteLine("Journal loaded successfully!");
                    break;

                case "5":
                    Console.WriteLine("Exiting...");
                    break;

                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
    }
}
    }
