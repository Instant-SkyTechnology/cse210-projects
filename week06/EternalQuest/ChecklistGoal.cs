public class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _currentCount;
    private int _bonus;

    // CONSTRUCTOR
    public ChecklistGoal(string name, string description, int points, int target, int bonus, int current = 0)
        : base(name, description, points)
    {
        _targetCount = target;
        _bonus = bonus;
        _currentCount = current;
    }

    // GETTERS AND SETTERS
    public int GetTargetCount()
    {
        return _targetCount;
    }

    public void SetTargetCount(int targetCount)
    {
        _targetCount = targetCount;
    }

    public int GetCurrentCount()
    {
        return _currentCount;
    }

    public void SetCurrentCount(int currentCount)
    {
        _currentCount = currentCount;
    }

    public int GetBonus()
    {
        return _bonus;
    }

    public void SetBonus(int bonus)
    {
        _bonus = bonus;
    }

    // METHODS
    public override int RecordEvent()
    {
        _currentCount++;

        if (_currentCount == _targetCount)
            return _points + _bonus;

        return _points;
    }

    public override bool IsComplete()
    {
        return _currentCount >= _targetCount;
    }

    public override string GetDetailsString()
    {
        string checkbox = IsComplete() ? "[X]" : "[ ]";
        return $"{checkbox} {_shortName} ({_description}) -- Completed {_currentCount}/{_targetCount}";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal|{_shortName}|{_description}|{_points}|{_bonus}|{_targetCount}|{_currentCount}";
    }
}
