//-----------------------------------------------------------------------
// <copyright file="Round.cs" company="Имя Компании">
//     Копирайт тег
// </copyright>
//-----------------------------------------------------------------------

namespace Task3OOP
{
    using System;
    using System.Drawing;

    /// <summary>
    /// класс описывающий окружность
    /// </summary>
    public class Round : Shape
    {
        /// <summary>
        /// конструктор объектов класса окружность
        /// </summary>
        /// <param name="center">центр окружности</param>
        /// <param name="radius">радиус окружности</param>
        public Round(Point center, int radius) : base(center)
        {
            this.Radius = radius;
        }

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
    }
}
