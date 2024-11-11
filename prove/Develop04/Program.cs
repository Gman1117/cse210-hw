class Program
{
    static void Main(string[] args)
    {
        bool running = true;
        
        while (running)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    BreathingActivity breathing = new BreathingActivity();
                    breathing.RunBreathingActivity();
                    break;

                case "2":
                    ReflectionActivity reflection = new ReflectionActivity();
                    reflection.RunReflectionActivity();
                    break;

                case "3":
                    ListingActivity listing = new ListingActivity();
                    listing.RunListingActivity();
                    break;

                case "4":
                    running = false;
                    Console.WriteLine("\nThank you for using the Mindfulness Program!");
                    Thread.Sleep(2000);
                    break;

                default:
                    Console.WriteLine("\nInvalid choice. Press any key to continue.");
                    Console.ReadKey();
                    break;
            }
        }
    }
}