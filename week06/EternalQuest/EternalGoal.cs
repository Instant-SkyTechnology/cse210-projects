public class EternalGoal : Goal
{
    // CONSTRUCTOR
    public EternalGoal(string name, string description, int points)
        : base(name, description, points) { }

    // METHODS
    public override int RecordEvent()
    {
        return _points;  
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal|{_shortName}|{_description}|{_points}";
    }
}
