//-----------------------------------------------------------------------
// <copyright file="Square.cs" company="Имя Компании">
//     Копирайт тег
// </copyright>
//-----------------------------------------------------------------------

namespace Task3OOP
{
    /// <summary>
    /// класс описывающий квадрат
    /// </summary>
    public class Square : Shape
    {
        /// <summary>
        /// длинна стороны квадрата
        /// </summary>
        public int Side { get; set; }

        /// <summary>
        /// вычисление площади квадрата
        /// </summary>
        /// <returns>плошадь квадрата</returns>
        public override double CountArea()
        {
            return this.Side * this.Side;
        }

        /// <summary>
        /// вычисление периметра квадрата
        /// </summary>
        /// <returns>периметр квадрата</returns>
        public override double CountPerimeter()
        {
            return this.Side * 4;
        }
    }
}
