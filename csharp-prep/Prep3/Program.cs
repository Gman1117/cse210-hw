using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicnumber = randomGenerator.Next(1,11);
        int picknum = -1;
        while ( picknum != magicnumber )
        {
            Console.Write(" What is your guess: ");
            picknum = int.Parse(Console.ReadLine());

            if (magicnumber>picknum)
            {
                Console.WriteLine("Higher");
            }
            else if (magicnumber<picknum)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("you Guessed it");
            }

        }
    }
}