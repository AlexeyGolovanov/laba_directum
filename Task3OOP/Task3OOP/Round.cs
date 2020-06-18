//-----------------------------------------------------------------------
// <copyright file="Round.cs" company="Имя Компании">
//     Копирайт тег
// </copyright>
//-----------------------------------------------------------------------

namespace Task3OOP
{
    using System;

    /// <summary>
    /// класс описывающий окружность
    /// </summary>
    public class Round : Shape
    {
        /// <summary>
        /// радиус окружности
        /// </summary>
        public int Radius { get; set; }

        /// <summary>
        /// вычисление площади окружности
        /// </summary>
        /// <returns>площадь окружности</returns>
        public override double CountArea()
        {
            return 0;
        }

        /// <summary>
        /// вычисление длины окружности
        /// </summary>
        /// <returns>длина окружности</returns>
        public override double CountPerimeter()
        {
            return 2 * Math.PI * this.Radius;
        }

        // Было бы не плохо задавать радиус через конструктор.
        // Да и другие параметры в других фигурах тоже.
  }
}
