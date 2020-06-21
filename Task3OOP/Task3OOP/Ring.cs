//-----------------------------------------------------------------------
// <copyright file="Ring.cs" company="Имя Компании">
//     Копирайт тег
// </copyright>
//-----------------------------------------------------------------------

namespace Task3OOP
{
    using System;
    using System.Drawing;

    /// <summary>
    /// класс описывающий кольцо
    /// </summary>
    public class Ring : Circle
    {
        /// <summary>
        /// конструктор объектов класса кольцо
        /// </summary>
        /// <param name="center">центр фигуры</param>
        /// <param name="radius">внешний радиус</param>
        /// <param name="radiusInner">внутренний радиус</param>
        public Ring(Point center, int radius, int radiusInner) : base(center, radius)
        {
            this.RadiusInner = radiusInner;
        }

        /// <summary>
        /// внутренний радиус кольца
        /// </summary>
        public int RadiusInner { get; set; }

        /// <summary>
        /// вычисление площади кольца
        /// </summary>
        /// <returns>площвдь кольца</returns>
        public override double CountArea()
        {
            return base.CountArea() - (Math.PI * this.RadiusInner * this.RadiusInner);
        }

        /// <summary>
        /// вычисление периметра кольца
        /// </summary>
        /// <returns>периметр кольца</returns>
        public override double CountPerimeter()
        {
            return base.CountPerimeter() + (2 * Math.PI * this.RadiusInner);
        }
    }
}
