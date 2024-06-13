using ShapeAreaCalculatorLibrary;
using ShapeAreaCalculatorLibrary.Shapes;

namespace ShapeAreaCalculatorTests.Triangle;

public class IncorrectValuesOfTriangleSides
{
    [TestFixture]
    public class IncorrectValueOfCircleRadius
    {
        [Test]
        public void Test1()
        {
            //Arrange, act and assert
            Assert.Throws<ArgumentException>(() =>
            {
                _ = new ShapeAreaCalculatorLibrary.Shapes.Triangle(sideOne: -1, sideTwo: 3, sideThree: 5);
            });
        }
        
        [Test]
        public void Test2()
        {
            //Arrange, act and assert
            Assert.Throws<ArgumentException>(() =>
            {
                _ = new ShapeAreaCalculatorLibrary.Shapes.Triangle(sideOne: 3, sideTwo: 0, sideThree: 6);
            });
        }
    }
}