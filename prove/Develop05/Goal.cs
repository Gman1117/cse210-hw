using System;
using System.Collections.Generic;
using System.IO;
public abstract class Goal
{
    protected string name;
    protected string description;
    protected int points;
    protected bool isComplete;

    public Goal(string name, string description, int points)
    {
        this.name = name;
        this.description = description;
        this.points = points;
        this.isComplete = false;
    }

    public abstract int RecordEvent();
    public abstract string GetStatusString();
    public abstract string GetStringRepresentation();
    public abstract void LoadFromString(string[] data);

    public string GetName() => name;
    public bool IsComplete() => isComplete;
}