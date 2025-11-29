using System;
using System.Collections.Generic;
using System.Threading;

public class ListingActivity : Activity
{
    private static string[] _prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt spiritual peace this month?",
        "Who are some of your personal heroes?"
    };

    // CONSTRUCTOR
    public ListingActivity()
        : base("Listing",
        "This activity will help you reflect on the good things in your life by having you list as many things as you can.")
    {
    }

    // METHODS
    public override void Run()
    {
        Start();

        Random rand = new Random();
        Console.WriteLine("\nList as many responses as you can to the following prompt:");
        Console.WriteLine($"--- {_prompts[rand.Next(_prompts.Length)]} ---\n");

        Console.Write("Starting in ");
        Countdown(5);

        List<string> items = new List<string>();
        int start = Environment.TickCount;

        while ((Environment.TickCount - start) / 1000 < Duration)
        {
            Console.Write("> ");
            items.Add(Console.ReadLine());
        }

        Console.WriteLine($"\nYou listed {items.Count} items.");

        End();
    }
}
