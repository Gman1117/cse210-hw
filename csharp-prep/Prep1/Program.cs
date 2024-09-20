using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("what is your firt name? ");
        string First= Console.ReadLine();

        Console.WriteLine("What is your Last name? ");
        string Last= Console.ReadLine();

        Console.WriteLine($"Your name is {Last}, {First} {Last}");
    }
}