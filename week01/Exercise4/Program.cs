using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int number = -1;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (number != 0)
        {
            
            string userNumber = Console.ReadLine();
            number = int.Parse(userNumber);


            if (number != 0)
            {
                numbers.Add(number);
            }

        }
        
    int sum = 0;
    foreach (int listNumber in numbers)
    {
        sum += listNumber;
    }

    float averageListNumber = 0;
    averageListNumber = (float)sum / numbers.Count;

    int largestNumber = 0;
    foreach (int listNumber in numbers)
        {
            if (listNumber > largestNumber)
            {
                largestNumber = listNumber;
            }
        }

    Console.WriteLine($"The sum is {sum}");
    Console.WriteLine($"The average is {averageListNumber}");
    Console.WriteLine($"The largest number is {largestNumber}");
            
    }

}