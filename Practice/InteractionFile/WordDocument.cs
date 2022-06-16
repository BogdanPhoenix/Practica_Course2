using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Practice
{
    /// <summary>
    /// Клас для взаємодії з Word файлами
    /// </summary>
    class WordDocument
    {
        private static DataTable dataTable = new DataTable();
        private const int sizeTableProperties = 12;

        #region Імпорт даних
        public static DataTable ImportWordFile(string nameOpenFile)
        {
            try
            {
                bool isTable;
                using (WordprocessingDocument doc = WordprocessingDocument.Open(nameOpenFile, false))
                {
                    isTable = doc.MainDocumentPart.Document.Body.Elements<Table>().Any();
                }
                if (isTable)
                {
                    ReadDocxFileTable(nameOpenFile);
                }
                else
                {
                    ReadDocxFileList(nameOpenFile);
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show($"Відбувся збій під час отримання даних з файлу.\nТекст помилки: {ex.Message}.", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Відбувся збій під час опрацювання даних.\nТекст помилки: {ex.Message}.", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return dataTable;
        }
        /// <summary>
        /// Метод для отримання даних з вибраного файлу DOCX "Таблиця"
        /// </summary>
        private static void ReadDocxFileTable(string nameOpenFile)
        {
            using (WordprocessingDocument docx = WordprocessingDocument.Open(nameOpenFile.Trim(), false))
            {
                int rowCount = 0;
                Table table = docx.MainDocumentPart.Document.Body.Elements<Table>().First();
                IEnumerable<TableRow> rows = table.Elements<TableRow>();

                foreach (TableRow row in rows)
                {
                    dataTable.Rows.Add();
                    int i = 0;
                    foreach (TableCell cell in row.Descendants<TableCell>())
                    {
                        if (rowCount == 0)
                        {
                            dataTable.Columns.Add($"Column{i}");
                        }
                        dataTable.Rows[dataTable.Rows.Count - 1][i++] = cell.InnerText;
                    }
                    ++rowCount;
                }
            }
        }
        /// <summary>
        /// Метод для отримання даних з вибраного файлу DOCX "Список"
        /// </summary>
        private static void ReadDocxFileList(string nameOpenFile)
        {
            using (WordprocessingDocument wordDocument = WordprocessingDocument.Open(nameOpenFile, false))
            {
                var paragraphs = wordDocument.MainDocumentPart.Document.Body.Descendants<Paragraph>();
                dataTable.Columns.Add("Column0");
                foreach (var paragraph in paragraphs)
                {
                    dataTable.Rows.Add(paragraph.InnerText);
                }
            }
        }
        #endregion
        #region Експорт даних
        public static void ExportWordListFile(string nameOpenFile, DataTable data, bool addNumbering)
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
                using (WordprocessingDocument wordDocument = WordprocessingDocument.Create(nameOpenFile, WordprocessingDocumentType.Document))
                {
                    MainDocumentPart mainPart = wordDocument.AddMainDocumentPart();

                    mainPart.Document = new Document();
                    Body body = mainPart.Document.AppendChild(new Body());
                    Paragraph para = null;

                    int index = 0;
                    string number;
                    foreach (DataRow row in data.Rows)
                    {
                        for (int i = 0; i < row.ItemArray.Length; ++i)
                        {
                            if (row.ItemArray[i].ToString().Length > 0)
                            {
                                number = addNumbering ? $"{++index}: " : "";
                                para = body.AppendChild(new Paragraph());
                                Run run = para.AppendChild(new Run());
                                run.AppendChild(new Text($"{number}{row.ItemArray[i]}"));
                            }
                        }
                    }
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
        public static void ExportWordTableFile(string nameOpenFile, DataTable data)
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
                using (WordprocessingDocument wordDocument = WordprocessingDocument.Create(nameOpenFile, WordprocessingDocumentType.Document))
                {
                    Table table = new Table();

                    TableProperties tblProp = new TableProperties(
                        new TableBorders(
                            new TopBorder()
                            {
                                Val = new EnumValue<BorderValues>(BorderValues.Dashed),
                                Size = sizeTableProperties
                            },
                            new BottomBorder()
                            {
                                Val = new EnumValue<BorderValues>(BorderValues.Dashed),
                                Size = sizeTableProperties
                            },
                            new LeftBorder()
                            {
                                Val = new EnumValue<BorderValues>(BorderValues.Dashed),
                                Size = sizeTableProperties
                            },
                            new RightBorder()
                            {
                                Val = new EnumValue<BorderValues>(BorderValues.Dashed),
                                Size = sizeTableProperties
                            },
                            new InsideHorizontalBorder()
                            {
                                Val = new EnumValue<BorderValues>(BorderValues.Dashed),
                                Size = sizeTableProperties
                            },
                            new InsideVerticalBorder()
                            {
                                Val = new EnumValue<BorderValues>(BorderValues.Dashed),
                                Size = sizeTableProperties
                            }
                        )
                    );

                    table.AppendChild<TableProperties>(tblProp);

                    foreach (DataRow row in data.Rows)
                    {
                        TableRow newRow = new TableRow();
                        for (int i = 0; i < row.ItemArray.Length; ++i)
                        {
                            TableCell newCell = new TableCell();
                            newCell.Append(new TableCellProperties(new TableCellWidth() { Type = TableWidthUnitValues.Dxa, Width = "2400" }));
                            if (row.ItemArray[i].ToString().Length > 0)
                            {
                                newCell.Append(new Paragraph(new Run(new Text($"{row.ItemArray[i]}"))));
                            }
                            else
                            {
                                newCell.Append(new Paragraph(new Run(new Text(""))));
                            }
                            newRow.Append(newCell);
                        }
                        table.Append(newRow);
                    }

                    MainDocumentPart mainPart = wordDocument.AddMainDocumentPart();

                    mainPart.Document = new Document();
                    Body body = mainPart.Document.AppendChild(new Body());
                    body.Append(table);
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