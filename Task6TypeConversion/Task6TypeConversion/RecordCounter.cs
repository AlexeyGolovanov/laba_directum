namespace Task6TypeConversion
{
    using System;
    using System.IO;
    using System.Text.RegularExpressions;

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
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Match match = Regex.Match(line, @"^[0-2]\d\.[0-1]\d\.[1-2]\d{3}\t\d{1,2}:\d{2}:\d{2}");
                    if (match.Success && DateTime.Parse(match.Value) > startDate && DateTime.Parse(match.Value) < endDate)
                    {
                        connectionCounter++;
                    }
                }
            }

            return connectionCounter;
        }
    }
}
