public class WritingAssignment : Assignment
{
    private string _title;

    // CONSTRUCTORS
    public WritingAssignment() : base()
    {
        _title = "Unknown Title";
    }
    public WritingAssignment(string student, string topic, string title) : base(student, topic)
    {
        _title = title;
    }

    // GETTERS AND SETTERS
    public string GetTitle()
    {
        return _title;
    }
    public void SetTitle(string title)
    {
        _title = title;
    }

    // METHOD
    public string GetWritingInformation()
    {
        return $"{_title} by {_studentName}";
    }
}