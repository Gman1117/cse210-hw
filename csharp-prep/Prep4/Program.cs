using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers= new ();
        int picknum= -1;
        while (picknum != 0)
        {
            Console.Write("Enter a number (0 to quit): ");
            string i = Console.ReadLine();
            picknum= int.Parse(i);

            if (picknum !=0)
            {
                numbers.Add(picknum);
            }

        }
        int sum =0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"the sum of the numbers is {sum}");
        float average = ((float)sum/ numbers.Count);
        Console.WriteLine($"The Average is {average}");
        int max = numbers [0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }

            
        }
        Console.WriteLine($"The Max is {max}");

    }
}