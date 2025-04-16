class Swimming : Activity
{
    private int _laps;

    public Swimming(string date, int minutes, int laps)
        : base(date, minutes)
    {
        _laps = laps;
    }

    public override double GetDistance() => _laps * 50 / 1000.0 * 0.62; // Convert to miles

    public override double GetSpeed() => GetDistance() / GetMinutes() * 60;

    public override double GetPace() => GetMinutes() / GetDistance();
}
