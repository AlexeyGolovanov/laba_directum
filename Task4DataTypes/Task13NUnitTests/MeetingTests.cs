using System;
using NUnit.Framework;
using Subtask1;

namespace Task13NUnitTests
{
    /// <summary>
    /// ����� ������� ������
    /// </summary>
    public class MeetingTests
    {
        /// <summary>
        /// ���� �������� �������� ������� ������ meeting
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
        /// ���� �������� ������� ������ meeting ��� �������� ���� ���������
        /// </summary>
        [Test]
        public void CreateNullEndDate()
        {
            var meeting = new Meeting();
            meeting.StartDate = DateTime.Now + TimeSpan.FromMinutes(30);
            Assert.IsNull(meeting.Duration);
        }

        /// <summary>
        /// ���� �������� ������� ������ meetingWithType
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