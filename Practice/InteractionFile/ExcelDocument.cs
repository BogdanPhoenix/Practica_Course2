using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Practice
{
    /// <summary>
    /// Клас для взаємодії з Excel файлами
    /// </summary>
    class ExcelDocument
    {
        private static DataTable dataTable = null;
        #region Імпорт
        /// <summary>
        /// Метод для зчитування даних з файлів Excel
        /// </summary>
        /// <returns>Повертає таблицю даних, файлів Excel</returns>
        public static DataTable ImportExcelFile(string nameOpenFile)
        {
            try
            {
                dataTable = new DataTable();
                using (SpreadsheetDocument xlsx = SpreadsheetDocument.Open(nameOpenFile, false))
                {
                    WorkbookPart workbookPart = xlsx.WorkbookPart;
                    WorksheetPart worksheetPart = workbookPart.WorksheetParts.First();
                    SheetData sheetData = worksheetPart.Worksheet.Elements<SheetData>().First();
                    foreach (Row row in sheetData.Elements<Row>())
                    {
                        if (row.RowIndex.Value == 1)
                        {
                            int index = 0;
                            foreach (Cell cell in row.Elements<Cell>())
                            {
                                dataTable.Columns.Add($"Column{index++}");
                            }
                        }
                        DataRow tempRow = dataTable.NewRow();
                        int columnIndex = 0;
                        foreach (Cell cell in row.Descendants<Cell>())
                        {
                            int cellColumnIndex = (int)GetColumnIndexFromName(GetColumnName(cell.CellReference));
                            cellColumnIndex--;
                            if (columnIndex < cellColumnIndex)
                            {
                                do
                                {
                                    tempRow[columnIndex] = "";
                                    columnIndex++;
                                }
                                while (columnIndex < cellColumnIndex);
                            }
                            tempRow[columnIndex] = GetCellValue(xlsx, cell);

                            columnIndex++;
                        }
                        dataTable.Rows.Add(tempRow);
                    }
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show($"Відбувся збій під час отримання даних з файлу.\nТекст помилки: {ex.Message}.", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dataTable.Clear();
                dataTable = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Відбувся збій під час опрацювання даних.\nТекст помилки: {ex.Message}.", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dataTable.Clear();
                dataTable = null;
            }
            return dataTable;
        }
        /// <summary>
        /// Метод для вираховування імені комірки, аналізуючи вказану клітинку, щоб отримати назву стовпця
        /// </summary>
        /// <param name="cellReference">Адреса комірки</param>
        /// <returns>Повертає ім'я стовпчика</returns>
        public static string GetColumnName(string cellReference)
        {
            Regex regex = new Regex("[A-Za-z]+");
            Match match = regex.Match(cellReference);
            return match.Value;
        }
        /// <summary>
        /// Метод враховує лише ім’я стовпця (без індексу рядка), він поверне нульовий індекс стовпця.
        /// Примітка. Цей метод оброблятиме лише стовпці довжиною до двох (тобто від A до Z і від AA до ZZ).
        /// За потреби можна застосувати довжину три.
        /// </summary>
        /// <param name="columnName">Ім'я колонки</param>
        /// <returns>Повертає не нульовий індекс, якщо перетворення було успішним; інакше нульовий</returns>
        public static int? GetColumnIndexFromName(string columnName)
        {
            string name = columnName;
            int number = 0;
            int pow = 1;
            for (int i = name.Length - 1; i >= 0; i--)
            {
                number += (name[i] - 'A' + 1) * pow;
                pow *= 26;
            }
            return number;
        }
        /// <summary>
        /// Метод для отримання даних з комірки
        /// </summary>
        /// <param name="document">Поточний Excel документ</param>
        /// <param name="cell">Дані про комірку</param>
        /// <returns>Повертає вміст комірки</returns>
        public static string GetCellValue(SpreadsheetDocument document, Cell cell)
        {
            SharedStringTablePart stringTablePart = document.WorkbookPart.SharedStringTablePart;
            if (cell.CellValue == null)
            {
                return "";
            }
            string value = cell.CellValue.InnerXml;
            if (cell.DataType != null && cell.DataType.Value == CellValues.SharedString)
            {
                return stringTablePart.SharedStringTable.ChildElements[int.Parse(value)].InnerText;
            }
            else
            {
                return value;
            }
        }
        #endregion
        #region Експорт даних
        public static void ExportExcelTableFile(string nameOpenFile, DataTable data, bool isTable)
        {
            try
            {
                if (File.Exists(nameOpenFile))
                {
                    DialogResult result = MessageBox.Show($"Даний файл \"{nameOpenFile}\" вже існує. \nЧи хотіли б ви його замінити", "Увага", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.No)
                    {
                        return;
                    }
                }

                using (SpreadsheetDocument spreadsheetDocument = SpreadsheetDocument.Create(nameOpenFile, SpreadsheetDocumentType.Workbook))
                {
                    UInt32Value index = 1;
                    WorkbookPart workbookpart = spreadsheetDocument.AddWorkbookPart();
                    workbookpart.Workbook = new Workbook();

                    WorksheetPart worksheetPart = workbookpart.AddNewPart<WorksheetPart>();
                    SheetData sheetData = new SheetData();
                    worksheetPart.Worksheet = new Worksheet(sheetData);

                    Sheets sheets = spreadsheetDocument.WorkbookPart.Workbook.AppendChild(new Sheets());

                    Sheet sheet = new Sheet()
                    {
                        Id = spreadsheetDocument.WorkbookPart.
                        GetIdOfPart(worksheetPart),
                        SheetId = 1,
                        Name = "numbersFibonachi"
                    };
                    if (isTable)
                    {
                        int indexLetter, indexAlphabet;
                        foreach (DataRow row in data.Rows)
                        {
                            indexLetter = 65;
                            indexAlphabet = 1;
                            Row newRow = new Row { RowIndex = index++ };
                            for (int i = 0; i < row.ItemArray.Length; ++i)
                            {
                                if (indexLetter > 90)
                                {
                                    ++indexAlphabet;
                                    indexLetter = 65;
                                }
                                Cell cell = new Cell() { CellReference = $"{Convert.ToChar(indexLetter++)}{indexAlphabet}" };
                                if (row.ItemArray[i].ToString().Length > 0)
                                {
                                    cell.CellValue = new CellValue(Convert.ToDecimal(row.ItemArray[i]));
                                    cell.DataType = CellValues.Number;
                                }
                                else
                                {
                                    cell.CellValue = new CellValue("");
                                    cell.DataType = CellValues.String;
                                }
                                newRow.Append(cell);
                            }
                            sheetData.Append(newRow);
                        }
                    }
                    else
                    {
                        foreach (DataRow row in data.Rows)
                        {
                            for (int i = 0; i < row.ItemArray.Length; ++i)
                            {
                                Row newRow = new Row { RowIndex = index++ };
                                Cell cell = new Cell() { CellReference = "A1" };
                                if (row.ItemArray[i].ToString().Length > 0)
                                {
                                    cell.CellValue = new CellValue(Convert.ToDecimal(row.ItemArray[i]));
                                    cell.DataType = CellValues.Number;
                                }
                                else
                                {
                                    cell.CellValue = new CellValue("");
                                    cell.DataType = CellValues.String;
                                }
                                newRow.Append(cell);
                                sheetData.Append(newRow);
                            }
                        }
                    }

                    sheets.Append(sheet);
                    workbookpart.Workbook.Save();
                    spreadsheetDocument.Close();
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show($"Відбувся збій під час занесення даних у файл.\nТекст помилки: {ex.Message}.", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Відбувся збій під час опрацювання даних.\nТекст помилки: {ex.Message}.", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion
    }
}