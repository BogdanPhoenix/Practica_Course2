using System;
using System.Data;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Practice
{
    /// <summary>
    /// Клас для взаємодії з текстовими файлами
    /// </summary>
    class TXTDocument
    {
        private static DataTable dataTable = null;
        /// <summary>
        /// Метод для зчитування даних з текстового файлу
        /// </summary>
        /// <returns>Повертає таблицю даних</returns>
        public static DataTable ImportTXTFile(string nameOpenFile)
        {
            if (!nameOpenFile.Equals(""))
            {
                StreamReader file = null;
                try
                {
                    dataTable = new DataTable();
                    file = new StreamReader(nameOpenFile, Encoding.UTF8);
                    dataTable.Columns.Add("0", typeof(string));
                    while (!file.EndOfStream)
                    {
                        dataTable.Rows.Add(file.ReadLine());
                    }
                    file.Close();
                }
                catch (IOException ex)
                {
                    MessageBox.Show($"Відбувся збій під час отримання даних з файлу.\nТекст помилки: {ex.Message}.", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dataTable.Clear();
                    file.Close();
                    dataTable = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Відбувся збій під час опрацювання даних.\nТекст помилки: {ex.Message}.", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dataTable.Clear();
                    file.Close();
                    dataTable = null;
                }
            }
            return dataTable;
        }
        public static void ExportTXTFile(string nameCreateFile, DataTable data, bool addNumbering)
        {
            StreamWriter file = null;
            try
            {
                if (File.Exists(nameCreateFile))
                {
                    DialogResult result = MessageBox.Show($"Даний файл \"{nameCreateFile}\" вже існує. \nЧи хотіли б ви його замінити", "Увага", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.No)
                    {
                        return;
                    }
                }
                file = new StreamWriter(nameCreateFile, false);
                int index = 0;
                string number;
                foreach (DataRow row in data.Rows)
                {
                    for (int i = 0; i < row.ItemArray.Length; ++i)
                    {
                        number = addNumbering ? $"{++index}: " : "";
                        file.WriteLine($"{number}{row.ItemArray[i]}");
                    }
                }
            }

            catch (IOException ex)
            {
                MessageBox.Show($"Під час створення файлу сталася помилка.\nТекст помилки: {ex.Message}.", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Під час створення файлу сталася помилка.\nТекст помилки: {ex.Message}.", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                if (file != null)
                {
                    file.Close();
                }
            }
        }
    }
}
