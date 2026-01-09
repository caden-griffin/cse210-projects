using System;

class Program
{
    static void Main(string[] args)
    {

        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int squaredNumber = SquareNumber(userNumber);
        DisplayResult(userName, squaredNumber);

        static void DisplayWelcome()

            {
                Console.WriteLine("Welcome to the Program!");
            }

        static string PromptUserName ()
            {
                Console.WriteLine("Input full name:");
                string fullName = Console.ReadLine();
                return fullName;
            }
        
        static int PromptUserNumber ()
            {
                Console.WriteLine("Input usernumber");
                int number = int.Parse(Console.ReadLine());
                return number;
            }
        
        static int SquareNumber (int userNumber)
            {
                int squaredNumber = userNumber * userNumber;
                return squaredNumber;

            }
        
        static void DisplayResult (string userName, int squaredNumber)
            {
                Console.WriteLine($"{userName}, the square of your number is {squaredNumber}");
            }

    }

}