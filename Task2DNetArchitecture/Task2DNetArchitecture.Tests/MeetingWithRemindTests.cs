namespace Task2DNetArchitecture.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// класс тестов для объектов встреч с напоминаниями
    /// </summary>
    [TestClass]
    public class MeetingWithRemindTests
    {
        /// <summary>
        /// флаг выхода из цикла
        /// </summary>
        private bool flag;

        /// <summary>
        /// тест создания экземпляра встречи с напоминанием
        /// </summary>
        [TestMethod]
        public void MeetingCreation()
        {
            var meeting = new MeetingWithRemind
            {
                StartDate = DateTime.Now
            };
            meeting.EndDate = meeting.StartDate + TimeSpan.FromMinutes(5);
            Assert.IsNotNull(meeting);
        }

        /// <summary>
        /// тест расчета продолжительности встречи
        /// </summary>
        [TestMethod]
        public void DurationCount()
        {
            var duration = TimeSpan.FromMinutes(15);
            var meeting = new MeetingWithRemind
            {
                StartDate = DateTime.Now
            };
            meeting.EndDate = meeting.StartDate + duration;
            Assert.AreEqual(duration, meeting.Duration);
        }

        /// <summary>
        /// тест срабатывания события вызова напоминания
        /// </summary>
        [TestMethod]
        public void RemindEventTest()
        {
            var duration = TimeSpan.FromMinutes(15);
            var meeting = new MeetingWithRemind
            {
                StartDate = DateTime.Now + TimeSpan.FromMinutes(5)
            };

            meeting.EndDate = meeting.StartDate + duration;
            meeting.RemindTime = meeting.StartDate - TimeSpan.FromMinutes(4);
            meeting.Remind += this.Meeting_Remind;
            while (!this.flag)
            {
            }

            Assert.IsTrue(this.flag);
            this.flag = false;
            meeting.Remind -= this.Meeting_Remind;
        }

        /// <summary>
        /// изменение значения флага выхода из цикла
        /// </summary>
        /// <param name="message">передаваемая в метод строка</param>
        private void Meeting_Remind(string message)
        {
            this.flag = true;
        }
    }
}
