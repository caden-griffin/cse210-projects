using System;
// I exceeded requirements by saving to a json file.
class Program
{
    static void Main(string[] args)
    {
        int number = 0;

        Journal journal = new Journal();

        Prompts prompts = new Prompts();
        
        while (number != 5)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            number = int.Parse(Console.ReadLine());

            if (number == 1)
            {
                Entry entry = new Entry();
                entry._date = DateTime.Now.ToShortDateString();

                string _prompt = prompts.GetRandomPrompt();
                entry._prompt = _prompt;

                Console.WriteLine(_prompt);
                Console.Write("> ");
                entry._response = Console.ReadLine();

                journal.AddEntry(entry);
            }

            else if (number == 2)
            {
                journal.DisplayEntries();
            }

            else if (number == 3)
            {
                Console.Write("Enter filename to load: ");
                string filename = Console.ReadLine();
                journal.LoadFromFile(filename);
                Console.WriteLine("Journal loaded successfully!");
            }

            else if (number == 4)
            {
                Console.Write("Enter filename to save: ");
                string filename = Console.ReadLine();
                journal.SaveToFile(filename);
                Console.WriteLine("Journal saved successfully!");
            }
        }

    }
}