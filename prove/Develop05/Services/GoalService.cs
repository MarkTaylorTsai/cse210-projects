using System;
using System.Collections.Generic;

public class GoalService
{
    private List<GoalBase> goals = new List<GoalBase>();

    public void AddGoal(GoalBase goal)
    {
        goals.Add(goal);
    }

    public void RecordGoalAchievement(string goalName, int pointsEarned)
    {
        var goal = goals.Find(g => g.Name == goalName);
        goal?.EarnPoints(pointsEarned);
    }

    public void DisplayGoals()
    {
        foreach (var goal in goals)
        {
            var status = goal is CheckGoal checkGoal ?
                $"Completed {checkGoal.CurrentCount}/{checkGoal.TargetCount} times" : "Goal";
            Console.WriteLine($"{goal.Name}: {status}, Total Points: {goal.Points}");
        }
    }
}