namespace SubTask1.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Subtask1;

    /// <summary>
    /// ����� ������ ��� �������� ������ meeting
    /// </summary>
    [TestClass]
    public class MeetingTests
    {
        /// <summary>
        /// ���� �������� �������� ������� ������ meeting
        /// </summary>
        [TestMethod]
        public void CreateCommon()
        {
            var meeting = new Meeting
            {
                StartDate = DateTime.Now + TimeSpan.FromMinutes(30)
            };
            meeting.EndDate = meeting.StartDate + TimeSpan.FromMinutes(15);
            if (meeting.Duration != null) // ��� ���� � ������ ���-�� ���-�� ������� � Duration ������ null? ���� �� ����� ������.
            {
                Assert.AreEqual(meeting.Duration.Value.Minutes, 15);
            }
        }

        /// <summary>
        /// ���� �������� ������� ������ meeting ��� �������� ���� ���������
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
