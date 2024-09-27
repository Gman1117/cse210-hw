using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();
        String UserName= PromptUserName();
        int UserNumber = PromptUserNumber();
       int finalnumber= SquaredNumber(UserNumber);
       Displayresult(UserName,finalnumber);
        static void DisplayWelcomeMessage()
        
        {
            Console.WriteLine("Welcome to the Program");
        
        }
        static string PromptUserName()
        {
            Console.Write("What is your name: ");
            string name =Console.ReadLine();
            return name;
        }
        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            int number = int.Parse(Console.ReadLine());
            return number;
        }
        static int SquaredNumber(int number)
        {
            int square = number * number;
            return square;

        }
        static void Displayresult(string name, int square)
        {
            Console.WriteLine($"{name}, Your number squared {square}");
        }

    }
}