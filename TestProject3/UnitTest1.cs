namespace TestProject3
{
    [TestClass]
    public class RectangleTests
    {
        [TestMethod]
        public void TestArea()
        {
            double side1 = 5;
            double side2 = 10;
            Rectangle rectangle = new Rectangle(side1, side2);

            double result = rectangle.Area;

            Assert.AreEqual(50, result, "Area возвращает неверное значение");

        }


        [TestMethod]
        public void TestPerimeter()
        {
            double side1 = 15;
            double side2 = 10;
            Rectangle rectangle = new Rectangle(side1, side2);

            double result = rectangle.Perimeter;

            Assert.AreEqual(50, result, "Perimeter возвращает неверное значение");

        }
    }
}