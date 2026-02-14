public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "Who are some of your personal heroes?",
        "What are personal strengths of yours?"
    };

    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by listing as many things as you can.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();

        Random random = new Random();
        Console.WriteLine("List as many itmes as you can to the following prompt:");
        Console.WriteLine($"--- {_prompts[random.Next(_prompts.Count)]} ---");
        Console.Write("You may begin in : ");
        ShowCountDown(5);
        Console.WriteLine();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        _count = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            _count++;
        }

        Console.WriteLine($"You Listed {_count} items!");
        DisplayEndingMessage();
    }
}