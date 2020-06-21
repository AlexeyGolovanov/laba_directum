//-----------------------------------------------------------------------
// <copyright file="Triangle.cs" company="Имя Компании">
//     Копирайт тег
// </copyright>
//-----------------------------------------------------------------------

namespace Task3OOP
{
    using System;
    using System.Drawing;

    /// <summary>
    /// класс описывающий триугольник
    /// </summary>
    public class Triangle : Shape
    {
        /// <summary>
        /// конструктор объектов класса триугольник
        /// </summary>
        /// <param name="center">центр триугольника</param>
        /// <param name="side1">длина первой стороны</param>
        /// <param name="side2">длина второй стороны</param>
        /// <param name="side3">длина третей стороны</param>
        public Triangle(Point center, int side1, int side2, int side3) : base(center)
        {
            this.Side1 = side1;
            this.Side2 = side2;
            this.Side3 = side3;
        }

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
        /// вычисление периметра триугольника
        /// </summary>
        /// <returns>периметр триугольника</returns>
        public override double CountPerimeter()
        {
            return this.Side1 + this.Side2 + this.Side3;
        }

        /// <summary>
        /// вычисление площади триугольника
        /// </summary>
        /// <returns>плошадь триугольника</returns>
        public override double CountArea()
        {
            var perimeterHalf = this.CountPerimeter() / 2;
            return Math.Sqrt(perimeterHalf * (perimeterHalf - this.Side1) * (perimeterHalf - this.Side2) * (perimeterHalf - this.Side3));
        }
    }
}
