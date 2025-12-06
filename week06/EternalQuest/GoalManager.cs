using System;
using System.Collections.Generic;
using System.IO;

// I added a warning message in case the user type in invalid 
// number in the Eternal Quest Menu and Goal List. Also, I added DeleteGoal.

public class GoalManager
{
    private int _score;
    private List<Goal> _goals = new List<Goal>();

    public void Start()
    {
        bool running = true;

        while (running)
        {
            DisplayPlayerInfo();
            Console.WriteLine("\n=== Eternal Quest Menu ===");

            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goal Details");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. Delete Goal");
            Console.WriteLine("7. Quit");
            Console.Write("Choose an option: ");

            switch (Console.ReadLine())
            {
                case "1": CreateGoal(); break;
                case "2": ListGoalDetails(); break;
                case "3": RecordEvent(); break;
                case "4": SaveGoals(); break;
                case "5": LoadGoals(); break;
                case "6": DeleteGoal(); break;
                case "7":running = false;
                    Console.WriteLine("==========================");
                    Console.WriteLine("Thank you. Goodbye!");
                    Console.WriteLine("==========================");
                    Console.WriteLine();
                    break;

                default:
                    Console.WriteLine("==================================================");
                    Console.WriteLine("Invalid option! Please enter a number from 1 to 7.");
                    Console.WriteLine("==================================================");
                    break;
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"\nCurrent Score: {_score} points");
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("\n=== Goal List ===");

        int i = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{i}. {goal.GetDetailsString()}");
            i++;
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("\nWhich type of goal would you like to create?");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Choice: ");

        string choice = Console.ReadLine();
        if (choice != "1" && choice != "2" && choice != "3")
        {
            Console.WriteLine("========================================");
            Console.WriteLine("Invalid choice! Please enter 1, 2, or 3.");
            Console.WriteLine("========================================");
            return;
        }

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();

        Console.Write("Enter goal description: ");
        string desc = Console.ReadLine();

        Console.Write("Enter point value: ");
        int points = int.Parse(Console.ReadLine());

        if (choice == "1")
        {
            _goals.Add(new SimpleGoal(name, desc, points));
        }
        else if (choice == "2")
        {
            _goals.Add(new EternalGoal(name, desc, points));
        }
        else if (choice == "3")
        {
            Console.Write("Enter target completions: ");
            int target = int.Parse(Console.ReadLine());

            Console.Write("Enter bonus points: ");
            int bonus = int.Parse(Console.ReadLine());

            _goals.Add(new ChecklistGoal(name, desc, points, target, bonus));
        }

        Console.WriteLine("Goal created!");
    }

    public void RecordEvent()
    {
        ListGoalDetails();
        Console.Write("\nWhich goal did you accomplish? ");

        int index = int.Parse(Console.ReadLine()) - 1;

        int pointsEarned = _goals[index].RecordEvent();
        _score += pointsEarned;

        Console.WriteLine($"\nYou earned {pointsEarned} points!");
    }

    public void SaveGoals()
    {
        Console.Write("Enter filename to save: ");
        string filename = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }

        Console.WriteLine("Goals saved successfully.");
    }

    public void LoadGoals()
    {
        Console.Write("Enter filename to load: ");
        string filename = Console.ReadLine();

        _goals.Clear();

        string[] lines = File.ReadAllLines(filename);
        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split('|');

            string type = parts[0];
            string name = parts[1];
            string desc = parts[2];
            int points = int.Parse(parts[3]);

            if (type == "SimpleGoal")
            {
                bool complete = bool.Parse(parts[4]);
                _goals.Add(new SimpleGoal(name, desc, points, complete));
            }
            else if (type == "EternalGoal")
            {
                _goals.Add(new EternalGoal(name, desc, points));
            }
            else if (type == "ChecklistGoal")
            {
                int bonus = int.Parse(parts[4]);
                int target = int.Parse(parts[5]);
                int current = int.Parse(parts[6]);

                _goals.Add(new ChecklistGoal(name, desc, points, target, bonus, current));
            }
        }

        Console.WriteLine("Goals loaded successfully.");
    }
    public void DeleteGoal()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("\nThere are no goals to delete.");
            return;
        }

        Console.WriteLine("\n=== Delete a Goal ===");

        int i = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{i}. {goal.GetDetailsString()}");
            i++;
        }

        Console.Write("\nEnter the number of the goal to delete: ");
        string input = Console.ReadLine();
        int index;

        if (!int.TryParse(input, out index) || index < 1 || index > _goals.Count)
        {
            Console.WriteLine("==================================================");
            Console.WriteLine("Invalid number! Please enter a valid goal number.");
            Console.WriteLine("==================================================");
            return;
        }

        _goals.RemoveAt(index - 1);
        Console.WriteLine("Goal deleted successfully!");
    }

}
