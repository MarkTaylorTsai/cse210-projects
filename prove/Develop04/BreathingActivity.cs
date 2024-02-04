using System;
using System.Threading;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    protected override void PerformActivity()
    {
        int cycleDuration = 10; // Total duration for one full breath cycle (in and out)
        int cycles = Duration / cycleDuration; // Calculate how many cycles fit into the user-specified duration

        for (int i = 0; i < cycles; i++)
        {
            Console.WriteLine("Breathing in...");
            ShowCountdown(cycleDuration / 2); // Half the cycle duration for breathing in

            Console.WriteLine("Breathing out...");
            ShowCountdown(cycleDuration / 2); // Half the cycle duration for breathing out
        }
    }

    private void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"\r{i} seconds remaining... "); // Use \r to return to the line start
            Thread.Sleep(1000); // Wait for 1 second
        }
        Console.Write("\r                         \r"); // Clear the line after countdown
    }
}
