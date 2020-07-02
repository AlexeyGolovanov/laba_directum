namespace Task7IOStream
{
    using System;
    using System.IO;
    using System.Runtime.Serialization;

    /// <summary>
    /// Класс исключения, генерируемого при неудачной загрузке файла
    /// </summary>
    [Serializable]
    internal class LoadFileException : IOException
    {
        /// <summary>
        /// Без параметров
        /// </summary>
        public LoadFileException()
        {
        }

        /// <summary>
        /// С сообщением
        /// </summary>
        /// <param name="message">Передаваемое сообшение</param>
        public LoadFileException(string message) : base(message)
        {
        }

        /// <summary>
        /// С сообщением и ошибкой
        /// </summary>
        /// <param name="message">Передаваемое сообшение</param>
        /// <param name="innerException">Передаваемая ошибка</param>
        public LoadFileException(string message, Exception innerException) : base(message, innerException)
        {
        }

        /// <summary>
        /// С данными для сериализации и потоком сериализации
        /// </summary>
        /// <param name="info">Данные для сериализации</param>
        /// <param name="context">Источник и назначение потока сериализации</param>
        protected LoadFileException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}