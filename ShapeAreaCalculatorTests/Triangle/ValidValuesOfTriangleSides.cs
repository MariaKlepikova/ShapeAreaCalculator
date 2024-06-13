using ShapeAreaCalculatorLibrary;
using ShapeAreaCalculatorLibrary.Shapes;

namespace ShapeAreaCalculatorTests.Triangle;

[TestFixture]
public class ValidValuesOfTriangleSides
{
    [Test]
    public void Test1()
    {
        //Arrange
        var shape = new AreaCalculator();
        
        var triangle = new ShapeAreaCalculatorLibrary.Shapes.Triangle(sideOne: 40, sideTwo: 9, sideThree: 41);
        
        var expected = 180;
        
        //Act
        var result = shape.ExecuteCalculation(triangle);
        
        result = Math.Round(result, 5);
        
        //Assert
        Assert.AreEqual(expected, result);
    }
    
    [Test]
    public void Test2()
    {
        //Arrange
        var shape = new AreaCalculator();
        
        var triangle = new ShapeAreaCalculatorLibrary.Shapes.Triangle(sideOne: 17.8, sideTwo: 9.5, sideThree: 23);
        
        var expected = 78.86586;
        
        //Act
        var result = shape.ExecuteCalculation(triangle);
        
        result = Math.Round(result, 5);
        
        //Assert
        Assert.AreEqual(expected, result);
    }

}