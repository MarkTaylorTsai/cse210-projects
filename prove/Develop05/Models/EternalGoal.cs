using System;

public class EternalGoal : GoalBase
{
    public EternalGoal(string name) : base(name) { }

    public override void EarnPoints(int pointsEarned)
    {
        Points += pointsEarned;
        Console.WriteLine($"Earned {pointsEarned} points for {Name}. Total points: {Points}");
    }
}