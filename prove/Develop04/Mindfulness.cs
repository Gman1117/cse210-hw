public abstract class MindfulnessActivity
{
    protected int duration;
    protected string activityName;

    public MindfulnessActivity(string name)
    {
        activityName = name;
    }

    public void Run()
    {
        DisplayStartingMessage();
        PerformActivity();
        DisplayFinishingMessage();
        Console.WriteLine("\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();
    }

    protected virtual void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {activityName}!");
        Console.WriteLine("\n" + GetDescription());
        Console.Write("\nPlease enter the duration in seconds: ");
        duration = int.Parse(Console.ReadLine());
        Console.WriteLine("\nGet ready to begin...");
        ShowSpinner(3);
    }

    protected abstract string GetDescription();

    protected abstract void PerformActivity();

    protected virtual void DisplayFinishingMessage()
    {
        Console.WriteLine("\nWell done!");
        ShowSpinner(2);
        Console.WriteLine($"\nYou have completed {duration} seconds of the {activityName}.");
        ShowSpinner(2);
    }

    protected void ShowSpinner(int seconds)
    {
        string[] spinnerFrames = { "|", "/", "-", "\\" };
        int spinnerPosition = Console.CursorLeft;
        
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        int counter = 0;
        
        while (DateTime.Now < endTime)
        {
            Console.Write(spinnerFrames[counter % spinnerFrames.Length]);
            Thread.Sleep(250);
            Console.SetCursorPosition(spinnerPosition, Console.CursorTop);
            counter++;
        }
        Console.Write(" "); // Clear the last spinner character
    }

    protected void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b"); // Erase the number
        }
    }
}