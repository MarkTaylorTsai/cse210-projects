using System;

public class SimpleGoal : GoalBase
{
    public SimpleGoal(string name) : base(name) { }

    public override void EarnPoints(int pointsEarned)
    {
        Points += pointsEarned;
        Console.WriteLine($"Earned {pointsEarned} points for completing {Name}. Total points: {Points}");
    }
}