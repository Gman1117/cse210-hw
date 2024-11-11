public class BaseActivity
{
    protected int duration;
    protected string name;
    protected string description;

    public BaseActivity(string activityName, string activityDescription)
    {
        name = activityName;
        description = activityDescription;
    }

    protected void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {name}!");
        Console.WriteLine($"\n{description}");
        Console.Write("\nHow long, in seconds, would you like for your session? ");
        duration = int.Parse(Console.ReadLine());
        Console.WriteLine("\nGet ready...");
        ShowSpinner(3);
    }

    protected void DisplayEndingMessage()
    {
        Console.WriteLine("\nWell done!!");
        ShowSpinner(3);
        Console.WriteLine($"\nYou have completed another {duration} seconds of the {name}.");
        ShowSpinner(3);
    }

    protected void ShowSpinner(int seconds)
    {
        List<string> spinnerStrings = new List<string> { "|", "/", "-", "\\" };
        DateTime endTime = DateTime.Now.AddSeconds(seconds);

        int i = 0;
        while (DateTime.Now < endTime)
        {
            Console.Write(spinnerStrings[i]);
            Thread.Sleep(250);
            Console.Write("\b \b");
            i++;
            if (i >= spinnerStrings.Count)
            {
                i = 0;
            }
        }
    }

    protected void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}