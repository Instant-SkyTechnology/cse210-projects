using System;
using System.Threading;

public abstract class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    // CONSTRUCTOR
    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    // METHODS
    public void Start()
    {
        Console.Clear();
        Console.WriteLine($"=== {_name} Activity ===");
        Console.WriteLine(_description);
        Console.Write("Enter duration in seconds: ");
        _duration = int.Parse(Console.ReadLine());

        Console.Write("Get ready ");
        PauseWithSpinner();
    }

    public void End()
    {
        Console.Write("\nWell done! ");
        PauseWithSpinner();
        Console.Write($"\nYou completed the {_name} activity for {_duration} seconds. ");
        PauseWithSpinner();
    }

    protected int Duration => _duration;

    protected void PauseWithSpinner()
    {
        List<string> animationString = new List<string>();
        animationString.Add("|");
        animationString.Add("/");
        animationString.Add("-");
        animationString.Add("\\");
        animationString.Add("|");
        animationString.Add("/");
        animationString.Add("-");
        animationString.Add("\\");

        foreach (string s in animationString)
        {
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine();
    }

    protected void Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine();
    }

    public abstract void Run();
}
