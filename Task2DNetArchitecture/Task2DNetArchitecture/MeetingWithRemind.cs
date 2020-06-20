//-----------------------------------------------------------------------
// <copyright file="MeetingWithRemind.cs" company="Имя Компании">
//     Копирайт тег
// </copyright>
//-----------------------------------------------------------------------

namespace Task2DNetArchitecture
{
    using System;
    using System.Timers;

    /// <summary>
    /// класс описывает встречи с напоминанием. Наследуется от класса Meeting и реализует интерфейс IRemind
    /// </summary>
    public class MeetingWithRemind : Meeting, IRemind
    {
        /// <summary>
        /// таймер для проверки необходимости вызова напоминанния
        /// </summary>
        private readonly Timer timer;

        /// <summary>
        /// Initializes a new instance of the <see cref="MeetingWithRemind"/> class.
        /// </summary>
        public MeetingWithRemind()
        {
            this.timer = new Timer();
            this.timer.Interval = 60000;
            this.timer.Start();
            this.timer.Elapsed += this.CheckTime;  // Таймер не запущен. Нужно вызвать метод Start().
        }

        /// <summary>
        /// делегат для вызова метода принимающего строку и ничего не возвращающего
        /// </summary>
        /// <param name="message">передаваемая в метод строка</param>
        public delegate void ReminderHandler(string message);

        /// <summary>
        /// событие вызова напоминания
        /// </summary>
        public event ReminderHandler Remind;

        /// <summary>
        /// Время вызова напоминания
        /// </summary>
        public DateTime RemindTime { get; set; }

        /// <summary>
        /// метод проверяющий настоящее время с установленным временем напоминания и в случаи совпадения до минут вызывыющий напоминание
        /// </summary>
        /// <param name="source">Источник события</param>
        /// <param name="e">Объект ElapsedEventArgs, содержащий данные события</param>
        private void CheckTime(object source, ElapsedEventArgs e)
        {
            if (DateTime.Now >= this.RemindTime)
            {
                this.Remind?.Invoke("Sample reminder text");

                if (DateTime.Now >= this.StartDate)
                {
                    this.timer.Stop();
                }
            }
        }
    }
}
