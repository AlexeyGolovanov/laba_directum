namespace Task9Reflection
{
    using System;
    using System.Configuration;
    using System.IO;

    /// <summary>
    /// Основной класс приложения
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Точка входа
        /// </summary>
        public static void Main()
        {
            Console.WriteLine("Общие свойства:");
            var configReader = new ConfigReader();
            Console.WriteLine(configReader.GetAppSettings("IntSetting"));
            Console.WriteLine(configReader.GetAppSettings("StrSetting"));

            Console.WriteLine("\nКастомные свойства:");
            var settingsSection = (ConfigReader.SettingsSection)ConfigurationManager.GetSection("ProgramSettings");
            var settings = settingsSection.SubSettings;

            foreach (ConfigurationElement element in settings)
            {
                foreach (PropertyInformation prop in element.ElementInformation.Properties)
                {
                    Console.WriteLine($"Свойство:{prop.Name} \tЗначение:{prop.Value}");
                }
            }

            Console.WriteLine("\nRead-write свойства объектов из dll\n");
            var path = Path.GetFullPath(@"..\..\dllFirst\TestLibrary.dll");
            ClassAnalyzer.PrintPropertiesOfCreatedInstance(path, "TestLibrary.TestClass");
            Console.WriteLine();
            path = Path.GetFullPath(@"..\..\dllSecond\TestLibrary.dll");
            ClassAnalyzer.PrintPropertiesOfCreatedInstance(path, "TestLibrary.TestClass");
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
