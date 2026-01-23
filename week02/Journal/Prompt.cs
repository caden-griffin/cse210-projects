using System;
using System.Collections.Generic;

public class Prompts
{
    private List<string> _prompts;
    
    public Prompts()
    {
        _prompts = new List<string>()
        {
            "What were the three most interesting things to happen today?",
            "What was your favorite part of today?",
            "What is something unexpected that happened today?",
            "What is one thing you wish you could redo today?",
            "What is something that happened today that you will remember tomorrow?",
            "How did you improve someone elses day today?"
        };
    }

    public string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(0, _prompts.Count);
        return _prompts[index];
    }
}