public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless.",
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult."
    };

    private List<string> _questions = new List<string>
    {
        "How did you feel when it was complete?",
        "How did you get started?",
        "Why was this experience meaningful to you?",
        "What is your favorite thing about this experience?",
        "Have you ever done anytihing like this before?"
    };

    public ReflectingActivity() : base("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();

        Random random = new Random();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        Console.WriteLine($"--- {_prompts[random.Next(_prompts.Count)]} ---");
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue");
        Console.ReadLine();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write($"> {_questions[random.Next(_questions.Count)]} ");
            ShowSpinner(5);
            Console.WriteLine();
        }

        DisplayEndingMessage();
    }
}