using System;
using System.Threading;

public abstract class Activity
{
    protected string Name { get; set; }
    protected string Description { get; set; }
    protected int Duration { get; set; }

    public Activity(string _name, string _description)
    {
        Name = _name;
        Description = _description;
    }

    public void ExecuteActivity()
    {
        DisplayStartMessage();
        SetDuration();
        PerformActivity();
        DisplayEndMessage();
    }

    protected virtual void DisplayStartMessage()
    {
        Console.WriteLine($"Activity: {Name}\nDescription: {Description}");
        Console.WriteLine("Please enter the duration of the activity in seconds:");
    }

    protected void SetDuration()
    {
        if (int.TryParse(Console.ReadLine(), out int _duration))
        {
            Duration = _duration;
        }
        else
        {
            Console.WriteLine("Invalid input. Setting default duration to 60 seconds.");
            Duration = 60;
        }

        Console.WriteLine("Prepare to begin. Please get ready...");
        Thread.Sleep(3000);
    }

    protected abstract void PerformActivity(); // To be implemented by derived classes

    protected virtual void DisplayEndMessage()
    {
        Console.WriteLine($"You have completed the {Name} activity. Great job!");
        Thread.Sleep(3000); // Pause before ending
    }
}