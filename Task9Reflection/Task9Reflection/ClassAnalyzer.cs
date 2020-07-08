namespace Task9Reflection
{
    using System;
    using System.Reflection;

    /// <summary>
    /// Класс для работы со свойствами классов
    /// </summary>
    internal static class ClassAnalyzer
    {
        /// <summary>
        /// Вывод в консоль reed-write свойств объекта
        /// </summary>
        /// <param name="instance"> Объект класса </param>
        public static void PrintReadWriteProperties(object instance)
        {
            var properties = instance.GetType().GetProperties();
            foreach (var property in properties)
            {
                if (property.CanRead && property.CanWrite &&
                    property.GetCustomAttribute<ObsoleteAttribute>(true) == null)
                {
                    Console.WriteLine($"Свойство: {property.Name}\tЗначение: {property.GetValue(instance)}"); // to change
                }
            }
        }

        /// <summary>
        /// Загрузка сборки выводит в консоль reed-write свойств объекта из нее.
        /// </summary>
        /// <param name="assemblyPath"> Полный путь до сборки </param>
        /// <param name="className"> Имя класса в рассматриваемой сборке </param>
        public static void PrintPropertiesOfCreatedInstance(string assemblyPath, string className)
        {
            var assembly = Assembly.LoadFile(assemblyPath);
            var type = assembly.GetType(className);
            var constructor = type.GetConstructors()[0];
            var instance = constructor.Invoke(new object[0]);
            PrintReadWriteProperties(instance);
        }
    }
}
