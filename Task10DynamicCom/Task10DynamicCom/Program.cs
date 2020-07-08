namespace Task10DynamicCom
{
    using System.IO;

    /// <summary>
    /// Основной класс приложения
    /// </summary>
    public class Program
    {
        /// <summary>
        /// точка входа
        /// </summary>
        public static void Main()
        {
            EarlyBinding.FillMultiplicationTable(Directory.GetCurrentDirectory() + @"\EarlyBindingTable.xlsx");
            LateBinding.FillMultiplicationTable(Directory.GetCurrentDirectory() + @"\LateBindingTable.xlsx");
        }
    }
}
