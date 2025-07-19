using System;
using System.Collections.Generic;

public class PromptGenerator
{
    private List<string> _prompts = new()
    {
        "Who was the most interesting person I interacted with today?",

        "What was the best part of my day?",

        "How did I see the hand of the Lord in my life today?",

        "What was the strongest emotion I felt today?",

        "If I had to do one thing today, what would it be?"
    };

    public string GetRandomPrompt()
    {
        Random rnd = new();
        int index = rnd.Next(_prompts.Count);
        return _prompts[index];
    }
}