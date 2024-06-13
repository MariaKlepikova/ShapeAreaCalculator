namespace ShapeAreaCalculatorTests.Circle;

[TestFixture]
public class IncorrectValueOfCircleRadius
{
    [Test]
    public void Test1()
    {
        //Arrange, act and assert
        Assert.Throws<ArgumentException>(() =>
        {
            _ = new ShapeAreaCalculatorLibrary.Shapes.Circle { Radius = -2 };
        });
    }
}