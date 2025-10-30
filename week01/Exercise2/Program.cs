using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the grade percent? ");
        string gradePecent = Console.ReadLine();
        int gradeNumber = int.Parse(gradePecent);

        string letter = "";

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

        int LastDigit = gradeNumber % 10;
        string sign = "";

        // determine the sign
        if (LastDigit >= 7)

        {
            sign = "+";
        }

        else if (LastDigit < 3)
        {
            sign = "-";
        }

        else
        {
            sign = "";
        }    

        // handle exceptions cases (A+, F+, F-)
        if (letter == "A" && sign == "+")
        {
            sign = "";   
        }
            
        else if (letter == "F")
        {
            sign = "";
        }
            

        Console.WriteLine($"You have earned the grade {letter}{sign}");

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