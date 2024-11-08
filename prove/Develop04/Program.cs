public class Program
{
    public static void Main(string[] args)
    {
        bool running = true;
        while (running)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start Breathing Activity");
            Console.WriteLine("  2. Start Reflection Activity");
            Console.WriteLine("  3. Start Listing Activity");
            Console.WriteLine("  4. Quit");
            Console.Write("\nSelect a choice from the menu: ");

            string choice = Console.ReadLine();
            MindfulnessActivity activity = null;

            switch (choice)
            {
                case "1":
                    activity = new BreathingActivity();
                    break;
                case "2":
                    activity = new ReflectionActivity();
                    break;
                case "3":
                    activity = new ListingActivity();
                    break;
                case "4":
                    running = false;
                    Console.WriteLine("\nThank you for using the Mindfulness Program!");
                    Thread.Sleep(2000);
                    continue;
                default:
                    Console.WriteLine("\nInvalid choice. Press any key to try again.");
                    Console.ReadKey();
                    continue;
            }

            if (activity != null)
                activity.Run();
        }
    }
}