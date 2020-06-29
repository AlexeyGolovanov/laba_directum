namespace Task7IOStream
{
    using System;
    using System.Windows.Forms;

    /// <summary>
    /// Главный класс приложения
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
