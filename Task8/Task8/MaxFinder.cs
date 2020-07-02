namespace SubTusk2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Класс поиска наибольшего значения
    /// </summary>
    public class MaxFinder
    {
        /// <summary>
        /// Поиск наибольшего из 3-х
        /// </summary>
        /// <typeparam name="T">Тип данных</typeparam>
        /// <param name="first">Первое значение</param>
        /// <param name="second">Второе значение</param>
        /// <param name="third">Третее значение</param>
        /// <returns>Наибольгее значение из переданных</returns>
        public static T GetMaxOfThree<T>(T first, T second, T third) where T : IComparable<T>
        {
            var threeValues = new List<T> { first, second, third };
            return threeValues.Max();
        }
    }
}
