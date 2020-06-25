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
            Console.WriteLine(new StringValue("AAA") == new StringValue("AAA"));
            Console.WriteLine(new StringValue("AAA") != new StringValue("AAA")); 

            StringValue sw = null;
            Console.WriteLine(new StringValue("AAA").Equals(sw));
            Console.WriteLine(sw == new StringValue("AAA"));
            Console.WriteLine(sw != new StringValue("AAA"));
            Console.WriteLine(new StringValue("AAA") == sw);
            Console.WriteLine(new StringValue("AAA") != sw);
        }
    }
}
