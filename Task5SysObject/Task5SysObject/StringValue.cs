namespace Task5SysObject
{
    /// <summary>
    /// класс описываюзий значение строки
    /// </summary>
    public class StringValue
    {
        /// <summary>
        /// конструктор класса StringValue
        /// </summary>
        /// <param name="value">значение строки</param>
        public StringValue(string value)
        {
            this.Value = value;
        }

        /// <summary>
        /// значение строки
        /// </summary>
        public string Value { get; private set; }

        /// <summary>
        /// переопределение оператора логического равно
        /// </summary>
        /// <param name="sw1">первый объект</param>
        /// <param name="sw2">второй объект</param>
        /// <returns>равны ли значения</returns>
        public static bool operator ==(StringValue sw1, StringValue sw2)
        {
            return sw1 != null && sw1.Equals(sw2);
        }

        /// <summary>
        /// переопределение оператора не равно
        /// </summary>
        /// <param name="sw1">первый объект</param>
        /// <param name="sw2">второй объект</param>
        /// <returns>не равны ли значения</returns>
        public static bool operator !=(StringValue sw1, StringValue sw2)
        {
            return sw1 != null && !sw1.Equals(sw2);  // На данный момент здесь падает stackoverflow, т.к. оператор вызывает сам себя.
                                                     // Советую обратить внимание на оператор "?" для проверки на null.
                                                     // +Странно получается: Если 1 операнд null, то != вернул false. И == вернёт false.
        }

        /// <summary>
        /// сравнение объектов StringValue по значению
        /// </summary>
        /// <param name="sw">объект для сравнения</param>
        /// <returns>равны ли значения</returns>
        public bool Equals(StringValue sw)
        {
            return this.Value == sw.Value;
        }

        /// <summary>
        /// переопределение сравнения объектов из класса .Object
        /// </summary>
        /// <param name="o">объект для сравнения</param>
        /// <returns>равны ли значения</returns>
        public override bool Equals(object o)
        {
            return o != null && this.Value == o.ToString(); // Надо проверять тип o. Это можно сделать с помощью оператора is. 
                                                            // Должна получится проверка типа (o is StringValue value).
                                                            // Тогда value будет типа StringValue и для его передаём как аргумент в Equals, который у нас перегружен выше.
        }

        /// <summary>
        /// метод подсчета кэш-суммы объекта
        /// </summary>
        /// <returns>кэш сумма</returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();  // Не лучший вариант. Лучше использовать хэш строки.
        }
    }
}
