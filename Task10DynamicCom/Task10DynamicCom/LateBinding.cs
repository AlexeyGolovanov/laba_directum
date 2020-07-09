namespace Task10DynamicCom
{
    using System;

    /// <summary>
    /// Класс для работы с COM применяя позднее связывание
    /// </summary>
    public class LateBinding
    {
        /// <summary>
        /// Заполняет страницу excel файла таблицей умножения 
        /// </summary>
        /// <param name="filePath">Путь до файла</param>
        public static void FillMultiplicationTable(string filePath)
        {
            dynamic excelApp = Activator.CreateInstance(Type.GetTypeFromProgID("Excel.Application"));
            excelApp.SheetsInNewWorkbook = 1;
            excelApp.Workbooks.Add(Type.Missing);

            dynamic newSheet = excelApp.Worksheets[1];
            newSheet.Name = "Позднее связывание";

            for (int rowIndex = 1; rowIndex < 10; rowIndex++)
            {
                newSheet.Cells[rowIndex, 1] = rowIndex;
                newSheet.Cells[1, rowIndex] = rowIndex;
                for (int columnIndex = 1; columnIndex < 10; columnIndex++)
                {
                    newSheet.Cells[rowIndex, columnIndex] = rowIndex * columnIndex;
                }
            }

            dynamic upperRow = newSheet.Range("A1", "I1");
            upperRow.Cells.Font.Bold = true;
            dynamic leftColumn = newSheet.Range("A1", "A9");
            leftColumn.Cells.Font.Bold = true;
            dynamic fullTable = newSheet.Range("A1", "I9");
            dynamic lineStyle = Type.GetType("Microsoft.Office.Interop.Excel.XlLineStyle");
            if (lineStyle != null)
            {
                dynamic continuous = lineStyle.GetField("xlContinuous").GetValue(lineStyle);
                fullTable.Borders.LineStyle = continuous;
            }

            dynamic accessMode = Type.GetType("Microsoft.Office.Interop.Excel.XlSaveAsAccessMode");
            if (accessMode != null)
            {
                dynamic shared = accessMode.GetField("xlShared").GetValue(accessMode);
                excelApp.Application.ActiveWorkbook.SaveAs(
                    filePath,
                    Type.Missing,
                    Type.Missing,
                    Type.Missing,
                    Type.Missing,
                    Type.Missing,
                    shared,
                    Type.Missing,
                    Type.Missing,
                    Type.Missing,
                    Type.Missing,
                    Type.Missing);
            }

            excelApp.Quit();
        }
    }
}
