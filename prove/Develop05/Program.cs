using System;
using System.Collections.Generic;
using System.IO;


public class Program
{
    private static QuestManager questManager = new QuestManager();

    public static void Main()
    {
        bool running = true;
        while (running)
        {
            Console.WriteLine("\n1. Create New Goal");
            Console.WriteLine("2. Record Event");
            Console.WriteLine("3. Display Goals");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. Exit");
            Console.Write("\nSelect an option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateNewGoal();
                    break;
                case "2":
                    RecordGoalEvent();
                    break;
                case "3":
                    questManager.DisplayGoals();
                    break;
                case "4":
                    SaveGoals();
                    break;
                case "5":
                    LoadGoals();
                    break;
                case "6":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }

    private static void CreateNewGoal()
    {
        Console.WriteLine("\nSelect goal type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        
        Console.Write("Enter goal type: ");
        string typeChoice = Console.ReadLine();

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        
        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();
        
        Console.Write("Enter points for completing: ");
        int points = int.Parse(Console.ReadLine());

        Goal newGoal;
        switch (typeChoice)
        {
            case "1":
                newGoal = new SimpleGoal(name, description, points);
                break;
            case "2":
                newGoal = new EternalGoal(name, description, points);
                break;
            case "3":
                Console.Write("Enter target count: ");
                int targetCount = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus points: ");
                int bonusPoints = int.Parse(Console.ReadLine());
                newGoal = new ChecklistGoal(name, description, points, targetCount, bonusPoints);
                break;
            default:
                Console.WriteLine("Invalid goal type.");
                return;
        }

        questManager.AddGoal(newGoal);
        Console.WriteLine("Goal created successfully!");
    }

    private static void RecordGoalEvent()
    {
        questManager.DisplayGoals();
        Console.Write("\nEnter the goal number to record: ");
        if (int.TryParse(Console.ReadLine(), out int goalNumber))
        {
            questManager.RecordEvent(goalNumber - 1);
            Console.WriteLine("Event recorded successfully!");
        }
        else
        {
            Console.WriteLine("Invalid goal number.");
        }
    }

    private static void SaveGoals()
    {
        Console.Write("Enter filename to save (e.g., mygoals.txt): ");
        string filename = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(filename))
        {
            filename = "goals.txt";
        }
        if (!filename.EndsWith(".txt"))
        {
            filename += ".txt";
        }
        questManager.SaveToFile(filename);
    }

    private static void LoadGoals()
    {
        Console.Write("Enter filename to load (e.g., mygoals.txt): ");
        string filename = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(filename))
        {
            filename = "goals.txt";
        }
        if (!filename.EndsWith(".txt"))
        {
            filename += ".txt";
        }
        questManager.LoadFromFile(filename);
    }
}