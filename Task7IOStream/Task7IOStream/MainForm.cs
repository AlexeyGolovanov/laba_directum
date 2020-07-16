namespace Task7IOStream
{
    using System;
    using System.Windows.Forms;

    /// <summary>
    /// Класс главной формы
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Инициализация формы
        /// </summary>
        public MainForm()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// действия по нажатию кнопки
        /// </summary>
        /// <param name="sender">Object Sender</param>
        /// <param name="e">Event Args</param>
        private void Btn_Click(object sender, EventArgs e)
        {
            this.LoadToRichTextBox();
        }

        /// <summary>
        /// Заполнение RichTextBox в форме
        /// </summary>
        private void LoadToRichTextBox()
        {
            rtb.Rtf = ArchiveReader.ReadFromGzip(@"..\..\..\..\Task7IOStream\q2.rtf.gz");
        }
    }
}
