//-----------------------------------------------------------------------
// <copyright file="IRemind.cs" company="Имя Компании">
//     Копирайт тег
// </copyright>
//-----------------------------------------------------------------------

namespace Task2DNetArchitecture
{
    using System;

    /// <summary>
    /// Интерфейс описывает необходимые методы для встреч с напоминанием
    /// </summary>
    public interface IRemind
    {
        /// <summary>
        /// Время вызова напоминания
        /// </summary>
        public DateTime RemindTime { get; set; }
    }
}
