using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Néfi", 3, 7);
        Scripture scripture = new Scripture(reference, "\n And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.");

        System.Console.WriteLine("Welcome to Scripture Memorizer program!");
        while (!scripture.IsAllHidden())
        {
            Console.Clear();
            System.Console.WriteLine(scripture.GetDisplay());
            System.Console.WriteLine("You will use 'enter key' or type quit.");
            string quit = Console.ReadLine();
            if (quit == "quit")
            {
                break;
            }
            scripture.HideRandom(1);
        }
        System.Console.WriteLine("Thanks!");
        Console.Clear();
        Console.WriteLine(scripture.GetDisplay());

    }
}