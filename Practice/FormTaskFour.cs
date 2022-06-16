using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using System.IO;
using Bunifu.UI.WinForms.BunifuButton;
using Bunifu.UI.WinForms;

namespace Practice
{
    public partial class FormTaskFour : Form
    {
        private Dictionary<int, decimal> fibonachi = new Dictionary<int, decimal>();
        private Dictionary<int, decimal> extraError = new Dictionary<int, decimal>();
        private Dictionary<int, decimal> duplicatError = new Dictionary<int, decimal>();

        private static DataTable dataTable = null;

        private const int widthColumn = 150;
        public FormTaskFour()
        {
            InitializeComponent();
            openFileDialog.Filter = "All file(*.*)|*.*";

            buttonSearch.Click += (s, e) => { textBoxPathFile.Text = openFileDialog.ShowDialog() == DialogResult.OK ? openFileDialog.FileName : textBoxPathFile.Text; };
            buttonResult.Click += (s, e) => { DataResultPrint(FibonachiNumbers()); };
            buttonError.Click += (s, e) => { DeleteErrorOrDuplication(s, extraError); };
            buttonDuplication.Click += (s, e) => { DeleteErrorOrDuplication(s, duplicatError); };

            textBoxPathFile.TextChanged += (s, e) => { buttonImport.Enabled = textBoxPathFile.Text.Length != 0; };
            textBoxMaxNumber.TextChanged += (s, e) => { buttonResult.Enabled = textBoxMaxNumber.Text.Length != 0; };

            this.Resize += (s, e) => { DataResultPrint(fibonachi); };
        }

        private Dictionary<int, decimal> FibonachiNumbers()
        {
            Dictionary<int, decimal> trueResult = new Dictionary<int, decimal>() { {0, 0}, { 1, 1 } };
            decimal number = trueResult[trueResult.Count - 1];
            decimal max = Convert.ToDecimal(textBoxMaxNumber.Text);
            int index = trueResult.Count;
            while (true)
            {
                try
                {
                    number += trueResult[trueResult.Count - 2];
                    if (number > max)
                    {
                        break;
                    }
                    trueResult.Add(index++, number);
                }
                catch
                {
                    break;
                }
            }
            return trueResult;
        }

        private void DataResultPrint(Dictionary<int, decimal> dictionary)
        {
            dataResults.Columns.Clear();
            if (textBoxMaxNumber.Text.Length != 0)
            {
                labelErrorData.Height = 0;
                buttonCreate.Enabled = dataResults.Visible = true;

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
            }
            else
            {
                labelErrorData.Height = 200;
                buttonCreate.Enabled = dataResults.Visible = false;
            }
        }

        private void CheckEqualsError()
        {
            extraError.Clear();
            Dictionary<int, decimal> trueResult = FibonachiNumbers();
            foreach(var item in fibonachi)
            {
                if (!trueResult.ContainsValue(item.Value))
                {
                    extraError.Add(item.Key, item.Value);
                }
            }

            buttonError.Visible = extraError.Count > 0;
            buttonError.ToolTipText = $"Виявлено дані, які не входять в ряд Фібоначі. ({extraError.Count})";
        }
        private void CheckEqualsWarning()
        {
            int index = 0;
            var sortedDict = from entry in fibonachi orderby entry.Value ascending select entry;
            Dictionary<int, decimal> buffer = sortedDict.ToDictionary(entry => index++, entry => entry.Value);
            buttonWarning.Visible = !EqualsDictionary(fibonachi, buffer);
        }
        private bool EqualsDictionary(Dictionary<int, decimal> dictionatyOne, Dictionary<int, decimal> dictionaryTwo)
        {
            if(dictionatyOne.Count != dictionaryTwo.Count)
            {
                return false;
            }
            foreach(var item in dictionatyOne)
            {
                if (!dictionaryTwo[item.Key].Equals(item.Value))
                {
                    return false;
                }
            }
            return true;
        }
        private void CheckEqualsDuplication()
        {
            duplicatError.Clear();
            int indexOne = 0;
            var result = fibonachi.GroupBy(kvp => kvp.Value).ToDictionary(grp => grp.First().Key, grp => grp.Key);
            foreach(var item in fibonachi)
            {
                if (!result.ContainsKey(item.Key))
                {
                    if(item.Value == 1 && indexOne++ < 1)
                    {
                        continue;
                    }
                    duplicatError.Add(item.Key, item.Value);
                }
            }
            buttonDuplication.Visible = duplicatError.Count > 0;
            buttonDuplication.ToolTipText = $"Виявлено дані, які повторюються. ({duplicatError.Count})";
        }
        private void UpdateData(Dictionary<int, decimal> indexs, Color color)
        {
            int indexRow, indexColumn;
            foreach(var item in indexs)
            {
                indexRow = item.Key / dataResults.ColumnCount;
                indexColumn = item.Key - dataResults.ColumnCount * indexRow;
                dataResults.Rows[indexRow].Cells[indexColumn].Style.BackColor = color;
            }
        }
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

        private void ButtonCreate_Click(object sender, EventArgs e)
        {
            FormCreateFiles createFiles = new FormCreateFiles(textBoxPathFile.Text, dataResults);
            createFiles.ShowDialog();
            createFiles.Close();
        }

        private void ButtonImport_Click(object sender, EventArgs e)
        {
            int index = 0, indexNumber;
            string number;
            if(dataTable != null)
            {
                dataTable.Clear();
            }
            switch (Path.GetExtension(textBoxPathFile.Text))
            {
                case ".txt": dataTable = TXTDocument.ImportTXTFile(textBoxPathFile.Text); break;
                case ".docx": dataTable = WordDocument.ImportWordFile(textBoxPathFile.Text); break;
                case ".xlsx": dataTable = ExcelDocument.ImportExcelFile(textBoxPathFile.Text); break;
            }
            fibonachi.Clear();
            foreach (DataRow row in dataTable.Rows)
            {
                for(int i = 0; i < row.ItemArray.Length; ++i)
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
            DataResultPrint(fibonachi);
        }

        private void ButtonWarning_Click(object sender, EventArgs e)
        {
            int index = 0;
            Dictionary<decimal, int> buffer = new Dictionary<decimal, int>();
            var sortedDict = from entry in fibonachi orderby entry.Value ascending select entry;
            fibonachi = sortedDict.ToDictionary(entry => index++, entry => entry.Value);
            extraError = extraError.ToDictionary(entry => entry.Key, entry => fibonachi.FirstOrDefault(x => x.Value == entry.Key).Value);
            duplicatError = duplicatError.ToDictionary(entry => entry.Key, entry => fibonachi.FirstOrDefault(x => x.Value == entry.Key).Value);
            DataResultPrint(fibonachi);
            buttonWarning.Visible = false;
        }

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
    }
}