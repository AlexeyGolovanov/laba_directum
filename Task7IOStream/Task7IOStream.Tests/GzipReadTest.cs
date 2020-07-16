namespace Task7IOStream.Tests
{
    using NUnit.Framework;

    /// <summary>
    /// ����� ������ ��� ������� 7
    /// </summary>
    public class Tests
    {
        /// <summary>
        /// ���� ��������� ������ �� ����������������� rtf 
        /// </summary>
        [Test]
        public void ReadFromGzip()
        {
            var str = ArchiveReader.ReadFromGzip(@"..\..\..\Sample.rtf.gz");
            Assert.IsTrue(str.Contains("Sample Text"));
        }
    }
}