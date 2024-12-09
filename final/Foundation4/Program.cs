using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>
        {
            new Running 
            { 
                Date = new DateTime(2024, 7, 15), 
                Minutes = 30, 
                Distance = 3.0 
            },
            new Cycling 
            { 
                Date = new DateTime(2024, 7, 16), 
                Minutes = 45, 
                Speed = 12.0 
            },
            new Swimming 
            { 
                Date = new DateTime(2024, 7, 17), 
                Minutes = 40, 
                Laps = 40 
            }
        };

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}