namespace Task6TypeConversion.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// Класс тестов для класса, отвечающего за подсчет удовлетворяющих условиям записей в логе
    /// </summary>
    [TestClass]
    public class RecordCounterTests
    {
        /// <summary>
        /// Тест корректности подсчета числа подключений в указанный период
        /// </summary>
        [TestMethod]
        public void CountRecordInIntervalTest()
        {
            var start = new DateTime(2007, 1, 1);
            var end = new DateTime(2007, 12, 7);
            var amount = RecordCounter.CountRecordInInterval(
                @"..\..\..\..\Task6TypeConversion\ClientConnectionLog.log", start, end);
            Assert.AreEqual(amount, 8);
        }
    }
}
