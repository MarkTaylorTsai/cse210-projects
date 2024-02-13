using System;

public class CheckGoal : GoalBase
{
    public int TargetCount { get; private set; }
    public int CurrentCount { get; private set; }
    private int BonusPoints;

    public CheckGoal(string name, int targetCount, int bonusPoints) : base(name)
    {
        TargetCount = targetCount;
        BonusPoints = bonusPoints;
    }

    public override void EarnPoints(int pointsEarned)
    {
        CurrentCount++;
        Points += pointsEarned; Console.WriteLine($"Progress for {Name}: {CurrentCount}/{TargetCount}. Earned {pointsEarned} points. Total points: {Points}");

        if (CurrentCount == TargetCount)
        {
            Points += BonusPoints;
            Console.WriteLine($"Completed {Name}! Earned bonus {BonusPoints} points. Total points: {Points}");
        }
    }

}