namespace SubTask4
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    /// <summary>
    /// Класс с перебором колллекции строк
    /// </summary>
    public class TextEnumerator : IEnumerator<string>
    {
        /// <summary>
        /// Список со стороками для перебора
        /// </summary>
        private readonly List<string> rowsList;

        /// <summary>
        /// Позиция активного элемента
        /// </summary>
        private int currentPosition;

        /// <summary>
        /// Конструктор принимающий список строк
        /// </summary>
        /// <param name="rowsList">Список строк</param>
        public TextEnumerator(List<string> rowsList)
        {
            this.currentPosition = -1;
            this.rowsList = rowsList;
        }

        /// <summary>
        /// Активный элемент
        /// </summary>
        public string Current 
        {
            get
            {
                if (this.currentPosition == -1 || this.currentPosition >= this.rowsList.Count)
                {
                    throw new InvalidOperationException();
                }

                return this.rowsList[this.currentPosition];
            }
        }

        /// <summary>
        /// Активный элемент
        /// </summary>
        object IEnumerator.Current => this.Current;

        /// <summary>
        /// Смена активного элемента на следуюзий в коллекции
        /// </summary>
        /// <returns>Достигнут ли конец коллекции</returns>
        public bool MoveNext()
        {
            if (this.currentPosition < this.rowsList.Count - 1)
            {
                this.currentPosition++;
                return this.currentPosition < this.rowsList.Count;
            }

            return false;
        }

        /// <summary>
        /// Обнуление указателя активного элемента
        /// </summary>
        public void Reset()
        {
            this.currentPosition = -1;
        }

        /// <summary>
        /// Освобождение ресурсов
        /// </summary>
        public void Dispose()
        {
        }
    }
}
