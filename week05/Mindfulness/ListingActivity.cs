using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _usedPrompts;
    private Random _rand;

    public ListingActivity()
    {
        _name = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";

        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        _usedPrompts = new List<string>();
        _rand = new Random();
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("\nList as many responses you can to the following prompt:");
        Console.WriteLine($" --- {GetUniquePrompt()} ---\n");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine();

        List<string> userItems = new List<string>();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            if (Console.KeyAvailable)
            {
                string input = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(input))
                {
                    userItems.Add(input);
                }
            }
            else
            {
                Thread.Sleep(100);
                if (DateTime.Now >= endTime)
                {
                    break;
                }
            }
        }

        Console.WriteLine($"\nYou listed {userItems.Count} items!");
        DisplayEndingMessage();
    }

    private string GetUniquePrompt()
    {
        if (_usedPrompts.Count >= _prompts.Count)
        {
            _usedPrompts.Clear();
        }

        string prompt;
        do
        {
            int index = _rand.Next(_prompts.Count);
            prompt = _prompts[index];
        } while (_usedPrompts.Contains(prompt));

        _usedPrompts.Add(prompt);
        return prompt;
    }
}