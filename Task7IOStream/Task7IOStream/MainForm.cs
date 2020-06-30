namespace Task7IOStream
{
    using System;
    using System.IO;
    using System.IO.Compression;
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
        /// Загрузка данных из архива в RichTextBox
        /// </summary>
        private void LoadToRichTextBox()
        {
            try
            {
                using (FileStream fs = new FileStream(@"..\..\..\..\Task7IOStream\q2.rtf.gz", FileMode.Open))
                using (GZipStream decompressionStream = new GZipStream(fs, CompressionMode.Decompress))
                using (StreamReader sr = new StreamReader(decompressionStream))
                {
                    rtb.Rtf = sr.ReadToEnd();
                }
            }
            catch (UnauthorizedAccessException exception)
            {
                throw new LoadFileException(exception.Message, exception);
            }
            catch (FileNotFoundException exception)
            {
                throw new LoadFileException(exception.Message, exception);
            }
        }
    }
}
