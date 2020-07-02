namespace SubTask2.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using SubTusk2;

    /// <summary>
    /// ����� ������ ��� ������ MaxFinder
    /// </summary>
    [TestClass]
    public class MaxFinderTests
    {
        /// <summary>
        /// ���� ������ ����������� �� 3-� ��������
        /// </summary>
        [TestMethod]
        public void MaxOfThree()
        {
            var max1 = MaxFinder.GetMaxOfThree(1, 15, 9);
            Assert.AreEqual(max1, 15);

            var max2 = MaxFinder.GetMaxOfThree(
                new DateTime(1998, 1, 28), 
                new DateTime(1995, 1, 28), 
                new DateTime(1997, 1, 28));
            Assert.AreEqual(max2, new DateTime(1998, 1, 28));
        }
    }
}
