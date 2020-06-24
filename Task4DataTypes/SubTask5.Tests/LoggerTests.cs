namespace SubTask5.Tests
{
    using System.IO;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// ����� ������ �������� ������ Logger
    /// </summary>
    [TestClass]
    public class LoggerTests
    {
        /// <summary>
        /// ���� ����������� � ������������ ������ ������ � ����
        /// </summary>
        [TestMethod]
        public void WriteStringTest()
        {
            var path = @"LoggerTest.txt";
            var data = "Test string";
            var logger = new SubTask5.Logger(path); // logger ����� ������ ���� ������ � using
            logger.WriteString(data);

            using (StreamReader sr = new StreamReader(path))
            {
                Assert.AreEqual(sr.ReadLine(), data);
            }
        }
    }
}
