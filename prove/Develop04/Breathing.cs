public class BreathingActivity : BaseActivity
{
    public BreathingActivity() : base("Breathing Activity",  "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    public void RunBreathingActivity()
    {
        DisplayStartingMessage();

        for (int i = 0; i < duration; i += 4)
        {
            Console.Write("\n\nBreathe in...");
            ShowCountDown(2);
            Console.Write("\nBreathe out...");
            ShowCountDown(2);
        }

        DisplayEndingMessage();
    }
}