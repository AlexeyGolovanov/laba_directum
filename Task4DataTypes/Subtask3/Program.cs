namespace Subtask3
{
    using System;

    /// <summary>
    /// Тип прав.
    /// </summary>
    [Flags, Serializable]
    public enum AccessRights : byte // Лучше было вынести в отдельный файл.
    {
        /// <summary>
        /// Права на просмотр.
        /// </summary>
        View = 1,

        /// <summary>
        /// Права на выполнение.
        /// </summary>
        Run = 2,

        /// <summary>
        /// Права на добавление.
        /// </summary>
        Add = 4,

        /// <summary>
        /// Права на изменение.
        /// </summary>
        Edit = 8,

        /// <summary>
        /// Права на утверждение.
        /// </summary>
        Ratify = 16,

        /// <summary>
        /// Права на удаление.
        /// </summary>
        Delete = 32,

        /// <summary>
        /// Нет доступа.
        /// </summary>
        /// <remarks>
        /// Этот флаг имеет максимальный приоритет.
        /// Если он установлен, остальные флаги игнорируются 
        /// </remarks>
        AccessDenied = 64
    }

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

            var bitString = Convert.ToString((int)rightsSum, 2);    // Преобразование в строку похоже на костыль.
            var fullString = new string('0', 7 - bitString.Length) + bitString;
            if (fullString[0] == '1')   // Лучше проверить непосредственно rightsSum == AccessRights.AccessDenied
            {
                Console.WriteLine((AccessRights)Math.Pow(2, 6));
                return;
            }

            for (int i = 6; i >= 0; i--)
            {
                if (fullString[i] == '1') // Ну и тут соответственно лучше попробовать обойтись без строк.
                {
                    Console.WriteLine((AccessRights)Math.Pow(2, 6 - i));
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
