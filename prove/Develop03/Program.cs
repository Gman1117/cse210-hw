using System;

public class Program
{
    public static void Main()
    {
        ScriptureLibrary library = new ScriptureLibrary();
        
        // Load scriptures from file
        library.LoadFromFile("scriptures.txt");
        
        while (true)
        {
            Console.Clear();
            Console.WriteLine("1. Memorize a random scripture");
            Console.WriteLine("2. Exit");
            Console.Write("\nSelect an option: ");
            
            string choice = Console.ReadLine();
            if (choice == "2")
                break;

            if (choice == "1")
            {
                try
                {
                    Scripture scripture = library.GetRandomScripture();
                    MemorizeScripture(scripture);
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }
            }
        }
    }

    private static void MemorizeScripture(Scripture scripture)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to continue or type 'quit' to exit.");
            
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
                break;

            scripture.HideRandomWords(2);  // Hide 2 words at a time
            
            if (scripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine("\nCongratulations! You've memorized the scripture!");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                break;
            }
        }
    }
}