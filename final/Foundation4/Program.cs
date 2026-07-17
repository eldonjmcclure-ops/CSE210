using System;

class Program
{
    static void Main(string[] args)
    {
        Running running = new Running(5.2, new DateTime(2026, 7, 22), 42, "Running");
        Cycling cycling = new Cycling(18, new DateTime(2024, 5, 17), 75, "Cycling");
        Swimming swimming = new Swimming(40, new DateTime(2020, 7, 15), 35, "Swimming");

        List<Activity> activities = new List<Activity>(){running, cycling, swimming};
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.DisplaySummary());
            Console.WriteLine();
        }
    }
}