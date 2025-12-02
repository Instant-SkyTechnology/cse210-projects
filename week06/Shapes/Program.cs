using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        Square sq = new Square("Blue", 10);
        // Console.WriteLine($"The area of square is {sq.GetArea()}, {sq.GetColor()} color");

        Rectangle rec = new Rectangle("Yellow", 10, 2);

        Circle cir = new Circle("Orange", 6);

        List<Shape> shapess = new List<Shape>();
        shapess.Add(sq);
        shapess.Add(rec);
        shapess.Add(cir);
        foreach (Shape shap in shapess)
        {
            string colors = shap.GetColor();
            double areas = shap.GetArea();
            Console.WriteLine($"Color is {colors} and the area is {areas:F2}");
        }

        Console.WriteLine();
    }
}