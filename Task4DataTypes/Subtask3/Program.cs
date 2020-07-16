using System.Text;

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
        public static string DetectRights(AccessRights rightsSum)
        {
            if ((int)rightsSum > 127 || (int)rightsSum < 0)
            {
                return "invalid input format";
            }

            if ((int)rightsSum >= (int)AccessRights.AccessDenied)
            {
                return AccessRights.AccessDenied.ToString();
            }

            var rights = new StringBuilder();

            for (int i = 0; i <= 6; i++)
            {
                if ((int)rightsSum >= Math.Pow(2, i))
                {
                    rights.Append((AccessRights)Math.Pow(2, i)+" ");
                }
            }

            return rights.ToString();
        }

        /// <summary>
        /// основной метод программы с тестовыми данными
        /// </summary>
        private static void Main()
        {
            Console.WriteLine("Rights for 63");
            Console.WriteLine((AccessRights)63);

            Console.WriteLine("\nRights for 64");
            Console.WriteLine(DetectRights((AccessRights)64));

            Console.WriteLine("\nRights for 65");
            Console.WriteLine(DetectRights((AccessRights)65));

            Console.WriteLine("\nRights for 128");
            Console.WriteLine(DetectRights((AccessRights)128));
            Console.ReadLine();
        }
    }
}
