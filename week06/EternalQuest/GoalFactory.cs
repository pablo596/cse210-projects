static class GoalFactory
{
    public static Goal CreateGoalFromString(string data)
    {
        string[] parts = data.Split('|');
        string type = parts[0];

        if (type == "SimpleGoal")
        {
            SimpleGoal goal = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]));
            goal.SetIsComplete(bool.Parse(parts[4]));
            return goal;
        }
        else if (type == "EternalGoal")
        {
            return new EternalGoal(parts[1], parts[2], int.Parse(parts[3]));
        }
        else if (type == "ChecklistGoal")
        {
            ChecklistGoal goal = new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[5]), int.Parse(parts[4]));
            goal.SetAmountCompleted(int.Parse(parts[6]));
            return goal;
        }
        return null;
    }

    private static void SetAmountCompleted(this ChecklistGoal goal, int amount)
    {
        typeof(ChecklistGoal).GetField("_amountCompleted", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).SetValue(goal, amount);
    }

    private static void SetIsComplete(this SimpleGoal goal, bool complete)
    {
        typeof(SimpleGoal).GetField("_isComplete", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).SetValue(goal, complete);
    }
}
