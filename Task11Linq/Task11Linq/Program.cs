namespace Task11Linq
{
    using System;
    using SubTask4;

    /// <summary>
    /// Основной класс приложения
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Точка входа
        /// </summary>
        public static void Main()
        {
            var textRows = new TextRows("ClientConnectionLog.log");
            var filtred = textRows.GetFiltred(new DateTime(2007, 12, 18));
            foreach (string s in filtred)
            {
                Console.WriteLine(s);
            }
        }
    }
}
