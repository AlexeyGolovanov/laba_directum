namespace Task13NUnitTests
{
    using NUnit.Framework;
    using System.IO;

    /// <summary>
    /// класс тестов объектов класса Logger
    /// </summary>
    class SubTask5Tests
    {

        public class LoggerTests
        {
            /// <summary>
            /// тест возможности и корректности записи строки в файл
            /// </summary>
            [Test]
            public void WriteStringTest()
            {
                var path = @"LoggerTest.txt";
                var data = "Test string";

                using (var logger = new SubTask5.Logger(path))
                {
                    logger.WriteString(data);
                }

                using (StreamReader sr = new StreamReader(path))
                {
                    Assert.AreEqual(sr.ReadLine(), data);
                }
            }
        }
    }
}
