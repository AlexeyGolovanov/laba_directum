namespace Task3OOP.Tests
{
    using System.Drawing;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// класс тестов для класса квадрат
    /// </summary>
    [TestClass]
    public class SquareTests
    {
        /// <summary>
        /// проверка создания объекта
        /// </summary>
        [TestMethod]
        public void SquareCreation()
        {
            var center = new Point(0, 0);
            var square = new Square(center, 5);
            Assert.IsNotNull(square);
        }

        /// <summary>
        /// проверка корректности подсчета периметра
        /// </summary>
        [TestMethod]
        public void PerimeterCount()
        {
            var center = new Point(0, 0);
            var square = new Square(center, 5);
            Assert.AreEqual(square.Perimeter, 20);
        }

        /// <summary>
        /// проверка корректности подсчета площади
        /// </summary>
        [TestMethod]
        public void AreaCount()
        {
            var center = new Point(0, 0);
            var square = new Square(center, 5);
            Assert.AreEqual(square.Area, 25);
        }
    }
}
