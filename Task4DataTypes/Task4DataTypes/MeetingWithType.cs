//-----------------------------------------------------------------------
// <copyright file="MeetingWithType.cs" company="Имя Компании">
//     Копирайт тег
// </copyright>
//-----------------------------------------------------------------------

namespace Subtask1
{
    /// <summary>
    /// типы встреч
    /// </summary>
    public enum MeetingType
    {
        /// <summary>
        /// тип совещание
        /// </summary>
        Conference,

        /// <summary>
        /// тип поручение
        /// </summary>
        Commission,

        /// <summary>
        /// тип звонок
        /// </summary>
        PhoneCall,

        /// <summary>
        /// тип день рождения
        /// </summary>
        Birthday
    }

    /// <summary>
    /// класс встреч с указанием типа
    /// </summary>
    public class MeetingWithType : Meeting
    {
        /// <summary>
        /// тип встречи
        /// </summary>
        public MeetingType Type { get; set; }
    }
}
