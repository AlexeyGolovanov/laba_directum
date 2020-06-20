namespace Task2DNetArchitecture.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// класс тестов для объектов типа Meeting 
    /// </summary>
    [TestClass]
    public class MeetingTests
    {
        /// <summary>
        /// тест создания элемента класса
        /// </summary>
        [TestMethod]
        public void MeetingCreation()
        {
            var meeting = new Meeting
            {
                StartDate = DateTime.Now
            };
            meeting.EndDate = meeting.StartDate + TimeSpan.FromMinutes(5);
            Assert.IsNotNull(meeting);
        }

        /// <summary>
        /// тест расчета длительности встречи
        /// </summary>
        [TestMethod]
        public void DurationCount()
        {
            var duration = TimeSpan.FromMinutes(15);
            var meeting = new Meeting
            {
                StartDate = DateTime.Now
            };
            meeting.EndDate = meeting.StartDate + duration;

            Assert.AreEqual(duration, meeting.Duration);
        }
    }
}
