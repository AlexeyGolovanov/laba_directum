namespace SubTask1.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Subtask1;

    /// <summary>
    /// класс тестов для объектов класса meetingWithType
    /// </summary>
    [TestClass]
    public class MeetingWithTypeTests
    {
        /// <summary>
        /// тест создания объекта класса meetingWithType
        /// </summary>
        [TestMethod]
        public void CreateCommon()
        {
            var meeting = new MeetingWithType();
            meeting.Type = MeetingType.Birthday;
            Assert.AreEqual(meeting.Type, (MeetingType)3);  // MeetingType.Birthday
    }
    }
}
