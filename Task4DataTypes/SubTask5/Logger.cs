namespace SubTask5
{
    using System;
    using System.IO;

    /// <summary>
    /// Логгер - класс для ведения логов.
    /// </summary>
    public class Logger : IDisposable
    {
        /// <summary>
        /// Файл логов.
        /// </summary>
        private FileStream logFile;

        /// <summary>
        /// Писатель влог.
        /// </summary>
        private StreamWriter logWriter;

        /// <summary>
        /// Создать объект.
        /// </summary>
        /// <param name="fileName">Имя файла логов.</param>
        public Logger(string fileName)
        {
            this.logFile = new FileStream(fileName, FileMode.Append);
            this.logWriter = new StreamWriter(this.logFile);
        }

        /// <summary>
        /// освобождение ресурсов
        /// </summary>
        public void Dispose()
        {
            this.logWriter.Dispose();
            this.logFile.Dispose();
        }

        /// <summary>
        /// запись данных в файл
        /// </summary>
        /// <param name="data">данные для записи</param>
        public void WriteString(string data)
        {
            this.logWriter.WriteLine(data);
            this.Dispose(); // Здесь не нужно вызывать Dispose();
        }
    }
}
