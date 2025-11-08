using System;
using System.Collections.Generic;

public class PromptGenerator
{
    //INSPIRATION SOURCE VIDEOS POSTED IN CANVAS AND BY THE INSTRUCTOR
    public List<string> _prompts = new List<string>()
    {
        "What did you eat today?",
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}