namespace Task12LocalizedApp
{
    using System;
    using System.Reflection;
    using System.Resources;
    using System.Windows;

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Инициализация глпвного окна
        /// </summary>
        public MainWindow()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Обработчик события нажатия на кнопку
        /// </summary>
        /// <param name="sender"> Объект, присылающий событие </param>
        /// <param name="e"> Переданные аргументы </param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(TextMessages.HelloMessage);
        }

        /// <summary>
        /// Обработчик события инициализации окна
        /// </summary>
        /// <param name="sender"> Объект, присылающий событие </param>
        /// <param name="e"> Переданные аргументы </param>
        private void Window_Initialized(object sender, EventArgs e)
        {
            var resMan = new ResourceManager(
                "Task12LocalizedApp.TextMessages",
                Assembly.GetExecutingAssembly());
            MessageBox.Show(resMan.GetString("HelloMessage"));
        }
    }
}
