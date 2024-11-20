using System;
using System.Collections.Generic;
using System.IO;
public class ChecklistGoal : Goal
{
    private int targetCount;
    private int currentCount;
    private int bonusPoints;

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonusPoints) 
        : base(name, description, points)
    {
        this.targetCount = targetCount;
        this.bonusPoints = bonusPoints;
        this.currentCount = 0;
    }

    public ChecklistGoal() : base("", "", 0)
    {
        targetCount = 0;
        bonusPoints = 0;
        currentCount = 0;
    }

    public override int RecordEvent()
    {
        currentCount++;
        if (currentCount == targetCount)
        {
            isComplete = true;
            return points + bonusPoints;
        }
        return points;
    }

    public override string GetStatusString()
    {
        return $"[{(isComplete ? "X" : " ")}] {name} ({description}) - Completed {currentCount}/{targetCount} times";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal|{name}|{description}|{points}|{targetCount}|{currentCount}|{bonusPoints}|{isComplete}";
    }

    public override void LoadFromString(string[] data)
    {
        name = data[1];
        description = data[2];
        points = int.Parse(data[3]);
        targetCount = int.Parse(data[4]);
        currentCount = int.Parse(data[5]);
        bonusPoints = int.Parse(data[6]);
        isComplete = bool.Parse(data[7]);
    }
}