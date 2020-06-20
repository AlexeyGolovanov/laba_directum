//-----------------------------------------------------------------------
// <copyright file="Meeting.cs" company="Имя Компании">
//     Копирайт тег
// </copyright>
//-----------------------------------------------------------------------

namespace Task2DNetArchitecture
{
    using System;

    /// <summary>
    /// класс описывающий встречу
    /// </summary>
    public class Meeting
    {
        /// <summary>
        /// время начала встречи
        /// </summary>
        public DateTime StartDate { get; set; }

        /// <summary>
        /// время окончания встречи
        /// </summary>
        public DateTime EndDate { get; set; }

        /// <summary>
        /// продолжительность встречи
        /// </summary>
        public TimeSpan Duration
        {
            get
            {
                return this.EndDate - this.StartDate; 
            }
        }
    }
}
