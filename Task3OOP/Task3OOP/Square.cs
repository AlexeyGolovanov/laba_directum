//-----------------------------------------------------------------------
// <copyright file="Square.cs" company="Имя Компании">
//     Копирайт тег
// </copyright>
//-----------------------------------------------------------------------

namespace Task3OOP
{
    using System.Drawing;

    /// <summary>
    /// класс описывающий квадрат
    /// </summary>
    public class Square : Rectangle
    {
        /// <summary>
        /// конструктор объектов класса квдрат
        /// </summary>
        /// <param name="center">центр квадрата</param>
        /// <param name="side">длина стороны квадрата</param>
        public Square(Point center, int side) : base(center, side, side)
        {
        }
    }
}
