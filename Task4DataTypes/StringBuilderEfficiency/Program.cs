namespace StringBuilderEfficiency
{
    using System;
    using System.Diagnostics;
    using System.Text;

    /// <summary>
    /// класс с которого начинается выполнение программы
    /// </summary>
    public class Program
    {
        /// <summary>
        /// основной метод программы
        /// </summary>
        public static void Main()
        {
            var n = 10;
            for (int i = 0; i < 5; i++)
            {
                CountAppendTime(n);
                n *= 10;
            }

            Console.WriteLine();
            n = 10;
            for (int i = 0; i < 5; i++)
            {
                CountSubstringTime(n);
                n *= 10;
            }
        }

        /// <summary>
        /// сравнение времени объединения строк
        /// </summary>
        /// <param name="n">длина строки</param>
        private static void CountAppendTime(int n)
        {
            var results = new string[2];
            var watch = new Stopwatch();

            string str = string.Empty;
            StringBuilder sb = new StringBuilder();
            watch.Restart();
            for (int i = 0; i < n; i++)
            {
                str += "*";
            }

            results[0] = watch.ElapsedMilliseconds.ToString();
            watch.Restart();
            for (int i = 0; i < n; i++)
            {
                sb.Append("*");
            }

            results[1] = watch.ElapsedMilliseconds.ToString();

            Console.WriteLine("Average operation time, than string grows to {0} symbols", n);
            Console.WriteLine("string: {0} ms{2}StringBuilder {1} ms", results[0], results[1], '\t');
        }

        /// <summary>
        /// сравнение времени взьятия подстроки
        /// </summary>
        /// <param name="n">дллина строки</param>
        private static void CountSubstringTime(int n)
        {
            var results = new string[2];
            var watch = new Stopwatch();

            var str = new string('*', n);
            StringBuilder sb = new StringBuilder(str);
            watch.Restart();
            for (int i = 0; i < n; i++)
            {
                str = str.Substring(1);
            }

            results[0] = watch.ElapsedMilliseconds.ToString();
            watch.Restart();
            for (int i = 0; i < n; i++)
            {
                sb.Remove(0, 1);
            }

            results[1] = watch.ElapsedMilliseconds.ToString();

            Console.WriteLine("Average operation time, than we continuously take substrings [1;n] from string of {0} symbols", n);
            Console.WriteLine("string: {0} ms{2}StringBuilder {1} ms", results[0], results[1], '\t');
        }
    }
}
