//-----------------------------------------------------------------------
// <copyright file="Circle.cs" company="Имя Компании">
//     Копирайт тег
// </copyright>
//-----------------------------------------------------------------------

namespace Task3OOP
{
    using System;
    using System.Drawing;

    /// <summary>
    /// Класс описывающий круг
    /// </summary>
    public class Circle : Round // Circle - окружность. Round - круг. Спишем на неполноту задания.
    {
        /// <summary>
        /// конструктор для объектов класса круг 
        /// </summary>
        /// <param name="center">центр фигуры</param>
        /// <param name="radius">радиус круга</param>
        public Circle(Point center, int radius) : base(center, radius)
        {
        }

        /// <summary>
        /// вычисление площади круга
        /// </summary>
        /// <returns>алощадь круга</returns>  // площадь
        public override double CountArea()
        {
           return Math.PI * this.Radius * this.Radius;
        }
    }
}
