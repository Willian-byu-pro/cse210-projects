using System;

class Program
{
    static void Main(string[] args)
    {
        
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int square = SquareNumber(number);
        DisplayResult(name, square);


        
    }






    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string answer = Console.ReadLine();
        return answer;
    }


    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string answer2 = Console.ReadLine();
        int numb = int.Parse(answer2);
        return numb;
    }

    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }

        static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }

       

    
            



            
        
    
}