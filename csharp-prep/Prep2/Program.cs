using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("what is your grade percentage? ");
        string answer=Console.ReadLine();
        int precent= int.Parse(answer);
        string grade= "";
        if (precent>=90)
        {
            grade ="A";
        }
        else if (precent>=80)
        {
            grade ="B";
        }
        else if (precent>=70)
        {
            grade="C";
        }
        else if(precent>=60)
        {
            grade="D";
        }
        else
        {
            grade="F";
        }
        Console.WriteLine($"Your Grade is {grade}");
        if(precent>=70)
        {
            Console.WriteLine("You Passed the Class!!!");
        }
        else
        {
            Console.WriteLine("You Failed the Class sorry better luck next time");
        }
    }
}