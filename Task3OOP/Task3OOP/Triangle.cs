//-----------------------------------------------------------------------
// <copyright file="Triangle.cs" company="Имя Компании">
//     Копирайт тег
// </copyright>
//-----------------------------------------------------------------------

namespace Task3OOP
{
    using System;

    /// <summary>
    /// класс описывающий триугольник
    /// </summary>
    public class Triangle : Shape
    {
        /// <summary>
        /// длина первой стороны
        /// </summary>
        public int Side1 { get; set; }

        /// <summary>
        /// длина второй стороны
        /// </summary>
        public int Side2 { get; set; }

        /// <summary>
        /// длина третей стороны
        /// </summary>
        public int Side3 { get; set; }

        /// <summary>
        /// вычисление периметра триоугольника
        /// </summary>
        /// <returns>периметр триугольника</returns>
        public override double CountPerimeter()
        {
            return this.Side1 + this.Side2 + this.Side3;
        }

        /// <summary>
        /// вычисление площади триоугольника
        /// </summary>
        /// <returns>плошадь триугольника</returns>
        public override double CountArea()
        {
            var perimeterHalf = this.CountPerimeter() / 2;
            return Math.Sqrt(perimeterHalf * (perimeterHalf - this.Side1) * (perimeterHalf - this.Side2) * (perimeterHalf - this.Side3));
        }
    }
}
