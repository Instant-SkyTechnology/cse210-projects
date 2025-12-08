class Cycling : Activity
{
    private double _speed; // in kph

    //CONSTRUCTOR
    public Cycling(DateTime date, double lengthInMinutes, double speed)
        : base(date, lengthInMinutes)
    {
        _speed = speed;
    }

    // GETTERS AND SETTERS
    public double GetSpeedValue()
    {
        return _speed;
    }

    public void SetSpeedValue(double speed)
    {
        _speed = speed;
    }

    // METHODS
    public override double GetDistance()
    {
        return _speed * (GetLengthInMinutes() / 60);
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return 60 / _speed;
    }
}
