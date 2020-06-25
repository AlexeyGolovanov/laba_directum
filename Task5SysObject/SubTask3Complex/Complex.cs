#nullable enable
namespace SubTask3Complex
{
    using System;

    /// <summary>
    /// класс описываюзий косплексное число
    /// </summary>
    public class Complex : IComparable
    {
        /// <summary>
        /// действительная часть числа
        /// </summary>
        public int Re { get; set; }

        /// <summary>
        /// мнимая часть числа
        /// </summary>
        public int Im { get; set; }

        /// <summary>
        /// вычисление модуля комлексного числа
        /// </summary>
        /// <returns>модуль числа</returns>
        public double GetAbs()
        {
            return Math.Sqrt(Math.Pow(this.Re, 2) + Math.Pow(this.Im, 2));
        }

        /// <summary>
        /// реализация сравнения комплексных чисел по модулю
        /// </summary>
        /// <param name="obj">комплексное число для сравнения</param>
        /// <returns>1 - больше, -1 - меньше, 0 - равны</returns>
        public int CompareTo(object? obj)
        {
            var other = obj as Complex;
            if (other != null)      // Можно ещё короче: if (obj is Complex other)
            {
                return this.GetAbs().CompareTo(other.GetAbs());
            }

            throw new Exception("Невозможно сравнить");
        }
    }
}
