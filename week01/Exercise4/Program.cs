using System;
using System.Formats.Asn1;
using System.Globalization;
using System.Resources;

class Program
{
    static void Main(string[] args)
    {


        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        Console.Write("Enter number:");
        string resp = Console.ReadLine();
        int answer = int.Parse(resp);
        int largeNumber = 0;

        List<int> numbers = new List<int>();



        while (answer != 0)
        {
            if (answer != 0)
            {
                numbers.Add(answer);
    

            }

            Console.Write("Enter number:");
            resp = Console.ReadLine();
            answer = int.Parse(resp);








        }

        double SumValuer = 0;


        foreach (int numb in numbers)
        {
            SumValuer += numb;

            if (numb > largeNumber)
            {
                largeNumber = numb;
            }

        }

        double averege = SumValuer / numbers.Count;

        Console.WriteLine($"The sum is: {SumValuer}");
        Console.WriteLine($"The average is: {averege}");
        Console.WriteLine($"The largest number is: {largeNumber}");
        
        




    }
       


}