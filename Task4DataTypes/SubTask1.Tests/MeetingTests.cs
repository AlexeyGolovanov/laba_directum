namespace SubTask1.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Subtask1;

    /// <summary>
    /// класс тестов для объектов класса meeting
    /// </summary>
    [TestClass]
    public class MeetingTests
    {
        /// <summary>
        /// тест создания обычного объекта класса meeting
        /// </summary>
        [TestMethod]
        public void CreateCommon()
        {
            var meeting = new Meeting
            {
                StartDate = DateTime.Now + TimeSpan.FromMinutes(30)
            };
            meeting.EndDate = meeting.StartDate + TimeSpan.FromMinutes(15);
            if (meeting.Duration != null) // Что если в классе кто-то что-то сломает и Duration станет null? Тест не будет падать.
            {
                Assert.AreEqual(meeting.Duration.Value.Minutes, 15);
            }
        }

        /// <summary>
        /// тест создания оюъекта класса meeting без указания даты окончания
        /// </summary>
        [TestMethod]
        public void CreateNullEndDate()
        {
            var meeting = new Meeting();
            meeting.StartDate = DateTime.Now + TimeSpan.FromMinutes(30);
            Assert.IsNull(meeting.Duration);
        }
    }
}
