using System;

class Program
{
    static void Main(string[] args)
    {
        Activity[] activities = new Activity[]
        {
            new Running(new DateTime(2025, 12, 8), 20, 17.0),
            new Cycling(new DateTime(2025, 12, 8), 35, 29.0),
            new Swimming(new DateTime(2025, 12, 8), 50, 40)
        };

        Console.WriteLine();
        Console.WriteLine("===========================================================================================");
        string message = "Tracking Program";
        Console.WriteLine(message.PadLeft((94 + message.Length) / 2).PadRight(94));
        Console.WriteLine("===========================================================================================");
        Console.WriteLine();

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }

        Console.WriteLine("===========================================================================================");
        Console.WriteLine();
    }
}