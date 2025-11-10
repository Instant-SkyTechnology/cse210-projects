using System;

class Program
{
    static void Main(string[] args)
    {
        Fractions f1 = new Fractions();
        // f1.SetTop(1);
        // f1.SetBottom(1);
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());

        Fractions f2 = new Fractions(5);
        // f2.SetTop(5);
        // f2.SetBottom(1);
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());

        Fractions f3 = new Fractions(1, 4);
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());

        Fractions f4 = new Fractions(1, 3);
        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue());
;
        Console.WriteLine();
    }
}