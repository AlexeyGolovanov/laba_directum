namespace Task5SysObject
{
    using System;

    /// <summary>
    /// класс с которого начинается выполнение программы
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// основной метод программы с тестовыми данными
        /// </summary>
        private static void Main()
        {
            Console.WriteLine(new StringValue("AAA").Equals(new StringValue("AAA")));
        }
    }
}
