//-----------------------------------------------------------------------
// <copyright file="Rectangle.cs" company="Имя Компании">
//     Копирайт тег
// </copyright>
//-----------------------------------------------------------------------

namespace Task3OOP
{
    using System.Drawing;

    /// <summary>
    /// класс описывающий прямоугольник
    /// </summary>
    public class Rectangle : Shape
    {
        /// <summary>
        /// конструктор объектов класса прямоугольник
        /// </summary>
        /// <param name="center">центр фигуры</param>
        /// <param name="side1">длина одной стороны</param>
        /// <param name="side2">длина другой стороны</param>
        public Rectangle(Point center, int side1, int side2) : base(center)
        {
            this.Side1 = side1;
            this.Side2 = side2;
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
        /// вычисление площади прямоугольника
        /// </summary>
        /// <returns>плошадь прямоугольника</returns>
        public override double CountArea()
        {
            return this.Side1 * this.Side2;
        }

        /// <summary>
        /// вычисление периметра прямоугольника
        /// </summary>
        /// <returns>периметр прямоугольника</returns>
        public override double CountPerimeter()
        {
            return (this.Side1 * 2) + (this.Side2 * 2);
        }
    }
}
