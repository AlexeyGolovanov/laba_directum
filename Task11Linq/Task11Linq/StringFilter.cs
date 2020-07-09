namespace Task11Linq
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;
    using SubTask4;

    /// <summary>
    /// Класс обрабатываюзий коллекции строк
    /// </summary>
    internal static class StringFilter
    {
        /// <summary>
        /// Фильтрация и сортировка строк из класса TextRows
        /// </summary>
        /// <param name="stringRows"> Коллекция строк </param>
        /// <param name="date"> Дата рассматриваемых подключений </param>
        /// <returns>Отсортированная по времени коллекция подключений в указанную дату</returns>
        internal static List<string> GetFiltred(this TextRows stringRows, DateTime date)
        {
            return stringRows
                .Where(row => row.StartsWith($"{date:dd.MM.yyyy}"))
                .OrderBy(time => SeparateTime(time))
                .ToList();
        }

        /// <summary>
        /// Выделение времени из строки лога 
        /// </summary>
        /// <param name="row"> Строка для разбора </param>
        /// <returns>Время найденное в переданной строке</returns>
        internal static DateTime SeparateTime(string row)
        {
            var template = "H:mm:ss";
            var time = new Regex(@"\d{1,2}:\d{2}:\d{2}");
            return DateTime.ParseExact(time.Match(row).Value, template, null);
        }
    }
}
