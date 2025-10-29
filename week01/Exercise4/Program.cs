using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        List<int> Numbers = new List<int>();

        while (true) 
        {
            Console.Write("Enter number: ");
            int nuM = int.Parse(Console.ReadLine());

            if (nuM == 0)
            {
                break;
            }
            Numbers.Add(nuM);
        }
        Console.WriteLine();
        
        if (Numbers.Count > 0)
        {
            Console.WriteLine($"The sum is: {Numbers.Sum()}");
            Console.WriteLine($"The average is: {Numbers.Average():F2}");
            Console.WriteLine($"The largest number is: {Numbers.Max():F2}");
            Console.WriteLine($"The smallest positive number is: {Numbers.Min():F2}");

            Numbers.Sort();
            foreach (int num in Numbers)
            {
                Console.WriteLine(num);
            }
            
            Console.WriteLine();
        }
    }
}