namespace Task6TypeConversion
{
    using System;
    using System.IO;

    /// <summary>
    /// Класс содержащий метод подсчета подходяших строк в файле
    /// </summary>
    public class RecordCounter
    {
        /// <summary>
        /// Подсчет числа записей, находяшихся в указаном интервале 
        /// </summary>
        /// <param name="path">Путь до файла</param>
        /// <param name="startDate">Начало временного интервала</param>
        /// <param name="endDate">Конец временного интервала</param>
        /// <returns>число подключений в указанный период</returns>
        public static int CountRecordInInterval(string path, DateTime startDate, DateTime endDate)
        {
            var connectionCounter = 0;
            using (StreamReader sr = new StreamReader(path))
            {
                sr.ReadLine();
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    var connectionDate = DateTime.Parse(line.Substring(0, 19).Replace('\t', ' '));
                    if (connectionDate > startDate)
                    {
                        if (connectionDate < endDate)
                        {
                            connectionCounter++;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }

            return connectionCounter;
        }
    }
}
