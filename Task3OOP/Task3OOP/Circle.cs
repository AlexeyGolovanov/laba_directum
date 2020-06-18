//-----------------------------------------------------------------------
// <copyright file="Circle.cs" company="Имя Компании">
//     Копирайт тег
// </copyright>
//-----------------------------------------------------------------------

namespace Task3OOP
{
    using System;

    /// <summary>
    /// Класс описывающий круг
    /// </summary>
    public class Circle : Round
    {
        /// <summary>
        /// вычисление площади круга
        /// </summary>
        /// <returns>алощадь круга</returns>
        public override double CountArea()
        {
           return Math.PI * this.Radius * this.Radius;
        }
    }
}
