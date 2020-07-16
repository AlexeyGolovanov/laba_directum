namespace Task13NUnitTests
{
    using NUnit.Framework;
    using Subtask3;

    /// <summary>
    /// Класс тестов для класса определяюшего права доступа
    /// </summary>
    class SubTask3Tests
    {
        /// <summary>
        /// Тестирует корректность возвращаемой строки с правами доступа,
        /// в случае когда досутуп разрешен.
        /// </summary>
        [Test]
        public void RightsStringReturn()
        {
            string expected = "View Run Add ";
            Assert.AreEqual(expected, Program.DetectRights((AccessRights)7));
        }

        /// <summary>
        /// Тестирует корректность возвращаемой строки с правами доступа,
        /// в случае когда досутуп запрещен.
        /// </summary>
        [Test]
        public void AccesDeniedReturn()
        {
            Assert.AreEqual("AccessDenied", Program.DetectRights((AccessRights)64));
        }
    }
}
