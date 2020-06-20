namespace Task2DNetArchitecture.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// ����� ������ ��� �������� ���� Meeting 
    /// </summary>
    [TestClass]
    public class MeetingTests
    {
        /// <summary>
        /// ���� �������� �������� ������
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
        /// ���� ������� ������������ �������
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
