//-----------------------------------------------------------------------
// <copyright file="WithReminder.cs" company="Имя Компании">
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
    public class WithReminder : Meeting, IRemind  // Непонятное название. Лучше назвать MeetingWithRemind.
    {
        /// <summary>
        /// таймер для проверки необходимости вызова напоминанния
        /// </summary>
        private static Timer timer; // Почему решил использовать статическое поле?

        /// <summary>
        /// Время, в которое должно быть вызвано напоминание
        /// </summary>
        private DateTime remindTime;

        /// <summary>
        /// Initializes a new instance of the <see cref="WithReminder"/> class.
        /// </summary>
        public WithReminder()
        {
            timer = new Timer();
            timer.Interval = 60000;
            timer.Elapsed += this.CheckTime;  // Таймер не запущен. Нужно вызвать метод Start().
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
        /// Метод возвращает время вывода напоминания
        /// </summary>
        /// <returns>возвращает время напоминания о встрече</returns>
        public DateTime GetRemindTime()
        {
            return this.remindTime;
        }

        /// <summary>
        /// Метод устанавливает время напоминания о встрече
        /// </summary>
        /// <param name="minutes">промежуток времени в минутах, за который до встречи будет вызвано напоминание</param>
        public void SetRemindTime(int minutes)
        {
            this.remindTime = this.StartDate - TimeSpan.FromMinutes(minutes);
        }

        /// <summary>
        /// метод проверяющий настоящее время с установленным временем напоминания и в случаи совпадения до минут вызывыющий напоминание
        /// </summary>
        /// <param name="source">Источник события</param>
        /// <param name="e">Объект ElapsedEventArgs, содержащий данные события</param>
        private void CheckTime(object source, ElapsedEventArgs e)
        {
            var d1 = DateTime.Now;  // Не говорящее имя переменной. +Можно обойтись без неё.

            if (d1.ToString("g") == this.remindTime.ToString("g"))  // Почему проверяются строки?
                                                                    // Лучше проверить что текущее время больше времени напоминания.
            {
                this.Remind?.Invoke("Sample reminder text");
            }
        }
    }
}
