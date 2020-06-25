namespace SubTask3Complex.Tests
{
    using System.Collections;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// класс тестов для объектов класса комлексных чисел
    /// </summary>
    [TestClass]
    public class ComplexTests
    {
        /// <summary>
        /// тест корректности сортировки массива комплексных чисел
        /// </summary>
        [TestMethod]
        public void SortTest()
        {
            var twoComplexes = new ArrayList()
            {
                new Complex() { Re = 3, Im = 5 },
                new Complex() { Re = 2, Im = 2 }
            };

            Assert.AreEqual(((Complex)twoComplexes[0]).Re, 3);

            twoComplexes.Sort();

            Assert.AreEqual(((Complex)twoComplexes[0]).Re, 2);
        }
    }
}
