namespace Task3OOP.Tests
{
    using System;
    using System.Drawing;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// класс тестов для класса окружность
    /// </summary>
    [TestClass]
    public class RoundTests
    {
        /// <summary>
        /// проверка создания объекта
        /// </summary>
        [TestMethod]
        public void RoundCreation()
        {
            var center = new Point(0, 0);
            var round = new Round(center, 5);
            Assert.IsNotNull(round);
        }

        /// <summary>
        /// проверка корректности подсчета периметра
        /// </summary>
        [TestMethod]
        public void PerimeterCount()
        {
            var center = new Point(0, 0);
            var round = new Round(center, 5);
            Assert.AreEqual(Math.Round(round.Perimeter, 5), 31.41593);
        }

        /// <summary>
        /// проверка корректности подсчета площади
        /// </summary>
        [TestMethod]
        public void AreaCount()
        {
            var center = new Point(0, 0);
            var round = new Round(center, 5);
            Assert.AreEqual(round.Area, 0);
        }
    }
}
