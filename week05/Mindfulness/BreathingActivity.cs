using System;
using System.Threading;

public class BreathingActivity : Activity
{
    // CONSTRUCTOR
    public BreathingActivity()
        : base("Breathing",
        "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    // METHODS
    public override void Run()
    {
        Start();

        int timePassed = 0;

        while (timePassed < Duration)
        {
            Console.Write("Breathe in ");
            Countdown(3);
            timePassed += 3;

            if (timePassed >= Duration) break;

            Console.Write("Breathe out... ");
            Countdown(3);
            timePassed += 3;
        }

        End();
    }
}
