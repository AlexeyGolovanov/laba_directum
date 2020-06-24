namespace SubTask5.Tests
{
    using System.IO;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// класс тестов объектов класса Logger
    /// </summary>
    [TestClass]
    public class LoggerTests
    {
        /// <summary>
        /// тест возможности и корректности записи строки в файл
        /// </summary>
        [TestMethod]
        public void WriteStringTest()
        {
            var path = @"LoggerTest.txt";
            var data = "Test string";
            var logger = new SubTask5.Logger(path); // logger также должен быть обёрнут в using
            logger.WriteString(data);

            using (StreamReader sr = new StreamReader(path))
            {
                Assert.AreEqual(sr.ReadLine(), data);
            }
        }
    }
}
