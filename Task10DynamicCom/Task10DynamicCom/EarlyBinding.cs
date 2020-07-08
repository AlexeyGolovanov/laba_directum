namespace Task10DynamicCom
{
    using System;
    using Excel = Microsoft.Office.Interop.Excel;

    /// <summary>
    /// Класс для работы с COM применяя раннее связывание
    /// </summary>
    public class EarlyBinding
    {
        /// <summary>
        /// Заполняет страницу excel файла таблицей умножения 
        /// </summary>
        /// <param name="filePath">Путь до файла</param>
        public static void FillMultiplicationTable(string filePath)
        {
            var excelApp = new Excel.Application();
            excelApp.Workbooks.Add(Type.Missing);
            var newSheet = (Excel.Worksheet)excelApp.Worksheets[1];

            newSheet.Name = "Раннее связывание";

            for (int rowIndex = 1; rowIndex < 10; rowIndex++)
            {
                newSheet.Cells[1, rowIndex] = rowIndex;
                newSheet.Cells[rowIndex, 1] = rowIndex;
                for (int columnIndex = 1; columnIndex < 10; columnIndex++)
                {
                    newSheet.Cells[rowIndex, columnIndex] = rowIndex * columnIndex;
                }
            }

            newSheet.Range["A1", "I1"].Cells.Font.Bold = true;
            newSheet.Range["A1", "A9"].Cells.Font.Bold = true;
            newSheet.Range["A1", "I9"].Borders.LineStyle = Excel.XlLineStyle.xlContinuous;

            excelApp.Application.ActiveWorkbook.SaveAs(
                filePath,
                Type.Missing,
                Type.Missing,
                Type.Missing,
                Type.Missing,
                Type.Missing,
                Excel.XlSaveAsAccessMode.xlShared,
                Type.Missing,
                Type.Missing,
                Type.Missing,
                Type.Missing,
                Type.Missing);

            excelApp.Quit();
        }
    }
}
