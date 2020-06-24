namespace Subtask2
{
    using System.Data;
    using System.Text;

    /// <summary>
    /// класс для метода преобразования DataSet в строку
    /// </summary>
    public class DataToString
    {
        /// <summary>
        /// метод возвращающий данные DataSet в форме строки
        /// </summary>
        /// <param name="tablesSet">входной набор данных</param>
        /// <param name="rowSeparator">разделитель строк</param>
        /// <param name="columnSeparator">разделитель колонок</param>
        /// <param name="tableSeparator">разделитель таблиц</param>
        /// <returns>строка с данными из DataSet</returns>
        public static string DataParse(DataSet tablesSet, string rowSeparator, string columnSeparator, string tableSeparator)
        {
            var tempString = new StringBuilder();
            foreach (DataTable table in tablesSet.Tables)
            {
                foreach (DataRow row in table.Rows)
                {
                    foreach (DataColumn column in table.Columns)
                    {
                        tempString.Append(row[column].ToString() + columnSeparator);
                    }

                    tempString.Append(rowSeparator);
                }

                tempString.Append(tableSeparator);
            }

            return tempString.ToString();
        }
    }
}
