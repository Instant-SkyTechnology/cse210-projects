using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the grade percent? ");
        string gradePecent = Console.ReadLine();
        int gradeNumber = int.Parse(gradePecent);

        string letter = "";
        // string letteB = "B";
        // string letteC = "C";
        // string letteD = "D";
        // string letteF = "F";

        if (gradeNumber >= 90)
        {
            letter = "A";
        }
        else if (gradeNumber >= 80)
        {
            letter = "B";
        }
        else if (gradeNumber >= 70)
        {
            letter = "C";
        }
        else if (gradeNumber >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }


        Console.WriteLine($"You have earned the grade {letter}");

        if (gradeNumber >= 70)
        {
            Console.WriteLine("Congratulations! You have passed the course!");
        }
        else
        {
            Console.WriteLine("Sorry! You did not pass the course, consider retaking it.");
        }   
    
    }
}