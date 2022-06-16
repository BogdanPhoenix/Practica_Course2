using Bunifu.UI.WinForms;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Practice
{
    public partial class FormTaskTwo : Form
    {
        /// <summary>
        /// Вектор
        /// </summary>
        private double[] X, Y;
        /// <summary>
        /// Матриця
        /// </summary>
        private double[,] A;
        /// <summary>
        /// Максимальний елемент вектора Х
        /// </summary>
        private double m;
        /// <summary>
        /// Розмір за замовчування панелі із відображенням векторів та матриці
        /// </summary>
        private const int panelSetDateDefaultSize = 115;
        /// <summary>
        /// Максимальна кількість символів яку можна ввести в комірку
        /// </summary>
        private const int maxLengthCellText = 8;
        /// <summary>
        /// Конструктор
        /// </summary>
        public FormTaskTwo()
        {
            InitializeComponent();
            CheckSize();
            sizeVector.Scroll += (s, e) => { CheckSize(); };
        }
        /// <summary>
        /// Метод для зміни розміру векторів та матриці.
        /// Також відбувається графічне змінення розмірів таблиць
        /// </summary>
        private void CheckSize()
        {
            sizeVectorNow.Text = sizeVector.Value.ToString();
            X = new double[sizeVector.Value];
            Y = new double[sizeVector.Value];
            A = new double[sizeVector.Value, sizeVector.Value];
            CreateVector(dataVectorX, sizeVector.Value);
            CreateVector(dataVectorY, sizeVector.Value);
            CreateMatrix(dataMatrix, sizeVector.Value);
        }
        /// <summary>
        /// Метод для створення вектору та його графічного відображення
        /// </summary>
        /// <param name="data">Об'єкт таблиці</param>
        /// <param name="vectorSize">Розмір вектора</param>
        private void CreateVector(BunifuDataGridView data, int vectorSize)
        {
            data.Columns.Clear();
            data.Rows.Clear();
            int columnWidth = data.Width / vectorSize;
            for (int i = 0; i < vectorSize; i++)
            {
                data.Columns.Add(new DataGridViewTextBoxColumn() { Name = $"Column{i}", Width = columnWidth, Resizable = DataGridViewTriState.False });
            }
            data.Rows.Add();
        }
        /// <summary>
        /// Метод для створення матриці та її графічного відображення
        /// </summary>
        /// <param name="data">Об'єкт таблиці</param>
        /// <param name="matrixSize">Розмір квадратної матриці</param>
        private void CreateMatrix(BunifuDataGridView data, int matrixSize)
        {
            CreateVector(data, matrixSize);
            for (int i = data.RowCount; i < matrixSize; i++)
            {
                data.Rows.Add();
            }
            panelSetDate.Height = panelSetDateDefaultSize + data.RowHeadersWidth * (matrixSize - 1);
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
        /// Метод для зчитування даних у вектор
        /// </summary>
        /// <param name="data">Таблиця даних</param>
        /// <returns>Вектор даних, які були отримані з таблиці</returns>
        private double[] ReadVector(BunifuDataGridView data)
        {
            double[] buffer = new double[data.ColumnCount];
            for (int i = 0; i < data.ColumnCount; ++i)
            {
                buffer[i] = Convert.ToDouble(data.Rows[0].Cells[i].Value);
            }
            return buffer;
        }
        /// <summary>
        /// Метод для зчитування даних в матрицю
        /// </summary>
        /// <param name="data">Таблиця даних</param>
        /// <returns>Матрицю даних, які були отримані з таблиці</returns>
        private double[,] ReadMatrix(BunifuDataGridView data)
        {
            double[,] buffer = new double[data.RowCount, data.ColumnCount];
            for (int i = 0; i < data.RowCount; ++i)
            {
                for (int j = 0; j < data.ColumnCount; ++j)
                {
                    buffer[i, j] = Convert.ToDouble(data.Rows[i].Cells[j].Value);
                }
            }
            return buffer;
        }
        /// <summary>
        /// Метод для отримання результату
        /// </summary>
        /// <param name="sender">Об'єкт кнопки</param>
        /// <param name="e">Базовый клас для класів, який містить дані властивостей та надає їх</param>
        private void Result_Click(object sender, EventArgs e)
        {
            try
            {
                X = ReadVector(dataVectorX);
                Y = ReadVector(dataVectorY);
                A = ReadMatrix(dataMatrix);
                m = X.Max();
                resultInfo.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
                resultInfo.Text = $"Рівняння: B = m<sup>n</sub>&#8721<sub>i=1</sub>x<sub>i</sub><sup>n</sub>&#8721<sub>k=1</sub>a<sub>ik</sub>y<sub>k</sub> <br><br>Результат: B = {Calculation()}";
            }
            catch(Exception ex) 
            {
                MessageBox.Show($"Під час обчислення сталася помилка. \nТекст помилки: {ex.Message}", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        /// <summary>
        /// Метод для обчистення даних
        /// </summary>
        /// <returns>Суму функції</returns>
        private double Calculation()
        {
            double result = 0, buffer;

            for (int i = 0; i < sizeVector.Value; ++i)
            {
                buffer = 0;

                for (int k = 0; k < sizeVector.Value; ++k)
                {
                    buffer += A[i, k] * Y[k];
                }

                result += X[i] * buffer;
            }

            return result * m;
        }
        /// <summary>
        /// Метод для перевірки чи заповнений вектор
        /// </summary>
        /// <param name="data">Об'єкт таблиці</param>
        /// <param name="indexRow">Номер рядка</param>
        /// <returns>true якщо вектор є повністю заповненим, а інакше - false</returns>
        private bool CheckVector(BunifuDataGridView data, int indexRow)
        {
            if (data.Rows.Count == 0)
            {
                return false;
            }
            for (int i = 0; i < data.ColumnCount; ++i)
            {
                if (data.Rows[indexRow].Cells[i].Value == null || data.Rows[indexRow].Cells[i].Value.Equals(""))
                {
                    return false;
                }
            }

            return true;
        }
        /// <summary>
        /// Метод для перевірки чи заповнена матриця
        /// </summary>
        /// <param name="data">Об'єкт таблиці</param>
        /// <returns>true якщо матриця є повністю заповнена, а інакше - false</returns>
        private bool CheckMatrix(BunifuDataGridView data)
        {
            for(int i = 0; i < data.RowCount; ++i)
            {
                if (!CheckVector(data, i))
                {
                    return false;
                }
            }

            return true;
        }
        /// <summary>
        /// Метод для запуску перевірки чи заповнені всі комірки таблиці
        /// </summary>
        /// <param name="sender">Об'єкт комірки таблиці</param>
        /// <param name="e">Базовый клас для класів, який містить дані про властивості взаємодії з комірками та надає їх функціонал</param>
        private void CheckCellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            buttonResult.Enabled = CheckVector(dataVectorX, 0) && CheckVector(dataVectorY, 0) && CheckMatrix(dataMatrix);
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
