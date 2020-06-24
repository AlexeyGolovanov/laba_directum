//-----------------------------------------------------------------------
// <copyright file="Meeting.cs" company="Имя Компании">
//     Копирайт тег
// </copyright>
//-----------------------------------------------------------------------

namespace Subtask1
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
        public virtual DateTime? EndDate { get; set; }

        /// <summary>
        /// продолжительность встречи
        /// </summary>
        public virtual TimeSpan? Duration => this.EndDate != null ? this.EndDate - this.StartDate : null;
    }
}
