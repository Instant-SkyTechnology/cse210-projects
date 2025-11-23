using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        Console.WriteLine("================ HOMEWORK ===================");

        Assignment a1 = new Assignment("Steve KALALA", "CSE 210");
        Console.WriteLine(a1.GetSummary());
        Console.WriteLine("---------------------------------------------");
        Console.WriteLine();

        MathAssignment m1 = new MathAssignment("John Light", "WDD 231", "7.3", "5-1");
        Console.WriteLine(m1.GetSummary());
        Console.WriteLine(m1.GetHomeworkList());
        Console.WriteLine("---------------------------------------------");
        Console.WriteLine();

        WritingAssignment w1 = new WritingAssignment("Reagan Jorge", "Inheritance", "Debugging Homework Assignment");
        Console.WriteLine(w1.GetSummary());
        Console.WriteLine(w1.GetWritingInformation());

        Console.WriteLine("=============================================");
        Console.WriteLine();
    }
}