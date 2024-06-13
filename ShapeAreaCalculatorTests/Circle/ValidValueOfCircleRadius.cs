using ShapeAreaCalculatorLibrary;

namespace ShapeAreaCalculatorTests.Circle;

[TestFixture]
public class ValidValueOfCircleRadius
{
    [Test]
    public void Test1()
    {
        //Arrange
        var areaCalculator = new AreaCalculator();
        var circle = new ShapeAreaCalculatorLibrary.Shapes.Circle()
        {
            Radius = 12,
        };
        var expected = 452.38934;
        
        //Act
        var result = areaCalculator.ExecuteCalculation(circle);
        result = Math.Round(result, 5);
        
        //Assert
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test2()
    {
        //Arrange
        var shape = new AreaCalculator();
        var circle = new ShapeAreaCalculatorLibrary.Shapes.Circle()
        {
            Radius = 4.567,
        };
        var expected = 65.52573;

        //Act
        var result = shape.ExecuteCalculation(circle);
        result = Math.Round(result, 5);

        //Assert
        Assert.AreEqual(expected, result);
    }
}