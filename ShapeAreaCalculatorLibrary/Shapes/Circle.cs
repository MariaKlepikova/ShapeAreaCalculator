using ShapeAreaCalculatorLibrary.Shapes.Abstract;

namespace ShapeAreaCalculatorLibrary.Shapes;

public class Circle : ICalculatableAreaOfShape
{
    private double _radius;
    public double Radius
    {
        get => _radius;
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException($"Значение {nameof(Radius)} не может быть меньше или равно нулю");
            }
                
            _radius = value;
        }
    }

    public double CalculateArea()
    {
        return Math.PI * (_radius * _radius);
    }
}