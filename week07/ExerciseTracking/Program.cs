using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        activities.Add(new Running(new DateTime(2022, 11, 3), 30, 4.8)); // km
        activities.Add(new Cycling(new DateTime(2022, 11, 3), 45, 20));   // km/h
        activities.Add(new Swimming(new DateTime(2022, 11, 3), 60, 40)); // voltas

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    
    }
}