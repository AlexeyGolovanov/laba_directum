using System;
using NUnit.Framework;
using Subtask1;

namespace Task13NUnitTests
{
    /// <summary>
    /// Тесты классов встреч
    /// </summary>
    public class MeetingTests
    {
        /// <summary>
        /// тест создания обычного объекта класса meeting
        /// </summary>
        [Test]
        public void CreateCommon()
        {
            var meeting = new Meeting
            {
                StartDate = DateTime.Now + TimeSpan.FromMinutes(30)
            };
            meeting.EndDate = meeting.StartDate + TimeSpan.FromMinutes(15);
            if (meeting.Duration != null)
            {
                Assert.AreEqual(meeting.Duration.Value.Minutes, 15);
            }
        }

        /// <summary>
        /// тест создания оюъекта класса meeting без указания даты окончания
        /// </summary>
        [Test]
        public void CreateNullEndDate()
        {
            var meeting = new Meeting();
            meeting.StartDate = DateTime.Now + TimeSpan.FromMinutes(30);
            Assert.IsNull(meeting.Duration);
        }

        /// <summary>
        /// тест создания объекта класса meetingWithType
        /// </summary>
        [Test]
        public void CreateMeetingWithType()
        {
            var meeting = new MeetingWithType
            {
                Type = MeetingType.Birthday
            };
            Assert.AreEqual(meeting.Type, MeetingType.Birthday);
        }
    }
}