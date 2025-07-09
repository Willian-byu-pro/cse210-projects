using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicnumber = randomGenerator.Next(1, 11);


        Console.WriteLine("What is your guess?");
        int guess = int.Parse(Console.ReadLine());

        while (guess != magicnumber)
        {
            if (guess < magicnumber)
            {
                Console.WriteLine("Lower");
                
            }


            else
            {
                Console.WriteLine("Higher");
                
            }

            Console.WriteLine("What is your guess?");
            guess = int.Parse(Console.ReadLine());
        }
        
        Console.WriteLine("You guessed it!");
      

    }
}