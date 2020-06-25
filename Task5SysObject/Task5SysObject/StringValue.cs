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
            return sw1 != null && !sw1.Equals(sw2);
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
            return o != null && this.Value == o.ToString();
        }

        /// <summary>
        /// метод подсчета кэш-суммы объекта
        /// </summary>
        /// <returns>кэш сумма</returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
