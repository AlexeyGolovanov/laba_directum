namespace Task7IOStream
{
    using System;
    using System.IO;
    using System.IO.Compression;

    /// <summary>
    /// Класс обработки даееых из архивов
    /// </summary>
    public static class ArchiveReader
    {
        /// <summary>
        /// Загрузка данных из архива в строку
        /// </summary>
        /// <param name="path"> Путь до файла архива </param>
        /// <returns> Считанная из rtf строка </returns>
        public static string ReadFromGzip(string path)
        {
            string result;
            try
            {
                using (FileStream fs = new FileStream(path, FileMode.Open))
                using (GZipStream decompressionStream = new GZipStream(fs, CompressionMode.Decompress))
                using (StreamReader sr = new StreamReader(decompressionStream))
                {
                    result = sr.ReadToEnd();
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

            return result;
        }
    }
}
