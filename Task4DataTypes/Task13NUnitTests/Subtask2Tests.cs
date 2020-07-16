namespace Task13NUnitTests
{
    using NUnit.Framework;
    using Subtask2;
    using System.Data;

    /// <summary>
    /// Тесты для подзадания 2
    /// </summary>
    public class Subtask2Tests
    {
        /// <summary>
        /// тест разделения записей DataSet
        /// </summary>
        [Test]
        public void DataToStringTest()
        {
            DataTable table1 = new DataTable("patients");
            table1.Columns.Add("name");
            table1.Columns.Add("id");
            table1.Rows.Add("sam", 1);
            table1.Rows.Add("mark", 2);

            DataTable table2 = new DataTable("medications");
            table2.Columns.Add("id");
            table2.Columns.Add("medication");
            table2.Rows.Add(1, "atenolol");
            table2.Rows.Add(2, "amoxicillin");

            DataSet set = new DataSet("office");
            set.Tables.Add(table1);
            set.Tables.Add(table2);

            var expectedString = "sam\t1\t\nmark\t2\t\n\n\n1\tatenolol\t\n2\tamoxicillin\t\n\n\n";
            var actualString = DataToString.DataParse(set, "\n", "\t", "\n\n");

            Assert.AreEqual(actualString, expectedString);
        }
    }
}
