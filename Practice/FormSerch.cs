using System;
using System.Drawing;
using System.Windows.Forms;

namespace Practice
{
    public partial class FormSerch : Form
    {
        /// <summary>
        /// Індекс рядка для взаємодії з коміркою
        /// </summary>
        private int indexRow = -1;
        /// <summary>
        /// Індекс колонки для взаємодії з коміркою
        /// </summary>
        private int indexColumn = -1;
        /// <summary>
        /// Властивість для взаємодії з таблицею, яка знаходиться в батьківській формі
        /// </summary>
        public DataGridView Data { get; set; }
        /// <summary>
        /// Властивість для перевірки чи можна здійснювати пошук чи ні
        /// </summary>
        public bool IsSearch { get; set; }
        /// <summary>
        /// Конструктор
        /// </summary>
        public FormSerch()
        {
            InitializeComponent();

            textBoxIndex.KeyPress += CommonFunctionality.OnlyDigit;
            textBoxIndex.KeyPress += TextBoxIndex_KeyPress;

            bunifuButtonClose.Click += (s, e) => { Hide(); };
            bunifuButtonMinimized.Click += (s, e) => { WindowState = FormWindowState.Minimized; };
        }
        /// <summary>
        /// Метод для перевірки номер числа в ряду, який ввів користувач. Якщо він вільший за максимльну довжину ряду, то виводиться відповідне повідомлення
        /// </summary>
        /// <param name="sender">Об'єкт текстового поля</param>
        /// <param name="e">Базовый клас для класів, який містить дані про властивість натиску на клавішу та надає її функціонал</param>
        private void TextBoxIndex_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Back && Convert.ToInt32(textBoxIndex.Text + e.KeyChar) > Data.RowCount * Data.ColumnCount)
            {
                e.Handled = true;
                bunifuSnackbar.Show(this, $"Максимально допустимий індекс становить {Data.RowCount * Data.ColumnCount}");
            }
            else if (e.KeyChar == (char)Keys.Enter)
            {
                ButtonSearch_Click(buttonSearch, new EventArgs());
            }
        }
        /// <summary>
        /// Метод для графічного відображення комірки, номер числа якої ввів користувач
        /// </summary>
        /// <param name="sender">Об'єкт кнопки</param>
        /// <param name="e">Базовый клас для класів, який містить дані властивостей та надає їх</param>
        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            if (IsSearch)
            {
                if (indexRow >= 0 && indexColumn >= 0)
                {
                    Data[indexColumn, indexRow].Style.BackColor = Color.White;
                    Data[indexColumn, indexRow].Style.ForeColor = Color.Black;
                }
                int index = Convert.ToInt32(textBoxIndex.Text) - 1;
                indexRow = index / Data.ColumnCount;
                indexColumn = index - Data.ColumnCount * indexRow;
                Data[indexColumn, indexRow].Style.BackColor = Color.Green;
                Data[indexColumn, indexRow].Style.ForeColor = Color.White;
                labelResult.Text = Data[indexColumn, indexRow].Value == null ? "Дана клітинка є пустою" : Data[indexColumn, indexRow].Value.ToString();
            }
            else
            {
                bunifuSnackbar.Show(this, "Пошук виконати не можливо. В даній таблиці допущені помилки. Виправіть їх та продовжте пошук.");
            }
        }
        /// <summary>
        /// Метод для скидання полів у форми після оновлення таблиці в батьківській формі
        /// </summary>
        public void UpdateForm()
        {
            textBoxIndex.Text = "";
            labelResult.Text = "Дані відсутні";
        }
    }
}
