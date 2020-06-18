//-----------------------------------------------------------------------
// <copyright file="Ring.cs" company="Имя Компании">
//     Копирайт тег
// </copyright>
//-----------------------------------------------------------------------

namespace Task3OOP
{
    using System;

    /// <summary>
    /// класс описывающий кольцо
    /// </summary>
    public class Ring : Circle
    {
        /// <summary>
        /// ынутренний радиус кольца  // Ещё опечатка. Лучше быть с этим чуть внимательнее.
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
