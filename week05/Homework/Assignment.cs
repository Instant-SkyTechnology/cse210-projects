public class Assignment
{
    protected string _studentName;
    protected string _topic;

    // CONSTRUCTORS
    public Assignment()
    {
        _studentName = "Unknown Student";
        _topic = "Unknown Topic";
    }
    public Assignment(string student, string topic)
    {
        _studentName = student;
        _topic = topic;
    }

    // GETTERS AND SETTERS
    public string GetStudentName()
    {
        return _studentName;
    }
    public void SetStudentName(string student)
    {
        _studentName = student;
    }
    public string GetTopic()
    {
        return _topic;
    }
    public void SetTopic(string topic)
    {
        _topic = topic;
    }

    // METHODS
    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }
}