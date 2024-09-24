namespace Solid._02.OCP.RealSample.Right;

/// <summary>
/// Clase que respeta el principio Open/Closed.
/// Utilizamos una interfaz IShape que define un método CalculateArea.
/// Cada forma geométrica implementa esta interfaz y proporciona su propia implementación del método CalculateArea.
/// La clase AreaCalculator simplemente llama al método CalculateArea de la interfaz,
/// lo que permite agregar nuevas formas sin modificar la clase AreaCalculator.
/// </summary>
public class AreaCalculator
{
    public double CalculateArea(IShape shape)
    {
        return shape.CalculateArea();
    }
}

public interface IShape
{
    double CalculateArea();
}

public class Rectangle : IShape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public double CalculateArea()
    {
        return Width * Height;
    }
}

public class Circle : IShape
{
    public double Radius { get; set; }

    public double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
}

public class Triangle : IShape
{
    public double Base { get; set; }
    public double Height { get; set; }

    public double CalculateArea()
    {
        return 0.5 * Base * Height;
    }
}
