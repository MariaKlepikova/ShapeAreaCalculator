using ShapeAreaCalculatorLibrary.Shapes.Abstract;

namespace ShapeAreaCalculatorLibrary;

public class AreaCalculator
{
    public double ExecuteCalculation(ICalculatableAreaOfShape shape)
    {
        return shape.CalculateArea();
    }
}