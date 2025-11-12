//#------------------------------------#
//#----------PROJECT JOURNAL-----------#
//#----------STEVE B. KALALA-----------#
//#------------------------------------#
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //INSPIRATION SOURCE SHOPPING CART PROJECT CSE110
        //INSPIRATION SOURCE VIDEOS POSTED IN CANVAS AND BY THE INSTRUCTOR

        Journal theJournal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        int choice = 0;

        while (choice != 5)
        {
            Console.WriteLine("Please select one of the following:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            Console.Write("What would you like to do? ");
            // int choiceEntry = int.Parse(Console.ReadLine());
            string Userinput = Console.ReadLine();

            int choiceEntry;
            if (!int.TryParse(Userinput, out choiceEntry))
            {
                Console.WriteLine("Invalid input! Please enter a number between 1 and 5.\n");
                continue;
            }

            if (choiceEntry == 1)
            {
                Console.WriteLine("\nYou selected: Write\n");
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine(prompt);
                Console.Write(">> ");
                string entryText = Console.ReadLine();

                Entry newEntry = new Entry(prompt, entryText);
                theJournal.AddEntry(newEntry);
            }
            else if (choiceEntry == 2)
            {
                Console.WriteLine("\nYou selected: Display\n");
                theJournal.DisplayAll();
            }
            else if (choiceEntry == 3)
            {
                Console.WriteLine("You selected: Load");
                Console.Write("\nEnter the filename to load: ");
                string filename = Console.ReadLine();
                theJournal.LoadFromFile(filename);
            }
            else if (choiceEntry == 4)
            {
                Console.WriteLine("You selected: Save");
                Console.Write("\nEnter the filename to save: ");
                string fileName = Console.ReadLine();
                theJournal.SaveToFile(fileName);
            }
            else if (choiceEntry == 5)
            {
                Console.WriteLine("============================");
                string message = "Thank you. Goodbye!";
                Console.WriteLine(message.PadLeft((28 + message.Length) / 2).PadRight(28));
                Console.WriteLine("============================");
                Console.WriteLine();
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please select a number between 1 and 5.");
            }
            Console.WriteLine();
        }
    }
}