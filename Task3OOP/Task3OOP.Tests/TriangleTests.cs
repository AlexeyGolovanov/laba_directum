namespace Task3OOP.Tests
{
    using System;
    using System.Drawing;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// ����� ������ ��� ������ �����������
    /// </summary>
    [TestClass]
    public class TriangleTests
    {
        /// <summary>
        /// �������� �������� �������
        /// </summary>
        [TestMethod]
        public void TriangleCreation()
        {
            var center = new Point(0, 0);
            var triangle = new Triangle(center, 3, 5, 7);
            Assert.IsNotNull(triangle);
        }

        /// <summary>
        /// �������� ������������ �������� ���������
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
        /// �������� ������������ �������� �������
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
