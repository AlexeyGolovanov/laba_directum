namespace SubTask4
{
    using System;

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
            var collection = new TextRows(@".\TestTextFile.txt");
            foreach (var element in collection)
            {
                Console.WriteLine(element);
            }
        }
    }
}
