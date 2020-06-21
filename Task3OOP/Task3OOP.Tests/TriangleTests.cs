namespace Task3OOP.Tests
{
    using System;
    using System.Drawing;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// класс тестов для класса триугольник
    /// </summary>
    [TestClass]
    public class TriangleTests
    {
        /// <summary>
        /// проверка создания объекта
        /// </summary>
        [TestMethod]
        public void TriangleCreation()
        {
            var center = new Point(0, 0);
            var triangle = new Triangle(center, 3, 5, 7);
            Assert.IsNotNull(triangle);
        }

        /// <summary>
        /// проверка корректности подсчета периметра
        /// </summary>
        [TestMethod]
        public void PerimeterCount()
        {
            var center = new Point(0, 0);
            var triangle = new Triangle(center, 3, 5, 7);
            var perimeter = triangle.Perimeter;
            Assert.AreEqual(perimeter, 15);
        }

        /// <summary>
        /// проверка корректности подсчета площади
        /// </summary>
        [TestMethod]
        public void AreaCount()
        {
            var center = new Point(0, 0);
            var triangle = new Triangle(center, 3, 5, 7);
            var area = triangle.Area;
            Assert.AreEqual(Math.Round(area, 6), 6.495191);
        }
    }
}
