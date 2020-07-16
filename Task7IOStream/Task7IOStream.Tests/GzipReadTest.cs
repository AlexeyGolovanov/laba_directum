namespace Task7IOStream.Tests
{
    using NUnit.Framework;

    /// <summary>
    /// Класс тестов для задания 7
    /// </summary>
    public class Tests
    {
        /// <summary>
        /// Тест получения строки из заарзивированного rtf 
        /// </summary>
        [Test]
        public void ReadFromGzip()
        {
            var str = ArchiveReader.ReadFromGzip(@"..\..\..\Sample.rtf.gz");
            Assert.IsTrue(str.Contains("Sample Text"));
        }
    }
}