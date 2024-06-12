using ShapeAreaCalculatorLibrary.Shapes.Abstract;

namespace ShapeAreaCalculatorLibrary.Shapes;

public class Triangle : ICalculatableAreaOfShape
{
    public double SideOne { get; }
    public double SideTwo  { get; }
    public double SideThree  { get; }

    public Triangle(double sideOne, double sideTwo, double sideThree)
    {
        ThrowIfTriangleNotPossible(sideOne, sideTwo, sideThree);
            
        SideOne = sideOne;
        SideTwo = sideTwo;
        SideThree = sideThree;
    }
        
    private static void ThrowIfTriangleNotPossible(double sideOne, double sideTwo, double sideThree)
    {
        if (sideOne <= 0 ||
            sideTwo <= 0 ||
            sideThree <= 0)
        {
            throw new ArgumentException("Сторона треугольника не может быть отрицательным числом или равной нулю");
        }

        if (sideOne >= sideTwo + sideThree ||
            sideTwo >= sideOne + sideThree ||
            sideThree >= sideOne + sideTwo)
        {
            throw new ArgumentException(
                "Одна сторона треугольника больше суммы двух других сторон. Треугольник не может существовать");
        }
    }

    public double CalculateArea()
    {
        var isTriangleRectangular = CheckIsTriangleRectangular(out var cathetusOne, out var cathetusTwo);

        return isTriangleRectangular 
            ? CalculateRectangleTriangleArea(cathetusOne, cathetusTwo) 
            : CalculateSimpleTriangleArea();
    }

    private double CalculateSimpleTriangleArea()
    {
        var halfPerimeter = (SideOne + SideTwo + SideThree) / 2;

        return Math.Sqrt(halfPerimeter * (halfPerimeter - SideOne) * (halfPerimeter - SideTwo) *
                         (halfPerimeter - SideThree));
    }

    private static double CalculateRectangleTriangleArea(double cathetusOne, double cathetusTwo)
    {
        return cathetusOne * cathetusTwo / 2;
    }

    private bool CheckIsTriangleRectangular(out double cathetusOne, out double cathetusTwo)
    {
        var sides = new[] { SideOne, SideTwo, SideThree }
            .Order()
            .ToArray();
            
        cathetusOne = sides[0];

        cathetusTwo = sides[1];
        
        var hypotenuse = sides[2];
 
        var squareOfHypotenuse = hypotenuse * hypotenuse;

        var sumOfSquaresCathetes = cathetusOne * cathetusOne + cathetusTwo * cathetusTwo;

        var isRectangular = squareOfHypotenuse == sumOfSquaresCathetes;

        return isRectangular;
    }
}