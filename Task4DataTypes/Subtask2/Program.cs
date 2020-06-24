namespace Subtask2
{
    using System;
    using System.Data;

    /// <summary>
    /// класс с которого начинается выполнение программы
    /// </summary>
    public class Program
    {
        /// <summary>
        /// основной метод программы с тестовыми данными
        /// </summary>
        private static void Main()
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

            var stringOfData = DataToString.DataParse(set, "\n", "\t", "\n\n");
            Console.Write(stringOfData);
            Console.ReadLine();
        }
    }
}
