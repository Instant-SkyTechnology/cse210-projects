using System;

public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;

    // CONSTRUCTOR
    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    // GETTERS AND SETTERS
    public string GetShortname()
    {
        return _shortName;
    }
    public void SetShortname(string shortname)
    {
        _shortName = shortname;
    }
    public string GetDescription()
    {
        return _description;
    }
    public void SetDescription(string description)
    {
        _description = description;
    }

    public int GetPoints()
    {
        return _points;
    }
    public void SetPoints(int points)
    {
        _points = points;
    }

    // METHODS
    public abstract int RecordEvent();
    public abstract bool IsComplete();

    public virtual string GetDetailsString()
    {
        string checkbox = IsComplete() ? "[X]" : "[ ]";
        return $"{checkbox} {_shortName} ({_description})";
    }

    public abstract string GetStringRepresentation();
}
