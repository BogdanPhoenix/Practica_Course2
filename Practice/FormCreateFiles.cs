using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace Practice
{
    public partial class FormCreateFiles : Form
    {
        /// <summary>
        /// Таблиця в яку заносяться дані із файлу
        /// </summary>
        private DataTable dataTable = null;
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="nameFileSave">Шлях до файла</param>
        /// <param name="data"></param>
        public FormCreateFiles(string nameFileSave, DataGridView data)
        {
            InitializeComponent();

            dropdownTypeFile.SelectedIndex = 0;

            bunifuButtonClose.Click += (s, e) => { Hide(); };
            bunifuButtonMinimized.Click += (s, e) => { WindowState = FormWindowState.Minimized; };
            ReadData(data);
            if (nameFileSave.Length > 0)
            {
                buttonSave.Enabled = true;
                dropdownTypeFile.Text = Path.GetExtension(nameFileSave);
                DropdownTypeFile_SelectedIndexChanged(new object(), new EventArgs());
            }
            dropdownTypeSave.SelectedIndexChanged += (s, e) => { CheckNumbering(); };
        }
        /// <summary>
        /// Метод для зчитування даних з графічної таблиці у звичайну для подальшого зберігання
        /// </summary>
        /// <param name="dataGridView"></param>
        private void ReadData(DataGridView dataGridView)
        {
            dataTable = new DataTable();
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                dataTable.Columns.Add(column.HeaderText);
            }

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                dataTable.Rows.Add();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null)
                    {
                        dataTable.Rows[dataTable.Rows.Count - 1][cell.ColumnIndex] = cell.Value.ToString();
                    }
                }
            }
        }
        /// <summary>
        /// Метод для варіанту зберігання даних у файл
        /// </summary>
        /// <param name="sender">Об'єкт кнопки</param>
        /// <param name="e">Базовый клас для класів, який містить дані властивостей та надає їх</param>
        private void DropdownTypeFile_SelectedIndexChanged(object sender, EventArgs e)
        {
            dropdownTypeSave.Items.Clear();
            switch (dropdownTypeFile.Text)
            {
                case ".txt": dropdownTypeSave.Items.Add("лише список"); break;
                case ".docx":
                case ".xlsx":
                    dropdownTypeSave.Items.Add("список");
                    dropdownTypeSave.Items.Add("таблиця");
                    break;
            }
            dropdownTypeSave.SelectedIndex = 0;
            CheckNumbering();
        }
        /// <summary>
        /// Метод для перевірки чи відображати поле для вибору додання номерації чи ні
        /// </summary>
        private void CheckNumbering()
        {
            if(dropdownTypeFile.Text == ".xlsx" || dropdownTypeSave.Text.ToLower() == "таблиця")
            {
                checkBoxAddNumbering.Visible = labelAddNumbering.Visible = false;
                checkBoxAddNumbering.Checked = false;
            }
            else
            {
                checkBoxAddNumbering.Visible = labelAddNumbering.Visible = true;
            }
        }
        /// <summary>
        /// Метод для вибору файлу в який буде здійснюватися зберігання
        /// </summary>
        /// <param name="sender">Об'єкт кнопки</param>
        /// <param name="e">Базовый клас для класів, який містить дані властивостей та надає їх</param>
        private void ButtonImport_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = $"File (*{dropdownTypeFile.Text})|*{dropdownTypeFile.Text}";
            textBoxPathFile.Text = saveFileDialog.ShowDialog() == DialogResult.OK ? saveFileDialog.FileName : textBoxPathFile.Text;
            if (!textBoxPathFile.Text.EndsWith(dropdownTypeFile.Text))
            {
                textBoxPathFile.Text += dropdownTypeFile.Text;
            }
            buttonSave.Enabled = textBoxPathFile.Text.Length > 0;
        }
        /// <summary>
        /// Метод для збереження даних у файл
        /// </summary>
        /// <param name="sender">Об'єкт кнопки</param>
        /// <param name="e">Базовый клас для класів, який містить дані властивостей та надає їх</param>
        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (textBoxPathFile.Text.EndsWith(dropdownTypeFile.Text))
            {
                try
                {
                    switch (dropdownTypeFile.Text)
                    {
                        case ".txt": TXTDocument.ExportTXTFile(textBoxPathFile.Text, dataTable, checkBoxAddNumbering.Checked); break;
                        case ".docx":
                            switch (dropdownTypeSave.Text)
                            {
                                case "список": WordDocument.ExportWordListFile(textBoxPathFile.Text, dataTable, checkBoxAddNumbering.Checked); break;
                                case "таблиця": WordDocument.ExportWordTableFile(textBoxPathFile.Text, dataTable); break;
                            }
                            break;
                        case ".xlsx": ExcelDocument.ExportExcelTableFile(textBoxPathFile.Text, dataTable, dropdownTypeSave.Text.Equals("таблиця")); break;
                        default: MessageBox.Show("Даний тип файлу відсутній у списку. Виберіть доступний файл.", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
                    }
                    MessageBox.Show("Файл було успішно створенно.", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Під час збереження файлу ствлвся помилка. \nТекст помилки: {ex.Message}", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show($"Розширення файлу, яке ви ввели не збігається з тим, що вибране в пункті \"Тип файлу\". Вкажіть відповідний тип файлу", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
