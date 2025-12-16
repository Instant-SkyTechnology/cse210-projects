using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Options:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the options: ");

            // Read the input
            string userInput = Console.ReadLine();

            int choiceEntry;
            if (!int.TryParse(userInput, out choiceEntry))
            {
                Console.WriteLine("Invalid input! Please enter a number between 1 and 4.\n");
                Console.WriteLine("Press Enter to continue...");
                Console.ReadLine();
                continue;
            }

            Activity activity = null;

            if (choiceEntry == 1)
            {
                activity = new BreathingActivity();
            }
            else if (choiceEntry == 2)
            {
                activity = new ReflectionActivity();
            }
            else if (choiceEntry == 3)
            {
                activity = new ListingActivity();
            }
            else if (choiceEntry == 4)
            {
                Console.WriteLine("===================================");
                string message = "Thank you. Goodbye!";
                Console.WriteLine(message.PadLeft((35 + message.Length) / 2).PadRight(35));
                Console.WriteLine("===================================");
                Console.WriteLine();
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please select a number between 1 and 4.");
                Console.WriteLine("Press Enter to continue...");
                Console.ReadLine();
                continue;
            }

            // Run the selected activity
            activity.Run();

            Console.WriteLine("\nPress Enter to return to menu...");
            Console.ReadLine();
        }
    }
}