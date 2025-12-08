class Swimming : Activity
{
    private int _laps;
    private const double LapLengthMeters = 50;

    //CONSTRUCTOR
    public Swimming(DateTime date, double lengthInMinutes, int laps)
        : base(date, lengthInMinutes)
    {
        _laps = laps;
    }

    // GETTERS AND SETTERS
    public int GetLaps()
    {
        return _laps;
    }

    public void SetLaps(int laps)
    {
        _laps = laps;
    }

    // METHOD
    public override double GetDistance()
    {
        return _laps * LapLengthMeters / 1000; // km
    }

    public override double GetSpeed()
    {
        return (GetDistance() / GetLengthInMinutes()) * 60;
    }

    public override double GetPace()
    {
        return GetLengthInMinutes() / GetDistance();
    }
}
