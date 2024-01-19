using System;
using System.Collections.Generic;

public class PromptManager
{
    private List<string> prompts;
    private Random random;

    public PromptManager()
    {
        random = new Random();
        prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };
    }

    public string GetRandomPromt()
    {
        int index = random.Next(prompts.Count);
        return prompts[index];
    }
}