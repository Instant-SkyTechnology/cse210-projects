public class Circle : Shape
{
    private double _radius;

    // CONSTRUCTOR
    public Circle(string color, double radius) : base(color)
    {
        _radius = radius;
    }

    // GETTERS AND SETTERS
    public double GetRedius()
    {
        return _radius;
    }
    public void SetRedius(double radius)
    {
        _radius = radius;
    }

    // METHOD
    public override double GetArea()
    {
        return Math.PI* _radius *_radius;
    }
}