using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your percentage?");
        string porcent = Console.ReadLine();

        int answer = int.Parse(porcent);



        String letter = "";
        string sig = "";




        if (answer >= 90)
        {
            letter = "A";
            int teg = answer % 10;
            if (teg < 3)
            {
                sig = "- ";
            }

        }

        else if (answer >= 80)
        {
            letter = "B";
            int teg = answer % 10;
            if (teg >= 7)
            {
                sig = "+ ";
            };
            if (teg < 3)
            {
                sig = "- ";
            }

        }

        else if (answer >= 70)
        {
            letter = "C";
            int teg = answer % 10;
            if (teg >= 7)
            {
                sig = "+ ";
            }
            if (teg < 3)
            {
                sig = "- ";
            }

        }

        else if (answer >= 60)
        {
            letter = "D";
            int teg = answer % 10;
            if (teg >= 7)
            {
                sig = "+ ";
            }
            if (teg < 3)
            {
                sig = "- ";
            }

        }

        else if (answer < 60)
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is:{letter}{sig}");

        if (answer >= 70)
        {
            Console.WriteLine("You passed!");
        }

        else
        {
            Console.WriteLine("Better luck next time!");
        }        
        


    }
}