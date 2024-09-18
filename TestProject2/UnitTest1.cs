namespace Task3.Tests
{
    [TestClass]
    public class FigureTests
    {
        [TestMethod]
        public void TestLengthSide()
        {
            Point p1 = new Point(0, 0);
            Point p2 = new Point(3, 4);
            Figure figure = new Figure(p1, p2, p1, p2);

            double result = figure.LengthSide(p1, p2);

            Assert.AreEqual(5, result, "LengthSide возвращает неверное значение");
        }

        [TestMethod]
        public void TestPerimeterCalculator()
        {
            Point p1 = new Point(1, 1);
            Point p2 = new Point(1, 5);
            Point p3 = new Point(8, 5);
            Point p4 = new Point(8, 1);
            Figure rectangle = new Figure(p1, p2, p3, p4);

            double result = rectangle.PerimeterCalculator();

            Assert.AreEqual(22, result, "PerimeterCalculator возвращает неверное значение");
        }
    }
}
