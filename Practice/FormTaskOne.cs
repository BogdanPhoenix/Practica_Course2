using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Practice
{
    public partial class FormTaskOne : Form
    {
        /// <summary>
        /// Дані для побудови графіка
        /// </summary>
        private readonly Dictionary<int, double> graphData = new Dictionary<int, double>();
        /// <summary>
        /// Розмір бокової панелі, яка відповідає за виведення графік, коли вона знаходиться у закритому стані
        /// </summary>
        private const int closeWidthPanelRight = 50;
        /// <summary>
        /// Розмір бокової панелі, яка відповідає за виведення графіку, коли вона знаходиться у відкритому стані
        /// </summary>
        private const int openWidthPanelRight = 500;
        /// <summary>
        /// Конструктор
        /// </summary>
        public FormTaskOne()
        {
            InitializeComponent();
            textBoxArgument_1.KeyPress += CommonFunctionality.CheckDigit;
            textBoxArgument_1.KeyPress += MaxLengthTextBox;
            textBoxArgument_2.KeyPress += CommonFunctionality.CheckDigit;
            textBoxArgument_2.KeyPress += MaxLengthTextBox;
            textBoxMax.KeyPress += MaxLengthTextBox;

            textBoxArgument_1.TextChanged += (s, e) => { CheckActive(); };
            textBoxArgument_2.TextChanged += (s, e) => { CheckActive(); };
            textBoxMax.TextChanged += (s, e) => { CheckActive(); };
        }

        #region Пункт 1
        /// <summary>
        /// Маска для поля, яке отримує дані про кількість ітерацій циклу
        /// </summary>
        /// <param name="sender">Об'єкт текстового поля</param>
        /// <param name="e">Базовый клас для класів, який містить дані про властивість натиску на клавішу та надає її функціонал</param>
        private void BunifuTextBoxMax_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = ((e.KeyChar == '0' && textBoxMax.Text.Length == 0) || e.KeyChar == '.' || e.KeyChar == ',' || !char.IsDigit(e.KeyChar)) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Delete;
        }
        /// <summary>
        /// Метод для отримання загальної суми для першого пункту
        /// </summary>
        /// <param name="n">Кількість ітерацій циклу</param>
        /// <param name="x">Аргумент</param>
        /// <returns>Загальна сума</returns>
        private double Sum(int n, double x)
        {
            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += Math.Cos(x * i) / Fact(i);
            }
            return Math.Round(sum, 7);
        }
        /// <summary>
        /// Метод для отримання результату функції
        /// </summary>
        /// <param name="x">Аргумент</param>
        /// <returns>Значення функції</returns>
        private double ResultFunction(double x)
        {
            return Math.Round(Math.Pow(Math.E, Math.Cos(x)) * Math.Cos(Math.Sin(x)), 7);
        }
        #endregion

        #region Пункт 2
        /// <summary>
        /// Метод для переміщення в таблиці даних горизонтальною віссю для побудови графіка
        /// </summary>
        /// <param name="sender">Об'єкт слайдера</param>
        /// <param name="e">Базовый клас для класів, який містить дані про переміщення повзунця та надає його функціонал</param>
        private void PrecisionSlider_Scroll(object sender, Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs e)
        {
            precisionNow.Text = precisionSlider.Value - 1 == 0 ? "1" : $"10<sup>{precisionSlider.Value - 1}</sup>";
        }
        /// <summary>
        /// Метод для отримання загальної суми для другого пункту
        /// </summary>
        /// <param name="x">Аргумент</param>
        /// <returns>Загальна сума</returns>
        private double Sum(double x, double epsi)
        {
            graphData.Clear();
            double buffer, sum = 0;
            int numberElement = 0;
            do
            {
                buffer = Math.Cos(x * numberElement) / Fact(numberElement++);
                sum += buffer;
                graphData.Add(numberElement, Math.Round(sum, 7));
            }
            while (Math.Abs(buffer) >= epsi);
            return Math.Round(sum, 7);
        }
        /// <summary>
        /// Метод для створення таблиці даних для графіка та для побудови графіка
        /// </summary>
        private void CreateTableAndGraph()
        {
            int max, index = 1;
            dataResult.Columns.Clear();
            for (int i = 0; i <= graphData.Count; i++)
            {
                DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn
                {
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                    Frozen = i == 0,
                    HeaderText = $"Column{i}",
                    Name = $"Column{i}",
                    ReadOnly = false,
                    Resizable = DataGridViewTriState.False
                };
                dataResult.Columns.Add(column);
            }
            max = dataResult.ColumnCount - (dataResult.Width / dataResult.Columns[0].Width) + 1;
            if (max <= 0)
            {
                sliderDataResult.Visible = false;
            }
            else
            {
                sliderDataResult.Visible = true;
                sliderDataResult.Maximum = max;
            }
            chart.Series[0].Points.Clear();
            dataResult.Rows.Add("x");
            dataResult.Rows.Add("y");
            foreach (var item in graphData)
            {
                dataResult.Rows[0].Cells[index].Value = item.Key;
                dataResult.Rows[1].Cells[index++].Value = item.Value;
                chart.Series[0].Points.AddXY(item.Key, item.Value);
            }
        }
        /// <summary>
        /// Метод для присвоєння індексу стовпчика який буде відображатися першим
        /// </summary>
        /// <param name="sender">Об'єкт слайдера</param>
        /// <param name="e">Базовый клас для класів, який містить дані про переміщення повзунця та надає його функціонал</param>
        private void SliderDataResult_Scroll(object sender, Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs e)
        {
            try
            {
                dataResult.FirstDisplayedScrollingColumnIndex = dataResult.Columns[e.Value].Index;
            }
            catch { }
        }
        /// <summary>
        /// Метод для відображення поля з графіком та таблицею його даних
        /// </summary>
        /// <param name="sender">Об'єкт кнопки</param>
        /// <param name="e">Базовый клас для класів, який містить дані властивостей та надає їх</param>
        private void ButtonActiveGraph_Click(object sender, EventArgs e)
        {
            if (panelRight.Width == openWidthPanelRight)
            {
                panelRight.Width = closeWidthPanelRight;
                buttonActiveGraph.Image = Properties.Resources.back_arrow_64px;
                bunifuToolTip.SetToolTip(buttonActiveGraph, "Відкрити поле з графіком");
            }
            else
            {
                panelRight.Width = openWidthPanelRight;
                buttonActiveGraph.Image = Properties.Resources.open_arrow_64px;
                bunifuToolTip.SetToolTip(buttonActiveGraph, "Закрити поле з графіком");
            }
        }
        #endregion

        #region Спільний код
        /// <summary>
        /// Метод для відображення сторінки відповідного пункту
        /// </summary>
        /// <param name="sender">Об'єкт кнопки пункта</param>
        /// <param name="e">Базовый клас для класів, який містить дані властивостей та надає їх</param>
        private void SelectPage(object sender, EventArgs e)
        {
            buttonResult.Enabled = false;
            pages.SetPage(((Control)sender).Tag.ToString());
            resultInfo.Text = "Поле для виведення результату";
            resultInfo.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            switch (pages.PageName)
            {
                case "tabPage1":
                    textBoxArgument_1.Text = textBoxMax.Text = "";
                    panelRight.Width = 0;
                    break;
                case "tabPage2":
                    textBoxArgument_2.Text = "";
                    precisionSlider.Value = precisionSlider.Maximum;
                    precisionNow.Text = "1";
                    break;
            }
            CheckActive();
        }
        /// <summary>
        /// Метод для отримання факторіалу вказаного числа
        /// </summary>
        /// <param name="number">Число для факторіалу</param>
        /// <returns>Факторіал вкащаного числа</returns>
        private int Fact(int number)
        {
            return number == 0 ? 1 : number * Fact(number - 1);
        }
        /// <summary>
        /// Метод для отримання результату для кожного пункту
        /// </summary>
        /// <param name="sender">Об'єкт кнопки</param>
        /// <param name="e">Базовый клас для класів, який містить дані властивостей та надає їх</param>
        private void ButtonResult_Click(object sender, EventArgs e)
        {
            resultInfo.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            switch (pages.PageName)
            {
                case "tabPage1":
                    resultInfo.Text = $@"Рівняння: <sup>n</sub>&#8721<sub>i=0</sub> cos(x * i) / i!
                                      Функція: y = e<sup>cos x</sup>cos(sin x)
                                      Дані: x = {textBoxArgument_1.Text}; n = {textBoxMax.Text}
                                      Результат: рівняння = {Sum(Convert.ToInt32(textBoxMax.Text), Convert.ToDouble(textBoxArgument_1.Text))};
                                      функція = {ResultFunction(Convert.ToDouble(textBoxArgument_1.Text))}";
                    break;
                case "tabPage2":
                    resultInfo.Text = $@"Рівняння: <sup>n</sub>&#8721<sub>i=0</sub> cos(x * i) / i!
                                      Дані: x = {textBoxArgument_2.Text}; &#949 = 10<sup>{precisionSlider.Value - 1}</sup>; n = +&#8734
                                      Результат: {Sum(Convert.ToDouble(textBoxArgument_2.Text), Math.Pow(10, precisionSlider.Value - 1))}; 
                                      кількість елементів {graphData.Count}";
                    CreateTableAndGraph();
                    if (panelRight.Width == 0)
                    {
                        panelRight.Width = closeWidthPanelRight;
                    }
                    break;
            }
        }
        /// <summary>
        /// Метод для перевірки чи зробити кнопку "Результат" активною чи ні
        /// </summary>
        private void CheckActive()
        {
            switch (pages.PageName)
            {
                case "tabPage1":
                    buttonResult.Enabled = textBoxArgument_1.Text.Length > 0 && textBoxMax.Text.Length > 0;
                    break;
                case "tabPage2":
                    buttonResult.Enabled = textBoxArgument_2.Text.Length > 0;
                    break;
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
        #endregion
    }
}
