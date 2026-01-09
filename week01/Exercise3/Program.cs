using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1,101);

        
        int guess = -1384234252;

        while (guess != magicNumber)
        {
            Console.WriteLine("What is the magic number?");
            guess = int.Parse(Console.ReadLine());

            if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
            }

            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
            }

            else if (magicNumber == guess)
            {
                Console.WriteLine($"Correct! You guessed {guess}, which is the magic number!");
            }
        }
        
    }
}