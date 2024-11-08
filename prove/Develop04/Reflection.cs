public class ReflectionActivity : MindfulnessActivity
{
    private string[] prompts = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private string[] questions = {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectionActivity() : base("Reflection Activity") { }

    protected override string GetDescription()
    {
        return "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }

    protected override void PerformActivity()
    {
        Console.WriteLine("\nConsider the following prompt:\n");
        Console.WriteLine($"--- {prompts[new Random().Next(prompts.Length)]} ---\n");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.WriteLine("\nNow ponder on each of the following questions as they relate to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(3);
        Console.WriteLine();

        DateTime endTime = DateTime.Now.AddSeconds(duration);
        int questionIndex = 0;

        while (DateTime.Now < endTime && questionIndex < questions.Length)
        {
            Console.Write($"\n> {questions[questionIndex]} ");
            ShowSpinner(4);
            questionIndex++;
        }
    }
}