public class Point
{
    private int x, y;
    public int X
    {
        get { return x; }
    }
    public int Y
    {
        get { return y; }
    }
    public Point(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
}

public class Figure
{
    private Point[] points;

    public string Name
    {
        get;
        set;
    }

    public Figure(Point p1, Point p2, Point p3)
    {
        Array.Resize(ref points, 3);
        (points[0], points[1], points[2]) = (p1, p2, p3);
        Name = "Треугольник";
    }

    public Figure(Point p1, Point p2, Point p3, Point p4)
    {
        points = new Point[4];
        points[0] = p1;
        points[1] = p2;
        points[2] = p3;
        points[3] = p4;
        Name = "Четырехугольник";
    }

    public Figure(Point p1, Point p2, Point p3, Point p4, Point p5):this(p1, p2, p3, p4)
    {
        Array.Resize(ref points, 5);
        points[4] = p5;
        Name = "Пятиугольник";
    }


    public double LengthSide(Point A, Point B)
    {
        int dx = A.X - B.X;
        int dy = A.Y - B.Y;
        return Math.Sqrt(dx * dx + dy * dy);
    }

    public double PerimeterCalculator()
    {
        double perimeter = 0;
        for (int i = 0; i < points.Length ; i++)
        {
            perimeter += LengthSide(points[i], points[(i + 1) % points.Length]);
        }

        return perimeter;
        
    }
    public void print()
    {
        Console.WriteLine($"Название фигуры: {Name}");
        Console.WriteLine($"Периметр: {PerimeterCalculator()}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Point p1 = new Point(1, 1);
        Point p2 = new Point(1, 5);
        Point p3 = new Point(8, 5);
        Point p4 = new Point(8, 1);
        Figure rectangle = new Figure(p1, p2, p3, p4);
        rectangle.print();
    }
}