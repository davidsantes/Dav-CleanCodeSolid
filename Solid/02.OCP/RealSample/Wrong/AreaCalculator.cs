namespace Solid._02.OCP.RealSample.Wrong;

/// <summary>
/// Clase que viola el principio Open/Closed.
/// Esto es debido a que si se agrega una nueva forma, se debe modificar esta clase.
/// Esta clase no puede ser extendida sin modificar su código.
/// </summary>
public class AreaCalculator
{
    public double CalculateArea(object shape)
    {
        if (shape is Rectangle)
        {
            Rectangle rectangle = (Rectangle)shape;
            return rectangle.Width * rectangle.Height;
        }
        else if (shape is Circle)
        {
            Circle circle = (Circle)shape;
            return Math.PI * circle.Radius * circle.Radius;
        }
        // Si se agrega una nueva forma, se debe modificar esta clase
        else if (shape is Triangle)
        {
            Triangle triangle = (Triangle)shape;
            return 0.5 * triangle.Base * triangle.Height;
        }
        else
        {
            throw new ArgumentException("Unknown shape");
        }
    }

    public class Rectangle
    {
        public double Width { get; set; }
        public double Height { get; set; }
    }

    public class Circle
    {
        public double Radius { get; set; }
    }

    public class Triangle
    {
        public double Base { get; set; }
        public double Height { get; set; }
    }
}
