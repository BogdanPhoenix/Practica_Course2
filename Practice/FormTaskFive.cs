using Bunifu.UI.WinForms;
using System;
using System.Windows.Forms;

namespace Practice
{
    public partial class FormTaskFive : Form
    {
        private const int widthColumn = 100;
        private int maxCountColumn, maxCountColumnPrevious;
        private double[,] A;
        private readonly Random random = new Random();
        public FormTaskFive()
        {
            InitializeComponent();
            MaxCountColumn();
            CreateTable(dataResults);
            maxCountColumnPrevious = sizeMatrix.Value;
            this.Resize += (s, e) => { MaxCountColumn(); };
        }

        private void MaxCountColumn()
        {
            maxCountColumn = dataResults.Width / widthColumn;
            sizeMatrixMax.Text = maxCountColumn.ToString();
            if (sizeMatrix.Value > maxCountColumn)
            {
                sizeMatrix.Value = maxCountColumn;
            }
            sizeMatrix.Maximum = maxCountColumn;
        }

        private void CreateTable(DataGridView dataGridView)
        {
            dataGridView.Columns.Clear();
            for (int i = 0; i < sizeMatrix.Value; i++)
            {
                DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn
                {
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                    Frozen = true,
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

        private void CreateAutomaticallyData()
        {
            for (int i = 0; i < dataResults.RowCount; ++i)
            {
                for (int j = 0; j < dataResults.ColumnCount; ++j)
                {
                    dataResults.Rows[i].Cells[j].Value = random.Next(int.MinValue, int.MaxValue);
                }
            }
        }

        private void dataResults_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (radioButtonManually.Checked)
            {
                //A[e.RowIndex, e.ColumnIndex] = Convert.ToDouble(dataResults.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                buttonSort.Enabled = CheckAllDataCompleted();
            }
        }

        private bool CheckAllDataCompleted()
        {
            for (int i = 0; i < dataResults.RowCount; ++i)
            {
                for (int j = 0; j < dataResults.ColumnCount; ++j)
                {
                    if (dataResults.Rows[i].Cells[j].Value == null)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            A = new double[sizeMatrix.Value, sizeMatrix.Value];
            for (int i = 0; i < dataResults.RowCount; ++i)
            {
                for(int j = 0; j < dataResults.ColumnCount; ++j)
                {
                    A[i, j] = Convert.ToDouble(dataResults.Rows[i].Cells[j].Value);
                }
            }
            CreateTable(dataSortResults);
            Sort();
        }

        private void Sort()
        {
            int[] positiveCount = new int[sizeMatrix.Value];
            double[] buffer = new double[sizeMatrix.Value * sizeMatrix.Value];
            int count;
            for(int j = 0; j < sizeMatrix.Value; ++j)
            {
                count = 0;
                for(int i = 0; i < sizeMatrix.Value; ++i)
                {
                    if (A[i,j] > 0)
                    {
                        ++count;
                    }
                }
                positiveCount[j] = count;
            }
            count = 0;
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

        private void SortArray(double[] array)
        {
            double buffer;
            int min;
            for(int i = 0; i < array.Length; ++i)
            {
                min = i;
                buffer = array[i];
                for(int j= i + 1; j < array.Length; ++j)
                {
                    if (array[j] < buffer)
                    {
                        min = j;
                        buffer = array[j];
                    }
                }
                array[min] = array[i];
                array[i] = buffer;
            }
        }

        private void SizeMatrix_Scroll(object sender, Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs e)
        {
            if(sizeMatrix.Value != maxCountColumnPrevious)
            {
                sizeMatrixNow.Text = sizeMatrix.Value.ToString();
                CreateTable(dataResults);
                if (radioButtonAutomatically.Checked)
                {
                    CreateAutomaticallyData();
                }
                maxCountColumnPrevious = sizeMatrix.Value;
            }
        }

        private void RadioButtonManually_CheckedChanged2(object sender, BunifuRadioButton.CheckedChangedEventArgs e)
        {
            if (radioButtonManually.Checked)
            {
                CreateTable(dataResults);
                dataResults.ReadOnly = false;
            }
        }

        private void RadioButtonAutomatically_CheckedChanged2(object sender, BunifuRadioButton.CheckedChangedEventArgs e)
        {
            if (radioButtonAutomatically.Checked)
            {
                CreateAutomaticallyData();
                dataResults.ReadOnly = true;
                buttonSort.Enabled = true;
            }
        }
    }
}
