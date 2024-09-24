namespace CleanCode._01.Naming.Better;

public class Point
{
    public int X { get; set; }
    public int Y { get; set; }
}

public class PointRepository
{
    public List<Point> GetAllPoints()
    {
        List<Point> points = new List<Point>
        {
            new Point { X = 1, Y = 2 },
            new Point { X = 3, Y = 4 }
        };
        return points;
    }
}

public class PointPrinter
{
    public void PrintPoints(List<Point> points)
    {
        foreach (var point in points)
        {
            Console.WriteLine($"X: {point.X}, Y: {point.Y}");
        }
    }
}

class Init
{
    static void Start()
    {
        PointRepository pointRepository = new PointRepository();
        List<Point> points = pointRepository.GetAllPoints();

        PointPrinter pointPrinter = new PointPrinter();
        pointPrinter.PrintPoints(points);
    }
}
