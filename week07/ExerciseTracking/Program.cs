using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");

        List<Activity> activities = new List<Activity>
        {
            new Running(new DateTime(2023, 10, 1), 30, 5), // 5 km in 30 minutes
            new Cycling(new DateTime(2023, 10, 2), 60, 20), // 20 km/h for 60 minutes
            new Swimming(new DateTime(2023, 10, 3), 45, 20) // 20 laps in 45 minutes
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.Summary());
        }
    }
}