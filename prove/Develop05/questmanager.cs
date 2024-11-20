using System;
using System.Collections.Generic;
using System.IO;

public class QuestManager
{
    private List<Goal> goals;
    private int totalPoints;

    public QuestManager()
    {
        goals = new List<Goal>();
        totalPoints = 0;
    }

    public void AddGoal(Goal goal)
    {
        goals.Add(goal);
    }

    public void RecordEvent(int goalIndex)
    {
        if (goalIndex >= 0 && goalIndex < goals.Count)
        {
            totalPoints += goals[goalIndex].RecordEvent();
        }
    }

    public void DisplayGoals()
    {
        Console.WriteLine("\nCurrent Goals:");
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].GetStatusString()}");
        }
        Console.WriteLine($"\nTotal Points: {totalPoints}");
    }

    public void SaveToFile(string filename)
    {
        try 
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                writer.WriteLine(totalPoints);
                foreach (Goal goal in goals)
                {
                    writer.WriteLine(goal.GetStringRepresentation());
                }
            }
            Console.WriteLine($"Goals saved successfully to {filename}!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving file: {ex.Message}");
        }
    }

    public void LoadFromFile(string filename)
    {
        try
        {
            if (File.Exists(filename))
            {
                goals.Clear();
                string[] lines = File.ReadAllLines(filename);
                
                if (lines.Length > 0)
                {
                    totalPoints = int.Parse(lines[0]);
                    
                    for (int i = 1; i < lines.Length; i++)
                    {
                        string[] parts = lines[i].Split('|');
                        Goal goal = null;
                        
                        switch (parts[0])
                        {
                            case "SimpleGoal":
                                goal = new SimpleGoal();
                                break;
                            case "EternalGoal":
                                goal = new EternalGoal();
                                break;
                            case "ChecklistGoal":
                                goal = new ChecklistGoal();
                                break;
                        }

                        if (goal != null)
                        {
                            goal.LoadFromString(parts);
                            goals.Add(goal);
                        }
                    }
                }
                Console.WriteLine($"Goals loaded successfully from {filename}!");
            }
            else
            {
                Console.WriteLine($"File {filename} not found.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading file: {ex.Message}");
        }
    }
}