using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");

            string userName = PromptUserName();
            int userNumber = PromptUserNumber();
            int squaredNumber = SquareNumber(userNumber);

            DisplayResult(userName, squaredNumber);

        }

        DisplayWelcome();

        static string PromptUserName()
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            return name;
        }

        static int PromptUserNumber()
        {
            Console.WriteLine("What is your favorite number?");
            string EnteredNumber = Console.ReadLine();
            int number = int.Parse(EnteredNumber);
            return number;
        }

        static int SquareNumber(int number)
        {
            int UserNumberSquared = number * number;
            return UserNumberSquared;
        }

        static void DisplayResult(string name, int UserNumberSquared)
        {
            Console.WriteLine($"{name}, the square of your number is {UserNumberSquared}");
        }
    }
}