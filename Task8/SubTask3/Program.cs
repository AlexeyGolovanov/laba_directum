namespace SubTask3
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Главный класс приложения
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Основной метод
        /// </summary>
        private static void Main()
        {
            List<string> list = new List<string> { "one", "two", "three", "four", "five", "six", "seven" };
            var dictionary = new Dictionary<int, string>();
            dictionary.Add(1, "one");
            dictionary.Add(2, "two");
            dictionary.Add(3, "three");
            dictionary.Add(4, "four");
            dictionary.Add(5, "five");
            dictionary.Add(6, "six");
            dictionary.Add(7, "seven");

            foreach (var str in list)
            {
                Console.WriteLine(str);
            }

            Console.WriteLine();

            foreach (var pair in dictionary)
            {
                Console.WriteLine(pair);
            }
        }
    }
}
