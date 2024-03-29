using System;
using System.Collections.Generic;
using System.Threading;

public class ReflectionActivity : Activity
{
    private List<string> reflectionPrompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> reflectionQuestions = new List<string>
    {
         "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectionActivity() : base("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
    }

    protected override void PerformActivity()
    {
        Random random = new Random();
        int promptIndex = random.Next(reflectionPrompts.Count());
        Console.WriteLine(reflectionPrompts[promptIndex]);

        int totalDuration = Duration, questionTime = totalDuration / reflectionQuestions.Count;
        foreach (var question in reflectionQuestions)
        {
            if (totalDuration <= 0) break;
            Console.WriteLine(question);
            ShowCountdown(questionTime > 0 ? questionTime : 1);
            totalDuration -= questionTime;
        }
    }

    private void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.WriteLine($"\r{i} seconds remain for reflection... ");
            Thread.Sleep(1000);
        }

        Console.WriteLine("\r                       \r");
    }
}