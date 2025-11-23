public class MathAssignment : Assignment
{
    private string _textBookSection;
    private string _problems;

    // CONSTRUCTORS
    public MathAssignment() : base()
    {
        _textBookSection = "Unknown Section";
        _problems = "Unknown";
    }

    public MathAssignment(string student, string topic, string textbooksection, string problem) : base(student, topic)
    {
        _textBookSection = textbooksection;
        _problems = problem;
    }

    // GETTERS AND SETTERS
    public string GettextBookSectione()
    {
        return _textBookSection;
    }
    public void SetTextBookSection(string textsection)
    {
        _textBookSection = textsection;
    }
    public string GetProblem()
    {
        return _problems;
    }
    public void SetProblem(string problem)
    {
        _problems = problem;
    }

    public string GetHomeworkList()
    {
        return $"Section {_textBookSection} Problems {_problems}";
    }
}