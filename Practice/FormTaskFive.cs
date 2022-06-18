using Bunifu.UI.WinForms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Practice
{
    public partial class FormTaskFive : Form
    {
        /// <summary>
        /// Ширина стовпчиків таблиці
        /// </summary>
        private const int widthColumn = 100;
        /// <summary>
        /// Змінна для зберігання поточного максимально можливої кількості стовпчиків та рядків таблиць
        /// </summary>
        private int maxCountColumn;
        /// <summary>
        /// Змінна для зберігання попередньої максимально можливої кількості стовпчиків та рядків таблиць
        /// </summary>
        private int maxCountColumnPrevious;
        /// <summary>
        /// Матриця
        /// </summary>
        private double[,] A;
        /// <summary>
        /// Об'єкт для генерування псевдовипадкових чисел
        /// </summary>
        private readonly Random random = new Random();
        /// <summary>
        /// Максимальна кількість символів яку можна ввести в комірку
        /// </summary>
        private const int maxLengthCellText = 8;
        /// <summary>
        /// Колір фону комірки
        /// </summary>
        private Color backColor;
        /// <summary>
        /// Колір тексту комірки
        /// </summary>
        private Color foreColor;
        /// <summary>
        /// Конструктор
        /// </summary>
        public FormTaskFive()
        {
            InitializeComponent();
            MaxCountColumn();
            CreateTable(dataResults);
            CreateTable(dataSortResults);
            maxCountColumnPrevious = sizeMatrix.Value;
            sizeMatrix.Scroll += (s, e) => { UpdateScroll(); };
            this.Resize += (s, e) => { MaxCountColumn(); };
        }
        /// <summary>
        /// Визначення максимальної кількості стовпчиків та рядків таблиць в залежності від розмірів вікна
        /// </summary>
        private void MaxCountColumn()
        {
            try
            {
                maxCountColumn = dataResults.Width / widthColumn;
                sizeMatrixMax.Text = maxCountColumn.ToString();
                if (sizeMatrix.Value > maxCountColumn)
                {
                    sizeMatrix.Value = maxCountColumn;
                    sizeMatrixNow.Text = sizeMatrix.Value.ToString();
                    UpdateScroll();
                }
                sizeMatrix.Maximum = maxCountColumn;
            }
            catch { }
        }
        /// <summary>
        /// Метод для створення таблиці
        /// </summary>
        /// <param name="dataGridView">Об'єкт таблиці, з якою потрібно працювати</param>
        private void CreateTable(DataGridView dataGridView)
        {
            dataGridView.Columns.Clear();
            for (int i = 0; i < sizeMatrix.Value; i++)
            {
                DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn
                {
                    HeaderText = $"Column{i}",
                    Name = $"Column{i}",
                    ReadOnly = false,
                    Resizable = DataGridViewTriState.False
                };
                dataGridView.Columns.Add(column);
            }
            for (int i = dataGridView.Rows.Count; i < sizeMatrix.Value; i++)
            {
                dataGridView.Rows.Add();
            }
        }
        /// <summary>
        /// Мето для генерування автоматичних даних в таблицю в діапазоні від -1000 до 1000
        /// </summary>
        private void CreateAutomaticallyData()
        {
            for (int i = 0; i < dataResults.RowCount; ++i)
            {
                for (int j = 0; j < dataResults.ColumnCount; ++j)
                {
                    dataResults.Rows[i].Cells[j].Value = random.Next(-1000, 1000);
                }
            }
        }
        /// <summary>
        /// Метод для відстеження введених даних користувачем та запуск перевірки чи всі комірки таблиці заповнено
        /// </summary>
        /// <param name="sender">Об'єкт таблиці</param>
        /// <param name="e">Базовый клас для класів, який містить дані комірки та надає її функціонал</param>
        private void DataResults_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (radioButtonManually.Checked)
            {
                buttonSort.Enabled = CheckAllDataCompleted(dataResults);
                imageButtonNegative.Enabled = buttonSort.Enabled;
                imageButtonPositive.Enabled = buttonSort.Enabled;
            }
        }
        /// <summary>
        /// Метод для перевірки чи заповненні всі комірки таблиці
        /// </summary>
        /// <param name="data">Таблиця даних</param>
        /// <returns>true - якщо всі комірки таблиці заповненні, інакше - false</returns>
        private bool CheckAllDataCompleted(DataGridView data)
        {
            for (int i = 0; i < data.RowCount; ++i)
            {
                for (int j = 0; j < data.ColumnCount; ++j)
                {
                    if (data[j,i].Value == null)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        /// <summary>
        /// Метод для запуску сортування
        /// </summary>
        /// <param name="sender">Об'єкт кнопки</param>
        /// <param name="e">Базовый клас для класів, який містить дані властивостей та надає їх</param>
        private void ButtonSort_Click(object sender, EventArgs e)
        {
            A = new double[sizeMatrix.Value, sizeMatrix.Value];
            for (int i = 0; i < dataResults.RowCount; ++i)
            {
                for(int j = 0; j < dataResults.ColumnCount; ++j)
                {
                    A[i, j] = Convert.ToDouble(dataResults.Rows[i].Cells[j].Value);
                }
            }
            Sort();
        }
        /// <summary>
        /// Метод для сортування введених даних та виведення відсортованої таблиці
        /// </summary>
        private void Sort()
        {
            double[] buffer = new double[sizeMatrix.Value * sizeMatrix.Value];
            int count = 0;
            for(int i = 0; i < sizeMatrix.Value; ++i)
            {
                for(int j = 0; j < sizeMatrix.Value; ++j)
                {
                    buffer[count++] = A[i, j];
                }
            }
            SortArray(buffer);
            count = 0;
            for(int i = 0; i < dataSortResults.RowCount; ++i)
            {
                for(int j = 0; j < dataSortResults.ColumnCount; ++j)
                {
                    dataSortResults.Rows[i].Cells[j].Value = buffer[count++];
                }
            }
        }
        /// <summary>
        /// Метод для сортування масиву
        /// </summary>
        /// <param name="array">Масив, який потрібно відсортувати</param>
        private void SortArray(double[] array)
        {
            double buffer;
            int min;

            for (int i = 0; i < array.Length; ++i)
            {
                min = i;
                buffer = array[i];
                for (int j = i + 1; j < array.Length; ++j)
                {
                    if ((array[i] < 0 || array[j] >= 0) && array[j] < buffer)
                    {
                        min = j;
                        buffer = array[j];
                    }
                }
                array[min] = array[i];
                array[i] = buffer;
            }
        }
        /// <summary>
        /// Метод для відстеження зміни значення повзунка та перемалювання таблиць
        /// </summary>
        private void UpdateScroll()
        {
            if (sizeMatrix.Value != maxCountColumnPrevious)
            {
                sizeMatrixNow.Text = sizeMatrix.Value.ToString();
                CreateTable(dataResults);
                CreateTable(dataSortResults);
                if (radioButtonAutomatically.Checked)
                {
                    CreateAutomaticallyData();
                }
                maxCountColumnPrevious = sizeMatrix.Value;
                imageButtonNegative.Tag = false;
                imageButtonPositive.Tag = false;
                ImageButtonNegative(imageButtonNegative, new EventArgs());
                ImageButtonPositive(imageButtonPositive, new EventArgs());
            }
        }
        /// <summary>
        /// Метод для заповнення таблиці, коли вибраний режим "Вручну"
        /// </summary>
        /// <param name="sender">Об'єкт кнопки</param>
        /// <param name="e">Базовый клас для класів, який містить дані про властивість активного прапорця та надає його функціонал</param>
        private void RadioButtonManually_CheckedChanged2(object sender, BunifuRadioButton.CheckedChangedEventArgs e)
        {
            if (radioButtonManually.Checked)
            {
                CreateTable(dataResults);
                dataResults.ReadOnly = false;
                buttonSort.Enabled = false;
                imageButtonNegative.Tag = imageButtonNegative.Enabled = false;
                imageButtonPositive.Tag = imageButtonPositive.Enabled = false;
                ImageButtonNegative(imageButtonNegative, new EventArgs());
                ImageButtonPositive(imageButtonPositive, new EventArgs());
            }
        }
        /// <summary>
        /// Метод для заповнення таблиці, коли вибраний режим "Автоматично"
        /// </summary>
        /// <param name="sender">Об'єкт кнопки</param>
        /// <param name="e">Базовый клас для класів, який містить дані про властивість активного прапорця та надає його функціонал</param>
        private void RadioButtonAutomatically_CheckedChanged2(object sender, BunifuRadioButton.CheckedChangedEventArgs e)
        {
            if (radioButtonAutomatically.Checked)
            {
                CreateAutomaticallyData();
                dataResults.ReadOnly = true;
                buttonSort.Enabled = true;
                imageButtonNegative.Enabled = true;
                imageButtonPositive.Enabled = true;
                imageButtonNegative.Tag = false;
                imageButtonPositive.Tag = false;
                ImageButtonNegative(imageButtonNegative, new EventArgs());
                ImageButtonPositive(imageButtonPositive, new EventArgs());
            }
        }
        /// <summary>
        /// Метод для відображення в таблиці чисел, які менші нуля
        /// </summary>
        /// <param name="sender">Об'єкт кнопки</param>
        /// <param name="e">Базовый клас для класів, який містить дані властивостей та надає їх</param>
        private void ImageButtonNegative(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(imageButtonNegative.Tag))
            {
                backColor = Color.Green;
                foreColor = Color.White;
                imageButtonNegative.Tag = false;
                bunifuToolTip.SetToolTip(imageButtonNegative, "Натисніть, щоб прибрати позначки з всіх чисел, які менші нуля");
            }
            else
            {
                backColor = Color.White;
                foreColor = Color.Black;
                imageButtonNegative.Tag = true;
                bunifuToolTip.SetToolTip(imageButtonNegative, "Натисніть, щоб відобразити всі числа, які менші нуля");
            }
            UpdateData(dataResults, "negative", backColor, foreColor);
            UpdateData(dataSortResults, "negative", backColor, foreColor);
        }
        /// <summary>
        /// Метод для відображення в таблиці чисел, які більші або рівні нулю
        /// </summary>
        /// <param name="sender">Об'єкт кнопки</param>
        /// <param name="e">Базовый клас для класів, який містить дані властивостей та надає їх</param>
        private void ImageButtonPositive(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(imageButtonPositive.Tag))
            {
                backColor = Color.Orange;
                foreColor = Color.White;
                imageButtonPositive.Tag = false;
                bunifuToolTip.SetToolTip(imageButtonPositive, "Натисніть, щоб прибрати позначки з всіх чисел, які включно більші нуля");
            }
            else
            {
                backColor = Color.White;
                foreColor = Color.Black;
                imageButtonPositive.Tag = true;
                bunifuToolTip.SetToolTip(imageButtonPositive, "Натисніть, щоб відобразити всі числа, які включно більші нуля");
            }
            UpdateData(dataResults, "positive", backColor, foreColor);
            UpdateData(dataSortResults, "positive", backColor, foreColor);
        }
        /// <summary>
        /// Метод для відображення чисел певного типу
        /// </summary>
        /// <param name="data">Таблиця даних</param>
        /// <param name="type">Тип чисел</param>
        /// <param name="backColor">Колір фону комірки</param>
        /// <param name="foreColor">Колір тексту комірки</param>
        private void UpdateData(DataGridView data, string type, Color backColor, Color foreColor)
        {
            for (int i = 0; i < data.RowCount; ++i)
            {
                for (int j = 0; j < data.ColumnCount; ++j)
                {
                    switch (type)
                    {
                        case "negative":
                            if (Convert.ToDouble(data[j, i].Value) < 0)
                            {
                                data[j, i].Style.BackColor = backColor;
                                data[j, i].Style.ForeColor = foreColor;
                            }
                            break;
                        case "positive":
                            if (Convert.ToDouble(data[j, i].Value) >= 0)
                            {
                                data[j, i].Style.BackColor = backColor;
                                data[j, i].Style.ForeColor = foreColor;
                            }
                            break;
                    }
                }
            }
        }
        /// <summary>
        /// Метод для присвоєння кожній комірці перевірок, коли користувач натискає кнопку
        /// </summary>
        /// <param name="sender">Об'єкт комірки таблиці</param>
        /// <param name="e">Базовый клас для класів, який містить дані про можливість зміни властивостей комірки та надає її функціонал</param>
        private void Data_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress += new KeyPressEventHandler(CommonFunctionality.CheckDigit);
            e.Control.KeyPress += MaxLengthTextBox;
        }
        /// <summary>
        /// Метод для перевірки кількості введених символів в одну комірку
        /// </summary>
        /// <param name="sender">Об'єкт комірки таблиці</param>
        /// <param name="e">Базовый клас для класів, який містить дані про властивість натиску на клавішу та надає її функціонал</param>
        private void MaxLengthTextBox(object sender, KeyPressEventArgs e)
        {
            DataGridViewTextBoxEditingControl textCell = (DataGridViewTextBoxEditingControl)sender;
            if (e.KeyChar != (char)Keys.Back && textCell.Text.Length == maxLengthCellText)
            {
                bunifuSnackbar.Show(ParentForm, $"Ви ввели максимальну кількість символів ({maxLengthCellText})");
                e.Handled = true;
            }
        }
    }
}
