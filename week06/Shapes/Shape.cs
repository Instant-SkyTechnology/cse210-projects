public class Shape
{
    private string _color;

    // CONSTRUCTOR
    public Shape(string color)
    {
        _color = color;
    }

    // GETTERS AND SETTERS
    public string GetColor()
    {
        return _color;
    }
    public void SetColor(string color)
    {
        _color = color;
    }

    // METHOD
    public virtual double GetArea()
    {
        return 0;
    }
}