class BonusGoal : Goal
{
    private int _timesCompleted;
    private int _bonusThreshold;
    private int _bonusPoints;

    public BonusGoal(string name, string description, int points, int bonusThreshold, int bonusPoints)
        : base(name, description, points)
    {
        _timesCompleted = 0;
        _bonusThreshold = bonusThreshold;
        _bonusPoints = bonusPoints;
    }

    public override int RecordEvent()
    {
        _timesCompleted++;
        if (_timesCompleted % _bonusThreshold == 0)
        {
            return _points + _bonusPoints;
        }
        return _points;
    }

    public override bool IsComplete()
    {
        return false; // Bonus goals never complete fully
    }

    public override string GetDetailsString()
    {
        return $"[~] {_shortName} ({_description}) -- Times completed: {_timesCompleted}, bonus every {_bonusThreshold} times";
    }

    public override string GetStringRepresentation()
    {
        return $"BonusGoal|{_shortName}|{_description}|{_points}|{_bonusThreshold}|{_bonusPoints}|{_timesCompleted}";
    }
}