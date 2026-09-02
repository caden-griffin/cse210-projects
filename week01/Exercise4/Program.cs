using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int sum = 0;

        int UserNumber = -1;
        while (UserNumber != 0)
        {
            Console.WriteLine("Type a number (Input 0 to stop.)");
            string UserInput = Console.ReadLine();
            UserNumber = int.Parse(UserInput);

            if (UserNumber != 0)
            {
                numbers.Add(UserNumber);
            }
        }

        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"Sum: {sum}");


        float average = sum / numbers.Count();
        Console.WriteLine($"Average: {average}");

        int LargestNumber = numbers[0];

        foreach (int number in numbers)
        {
            if (number >= LargestNumber)
            {
                LargestNumber = number;
            }

        }
        Console.WriteLine($"The largest number is: {LargestNumber}");
    }
}