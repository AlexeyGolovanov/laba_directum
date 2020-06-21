namespace Task3OOP.Tests
{
    using System;
    using System.Drawing;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// класс тестов для класса круг
    /// </summary>
    [TestClass]
    public class CircleTests
    {
        /// <summary>
        /// проверка создания объекта
        /// </summary>
        [TestMethod]
        public void CircleCreation()
        {
            var center = new Point(0, 0);
            var circle = new Circle(center, 5);
            Assert.IsNotNull(circle);
        }

        /// <summary>
        /// проверка корректности подсчета периметра
        /// </summary>
        [TestMethod]
        public void PerimeterCount()
        {
            var center = new Point(0, 0);
            var circle = new Circle(center, 5);
            Assert.AreEqual(Math.Round(circle.Perimeter, 5), 31.41593);
        }

        /// <summary>
        /// проверка корректности подсчета площади
        /// </summary>
        [TestMethod]
        public void AreaCount()
        {
            var center = new Point(0, 0);
            var circle = new Circle(center, 5);
            Assert.AreEqual(Math.Round(circle.Area, 4), 78.5398);
        }
    }
}
