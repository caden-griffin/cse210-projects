using System;

class Program
{
    // EXCEEDING REQUIREMENTS NOTE:
    // 1. Implemented unique/non-repeating prompt and question selection algorithms in 
    //    ReflectingActivity and ListingActivity so that no item repeats until all have been used.
    // 2. Added session logging that tracks how many times each activity was performed during the program run.
    static void Main(string[] args)
    {
        int breathingCount = 0;
        int reflectingCount = 0;
        int listingCount = 0;

        string choice = "";
        while (choice != "4")
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");

            choice = Console.ReadLine();

            if (choice == "1")
            {
                BreathingActivity breathing = new BreathingActivity();
                breathing.Run();
                breathingCount++;
            }
            else if (choice == "2")
            {
                ReflectingActivity reflecting = new ReflectingActivity();
                reflecting.Run();
                reflectingCount++;
            }
            else if (choice == "3")
            {
                ListingActivity listing = new ListingActivity();
                listing.Run();
                listingCount++;
            }
            else if (choice == "4")
            {
                Console.Clear();
                Console.WriteLine("\nSession Summary:");
                Console.WriteLine($"- Breathing Activities Completed: {breathingCount}");
                Console.WriteLine($"- Reflecting Activities Completed: {reflectingCount}");
                Console.WriteLine($"- Listing Activities Completed: {listingCount}");
                Console.WriteLine("\nThank you for using the Mindfulness Program. Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please select 1 through 4.");
                Thread.Sleep(1500);
            }
        }
    }
}