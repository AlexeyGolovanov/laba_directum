namespace Task3OOP.Tests
{
    using System;
    using System.Drawing;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// класс тестов для класса кольцо
    /// </summary>
    [TestClass]
    public class RingTests
    {
        /// <summary>
        /// проверка создания объекта
        /// </summary>
        [TestMethod]
        public void RingCreation()
        {
            var center = new Point(0, 0);
            var ring = new Ring(center, 5, 4);
            Assert.IsNotNull(ring);
        }

        /// <summary>
        /// проверка корректности подсчета периметра
        /// </summary>
        [TestMethod]
        public void PerimeterCount()
        {
            var center = new Point(0, 0);
            var ring = new Ring(center, 5, 4);
            Assert.AreEqual(Math.Round(ring.Perimeter, 5), 56.54867);
        }

        /// <summary>
        /// проверка корректности подсчета площади
        /// </summary>
        [TestMethod]
        public void AreaCount()
        {
            var center = new Point(0, 0);
            var ring = new Ring(center, 5, 4);
            Assert.AreEqual(Math.Round(ring.Area, 4), 28.2743);
        }
    }
}
