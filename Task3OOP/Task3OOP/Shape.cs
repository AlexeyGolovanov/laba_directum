//-----------------------------------------------------------------------
// <copyright file="Shape.cs" company="Имя Компании">
//     Копирайт тег
// </copyright>
//-----------------------------------------------------------------------

namespace Task3OOP
{
    /// <summary>
    /// абстрактный класс для геометрических фигур
    /// </summary>
    public abstract class Shape
    {
        /// <summary>
        /// площадь фигуры
        /// </summary>
        public double Area { get => this.Area; set => this.CountArea(); }

        /// <summary>
        /// периметр фигуры
        /// </summary>
        public double Perimeter { get => this.Perimeter; set => this.CountPerimeter(); }

        /// <summary>
        /// координаты центра
        /// </summary>
        public int[] Center { get; set; }

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
