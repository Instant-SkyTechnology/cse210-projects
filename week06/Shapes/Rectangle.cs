public class Rectangle : Shape
{
    private double _length;
    private double _width;

    // CONSTRUCTOR
    public Rectangle(string color, double length, double width) : base(color)
    {
        _length = length;
        _width = width;
    }

    // GETTERS AND SETTERS
    public double GetLength()
    {
        return _length;
    }
    public void SetSite(double length)
    {
        _length = length;
    }
    public double GetWidth()
    {
        return _width;
    }
    public void SetWidth(double width)
    {
        _width = width;
    }

    // METHOD
    public override double GetArea()
    {
        return _length * _width;
    }
}