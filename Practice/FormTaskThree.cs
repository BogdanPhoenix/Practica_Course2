using Bunifu.UI.WinForms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Practice
{
    public partial class FormTaskThree : Form
    {
        private const int digits = 6;
        /// <summary>
        /// Розмір бокової панелі, яка відповідає за виведення графік, коли вона знаходиться у закритому стані
        /// </summary>
        private const int closeWidthPanelRight = 50;
        /// <summary>
        /// Розмір бокової панелі, яка відповідає за виведення графіку, коли вона знаходиться у відкритому стані
        /// </summary>
        private const int openWidthPanelRight = 500;
        /// <summary>
        /// Батьківська форма
        /// </summary>
        private readonly Form cloneParentForm;
        /// <summary>
        /// Об'єкт активної кнопки побудованого графіка
        /// </summary>
        private BunifuImageButton currentFunction;
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="parentForm">Об'єкт батьківської форми</param>
        public FormTaskThree(Form parentForm)
        {
            InitializeComponent();
            cloneParentForm = parentForm;

            minX.KeyPress += CommonFunctionality.CheckDigit;
            maxX.KeyPress += CommonFunctionality.CheckDigit;
            stepX.KeyPress += CommonFunctionality.CheckDigit;
        }

        #region Function
        /// <summary>
        /// Метод для обчислення результату першої формули
        /// </summary>
        /// <param name="x">Аргумент</param>
        /// <returns>Значення функції. При ОДЗ повертається прочерк</returns>
        private object FunctionOne(double x)
        {
            if (x == 0 || Math.Abs(x) == 1)
            {
                return "-";
            }
            return Math.Round(1 / (Math.Pow(x, 2) * (1 - Math.Pow(x, 4))), digits);
        }
        /// <summary>
        /// Метод для обчислення результату другої формули
        /// </summary>
        /// <param name="x">Аргумент</param>
        /// <returns>Значення функції. При ОДЗ повертається прочерк</returns>
        private object FunctionTwo(double x)
        {
            if (x <= -1)
            {
                return "-";
            }
            return Math.Round(Math.Pow(x, 2) / Math.Sqrt(1 + Math.Pow(x, 3)), digits);
        }
        /// <summary>
        /// Метод для обчислення результату третьої формули
        /// </summary>
        /// <param name="x">Аргумент</param>
        /// <returns>Значення функції. При ОДЗ повертається прочерк</returns>
        private object FunctionThree(double x)
        {
            double buffer = Math.Pow(1 - Math.Pow(Math.Sin(x), 3), 1.0 / 3);
            if (buffer == 0)
            {
                return "-";
            }
            return Math.Round(1 / buffer, digits);
        }
        /// <summary>
        /// Метод для обчислення результату четвертої формули
        /// </summary>
        /// <param name="x">Аргумент</param>
        /// <returns>Значення функції. При ОДЗ повертається прочерк</returns>
        private object FunctionFour(double x)
        {
            if (x == 0)
            {
                return "-";
            }
            return Math.Round(1 / (Math.Pow(x, 2) * Math.Exp(Math.Pow(x, 2))), digits);
        }
        /// <summary>
        /// Метод для обчислення результату п'ятої формули
        /// </summary>
        /// <param name="x">Аргумент</param>
        /// <returns>Значення функції. При ОДЗ повертається прочерк</returns>
        private object FunctionFive(double x)
        {
            double buffer = Math.Pow(Math.Cosh(x), 2);
            if (buffer == 0)
            {
                return "-";
            }
            return Math.Round(1 / buffer, digits);
        }
        /// <summary>
        /// Метод для обчислення результату шостої формули
        /// </summary>
        /// <param name="x">Аргумент</param>
        /// <returns>Значення функції. При ОДЗ повертається прочерк</returns>
        private object FunctionSix(double x)
        {
            if (x <= 1 || x == 2)
            {
                return "-";
            }
            return Math.Round(x / Math.Pow(Math.Log(x - 1), 2), digits);
        }
        /// <summary>
        /// Метод для обчислення результату сьомої формули
        /// </summary>
        /// <param name="x">Аргумент</param>
        /// <returns>Значення функції. При ОДЗ повертається прочерк</returns>
        private object FunctionSeven(double x)
        {
            double buffer = Math.Cosh(Math.Sin(x));
            if (buffer == 0)
            {
                return "-";
            }
            return Math.Round(1 / buffer, digits);
        }
        #endregion
        #region Graph
        /// <summary>
        /// Метод для побудови графіка до формули №1
        /// </summary>
        /// <param name="dig">Кількість знаків після коми</param>
        private void GraphOne(int dig)
        {
            int series;
            double buffer;
            for (int i = 0; i < dataResult.RowCount; ++i)
            {
                if (!dataResult.Rows[i].Cells[1].Value.Equals("-"))
                {
                    buffer = Math.Round(Convert.ToDouble(dataResult.Rows[i].Cells[0].Value.ToString()), dig);
                    if (buffer < -1)
                    {
                        series = 0;
                    }
                    else if (buffer < 0)
                    {
                        series = 1;
                    }
                    else if (buffer < 1)
                    {
                        series = 2;
                    }
                    else
                    {
                        series = 3;
                    }
                    chart.Series[series].Points.AddXY(buffer, Math.Round(Convert.ToDouble(dataResult.Rows[i].Cells[1].Value), dig));
                }
            }
        }
        /// <summary>
        /// Метод для побудови графіка до формули №2
        /// </summary>
        /// <param name="dig">Кількість знаків після коми</param>
        private void GraphTwo(int dig)
        {
            double buffer;
            for (int i = 0; i < dataResult.RowCount; ++i)
            {
                if (!dataResult.Rows[i].Cells[2].Value.Equals("-"))
                {
                    buffer = Math.Round(Convert.ToDouble(dataResult.Rows[i].Cells[0].Value.ToString()), dig);

                    if (buffer > -1)
                    {
                        chart.Series[0].Points.AddXY(buffer, Math.Round(Convert.ToDouble(dataResult.Rows[i].Cells[2].Value), dig));
                    }
                }
            }
        }
        /// <summary>
        /// Метод для побудови графіка до формули №3
        /// </summary>
        /// <param name="dig">Кількість знаків після коми</param>
        private void GraphThree(int dig)
        {
            double buffer;
            for (int i = 0; i < dataResult.RowCount; ++i)
            {
                if (!dataResult.Rows[i].Cells[3].Value.Equals("-"))
                {
                    if (dataResult.Rows[i].Cells[0].Value.ToString().EndsWith("π"))
                    {
                        buffer = GetPi(dataResult.Rows[i].Cells[0].Value.ToString(), dig);
                    }
                    else
                    {
                        buffer = Math.Round(Convert.ToDouble(dataResult.Rows[i].Cells[0].Value.ToString()), dig);
                    }

                    chart.Series[0].Points.AddXY(buffer, Math.Round(Convert.ToDouble(dataResult.Rows[i].Cells[3].Value), dig));
                }
            }
        }
        /// <summary>
        /// Метод для побудови графіка до формули №4
        /// </summary>
        /// <param name="dig">Кількість знаків після коми</param>
        private void GraphFour(int dig)
        {
            double buffer;
            for (int i = 0; i < dataResult.RowCount; ++i)
            {
                if (!dataResult.Rows[i].Cells[4].Value.Equals("-"))
                {
                    buffer = Math.Round(Convert.ToDouble(dataResult.Rows[i].Cells[0].Value.ToString()), dig);
                    chart.Series[buffer < 0 ? 0 : 1].Points.AddXY(buffer, Math.Round(Convert.ToDouble(dataResult.Rows[i].Cells[4].Value), dig));
                }
            }
        }
        /// <summary>
        /// Метод для побудови графіка до формули №5
        /// </summary>
        /// <param name="dig">Кількість знаків після коми</param>
        private void GraphFive(int dig)
        {
            double buffer;
            for (int i = 0; i < dataResult.RowCount; ++i)
            {
                if (!dataResult.Rows[i].Cells[5].Value.Equals("-"))
                {
                    if (dataResult.Rows[i].Cells[0].Value.ToString().EndsWith("π"))
                    {
                        buffer = GetPi(dataResult.Rows[i].Cells[0].Value.ToString(), dig);
                    }
                    else
                    {
                        buffer = Math.Round(Convert.ToDouble(dataResult.Rows[i].Cells[0].Value.ToString()), dig);
                    }
                    chart.Series[0].Points.AddXY(buffer, Math.Round(Convert.ToDouble(dataResult.Rows[i].Cells[5].Value), dig));
                }
            }
        }
        /// <summary>
        /// Метод для побудови графіка до формули №6
        /// </summary>
        /// <param name="dig">Кількість знаків після коми</param>
        private void GraphSix(int dig)
        {
            double buffer;
            for (int i = 0; i < dataResult.RowCount; ++i)
            {
                if (!dataResult.Rows[i].Cells[6].Value.Equals("-"))
                {
                    buffer = Math.Round(Convert.ToDouble(dataResult.Rows[i].Cells[0].Value.ToString()), dig);
                    chart.Series[buffer < 2 ? 0 : 1].Points.AddXY(buffer, Math.Round(Convert.ToDouble(dataResult.Rows[i].Cells[6].Value), dig));
                }
            }
        }
        /// <summary>
        /// Метод для побудови графіка до формули №7
        /// </summary>
        /// <param name="dig">Кількість знаків після коми</param>
        private void GraphSeven(int dig)
        {
            double buffer;
            for (int i = 0; i < dataResult.RowCount; ++i)
            {
                if (!dataResult.Rows[i].Cells[7].Value.Equals("-"))
                {
                    if (dataResult.Rows[i].Cells[0].Value.ToString().EndsWith("π"))
                    {
                        buffer = GetPi(dataResult.Rows[i].Cells[0].Value.ToString(), dig);
                    }
                    else
                    {
                        buffer = Math.Round(Convert.ToDouble(dataResult.Rows[i].Cells[0].Value.ToString()), dig);
                    }
                    chart.Series[0].Points.AddXY(buffer, Math.Round(Convert.ToDouble(dataResult.Rows[i].Cells[7].Value), dig));
                }
            }
        }
        /// <summary>
        /// Метод для отримання аргумента з числом π для тригонометричних функцій
        /// </summary>
        /// <param name="text">Дані з таблиці</param>
        /// <param name="dig">Кількість знаків після коми</param>
        /// <returns>Значення аргументу з числом π</returns>
        private double GetPi(string text, int dig)
        {
            text = text.Substring(0, text.LastIndexOf("π"));
            return Math.Round(Convert.ToDouble(text) * Math.PI, dig);
        }
        #endregion
        /// <summary>
        /// Метод для обчислення результату та заповнення таблиці даних
        /// </summary>
        /// <param name="sender">Об'єкт кнопки</param>
        /// <param name="e">Базовый клас для класів, який містить дані властивостей та надає їх</param>
        private void ButtonResult_Click(object sender, EventArgs e)
        {
            labelInfo.Visible = false;
            tableLayoutPanelFunction.Visible = true;
            dataResult.Rows.Clear();
            double min = Convert.ToDouble(minX.Text);
            double max = Convert.ToDouble(maxX.Text);
            double step = Convert.ToDouble(stepX.Text);
            int dig = stepX.Text.Length - stepX.Text.IndexOf(',') - 1;
            double pi = min == 0 ? 0.25 : Math.Ceiling(min / Math.PI);
            for (double i = min; i <= max; i += step)
            {
                i = Math.Round(i, dig);
                if (i != 0 && Math.Round(pi * Math.PI, dig) == i)
                {
                    dataResult.Rows.Add($"{pi}π", "-", "-", FunctionThree(pi * Math.PI), "-", FunctionFive(pi * Math.PI), "-", FunctionSeven(pi * Math.PI));
                    pi += 0.25;
                    i -= step;
                    if (pi == 0)
                    {
                        pi += 0.25;
                    }
                }
                else
                {
                    dataResult.Rows.Add(i, FunctionOne(i), FunctionTwo(i), FunctionThree(i), FunctionFour(i), FunctionFive(i), FunctionSix(i), FunctionSeven(i));
                }
            }
            CreateGraph(buttonFunction1, new EventArgs());
            if (panelRight.Width == 1)
            {
                panelRight.Width = closeWidthPanelRight;
            }
        }
        /// <summary>
        /// Метод для перевірки чи користувач заповнив всі необхідні поля перед отриманням результату
        /// </summary>
        /// <param name="sender">Об'єкт кнопки</param>
        /// <param name="e">Базовый клас для класів, який містить дані властивостей та надає їх</param>
        private void CheckActive(object sender, EventArgs e)
        {
            buttonResult.Enabled = minX.Text.Length > 0 && maxX.Text.Length > 0 && stepX.Text.Length > 0;
        }
        /// <summary>
        /// Метод для створення графіка функції, які залежить від від вибраної функції
        /// </summary>
        /// <param name="sender">Об'єкт кнопки</param>
        /// <param name="e">Базовый клас для класів, який містить дані властивостей та надає їх</param>
        private void CreateGraph(object sender, EventArgs e)
        {
            if (currentFunction != null)
            {
                currentFunction.BackColor = Color.Transparent;
                bunifuToolTip.SetToolTip(currentFunction, "Натисніть, щоб побудувати графік функції");
            }
            currentFunction = (BunifuImageButton)sender;
            currentFunction.BackColor = Color.FromArgb(102, 204, 51);
            bunifuToolTip.SetToolTip(currentFunction, "Побудовано графік даної функції");

            int dig = stepX.Text.Length - stepX.Text.IndexOf(',') - 1;
            for (int i = 0; i < chart.Series.Count; ++i)
            {
                chart.Series[i].Points.Clear();
            }
            int index = Convert.ToInt32(((BunifuImageButton)sender).Tag.ToString());
            switch (index)
            {
                case 1: GraphOne(dig); break;
                case 2: GraphTwo(dig); break;
                case 3: GraphThree(dig); break;
                case 4: GraphFour(dig); break;
                case 5: GraphFive(dig); break;
                case 6: GraphSix(dig); break;
                case 7: GraphSeven(dig); break;
            }
        }
        /// <summary>
        /// Метод для відкріття бокового вікна з графіком функції
        /// </summary>
        /// <param name="sender">Об'єкт кнопки</param>
        /// <param name="e">Базовый клас для класів, який містить дані властивостей та надає їх</param>
        private void ButtonActiveGraph_Click(object sender, EventArgs e)
        {
            if (panelRight.Width == openWidthPanelRight)
            {
                panelRight.Width = closeWidthPanelRight;
                ParentForm.Width -= openWidthPanelRight - closeWidthPanelRight;
                buttonActiveGraph.Image = Properties.Resources.open_arrow_64px;
                buttonActiveGraph.Tag = false;
                bunifuToolTip.SetToolTip(buttonActiveGraph, "Відкрити поле з графіком");
            }
            else
            {
                panelRight.Width = openWidthPanelRight;
                ParentForm.Width += openWidthPanelRight - closeWidthPanelRight;
                buttonActiveGraph.Image = Properties.Resources.back_arrow_64px;
                buttonActiveGraph.Tag = true;
                bunifuToolTip.SetToolTip(buttonActiveGraph, "Закрити поле з графіком");
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
    }
}
