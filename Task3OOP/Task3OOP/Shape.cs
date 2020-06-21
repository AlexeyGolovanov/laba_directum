//-----------------------------------------------------------------------
// <copyright file="Shape.cs" company="Имя Компании">
//     Копирайт тег
// </copyright>
//-----------------------------------------------------------------------

namespace Task3OOP
{
    using System.Drawing;

    /// <summary>
    /// абстрактный класс для геометрических фигур
    /// </summary>
    public abstract class Shape
    {
        /// <summary>
        /// конструктор объектов класса фигура
        /// </summary>
        /// <param name="center">центр фигуры</param>
        public Shape(Point center)
        {
            this.Center = center;
        }

        /// <summary>
        /// площадь фигуры
        /// </summary>
        public double Area { get => this.CountArea(); }

        /// <summary>
        /// периметр фигуры
        /// </summary>
        public double Perimeter { get => this.CountPerimeter(); } 

        /// <summary>
        /// координаты центра
        /// </summary>
        public Point Center { get; set; }

        /// <summary>
        /// метод вычисляющий периметр фигуры
        /// </summary>
        /// <returns>периметр фигуры</returns>
        public abstract double CountPerimeter();

        /// <summary>
        /// метод вычисляющий площадь фигуры
        /// </summary>
        /// <returns>площадь фигуры</returns>
        public abstract double CountArea();
    }
}
