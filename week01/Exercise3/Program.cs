using System;
using System.Runtime;

class Program
{
    static void Main(string[] args)
    {
        int amount = 0;
        string answer = "yes";

        while (answer == "yes")


        {
            Random randomGenerator = new Random();
            int RandomNumber = randomGenerator.Next(1, 101);
            int number = 0;
            while (number != RandomNumber)
            {
                Console.WriteLine("What is your guess?");
                string GuessedNumber = Console.ReadLine();
                number = int.Parse(GuessedNumber);
                amount += 1;
                if ((number) > RandomNumber)
                {
                    Console.WriteLine("Lower");
                }
                else if ((number) < RandomNumber)
                {
                    Console.WriteLine("Higher");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"You guessed in {amount} tries.");
                    amount = 0;
                    Console.WriteLine("Do you want to play again?");
                    answer = Console.ReadLine();
                }
            }

        }
    }
}