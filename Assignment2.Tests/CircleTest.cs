using NUnit.Framework;


namespace Assignment2.Tests
{
 
    public class CircleTest
    {

        //Get Radius
        [Test]
        public void ValidRadius_InputRadius()
        {
            Circle circle = new Circle();

            int actual = circle.GetRadius();
            Assert.AreEqual(1, actual);

        }

        [Test]
        public void ValidRadius_InputRadius0()
        {
            Circle circle = new Circle(0);

            int actual = circle.GetRadius();
            Assert.AreEqual(0, actual);
        }

        [Test]
        public void ValidRadius_InputRadiusNegative()
        {
            Circle circle = new Circle(-1);

            int actual = circle.GetRadius();
            Assert.AreEqual(-1, actual);
        }

        //Set Radius
        [Test]
        public void validSetRadius_SetRadiusEqualInputRadius()
        {
            Circle circle = new Circle(5);
            int radius = 5;
            circle.SetRadius(radius);
            int actual = circle.GetRadius();
            Assert.AreEqual(radius, actual);

        }

        [Test]
        public void validSetRadius_SetRadiusEqual0()
        {
            Circle circle = new Circle(0);
            int radius = 0;
            circle.SetRadius(radius);
            int actual = circle.GetRadius();
            Assert.AreEqual(radius, actual);

        }

        [Test]
        public void validSetRadius_EqualNegative()
        {
            Circle circle = new Circle(-5);
            int expected = -5;
            int actual = circle.GetRadius();
            Assert.AreEqual(expected, actual);

        }
        //Get Area
        [Test]
        public void validGetArea_ZeroValue()
        {
            Circle circle = new Circle(0);
            double expected = 0;
            double actual = circle.GetArea();
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void validGetArea_ActualValue()
        {
            Circle circle = new Circle(10);
            double expected = 314;
            double actual = circle.GetArea();
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void validGetArea_NegativeValue()
        {
            Circle circle = new Circle(5);
            double expected = 78.5;
            double actual = circle.GetArea();
            Assert.AreEqual(expected, actual);

        }

        //Get Circumference

        [Test]
        public void validCircumference_InputRadius0()
        {
            Circle circle = new Circle(0);
            double expected = 0;
            double actual = circle.GetCircumference();
            Assert.AreEqual(expected, actual);

        }
        [Test]
        public void validCircumference_InputRadius()
        {
            Circle circle = new Circle();
            double expected = 6.28;
            double actual = circle.GetCircumference();
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void validCircumference_InputRadiusNegative()
        {
            Circle circle = new Circle(-1);
            double expected = -6.28;
            double actual = circle.GetCircumference();
            Assert.AreEqual(expected, actual);
        }

    }
}