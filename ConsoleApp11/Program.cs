public class Rectangle
{
    private double sideA, sideB;
    public Rectangle(double side1, double side2)
    {
        sideA = side1;
        sideB = side2;
    }
    private double CalculateArea()
    {
        return sideA * sideB;
    }
    private double CalculatePerimeter()
    {
        return 2 * (sideA + sideB);
    }
    public double Area
    {
        get { return CalculateArea(); }

    }
    public double Perimeter
    {
        get { return CalculatePerimeter(); }
    }
}

class Programm
{
    static void Main(string[] args)
    {
        Console.Write("Введите длину стороны 1 прямоугольника: ");
        double side1 = double.Parse(Console.ReadLine());
        Console.Write("Введите длину стороны 2 прямоугольника: ");
        double side2 = double.Parse(Console.ReadLine());
        Rectangle rectangle = new Rectangle(side1, side2);
        Console.WriteLine($"Площадь прямоугольника: {rectangle.Area}");
        Console.WriteLine($"Периметр прямоугольника: {rectangle.Perimeter}");

    }
}
