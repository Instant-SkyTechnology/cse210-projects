public class Square : Shape
{
    private double _side;

    // CONSTRUCTOR
    public Square(string color, double side) : base(color)
    {
        _side = side;
    }

    // GETTERS AND SETTERS
    public double GetSide()
    {
        return _side;
    }
    public void SetSite(double side)
    {
        _side = side;
    }

    // METHOD
    public override double GetArea()
    {
        return _side * _side;
    }
}