using System;
using System.Collections.Generic;
using System.Threading;

public class ListingActivity : Activity
{
    private List<string> listingPrompts = new List<string>
    {
        "List things you're grateful for today.",
    "What are personal strengths that you're proud of?",
    "Who are people that have positively influenced your life?",
    "What are some achievements you've accomplished this year?",
    "Name happy moments you've experienced this past week.",
    "What are some skills or talents that you possess?",
    "List some acts of kindness you've witnessed or done recently.",
    "What are some goals you've set for yourself and achieved?",
    "Who are friends or family members that you appreciate, and why?",
    "What are some lessons you've learned that have shaped who you are?"
    };

    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }

    protected override void PerformActivity()
    {
        Random random = new Random();
        int promptIndex = random.Next(listingPrompts.Count);
        Console.WriteLine(listingPrompts[promptIndex]);

        Console.WriteLine("Start listing now! (Press ENTER after each item, type 'done' to finish)");

        var items = new List<string>();
        string input;
        DateTime endTime = DateTime.Now.AddSeconds(Duration);
        do
        {
            input = Console.ReadLine();
            if (input.ToLower() != "done" && DateTime.Now < endTime)
            {
                items.Add(input);
            }
        } while (input.ToLower() != "done" && DateTime.Now < endTime);

        Console.WriteLine($"You've listed {items.Count} items.");
        foreach (var item in items)
        {
            Console.WriteLine(item);
        }
    }
}