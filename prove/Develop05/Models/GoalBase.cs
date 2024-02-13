using System;

public abstract class GoalBase
{
    public string Name { get; set; }
    public int Points { get; protected set; }

    protected GoalBase(string name)
    {
        Name = name;
    }

    public abstract void EarnPoints(int pointsEarned);
}