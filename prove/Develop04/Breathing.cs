public class BreathingActivity : MindfulnessActivity
{
    public BreathingActivity() : base("Breathing Activity") { }

    protected override string GetDescription()
    {
        return "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    protected override void PerformActivity()
    {
        Console.WriteLine("\n");
        for (int i = 0; i < duration; i += 4)
        {
            Console.Write("\nBreathe in... ");
            ShowCountDown(2);
            Console.Write("\nBreathe out... ");
            ShowCountDown(2);
        }
    }
}