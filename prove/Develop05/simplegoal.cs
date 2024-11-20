using System;
using System.Collections.Generic;
using System.IO;
public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points) 
        : base(name, description, points) { }

    public SimpleGoal() : base("", "", 0) { }

    public override int RecordEvent()
    {
        if (!isComplete)
        {
            isComplete = true;
            return points;
        }
        return 0;
    }

    public override string GetStatusString()
    {
        return $"[{(isComplete ? "X" : " ")}] {name} ({description})";
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal|{name}|{description}|{points}|{isComplete}";
    }

    public override void LoadFromString(string[] data)
    {
        name = data[1];
        description = data[2];
        points = int.Parse(data[3]);
        isComplete = bool.Parse(data[4]);
    }
}