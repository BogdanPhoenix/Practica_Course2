using Bunifu.UI.WinForms;
using Bunifu.UI.WinForms.BunifuAnimatorNS;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice
{
    public partial class FormTaskThree : Form
    {
        private const int digits = 4;
        private BunifuLabel labelCurrent = null;
        public FormTaskThree()
        {
            InitializeComponent();

            minX.KeyPress += CommonFunctionality.CheckDigit;
            maxX.KeyPress += CommonFunctionality.CheckDigit;
            stepX.KeyPress += CommonFunctionality.CheckDigit;
        }

        #region Function
        private string FunctionOne(double x)
        {
            if (x == 0 || Math.Abs(x) == 1)
            {
                return "-";
            }
            return Math.Round(1 / (Math.Pow(x, 2) * (1 - Math.Pow(x, 4))), digits).ToString();
        }
        private string FunctionTwo(double x)
        {
            if (x <= -1)
            {
                return "-";
            }
            return Math.Round(Math.Pow(x, 2) / Math.Sqrt(1 + Math.Pow(x, 3)), digits).ToString();
        }
        private string FunctionThree(double x)
        {
            double buffer = Math.Pow(1 - Math.Pow(Math.Sin(x), 3), 1.0 / 3);
            if (buffer == 0)
            {
                return "-";
            }
            return Math.Round(1 / buffer, digits).ToString();
        }
        private string FunctionFour(double x)
        {
            if (x == 0)
            {
                return "-";
            }
            return Math.Round(1 / (Math.Pow(x, 2) * Math.Exp(Math.Pow(x, 2))), digits).ToString();
        }
        private string FunctionFive(double x)
        {
            double buffer = Math.Pow(Math.Cosh(x), 2);
            if (buffer == 0)
            {
                return "-";
            }
            return Math.Round(1 / buffer, digits).ToString();
        }
        private string FunctionSix(double x)
        {
            if (x <= 1 || x == 2)
            {
                return "-";
            }
            return Math.Round(x / Math.Pow(Math.Log(x - 1), 2), digits).ToString();
        }
        private string FunctionSeven(double x)
        {
            double buffer = Math.Cosh(Math.Sin(x));
            if (buffer == 0)
            {
                return "-";
            }
            return Math.Round(1 / buffer, digits).ToString();
        }
        #endregion
        #region Graph
        private void GraphOne(int dig)
        {
            int series;
            double buffer;
            for (int i = 0; i < dataResult.RowCount; ++i)
            {
                if (dataResult.Rows[i].Cells[1].Value.Equals("-"))
                {
                    /*if (!dataResult.Rows[i].Cells[0].Value.ToString().EndsWith("π"))
                    {
                        buffer = Math.Round(Convert.ToDouble(dataResult.Rows[i].Cells[0].Value.ToString()), dig);
                        shift = Math.Pow(10, -1 * (dig + 1));
                        switch (buffer)
                        {
                            case -1:
                                chart.Series[0].Points.AddXY(-1 - shift, -20);
                                chart.Series[1].Points.AddXY(-1 + shift, 120);
                                break;
                            case 0: break;
                            case 1: break;
                        }
                    }*/
                    continue;
                }
                else
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
        private void GraphTwo(int dig)
        {
            double buffer;
            for (int i = 0; i < dataResult.RowCount; ++i)
            {
                if (dataResult.Rows[i].Cells[2].Value.Equals("-"))
                {
                    continue;
                }
                else
                {
                    buffer = Math.Round(Convert.ToDouble(dataResult.Rows[i].Cells[0].Value.ToString()), dig);

                    if (buffer > -1)
                    {
                        chart.Series[0].Points.AddXY(buffer, Math.Round(Convert.ToDouble(dataResult.Rows[i].Cells[2].Value), dig));
                    }
                }
            }
        }
        private void GraphThree(int dig)
        {
            double buffer;
            for (int i = 0; i < dataResult.RowCount; ++i)
            {
                if (dataResult.Rows[i].Cells[3].Value.Equals("-"))
                {
                    continue;
                }
                else
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
        private void GraphFour(int dig)
        {
            int series;
            double buffer;
            for (int i = 0; i < dataResult.RowCount; ++i)
            {
                if (dataResult.Rows[i].Cells[4].Value.Equals("-"))
                {
                    continue;
                }
                else
                {
                    buffer = Math.Round(Convert.ToDouble(dataResult.Rows[i].Cells[0].Value.ToString()), dig);
                    if (buffer < 0)
                    {
                        series = 0;
                    }
                    else
                    {
                        series = 1;
                    }
                    chart.Series[series].Points.AddXY(buffer, Math.Round(Convert.ToDouble(dataResult.Rows[i].Cells[4].Value), dig));
                }
            }
        }
        private void GraphFive(int dig)
        {
            double buffer;
            for (int i = 0; i < dataResult.RowCount; ++i)
            {
                if (dataResult.Rows[i].Cells[5].Value.Equals("-"))
                {
                    continue;
                }
                else
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
        private void GraphSix(int dig)
        {
            int series;
            double buffer;
            for (int i = 0; i < dataResult.RowCount; ++i)
            {
                if (dataResult.Rows[i].Cells[6].Value.Equals("-"))
                {
                    continue;
                }
                else
                {
                    buffer = Math.Round(Convert.ToDouble(dataResult.Rows[i].Cells[0].Value.ToString()), dig);
                    if (buffer < 2)
                    {
                        series = 0;
                    }
                    else
                    {
                        series = 1;
                    }
                    chart.Series[series].Points.AddXY(buffer, Math.Round(Convert.ToDouble(dataResult.Rows[i].Cells[6].Value), dig));
                }
            }
        }
        private void GraphSeven(int dig)
        {
            double buffer;
            for (int i = 0; i < dataResult.RowCount; ++i)
            {
                if (dataResult.Rows[i].Cells[7].Value.Equals("-"))
                {
                    continue;
                }
                else
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
        private double GetPi(string text, int dig)
        {
            text = text.Substring(0, text.LastIndexOf("π"));
            return Math.Round(Convert.ToDouble(text) * Math.PI, dig);
        }
        #endregion
        private void ButtonResult_Click(object sender, EventArgs e)
        {
            dataResult.Rows.Clear();
            double min = Convert.ToDouble(minX.Text);
            double max = Convert.ToDouble(maxX.Text);
            double step = Convert.ToDouble(stepX.Text);
            int dig = stepX.Text.Length - stepX.Text.IndexOf(',') - 1;
            double pi = min == 0 ? 0.25 : Math.Round(min / Math.PI, 0);
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
            CreateGraph(labelFunction1, new EventArgs());
        }

        private void CheckActive(object sender, EventArgs e)
        {
            buttonResult.Enabled = minX.Text.Length > 0 && maxX.Text.Length > 0 && stepX.Text.Length > 0;
        }

        private void CreateGraph(object sender, EventArgs e)
        {
            int dig = stepX.Text.Length - stepX.Text.IndexOf(',') - 1;
            for (int i = 0; i < chart.Series.Count; ++i)
            {
                chart.Series[i].Points.Clear();
            }
            int index = Convert.ToInt32(((BunifuLabel)sender).Tag.ToString());
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
    }
}
