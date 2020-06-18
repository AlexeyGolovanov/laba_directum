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
        /// установка времени напоминания в минутах до времени начала
        /// </summary>
        /// <param name="minutes">число минут</param>
        public void SetRemindTime(int minutes); // А почему не свойством, а методами. Просто интересно.

        /// <summary>
        /// вывод установленного времени напоминания о встрече
        /// </summary>
        /// <returns>возвращает время напоминания о встрече</returns>
        public DateTime GetRemindTime();
    }
}
