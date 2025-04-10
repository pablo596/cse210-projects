using System;

static class GoalFactory
{
    public static Goal CreateGoalFromString(string data)
    {
        string[] parts = data.Split('|');
        switch (parts[0])
        {
            case "SimpleGoal":
                var sg = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]));
                sg.SetIsComplete(bool.Parse(parts[4]));
                return sg;
            case "EternalGoal":
                return new EternalGoal(parts[1], parts[2], int.Parse(parts[3]));
            case "ChecklistGoal":
                var cg = new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[5]), int.Parse(parts[4]));
                cg.SetAmountCompleted(int.Parse(parts[6]));
                return cg;
            default: return null;
        }
    }
}