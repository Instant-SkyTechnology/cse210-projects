using System;
using System.Threading;

public class ReflectionActivity : Activity
{
    private static string[] _prompts = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private static string[] _questions = {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience?",
        "What did you learn about yourself?",
        "How can you keep this experience in mind?"
    };

    // CONSTRUCTOR
    public ReflectionActivity()
        : base("Reflection",
        "This activity will help you reflect on times in your life when you have shown strength and resilience.")
    {
    }

    // METHODS
    public override void Run()
    {
        Start();

        Random rand = new Random();
        Console.WriteLine("\nConsider the following prompt:");
        Console.WriteLine($"--- {_prompts[rand.Next(_prompts.Length)]} ---\n");

        Console.WriteLine("When you have something in mind, press Enter to continue...");
        Console.ReadLine();

        Console.Write("Now ponder on the following questions: ");
        PauseWithSpinner();

        int timePassed = 0;

        while (timePassed < Duration)
        {
            string question = _questions[rand.Next(_questions.Length)];
            Console.Write($"{question} ");
            PauseWithSpinner();
            timePassed += 4;
        }

        End();
    }
}
