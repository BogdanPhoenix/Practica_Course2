using Bunifu.UI.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Practice
{
    public partial class FormTaskFour : Form
    {
        /// <summary>
        /// Колекція ключей та значень для зберігання імпортованих даних або для створення ряду Фібоначчі
        /// Ключ - координата в списку
        /// Значення - імпортоване або згенероване число
        /// </summary>
        private Dictionary<int, decimal> fibonachi = new Dictionary<int, decimal>();
        /// <summary>
        /// Колекція ключей та значень для зберігання даних про елементи, які не входять в ряд Фібоначчі
        /// Ключ - координата в списку
        /// Значення - число, якого не має бути в ряді Фібоначі
        /// </summary>
        private Dictionary<int, decimal> extraError = new Dictionary<int, decimal>();
        /// <summary>
        /// Колекція ключей та значень для зберігання даних про числа, які входять в ряд Фібоначчі, але повторюються більше одного разу
        /// Ключ - координата в списку
        /// Значення - число, яке повторюється
        /// </summary>
        private Dictionary<int, decimal> duplicatError = new Dictionary<int, decimal>();
        /// <summary>
        /// Таблиця для імпорту даних з файлу
        /// </summary>
        private static DataTable dataTable = null;
        /// <summary>
        /// Дочірня форма для пошуку елемента за номером в таблиці
        /// </summary>
        private readonly FormSerch formSerch;
        /// <summary>
        /// Ширина стовпчиків в таблиці
        /// </summary>
        private const int widthColumn = 150;
        /// <summary>
        /// Конструктор
        /// </summary>
        public FormTaskFour()
        {
            InitializeComponent();

            formSerch = new FormSerch() { Data = dataResults };

            openFileDialog.Filter = "All file(*.*)|*.*";

            textBoxMaxNumber.KeyPress += CommonFunctionality.OnlyDigit;
            textBoxMaxNumber.KeyPress += (s, e) => { if (e.KeyChar == (char)Keys.Enter) DataResultPrint(FibonachiNumbers()); formSerch.UpdateForm(); };
            textBoxMaxNumber.TextChanged += (s, e) => { buttonResult.Enabled = textBoxMaxNumber.Text.Length != 0; };

            textBoxPathFile.KeyPress += (s, e) => { if (e.KeyChar == (char)Keys.Enter) ImageButtonDownload_Click(imageButtonDownload, new EventArgs()); };
            textBoxPathFile.TextChanged += (s, e) => { imageButtonDownload.ToolTipText = textBoxPathFile.Text.Length != 0 ? "Натисніть, щоб імпортувати вибраний файл" : "Натисніть, щоб обрати файл з даними"; };

            buttonResult.Click += (s, e) => { fibonachi = FibonachiNumbers(); DataResultPrint(fibonachi); formSerch.UpdateForm(); };
            buttonError.Click += (s, e) => { DeleteErrorOrDuplication(s, extraError); };
            buttonDuplication.Click += (s, e) => { DeleteErrorOrDuplication(s, duplicatError); };
            imageButtonSearch.Click += (s, e) => { formSerch.UpdateForm(); formSerch.Show(); };

            Resize += (s, e) => { DataResultPrint(fibonachi); };
        }
        /// <summary>
        /// Метод для генерування ряду Фібоначчі
        /// </summary>
        /// <returns>Колекцію ряду Фібоначчі, де ключ - це координата, а значення - число яке знаходиться за вказаним ключем</returns>
        private Dictionary<int, decimal> FibonachiNumbers()
        {
            Dictionary<int, decimal> trueResult = new Dictionary<int, decimal>() { { 0, 0 }, { 1, 1 } };
            decimal number = trueResult[trueResult.Count - 1];
            decimal max = Convert.ToDecimal(textBoxMaxNumber.Text);
            int index = trueResult.Count;

            try
            {
                if (radioButtonMaxValue.Checked)
                {
                    while (true)
                    {
                        number += trueResult[trueResult.Count - 2];
                        if (number > max)
                        {
                            break;
                        }
                        trueResult.Add(index++, number);
                    }
                }
                else
                {
                    for (; index < max; index++)
                    {
                        number += trueResult[trueResult.Count - 2];
                        trueResult.Add(index, number);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Під час обчислення ряду Фібоначчі сталася помилка. \nТекст помилки: {ex.Message}", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return trueResult;
        }
        /// <summary>
        /// Метод для створення та заповнення таблиці імпортованими або згенерованими даними
        /// </summary>
        /// <param name="dictionary">Колекцію з координатами та значеннями ряду</param>
        private void DataResultPrint(Dictionary<int, decimal> dictionary)
        {
            if (textBoxMaxNumber.Text.Length != 0)
            {
                dataResults.Columns.Clear();
                labelErrorData.Height = 0;
                imageButtonSearch.Visible = imageButtonCreate.Visible = dataResults.Visible = true;

                int max = dataResults.Width / widthColumn;
                for (int i = 0; i < max; i++)
                {
                    DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn
                    {
                        HeaderText = $"Column{i}",
                        Name = $"Column{i}",
                        ReadOnly = true,
                        Resizable = DataGridViewTriState.False
                    };
                    dataResults.Columns.Add(column);
                }

                int rows = dictionary.Count / dataResults.ColumnCount;
                for (int i = 0; i < rows; i++)
                {
                    dataResults.Rows.Add(GetFibonachi(dictionary, dataResults.ColumnCount, dataResults.ColumnCount * i, dataResults.ColumnCount * i + dataResults.ColumnCount));

                }
                if (rows * dataResults.ColumnCount < dictionary.Count)
                {
                    dataResults.Rows.Add(GetFibonachi(dictionary, dictionary.Count - rows * dataResults.ColumnCount, dataResults.ColumnCount * rows, dictionary.Count));
                }
                CheckEqualsError();
                CheckEqualsWarning();
                CheckEqualsDuplication();
                if (duplicatError.Count > 0)
                {
                    UpdateData(duplicatError, Color.Orange);
                }
                if (extraError.Count > 0)
                {
                    UpdateData(extraError, Color.Red);
                }
                formSerch.IsSearch = !buttonError.Visible && !buttonWarning.Visible && !buttonDuplication.Visible;
            }
            else
            {
                labelErrorData.Height = 200;
                imageButtonSearch.Visible = imageButtonCreate.Visible = dataResults.Visible = false;
            }
        }
        /// <summary>
        /// Метод для пошуку значень, які не входять в ряд Фібоначчі
        /// </summary>
        private void CheckEqualsError()
        {
            extraError.Clear();
            Dictionary<int, decimal> trueResult = FibonachiNumbers();
            foreach (var item in fibonachi)
            {
                if (!trueResult.ContainsValue(item.Value))
                {
                    extraError.Add(item.Key, item.Value);
                }
            }

            buttonError.Visible = extraError.Count > 0;
            buttonError.ToolTipText = $"Виявлено дані, які не входять в ряд Фібоначі. ({extraError.Count})";
        }
        /// <summary>
        /// Метод для перевірки чи значення в таблиці стоять в правильному порядку чи ні
        /// </summary>
        private void CheckEqualsWarning()
        {
            int index = 0;
            var sortedDict = from entry in fibonachi orderby entry.Value ascending select entry;
            Dictionary<int, decimal> buffer = sortedDict.ToDictionary(entry => index++, entry => entry.Value);
            buttonWarning.Visible = !EqualsDictionary(fibonachi, buffer);
        }
        /// <summary>
        /// Метод для перевірки колекцій чи за однаковими індекси знаходяться однакові значення
        /// </summary>
        /// <param name="dictionatyOne">Перша колекція для порівняння</param>
        /// <param name="dictionaryTwo">Друга колекція для порівняння</param>
        /// <returns>true - якщо дві колекції є рівні, інакше false</returns>
        private bool EqualsDictionary(Dictionary<int, decimal> dictionatyOne, Dictionary<int, decimal> dictionaryTwo)
        {
            if (dictionatyOne.Count != dictionaryTwo.Count)
            {
                return false;
            }
            foreach (var item in dictionatyOne)
            {
                if (!dictionaryTwo[item.Key].Equals(item.Value))
                {
                    return false;
                }
            }
            return true;
        }
        /// <summary>
        /// Метод для перевірки чи в таблиці знаходяться дублікати чи ні
        /// </summary>
        private void CheckEqualsDuplication()
        {
            duplicatError.Clear();
            int indexOne = 0;
            var result = fibonachi.GroupBy(kvp => kvp.Value).ToDictionary(grp => grp.First().Key, grp => grp.Key);
            foreach (var item in fibonachi)
            {
                if (!result.ContainsKey(item.Key))
                {
                    if (item.Value == 1 && indexOne++ < 1)
                    {
                        continue;
                    }
                    duplicatError.Add(item.Key, item.Value);
                }
            }
            buttonDuplication.Visible = duplicatError.Count > 0;
            buttonDuplication.ToolTipText = $"Виявлено дані, які повторюються. ({duplicatError.Count})";
        }
        /// <summary>
        /// Метод для графічного відображення комірок, в яких дані викликають деякі помилки
        /// </summary>
        /// <param name="indexs">Колекція даних з індексами комірок, через які виникають помилки</param>
        /// <param name="color">Колір помилки</param>
        private void UpdateData(Dictionary<int, decimal> indexs, Color color)
        {
            int indexRow, indexColumn;
            foreach (var item in indexs)
            {
                indexRow = item.Key / dataResults.ColumnCount;
                indexColumn = item.Key - dataResults.ColumnCount * indexRow;
                dataResults.Rows[indexRow].Cells[indexColumn].Style.BackColor = color;
            }
        }
        /// <summary>
        /// Метод для розбиття колекції на ряди в таблицю
        /// </summary>
        /// <param name="dictionary">Колекція з даними</param>
        /// <param name="size">Розмір ряду (кількість колонок таблиці)</param>
        /// <param name="start">Індекс початку ряду з колекції</param>
        /// <param name="end">Індекс закінчення ряду з колекції</param>
        /// <returns>Масив об'єктів, які заносяться в таблицю</returns>
        private object[] GetFibonachi(Dictionary<int, decimal> dictionary, int size, int start, int end)
        {
            object[] getArray = new object[size];
            int index = 0;
            for (; start < end; ++start)
            {
                getArray[index++] = dictionary[start];
            }

            return getArray;
        }
        /// <summary>
        /// Метод для виклику форми в які виконується збереження даних у файл
        /// </summary>
        /// <param name="sender">Об'єкт кнопки</param>
        /// <param name="e">Базовый клас для класів, який містить дані властивостей та надає їх</param>
        private void ImageButtonCreate_Click(object sender, EventArgs e)
        {
            FormCreateFiles createFiles = new FormCreateFiles(textBoxPathFile.Text, dataResults);
            createFiles.ShowDialog();
            createFiles.Close();
        }
        /// <summary>
        /// Метод для сортування даних в таблиці
        /// </summary>
        /// <param name="sender">Об'єкт кнопки</param>
        /// <param name="e">Базовый клас для класів, який містить дані властивостей та надає їх</param>
        private void ButtonSort_Click(object sender, EventArgs e)
        {
            int index = 0;
            var sortedDict = from entry in fibonachi orderby entry.Value ascending select entry;
            fibonachi = sortedDict.ToDictionary(entry => index++, entry => entry.Value);
            extraError = extraError.ToDictionary(entry => entry.Key, entry => fibonachi.FirstOrDefault(x => x.Value == entry.Key).Value);
            duplicatError = duplicatError.ToDictionary(entry => entry.Key, entry => fibonachi.FirstOrDefault(x => x.Value == entry.Key).Value);
            DataResultPrint(fibonachi);
            buttonWarning.Visible = false;
        }
        /// <summary>
        /// Метод для видаленння елементів в таблиці, які викликають помилки
        /// </summary>
        /// <param name="sender">Об'єкт кнопки</param>
        /// <param name="dictionary">Колекція даних для видалення</param>
        private void DeleteErrorOrDuplication(object sender, Dictionary<int, decimal> dictionary)
        {
            int index = 0;
            foreach (var item in dictionary)
            {
                fibonachi.Remove(item.Key);
            }
            fibonachi = fibonachi.ToDictionary(entry => index++, entry => entry.Value);
            dictionary = dictionary.ToDictionary(entry => entry.Key, entry => fibonachi.FirstOrDefault(x => x.Value == entry.Key).Value);
            DataResultPrint(fibonachi);
            ((BunifuImageButton)sender).Visible = false;
        }
        /// <summary>
        /// Метод для імпорту даних з файлу
        /// </summary>
        /// <param name="sender">Об'єкт кнопки</param>
        /// <param name="e">Базовый клас для класів, який містить дані властивостей та надає їх</param>
        private void ImageButtonDownload_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxPathFile.Text.Length == 0)
                {
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        textBoxPathFile.Text = openFileDialog.FileName;
                    }
                    else
                    {
                        MessageBox.Show("Ви не обрали файл з даними. Введіть шлях до файлу вручну або виберіть його через спеціальну форму, щоб продовжити імпорт.", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
                formSerch.UpdateForm();
                int index = 0, indexNumber;
                string number;
                if (dataTable != null)
                {
                    dataTable.Clear();
                }
                switch (Path.GetExtension(textBoxPathFile.Text))
                {
                    case ".txt": dataTable = TXTDocument.ImportTXTFile(textBoxPathFile.Text); break;
                    case ".docx": dataTable = WordDocument.ImportWordFile(textBoxPathFile.Text); break;
                    case ".xlsx": dataTable = ExcelDocument.ImportExcelFile(textBoxPathFile.Text); break;
                    default: MessageBox.Show("Вибраний вами файл має розширення, з яким не працює програма.", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
                }
                fibonachi.Clear();
                foreach (DataRow row in dataTable.Rows)
                {
                    for (int i = 0; i < row.ItemArray.Length; ++i)
                    {
                        number = row[i].ToString();
                        indexNumber = number.LastIndexOf(": ");
                        number = indexNumber > 0 ? number.Substring(indexNumber + 2) : number;
                        if (decimal.TryParse(number, out decimal buffer))
                        {
                            fibonachi.Add(index++, Convert.ToDecimal(number));
                        }
                    }
                }
                textBoxMaxNumber.Text = fibonachi.Values.Max().ToString();
                radioButtonMaxValue.Checked = true;
                DataResultPrint(fibonachi);
            }
            catch (IOException ex)
            {
                MessageBox.Show($"Під час отримання даних із файлу сталася помилка. \nТекст помилки: {ex.Message}", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Під час отримання даних сталася помилка. \nТекст помилки: {ex.Message}", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Маска для відображення користувачу інформації про максимальну довжину рядка
        /// </summary>
        /// <param name="sender">Об'єкт текстового поля</param>
        /// <param name="e">Базовый клас для класів, який містить дані про властивість натиску на клавішу та надає її функціонал</param>
        private void MaxLengthTextBox(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (e.KeyChar != (char)Keys.Back && textBox.Text.Length == textBox.MaxLength)
            {
                bunifuSnackbar.Show(ParentForm, $"Ви ввели максимальну кількість символів ({textBox.MaxLength})");
            }
        }
        /// <summary>
        /// Метод для очищення поля для введення значення або номеру ряду Фібоначчі
        /// </summary>
        /// <param name="sender">Об'єкт кнопки</param>
        /// <param name="e">Базовый клас для класів, який містить дані властивостей та надає їх</param>
        private void ClearMaxValue_Click(object sender, EventArgs e)
        {
            textBoxMaxNumber.Text = "";
        }
    }
}