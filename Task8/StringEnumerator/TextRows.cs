namespace SubTask4
{
    using System.Collections;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// Класс с перечислимой коллекцией
    /// </summary>
    public class TextRows : IEnumerable<string>
    {
        /// <summary>
        /// Коллекция строк
        /// </summary>
        private readonly List<string> rowsList;

        /// <summary>
        /// Конструктор заполняющий коллекцию из текстового файла 
        /// </summary>
        /// <param name="path">путь к текстовоиму файлу</param>
        public TextRows(string path)
        {
            this.rowsList = new List<string>();

            using (var reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    this.rowsList.Add(line);
                }
            }
        }

        /// <summary>
        /// Метод из IEnumerable
        /// </summary>
        /// <returns>Объект соответствуюзего класса, реализующего IEnumerator</returns>
        public IEnumerator<string> GetEnumerator()
        {
            return new TextEnumerator(this.rowsList);
        }

        /// <summary>
        /// Метод из IEnumerable
        /// </summary>
        /// <returns>Объект соответствуюзего класса, реализующего IEnumerator</returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
