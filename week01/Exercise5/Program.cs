using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string User = PromptUserName();

        int nuM = PromptUserNumber();

        int squarE = SquareNumber(nuM);

        DisplayResult(User, squarE);
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string UserName = Console.ReadLine();
        return UserName;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int nuMber = int.Parse(Console.ReadLine());
        return nuMber;
    }

    static int SquareNumber(int nuMber)
    {
        int square = nuMber * nuMber;
        return square;
    }

    static void DisplayResult(string UserName, int square)
    {
        Console.WriteLine($"{UserName}, the square of your number is {square}");
    }

}
