using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        Console.WriteLine("=============Exercise 1============");
        Console.WriteLine();
        Console.Write("What is your first name? ");
        string firstname = Console.ReadLine();

        Console.Write("What is your last name? ");
        string lastname = Console.ReadLine();

        Console.WriteLine($"Your name is {lastname}, {firstname} {lastname}");
        Console.WriteLine("===================================");
        Console.WriteLine();
    }
}