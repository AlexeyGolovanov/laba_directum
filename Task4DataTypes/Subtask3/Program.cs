namespace Subtask3
{
    using System;

    /// <summary>
    /// класс с которого начинается выполнение программы
    /// </summary>
    public class Program
    {
        /// <summary>
        /// метод определяющий имеющиеся права
        /// </summary>
        /// <param name="rightsSum">входное значение имеющихся прав</param>
        public static void DetectRights(AccessRights rightsSum)
        {
            if ((int)rightsSum > 127 || (int)rightsSum < 0)
            {
                Console.WriteLine("invalid input format");
                return;
            }

            if ((int)rightsSum >= (int)AccessRights.AccessDenied)
            {
                Console.WriteLine(AccessRights.AccessDenied);
                return;
            }

            for (int i = 0; i <= 6; i++)
            {
                if ((int)rightsSum >= Math.Pow(2, i))
                {
                    Console.WriteLine((AccessRights)Math.Pow(2, i));
                }
            }
        }

        /// <summary>
        /// основной метод программы с тестовыми данными
        /// </summary>
        private static void Main()
        {
            Console.WriteLine("Rights for 63");
            DetectRights((AccessRights)63);

            Console.WriteLine("\nRights for 64");
            DetectRights((AccessRights)64);

            Console.WriteLine("\nRights for 65");
            DetectRights((AccessRights)65);

            Console.WriteLine("\nRights for 128");
            DetectRights((AccessRights)128);
            Console.ReadLine();
        }
    }
}
