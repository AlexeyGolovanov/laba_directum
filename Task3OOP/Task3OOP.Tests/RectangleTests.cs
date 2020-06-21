namespace Task3OOP.Tests
{
    using System.Drawing;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// класс тестов для класса прямоугольник
    /// </summary>
    [TestClass]
    public class RectangleTests
    {
        /// <summary>
        /// проверка создания объекта
        /// </summary>
        [TestMethod]
        public void RectangleCreation()
        {
            var center = new Point(0, 0);
            var rectangle = new Task3OOP.Rectangle(center, 4, 5);
            Assert.IsNotNull(rectangle);
        }

        /// <summary>
        /// проверка корректности подсчета периметра
        /// </summary>
        [TestMethod]
        public void PerimeterCount()
        {
            var center = new Point(0, 0);
            var rectangle = new Task3OOP.Rectangle(center, 4, 5);
            Assert.AreEqual(rectangle.Perimeter, 18);
        }

        /// <summary>
        /// проверка корректности подсчета площади
        /// </summary>
        [TestMethod]
        public void AreaCount()
        {
            var center = new Point(0, 0);
            var rectangle = new Task3OOP.Rectangle(center, 4, 5);
            Assert.AreEqual(rectangle.Area, 20);
        }
    }
}
