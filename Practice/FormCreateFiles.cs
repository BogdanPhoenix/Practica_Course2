using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace Practice
{
    public partial class FormCreateFiles : Form
    {
        private DataTable dataTable = null;
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
