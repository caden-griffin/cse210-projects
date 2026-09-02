using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage?");

        string GradePercentage = Console.ReadLine();
        int Grade = int.Parse(GradePercentage);

        if ((Grade) >= 90)
        {
            Console.WriteLine("Your grade is an A.");
        }
        else if ((Grade) >= 80)
        {
            Console.WriteLine("Your grade is a B.");
        }
        else if ((Grade) >= 70)
        {
            Console.WriteLine("Your grade is a C.");
        }
        else if ((Grade) >= 60)
        {
            Console.WriteLine("Your grade is a D.");
        }
        else if ((Grade) <60)
        {
            Console.WriteLine("Your grade is an F.");
        }

        if ((Grade) <= 60)
        {
            Console.WriteLine("You Fail");
        }
        else
        {
            Console.WriteLine("You Pass!");
        }

    }
}