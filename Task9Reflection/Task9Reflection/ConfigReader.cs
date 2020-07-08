namespace Task9Reflection
{
    using System.Configuration;

    /// <summary>
    /// Класс для чтения конфигурации.
    /// </summary>
    public class ConfigReader
    {
        /// <summary>
        /// Считывание свойств из секции appSettings.
        /// </summary>
        /// <param name="name"> Имя параметра </param>
        /// <returns> Значение свойства </returns>
        public string GetAppSettings(string name)
        {
            string[] potentialValues = ConfigurationManager.AppSettings.GetValues(name);
            return (potentialValues != null
                && potentialValues.Length > 0
                && !string.IsNullOrEmpty(potentialValues[0]))
                ? potentialValues[0] : string.Empty;
        }

        /// <summary>
        /// Коллекция элементов конфигурации
        /// </summary>
        [ConfigurationCollection(typeof(SubSettingSection), CollectionType = ConfigurationElementCollectionType.AddRemoveClearMap)]
        public class SubSettingCollection : ConfigurationElementCollection
        {
            /// <summary>
            /// Создание элемента конфига
            /// </summary>
            /// <returns> Созданный элемент </returns>
            protected override ConfigurationElement CreateNewElement()
            {
                return new SubSettingSection();
            }

            /// <summary>
            /// Создание ключа элемента.
            /// </summary>
            /// <param name="element"> Элемент для получения ключа </param>
            /// <returns> Ключ элемента </returns>
            protected override object GetElementKey(ConfigurationElement element)
            {
                return ((SubSettingSection)element).SubSetting;
            }
        }

        /// <summary>
        /// Секция конфигурации
        /// </summary>
        public class SettingsSection : ConfigurationSection
        {
            /// <summary>
            /// Вывод коллекции элементов конфигурции 
            /// </summary>
            [ConfigurationProperty("", IsDefaultCollection = true, IsRequired = true)]
            public SubSettingCollection SubSettings => (SubSettingCollection)this[string.Empty];
        }

        /// <summary>
        /// Элемент конфигурации
        /// </summary>
        internal class SubSettingSection : ConfigurationElement
        {
            /// <summary>
            /// Ключ элемента.
            /// </summary>
            [ConfigurationProperty("SubSetting", IsRequired = true, IsKey = true)]
            public string SubSetting => (string)this["SubSetting"];

            /// <summary>
            /// Значение элемента.
            /// </summary>
            [ConfigurationProperty("SubSettingValue", IsRequired = true)]
            public string SubSettingValue => (string)this["SubSettingValue"];
        }
    }
}
