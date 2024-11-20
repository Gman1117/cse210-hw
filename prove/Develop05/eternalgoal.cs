using System;
using System.Collections.Generic;
using System.IO;
public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) 
        : base(name, description, points) { }

    public EternalGoal() : base("", "", 0) { }

    public override int RecordEvent()
    {
        return points;
    }

    public override string GetStatusString()
    {
        return $"[ ] {name} ({description}) - Eternal";
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal|{name}|{description}|{points}";
    }

    public override void LoadFromString(string[] data)
    {
        name = data[1];
        description = data[2];
        points = int.Parse(data[3]);
    }
}