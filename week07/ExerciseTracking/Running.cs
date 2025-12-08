class Running : Activity
{
    private double _distance; // in km

    //CONSTRUCTOR
    public Running(DateTime date, double lengthInMinutes, double distance)
        : base(date, lengthInMinutes)
    {
        _distance = distance;
    }

    // GETTERS AND SETTERS
    public double GetDistanceValue()
    {
        return _distance;
    }

    public void SetDistanceValue(double distance)
    {
        _distance = distance;
    }

    // METHODS
    public override double GetDistance()
    {
        return _distance;
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
