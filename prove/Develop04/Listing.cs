public class ListingActivity : BaseActivity
{
    private List<string> prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity(): base("Listing Activity","This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }

    public void RunListingActivity()
    {
        DisplayStartingMessage();

        // Get random prompt
        Random random = new Random();
        string prompt = prompts[random.Next(prompts.Count)];
        
        Console.WriteLine("\nList as many responses as you can to the following prompt:");
        Console.WriteLine($"--- {prompt} ---");
        Console.Write("\nYou may begin in: ");
        ShowCountDown(5);
        Console.WriteLine();

        // Get user responses until time runs out
        DateTime endTime = DateTime.Now.AddSeconds(duration);
        int itemCount = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string response = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(response))
            {
                itemCount++;
            }
        }

        Console.WriteLine($"\nYou listed {itemCount} items!");
        
        DisplayEndingMessage();
    }
}