using ShapeAreaCalculatorLibrary;

namespace ShapeAreaCalculatorTests.Triangle;

[TestFixture]
public class TriangleDoesNotExist
{ 
    [Test]
    public void Test1()
    {
        //Arrange, act and assert
        Assert.Throws<ArgumentException>(() =>
        {
            _ = new ShapeAreaCalculatorLibrary.Shapes.Triangle(sideOne: 3, sideTwo: 13, sideThree: 7);
        });
    }
    
    [Test]
    public void Test2()
    {
        //Arrange, act and assert
        Assert.Throws<ArgumentException>(() =>
        {
            _ = new ShapeAreaCalculatorLibrary.Shapes.Triangle(sideOne: 10.5, sideTwo: 29, sideThree: 7.89);
        });
    }
}