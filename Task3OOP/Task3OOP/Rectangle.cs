//-----------------------------------------------------------------------
// <copyright file="Rectangle.cs" company="Имя Компании">
//     Копирайт тег
// </copyright>
//-----------------------------------------------------------------------

namespace Task3OOP
{
    /// <summary>
    /// класс описывающий прямоугольник
    /// </summary>
    public class Rectangle : Square
    {
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
            return this.Side * this.Side2;
        }

        /// <summary>
        /// вычисление периметра прямоугольника
        /// </summary>
        /// <returns>периметр прямоугольника</returns>
        public override double CountPerimeter()
        {
            return (this.Side * 2) + (this.Side2 * 2);
        }
    }
}
