public class Fractions
{
    private int _top;
    private int _bottom;

    // CONSTRUCTORS
    public Fractions()
    {
        _top = 1;
        _bottom = 1;
    }
    public Fractions(int numerator)
    {
        _top = numerator;
        _bottom = 1;
    }
    public Fractions(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    // GETTERS AND SETTERS METHODS
    public int GetTop()
    {
        return _top;
    }
    public int SetTop(int Top)
    {
        return _top = Top;
    }

    public int GetBottom()
    {
        return _bottom;
    }
    public int SetBottom(int Bottom)
    {
        return _bottom = Bottom;
    }

    public string GetFractionString()
    {
        return $"{_top} / {_bottom}";
    }

    public double GetDecimalValue()
    {
        return (double) _top / (double) _bottom;
    }
}