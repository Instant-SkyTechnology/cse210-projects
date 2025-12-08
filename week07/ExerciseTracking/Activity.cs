using System;

public abstract class Activity
{
    private DateTime _date;
    private double _lengthInMinutes;

    //CONSTRUCTOR
    public Activity(DateTime date, double lengthInMinutes)
    {
        _date = date;
        _lengthInMinutes = lengthInMinutes;
    }

    // GETTERS AND SETTERS
    public DateTime GetDate()
    {
        return _date;
    }

    public void SetDate(DateTime date)
    {
        _date = date;
    }

    public double GetLengthInMinutes()
    {
        return _lengthInMinutes;
    }

    public void SetLengthInMinutes(double lengthInMinutes)
    {
        _lengthInMinutes = lengthInMinutes;
    }


    // METHODS
    public abstract double GetDistance(); // km
    public abstract double GetSpeed();    // kph
    public abstract double GetPace();     // km

    public virtual string GetSummary()
    {
        return $"{_date:dd MMM yyyy} {this.GetType().Name} ({_lengthInMinutes} min) - " +
               $"Distance: {GetDistance():F2} km, Speed: {GetSpeed():F2} kph, Pace: {GetPace():F2} min per km";
    }
}
