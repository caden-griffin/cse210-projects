using System;

//I exdeeded requirements by making sure that the random word selector only hides words that aren't already hidden.
class Program
{
    static void Main(string[] args)
    {
        Reference ref1 = new Reference("1 Nephi", 3, 7);
        string scriptureText = "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.";

        Scripture scripture = new Scripture(ref1, scriptureText);

        while (true)
        {
            Console.Clear();

            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();

            if (scripture.IsCompletelyHidden())
            {
                break;
            }

            Console.WriteLine("Press Enter to hide words, or type quit to exit");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(3);
        }
        Console.WriteLine("Program ended. Keep Practicing!");
    }
}