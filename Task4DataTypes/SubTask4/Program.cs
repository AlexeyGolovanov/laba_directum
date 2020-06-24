namespace SubTask4
{
    using System;

    /// <summary>
    /// класс с которого начинается выполнение программы
    /// </summary>
    public class Program
    {
        /// <summary>
        /// основной метод программы с тестовыми данными
        /// </summary>
        private static void Main()
        {
            DateTime now = DateTime.Now;
            Console.WriteLine("Форматы даты");
            Console.WriteLine("D: {0:D}", now);
            Console.WriteLine("d: {0:d}", now);
            Console.WriteLine("F: {0:f}", now);
            Console.WriteLine("f: {0:f}", now);
            Console.WriteLine("G: {0:G}", now);
            Console.WriteLine("g: {0:g}", now);
            Console.WriteLine("M: {0:M}", now);
            Console.WriteLine("O: {0:O}", now);
            Console.WriteLine("o: {0:o}", now);
            Console.WriteLine("R: {0:R}", now);
            Console.WriteLine("s: {0:s}", now);
            Console.WriteLine("T: {0:T}", now);
            Console.WriteLine("t: {0:t}", now);
            Console.WriteLine("U: {0:U}", now);
            Console.WriteLine("u: {0:u}", now);
            Console.WriteLine("Y: {0:Y}", now);

            Console.WriteLine("\nФорматы чисел");
            var numberDouble = 15.37;
            var numberInt = 15;
            var phone = 88005553535;
            Console.WriteLine(string.Format("C: {0:C2}", numberDouble));
            Console.WriteLine(string.Format("d: {0:d3}", numberInt));
            Console.WriteLine(string.Format("f: {0:f4}", numberDouble));
            Console.WriteLine(string.Format("x: {0:x}", numberInt));
            Console.WriteLine(string.Format("P: {0:P2}", numberDouble));
            Console.WriteLine(string.Format("{0:+# (###) ###-##-##}", phone));
            Console.ReadLine();
        }
    }
}
