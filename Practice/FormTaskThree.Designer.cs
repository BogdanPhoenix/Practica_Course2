using System;

namespace Practice
{
    partial class FormTaskThree
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if(Convert.ToBoolean(buttonActiveGraph.Tag) && panelRight.Width == openWidthPanelRight)
            {
                cloneParentForm.Width -= openWidthPanelRight - closeWidthPanelRight;
                buttonActiveGraph.Tag = false;
            }
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTaskThree));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties9 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties10 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties11 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties12 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelRight = new System.Windows.Forms.Panel();
            this.panelButtonActivGraph = new System.Windows.Forms.Panel();
            this.buttonActiveGraph = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.dataResult = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.ColumnX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFunction1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFunction2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFunction3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFunction4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFunction5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFunction6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFunction7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelInfo = new Bunifu.UI.WinForms.BunifuLabel();
            this.tableLayoutPanelFunction = new System.Windows.Forms.TableLayoutPanel();
            this.labelDataX = new Bunifu.UI.WinForms.BunifuLabel();
            this.buttonFunction1 = new Bunifu.UI.WinForms.BunifuImageButton();
            this.buttonFunction2 = new Bunifu.UI.WinForms.BunifuImageButton();
            this.buttonFunction3 = new Bunifu.UI.WinForms.BunifuImageButton();
            this.buttonFunction4 = new Bunifu.UI.WinForms.BunifuImageButton();
            this.buttonFunction5 = new Bunifu.UI.WinForms.BunifuImageButton();
            this.buttonFunction6 = new Bunifu.UI.WinForms.BunifuImageButton();
            this.buttonFunction7 = new Bunifu.UI.WinForms.BunifuImageButton();
            this.panelButtonResult = new System.Windows.Forms.Panel();
            this.buttonResult = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.panelSetData = new System.Windows.Forms.Panel();
            this.labelXStep = new Bunifu.UI.WinForms.BunifuLabel();
            this.labelXmax = new Bunifu.UI.WinForms.BunifuLabel();
            this.labelXmin = new Bunifu.UI.WinForms.BunifuLabel();
            this.maxX = new Bunifu.UI.WinForms.BunifuTextBox();
            this.minX = new Bunifu.UI.WinForms.BunifuTextBox();
            this.stepX = new Bunifu.UI.WinForms.BunifuTextBox();
            this.bunifuToolTip = new Bunifu.UI.WinForms.BunifuToolTip(this.components);
            this.bunifuSnackbar = new Bunifu.UI.WinForms.BunifuSnackbar(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.panelRight.SuspendLayout();
            this.panelButtonActivGraph.SuspendLayout();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataResult)).BeginInit();
            this.tableLayoutPanelFunction.SuspendLayout();
            this.panelButtonResult.SuspendLayout();
            this.panelSetData.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart
            // 
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart.Location = new System.Drawing.Point(0, 0);
            this.chart.Name = "chart";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.Blue;
            series1.LegendText = " ";
            series1.Name = "Series1";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = System.Drawing.Color.Blue;
            series2.Name = "Series2";
            series3.BorderWidth = 3;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Color = System.Drawing.Color.Blue;
            series3.Name = "Series3";
            series4.BorderWidth = 3;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Color = System.Drawing.Color.Blue;
            series4.Name = "Series4";
            this.chart.Series.Add(series1);
            this.chart.Series.Add(series2);
            this.chart.Series.Add(series3);
            this.chart.Series.Add(series4);
            this.chart.Size = new System.Drawing.Size(0, 532);
            this.chart.TabIndex = 5;
            this.chart.Text = "chart1";
            title1.BorderWidth = 2;
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title1.Name = "Title1";
            title1.Text = "Графік функцій";
            this.chart.Titles.Add(title1);
            this.bunifuToolTip.SetToolTip(this.chart, "");
            this.bunifuToolTip.SetToolTipIcon(this.chart, null);
            this.bunifuToolTip.SetToolTipTitle(this.chart, "");
            // 
            // panelRight
            // 
            this.panelRight.Controls.Add(this.chart);
            this.panelRight.Controls.Add(this.panelButtonActivGraph);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight.Location = new System.Drawing.Point(889, 5);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(1, 532);
            this.panelRight.TabIndex = 6;
            this.bunifuToolTip.SetToolTip(this.panelRight, "");
            this.bunifuToolTip.SetToolTipIcon(this.panelRight, null);
            this.bunifuToolTip.SetToolTipTitle(this.panelRight, "");
            // 
            // panelButtonActivGraph
            // 
            this.panelButtonActivGraph.Controls.Add(this.buttonActiveGraph);
            this.panelButtonActivGraph.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelButtonActivGraph.Location = new System.Drawing.Point(-49, 0);
            this.panelButtonActivGraph.Name = "panelButtonActivGraph";
            this.panelButtonActivGraph.Size = new System.Drawing.Size(50, 532);
            this.panelButtonActivGraph.TabIndex = 16;
            this.bunifuToolTip.SetToolTip(this.panelButtonActivGraph, "");
            this.bunifuToolTip.SetToolTipIcon(this.panelButtonActivGraph, null);
            this.bunifuToolTip.SetToolTipTitle(this.panelButtonActivGraph, "");
            // 
            // buttonActiveGraph
            // 
            this.buttonActiveGraph.AllowAnimations = true;
            this.buttonActiveGraph.AllowBorderColorChanges = true;
            this.buttonActiveGraph.AllowMouseEffects = true;
            this.buttonActiveGraph.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonActiveGraph.AnimationSpeed = 200;
            this.buttonActiveGraph.BackColor = System.Drawing.Color.Transparent;
            this.buttonActiveGraph.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(160)))), ((int)(((byte)(174)))));
            this.buttonActiveGraph.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(160)))), ((int)(((byte)(174)))));
            this.buttonActiveGraph.BorderRadius = 1;
            this.buttonActiveGraph.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderStyles.Solid;
            this.buttonActiveGraph.BorderThickness = 1;
            this.buttonActiveGraph.ColorContrastOnClick = 30;
            this.buttonActiveGraph.ColorContrastOnHover = 30;
            this.buttonActiveGraph.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.buttonActiveGraph.CustomizableEdges = borderEdges1;
            this.buttonActiveGraph.DialogResult = System.Windows.Forms.DialogResult.None;
            this.buttonActiveGraph.Image = global::Practice.Properties.Resources.open_arrow_64px;
            this.buttonActiveGraph.ImageMargin = new System.Windows.Forms.Padding(0);
            this.buttonActiveGraph.Location = new System.Drawing.Point(0, 241);
            this.buttonActiveGraph.Name = "buttonActiveGraph";
            this.buttonActiveGraph.RoundBorders = true;
            this.buttonActiveGraph.ShowBorders = false;
            this.buttonActiveGraph.Size = new System.Drawing.Size(50, 50);
            this.buttonActiveGraph.Style = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.ButtonStyles.Round;
            this.buttonActiveGraph.TabIndex = 0;
            this.buttonActiveGraph.Tag = "false";
            this.bunifuToolTip.SetToolTip(this.buttonActiveGraph, "Відкрити поле з графіком");
            this.bunifuToolTip.SetToolTipIcon(this.buttonActiveGraph, null);
            this.bunifuToolTip.SetToolTipTitle(this.buttonActiveGraph, "");
            this.buttonActiveGraph.Click += new System.EventHandler(this.ButtonActiveGraph_Click);
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.dataResult);
            this.panelLeft.Controls.Add(this.labelInfo);
            this.panelLeft.Controls.Add(this.tableLayoutPanelFunction);
            this.panelLeft.Controls.Add(this.panelButtonResult);
            this.panelLeft.Controls.Add(this.panelSetData);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLeft.Location = new System.Drawing.Point(5, 5);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(884, 532);
            this.panelLeft.TabIndex = 9;
            this.bunifuToolTip.SetToolTip(this.panelLeft, "");
            this.bunifuToolTip.SetToolTipIcon(this.panelLeft, null);
            this.bunifuToolTip.SetToolTipTitle(this.panelLeft, "");
            // 
            // dataResult
            // 
            this.dataResult.AllowCustomTheming = false;
            this.dataResult.AllowUserToAddRows = false;
            this.dataResult.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dataResult.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataResult.BackgroundColor = System.Drawing.Color.White;
            this.dataResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataResult.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataResult.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataResult.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataResult.ColumnHeadersHeight = 40;
            this.dataResult.ColumnHeadersVisible = false;
            this.dataResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnX,
            this.ColumnFunction1,
            this.ColumnFunction2,
            this.ColumnFunction3,
            this.ColumnFunction4,
            this.ColumnFunction5,
            this.ColumnFunction6,
            this.ColumnFunction7});
            this.dataResult.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dataResult.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dataResult.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataResult.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dataResult.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataResult.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dataResult.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dataResult.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dataResult.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dataResult.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataResult.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dataResult.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataResult.CurrentTheme.Name = null;
            this.dataResult.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataResult.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dataResult.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataResult.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dataResult.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataResult.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataResult.EnableHeadersVisualStyles = false;
            this.dataResult.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dataResult.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dataResult.HeaderBgColor = System.Drawing.Color.Empty;
            this.dataResult.HeaderForeColor = System.Drawing.Color.White;
            this.dataResult.Location = new System.Drawing.Point(0, 458);
            this.dataResult.Name = "dataResult";
            this.dataResult.ReadOnly = true;
            this.dataResult.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataResult.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataResult.RowTemplate.Height = 40;
            this.dataResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataResult.Size = new System.Drawing.Size(884, 74);
            this.dataResult.TabIndex = 15;
            this.dataResult.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.bunifuToolTip.SetToolTip(this.dataResult, "");
            this.bunifuToolTip.SetToolTipIcon(this.dataResult, null);
            this.bunifuToolTip.SetToolTipTitle(this.dataResult, "");
            // 
            // ColumnX
            // 
            this.ColumnX.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnX.FillWeight = 50F;
            this.ColumnX.HeaderText = "X";
            this.ColumnX.Name = "ColumnX";
            this.ColumnX.ReadOnly = true;
            this.ColumnX.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnX.Width = 50;
            // 
            // ColumnFunction1
            // 
            this.ColumnFunction1.FillWeight = 91.0805F;
            this.ColumnFunction1.HeaderText = "Column1";
            this.ColumnFunction1.Name = "ColumnFunction1";
            this.ColumnFunction1.ReadOnly = true;
            this.ColumnFunction1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ColumnFunction2
            // 
            this.ColumnFunction2.FillWeight = 91.0805F;
            this.ColumnFunction2.HeaderText = "Column2";
            this.ColumnFunction2.Name = "ColumnFunction2";
            this.ColumnFunction2.ReadOnly = true;
            this.ColumnFunction2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ColumnFunction3
            // 
            this.ColumnFunction3.FillWeight = 91.0805F;
            this.ColumnFunction3.HeaderText = "Column3";
            this.ColumnFunction3.Name = "ColumnFunction3";
            this.ColumnFunction3.ReadOnly = true;
            this.ColumnFunction3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ColumnFunction4
            // 
            this.ColumnFunction4.FillWeight = 91.0805F;
            this.ColumnFunction4.HeaderText = "Column4";
            this.ColumnFunction4.Name = "ColumnFunction4";
            this.ColumnFunction4.ReadOnly = true;
            this.ColumnFunction4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ColumnFunction5
            // 
            this.ColumnFunction5.FillWeight = 91.0805F;
            this.ColumnFunction5.HeaderText = "Column5";
            this.ColumnFunction5.Name = "ColumnFunction5";
            this.ColumnFunction5.ReadOnly = true;
            this.ColumnFunction5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ColumnFunction6
            // 
            this.ColumnFunction6.FillWeight = 91.0805F;
            this.ColumnFunction6.HeaderText = "Column6";
            this.ColumnFunction6.Name = "ColumnFunction6";
            this.ColumnFunction6.ReadOnly = true;
            this.ColumnFunction6.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ColumnFunction7
            // 
            this.ColumnFunction7.FillWeight = 91.0805F;
            this.ColumnFunction7.HeaderText = "Column7";
            this.ColumnFunction7.Name = "ColumnFunction7";
            this.ColumnFunction7.ReadOnly = true;
            this.ColumnFunction7.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // labelInfo
            // 
            this.labelInfo.AllowParentOverrides = false;
            this.labelInfo.AutoEllipsis = false;
            this.labelInfo.AutoSize = false;
            this.labelInfo.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelInfo.CursorType = System.Windows.Forms.Cursors.Default;
            this.labelInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelInfo.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInfo.Location = new System.Drawing.Point(0, 202);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Padding = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.labelInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelInfo.Size = new System.Drawing.Size(884, 256);
            this.labelInfo.TabIndex = 14;
            this.labelInfo.Text = "Поле для виведення результату";
            this.labelInfo.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelInfo.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.bunifuToolTip.SetToolTip(this.labelInfo, "");
            this.bunifuToolTip.SetToolTipIcon(this.labelInfo, null);
            this.bunifuToolTip.SetToolTipTitle(this.labelInfo, "");
            // 
            // tableLayoutPanelFunction
            // 
            this.tableLayoutPanelFunction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.tableLayoutPanelFunction.ColumnCount = 8;
            this.tableLayoutPanelFunction.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanelFunction.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanelFunction.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanelFunction.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanelFunction.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanelFunction.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanelFunction.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanelFunction.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanelFunction.Controls.Add(this.labelDataX, 0, 0);
            this.tableLayoutPanelFunction.Controls.Add(this.buttonFunction1, 1, 0);
            this.tableLayoutPanelFunction.Controls.Add(this.buttonFunction2, 2, 0);
            this.tableLayoutPanelFunction.Controls.Add(this.buttonFunction3, 3, 0);
            this.tableLayoutPanelFunction.Controls.Add(this.buttonFunction4, 4, 0);
            this.tableLayoutPanelFunction.Controls.Add(this.buttonFunction5, 5, 0);
            this.tableLayoutPanelFunction.Controls.Add(this.buttonFunction6, 6, 0);
            this.tableLayoutPanelFunction.Controls.Add(this.buttonFunction7, 7, 0);
            this.tableLayoutPanelFunction.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanelFunction.Location = new System.Drawing.Point(0, 127);
            this.tableLayoutPanelFunction.Name = "tableLayoutPanelFunction";
            this.tableLayoutPanelFunction.RowCount = 1;
            this.tableLayoutPanelFunction.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelFunction.Size = new System.Drawing.Size(884, 75);
            this.tableLayoutPanelFunction.TabIndex = 13;
            this.bunifuToolTip.SetToolTip(this.tableLayoutPanelFunction, "");
            this.bunifuToolTip.SetToolTipIcon(this.tableLayoutPanelFunction, null);
            this.bunifuToolTip.SetToolTipTitle(this.tableLayoutPanelFunction, "");
            this.tableLayoutPanelFunction.Visible = false;
            // 
            // labelDataX
            // 
            this.labelDataX.AllowParentOverrides = false;
            this.labelDataX.AutoEllipsis = false;
            this.labelDataX.AutoSize = false;
            this.labelDataX.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelDataX.CursorType = System.Windows.Forms.Cursors.Default;
            this.labelDataX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelDataX.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.labelDataX.Location = new System.Drawing.Point(0, 0);
            this.labelDataX.Margin = new System.Windows.Forms.Padding(0);
            this.labelDataX.Name = "labelDataX";
            this.labelDataX.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelDataX.Size = new System.Drawing.Size(50, 75);
            this.labelDataX.TabIndex = 0;
            this.labelDataX.Text = "X";
            this.labelDataX.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelDataX.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.bunifuToolTip.SetToolTip(this.labelDataX, "");
            this.bunifuToolTip.SetToolTipIcon(this.labelDataX, null);
            this.bunifuToolTip.SetToolTipTitle(this.labelDataX, "");
            // 
            // buttonFunction1
            // 
            this.buttonFunction1.ActiveImage = global::Practice.Properties.Resources.function11;
            this.buttonFunction1.AllowAnimations = true;
            this.buttonFunction1.AllowBuffering = false;
            this.buttonFunction1.AllowToggling = false;
            this.buttonFunction1.AllowZooming = true;
            this.buttonFunction1.AllowZoomingOnFocus = false;
            this.buttonFunction1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonFunction1.BackColor = System.Drawing.Color.Transparent;
            this.buttonFunction1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.buttonFunction1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("buttonFunction1.ErrorImage")));
            this.buttonFunction1.FadeWhenInactive = false;
            this.buttonFunction1.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.buttonFunction1.Image = global::Practice.Properties.Resources.function11;
            this.buttonFunction1.ImageActive = global::Practice.Properties.Resources.function11;
            this.buttonFunction1.ImageLocation = null;
            this.buttonFunction1.ImageMargin = 20;
            this.buttonFunction1.ImageSize = new System.Drawing.Size(90, 55);
            this.buttonFunction1.ImageZoomSize = new System.Drawing.Size(110, 75);
            this.buttonFunction1.InitialImage = ((System.Drawing.Image)(resources.GetObject("buttonFunction1.InitialImage")));
            this.buttonFunction1.Location = new System.Drawing.Point(54, 0);
            this.buttonFunction1.Margin = new System.Windows.Forms.Padding(0);
            this.buttonFunction1.Name = "buttonFunction1";
            this.buttonFunction1.Rotation = 0;
            this.buttonFunction1.ShowActiveImage = true;
            this.buttonFunction1.ShowCursorChanges = true;
            this.buttonFunction1.ShowImageBorders = true;
            this.buttonFunction1.ShowSizeMarkers = false;
            this.buttonFunction1.Size = new System.Drawing.Size(110, 75);
            this.buttonFunction1.TabIndex = 1;
            this.buttonFunction1.Tag = "1";
            this.bunifuToolTip.SetToolTip(this.buttonFunction1, "Натисніть, щоб побудувати графік функції");
            this.bunifuToolTip.SetToolTipIcon(this.buttonFunction1, null);
            this.buttonFunction1.ToolTipText = "";
            this.bunifuToolTip.SetToolTipTitle(this.buttonFunction1, "");
            this.buttonFunction1.WaitOnLoad = false;
            this.buttonFunction1.Zoom = 20;
            this.buttonFunction1.ZoomSpeed = 10;
            this.buttonFunction1.Click += new System.EventHandler(this.CreateGraph);
            // 
            // buttonFunction2
            // 
            this.buttonFunction2.ActiveImage = global::Practice.Properties.Resources.function2;
            this.buttonFunction2.AllowAnimations = true;
            this.buttonFunction2.AllowBuffering = false;
            this.buttonFunction2.AllowToggling = false;
            this.buttonFunction2.AllowZooming = true;
            this.buttonFunction2.AllowZoomingOnFocus = false;
            this.buttonFunction2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonFunction2.BackColor = System.Drawing.Color.Transparent;
            this.buttonFunction2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.buttonFunction2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("buttonFunction2.ErrorImage")));
            this.buttonFunction2.FadeWhenInactive = false;
            this.buttonFunction2.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.buttonFunction2.Image = global::Practice.Properties.Resources.function2;
            this.buttonFunction2.ImageActive = global::Practice.Properties.Resources.function2;
            this.buttonFunction2.ImageLocation = null;
            this.buttonFunction2.ImageMargin = 20;
            this.buttonFunction2.ImageSize = new System.Drawing.Size(90, 55);
            this.buttonFunction2.ImageZoomSize = new System.Drawing.Size(110, 75);
            this.buttonFunction2.InitialImage = ((System.Drawing.Image)(resources.GetObject("buttonFunction2.InitialImage")));
            this.buttonFunction2.Location = new System.Drawing.Point(173, 0);
            this.buttonFunction2.Margin = new System.Windows.Forms.Padding(0);
            this.buttonFunction2.Name = "buttonFunction2";
            this.buttonFunction2.Rotation = 0;
            this.buttonFunction2.ShowActiveImage = true;
            this.buttonFunction2.ShowCursorChanges = true;
            this.buttonFunction2.ShowImageBorders = true;
            this.buttonFunction2.ShowSizeMarkers = false;
            this.buttonFunction2.Size = new System.Drawing.Size(110, 75);
            this.buttonFunction2.TabIndex = 2;
            this.buttonFunction2.Tag = "2";
            this.bunifuToolTip.SetToolTip(this.buttonFunction2, "Натисніть, щоб побудувати графік функції");
            this.bunifuToolTip.SetToolTipIcon(this.buttonFunction2, null);
            this.buttonFunction2.ToolTipText = "";
            this.bunifuToolTip.SetToolTipTitle(this.buttonFunction2, "");
            this.buttonFunction2.WaitOnLoad = false;
            this.buttonFunction2.Zoom = 20;
            this.buttonFunction2.ZoomSpeed = 10;
            this.buttonFunction2.Click += new System.EventHandler(this.CreateGraph);
            // 
            // buttonFunction3
            // 
            this.buttonFunction3.ActiveImage = global::Practice.Properties.Resources.function31;
            this.buttonFunction3.AllowAnimations = true;
            this.buttonFunction3.AllowBuffering = false;
            this.buttonFunction3.AllowToggling = false;
            this.buttonFunction3.AllowZooming = true;
            this.buttonFunction3.AllowZoomingOnFocus = false;
            this.buttonFunction3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonFunction3.BackColor = System.Drawing.Color.Transparent;
            this.buttonFunction3.DialogResult = System.Windows.Forms.DialogResult.None;
            this.buttonFunction3.ErrorImage = ((System.Drawing.Image)(resources.GetObject("buttonFunction3.ErrorImage")));
            this.buttonFunction3.FadeWhenInactive = false;
            this.buttonFunction3.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.buttonFunction3.Image = global::Practice.Properties.Resources.function3;
            this.buttonFunction3.ImageActive = global::Practice.Properties.Resources.function31;
            this.buttonFunction3.ImageLocation = null;
            this.buttonFunction3.ImageMargin = 20;
            this.buttonFunction3.ImageSize = new System.Drawing.Size(90, 55);
            this.buttonFunction3.ImageZoomSize = new System.Drawing.Size(110, 75);
            this.buttonFunction3.InitialImage = ((System.Drawing.Image)(resources.GetObject("buttonFunction3.InitialImage")));
            this.buttonFunction3.Location = new System.Drawing.Point(292, 0);
            this.buttonFunction3.Margin = new System.Windows.Forms.Padding(0);
            this.buttonFunction3.Name = "buttonFunction3";
            this.buttonFunction3.Rotation = 0;
            this.buttonFunction3.ShowActiveImage = true;
            this.buttonFunction3.ShowCursorChanges = true;
            this.buttonFunction3.ShowImageBorders = true;
            this.buttonFunction3.ShowSizeMarkers = false;
            this.buttonFunction3.Size = new System.Drawing.Size(110, 75);
            this.buttonFunction3.TabIndex = 3;
            this.buttonFunction3.Tag = "3";
            this.bunifuToolTip.SetToolTip(this.buttonFunction3, "Натисніть, щоб побудувати графік функції");
            this.bunifuToolTip.SetToolTipIcon(this.buttonFunction3, null);
            this.buttonFunction3.ToolTipText = "";
            this.bunifuToolTip.SetToolTipTitle(this.buttonFunction3, "");
            this.buttonFunction3.WaitOnLoad = false;
            this.buttonFunction3.Zoom = 20;
            this.buttonFunction3.ZoomSpeed = 10;
            this.buttonFunction3.Click += new System.EventHandler(this.CreateGraph);
            // 
            // buttonFunction4
            // 
            this.buttonFunction4.ActiveImage = global::Practice.Properties.Resources.function4;
            this.buttonFunction4.AllowAnimations = true;
            this.buttonFunction4.AllowBuffering = false;
            this.buttonFunction4.AllowToggling = false;
            this.buttonFunction4.AllowZooming = true;
            this.buttonFunction4.AllowZoomingOnFocus = false;
            this.buttonFunction4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonFunction4.BackColor = System.Drawing.Color.Transparent;
            this.buttonFunction4.DialogResult = System.Windows.Forms.DialogResult.None;
            this.buttonFunction4.ErrorImage = ((System.Drawing.Image)(resources.GetObject("buttonFunction4.ErrorImage")));
            this.buttonFunction4.FadeWhenInactive = false;
            this.buttonFunction4.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.buttonFunction4.Image = global::Practice.Properties.Resources.function4;
            this.buttonFunction4.ImageActive = global::Practice.Properties.Resources.function4;
            this.buttonFunction4.ImageLocation = null;
            this.buttonFunction4.ImageMargin = 20;
            this.buttonFunction4.ImageSize = new System.Drawing.Size(55, 55);
            this.buttonFunction4.ImageZoomSize = new System.Drawing.Size(75, 75);
            this.buttonFunction4.InitialImage = ((System.Drawing.Image)(resources.GetObject("buttonFunction4.InitialImage")));
            this.buttonFunction4.Location = new System.Drawing.Point(429, 0);
            this.buttonFunction4.Margin = new System.Windows.Forms.Padding(0);
            this.buttonFunction4.Name = "buttonFunction4";
            this.buttonFunction4.Rotation = 0;
            this.buttonFunction4.ShowActiveImage = true;
            this.buttonFunction4.ShowCursorChanges = true;
            this.buttonFunction4.ShowImageBorders = true;
            this.buttonFunction4.ShowSizeMarkers = false;
            this.buttonFunction4.Size = new System.Drawing.Size(75, 75);
            this.buttonFunction4.TabIndex = 4;
            this.buttonFunction4.Tag = "4";
            this.bunifuToolTip.SetToolTip(this.buttonFunction4, "Натисніть, щоб побудувати графік функції");
            this.bunifuToolTip.SetToolTipIcon(this.buttonFunction4, null);
            this.buttonFunction4.ToolTipText = "";
            this.bunifuToolTip.SetToolTipTitle(this.buttonFunction4, "");
            this.buttonFunction4.WaitOnLoad = false;
            this.buttonFunction4.Zoom = 20;
            this.buttonFunction4.ZoomSpeed = 10;
            this.buttonFunction4.Click += new System.EventHandler(this.CreateGraph);
            // 
            // buttonFunction5
            // 
            this.buttonFunction5.ActiveImage = global::Practice.Properties.Resources.function5;
            this.buttonFunction5.AllowAnimations = true;
            this.buttonFunction5.AllowBuffering = false;
            this.buttonFunction5.AllowToggling = false;
            this.buttonFunction5.AllowZooming = true;
            this.buttonFunction5.AllowZoomingOnFocus = false;
            this.buttonFunction5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonFunction5.BackColor = System.Drawing.Color.Transparent;
            this.buttonFunction5.DialogResult = System.Windows.Forms.DialogResult.None;
            this.buttonFunction5.ErrorImage = ((System.Drawing.Image)(resources.GetObject("buttonFunction5.ErrorImage")));
            this.buttonFunction5.FadeWhenInactive = false;
            this.buttonFunction5.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.buttonFunction5.Image = global::Practice.Properties.Resources.function5;
            this.buttonFunction5.ImageActive = global::Practice.Properties.Resources.function5;
            this.buttonFunction5.ImageLocation = null;
            this.buttonFunction5.ImageMargin = 20;
            this.buttonFunction5.ImageSize = new System.Drawing.Size(55, 55);
            this.buttonFunction5.ImageZoomSize = new System.Drawing.Size(75, 75);
            this.buttonFunction5.InitialImage = ((System.Drawing.Image)(resources.GetObject("buttonFunction5.InitialImage")));
            this.buttonFunction5.Location = new System.Drawing.Point(548, 0);
            this.buttonFunction5.Margin = new System.Windows.Forms.Padding(0);
            this.buttonFunction5.Name = "buttonFunction5";
            this.buttonFunction5.Rotation = 0;
            this.buttonFunction5.ShowActiveImage = true;
            this.buttonFunction5.ShowCursorChanges = true;
            this.buttonFunction5.ShowImageBorders = true;
            this.buttonFunction5.ShowSizeMarkers = false;
            this.buttonFunction5.Size = new System.Drawing.Size(75, 75);
            this.buttonFunction5.TabIndex = 5;
            this.buttonFunction5.Tag = "5";
            this.bunifuToolTip.SetToolTip(this.buttonFunction5, "Натисніть, щоб побудувати графік функції");
            this.bunifuToolTip.SetToolTipIcon(this.buttonFunction5, null);
            this.buttonFunction5.ToolTipText = "";
            this.bunifuToolTip.SetToolTipTitle(this.buttonFunction5, "");
            this.buttonFunction5.WaitOnLoad = false;
            this.buttonFunction5.Zoom = 20;
            this.buttonFunction5.ZoomSpeed = 10;
            this.buttonFunction5.Click += new System.EventHandler(this.CreateGraph);
            // 
            // buttonFunction6
            // 
            this.buttonFunction6.ActiveImage = global::Practice.Properties.Resources.function6;
            this.buttonFunction6.AllowAnimations = true;
            this.buttonFunction6.AllowBuffering = false;
            this.buttonFunction6.AllowToggling = false;
            this.buttonFunction6.AllowZooming = true;
            this.buttonFunction6.AllowZoomingOnFocus = false;
            this.buttonFunction6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonFunction6.BackColor = System.Drawing.Color.Transparent;
            this.buttonFunction6.DialogResult = System.Windows.Forms.DialogResult.None;
            this.buttonFunction6.ErrorImage = ((System.Drawing.Image)(resources.GetObject("buttonFunction6.ErrorImage")));
            this.buttonFunction6.FadeWhenInactive = false;
            this.buttonFunction6.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.buttonFunction6.Image = global::Practice.Properties.Resources.function6;
            this.buttonFunction6.ImageActive = global::Practice.Properties.Resources.function6;
            this.buttonFunction6.ImageLocation = null;
            this.buttonFunction6.ImageMargin = 20;
            this.buttonFunction6.ImageSize = new System.Drawing.Size(90, 55);
            this.buttonFunction6.ImageZoomSize = new System.Drawing.Size(110, 75);
            this.buttonFunction6.InitialImage = ((System.Drawing.Image)(resources.GetObject("buttonFunction6.InitialImage")));
            this.buttonFunction6.Location = new System.Drawing.Point(649, 0);
            this.buttonFunction6.Margin = new System.Windows.Forms.Padding(0);
            this.buttonFunction6.Name = "buttonFunction6";
            this.buttonFunction6.Rotation = 0;
            this.buttonFunction6.ShowActiveImage = true;
            this.buttonFunction6.ShowCursorChanges = true;
            this.buttonFunction6.ShowImageBorders = true;
            this.buttonFunction6.ShowSizeMarkers = false;
            this.buttonFunction6.Size = new System.Drawing.Size(110, 75);
            this.buttonFunction6.TabIndex = 6;
            this.buttonFunction6.Tag = "6";
            this.bunifuToolTip.SetToolTip(this.buttonFunction6, "Натисніть, щоб побудувати графік функції");
            this.bunifuToolTip.SetToolTipIcon(this.buttonFunction6, null);
            this.buttonFunction6.ToolTipText = "";
            this.bunifuToolTip.SetToolTipTitle(this.buttonFunction6, "");
            this.buttonFunction6.WaitOnLoad = false;
            this.buttonFunction6.Zoom = 20;
            this.buttonFunction6.ZoomSpeed = 10;
            this.buttonFunction6.Click += new System.EventHandler(this.CreateGraph);
            // 
            // buttonFunction7
            // 
            this.buttonFunction7.ActiveImage = global::Practice.Properties.Resources.function7;
            this.buttonFunction7.AllowAnimations = true;
            this.buttonFunction7.AllowBuffering = false;
            this.buttonFunction7.AllowToggling = false;
            this.buttonFunction7.AllowZooming = true;
            this.buttonFunction7.AllowZoomingOnFocus = false;
            this.buttonFunction7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonFunction7.BackColor = System.Drawing.Color.Transparent;
            this.buttonFunction7.DialogResult = System.Windows.Forms.DialogResult.None;
            this.buttonFunction7.ErrorImage = ((System.Drawing.Image)(resources.GetObject("buttonFunction7.ErrorImage")));
            this.buttonFunction7.FadeWhenInactive = false;
            this.buttonFunction7.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.buttonFunction7.Image = global::Practice.Properties.Resources.function7;
            this.buttonFunction7.ImageActive = global::Practice.Properties.Resources.function7;
            this.buttonFunction7.ImageLocation = null;
            this.buttonFunction7.ImageMargin = 20;
            this.buttonFunction7.ImageSize = new System.Drawing.Size(90, 55);
            this.buttonFunction7.ImageZoomSize = new System.Drawing.Size(110, 75);
            this.buttonFunction7.InitialImage = ((System.Drawing.Image)(resources.GetObject("buttonFunction7.InitialImage")));
            this.buttonFunction7.Location = new System.Drawing.Point(769, 0);
            this.buttonFunction7.Margin = new System.Windows.Forms.Padding(0);
            this.buttonFunction7.Name = "buttonFunction7";
            this.buttonFunction7.Rotation = 0;
            this.buttonFunction7.ShowActiveImage = true;
            this.buttonFunction7.ShowCursorChanges = true;
            this.buttonFunction7.ShowImageBorders = true;
            this.buttonFunction7.ShowSizeMarkers = false;
            this.buttonFunction7.Size = new System.Drawing.Size(110, 75);
            this.buttonFunction7.TabIndex = 7;
            this.buttonFunction7.Tag = "7";
            this.bunifuToolTip.SetToolTip(this.buttonFunction7, "Натисніть, щоб побудувати графік функції");
            this.bunifuToolTip.SetToolTipIcon(this.buttonFunction7, null);
            this.buttonFunction7.ToolTipText = "";
            this.bunifuToolTip.SetToolTipTitle(this.buttonFunction7, "");
            this.buttonFunction7.WaitOnLoad = false;
            this.buttonFunction7.Zoom = 20;
            this.buttonFunction7.ZoomSpeed = 10;
            this.buttonFunction7.Click += new System.EventHandler(this.CreateGraph);
            // 
            // panelButtonResult
            // 
            this.panelButtonResult.Controls.Add(this.buttonResult);
            this.panelButtonResult.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButtonResult.Location = new System.Drawing.Point(0, 65);
            this.panelButtonResult.Name = "panelButtonResult";
            this.panelButtonResult.Size = new System.Drawing.Size(884, 62);
            this.panelButtonResult.TabIndex = 12;
            this.bunifuToolTip.SetToolTip(this.panelButtonResult, "");
            this.bunifuToolTip.SetToolTipIcon(this.panelButtonResult, null);
            this.bunifuToolTip.SetToolTipTitle(this.panelButtonResult, "");
            // 
            // buttonResult
            // 
            this.buttonResult.AllowAnimations = true;
            this.buttonResult.AllowMouseEffects = true;
            this.buttonResult.AllowToggling = false;
            this.buttonResult.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonResult.AnimationSpeed = 200;
            this.buttonResult.AutoGenerateColors = false;
            this.buttonResult.AutoRoundBorders = false;
            this.buttonResult.AutoSizeLeftIcon = true;
            this.buttonResult.AutoSizeRightIcon = true;
            this.buttonResult.BackColor = System.Drawing.Color.Transparent;
            this.buttonResult.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.buttonResult.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonResult.BackgroundImage")));
            this.buttonResult.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.buttonResult.ButtonText = "Результат";
            this.buttonResult.ButtonTextMarginLeft = 0;
            this.buttonResult.ColorContrastOnClick = 45;
            this.buttonResult.ColorContrastOnHover = 45;
            this.buttonResult.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.buttonResult.CustomizableEdges = borderEdges2;
            this.buttonResult.DialogResult = System.Windows.Forms.DialogResult.None;
            this.buttonResult.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.buttonResult.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.buttonResult.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.buttonResult.Enabled = false;
            this.buttonResult.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.buttonResult.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.buttonResult.ForeColor = System.Drawing.Color.White;
            this.buttonResult.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonResult.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.buttonResult.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.buttonResult.IconMarginLeft = 11;
            this.buttonResult.IconPadding = 10;
            this.buttonResult.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonResult.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.buttonResult.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.buttonResult.IconSize = 25;
            this.buttonResult.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.buttonResult.IdleBorderRadius = 40;
            this.buttonResult.IdleBorderThickness = 1;
            this.buttonResult.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.buttonResult.IdleIconLeftImage = null;
            this.buttonResult.IdleIconRightImage = null;
            this.buttonResult.IndicateFocus = false;
            this.buttonResult.Location = new System.Drawing.Point(387, 11);
            this.buttonResult.Name = "buttonResult";
            this.buttonResult.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.buttonResult.OnDisabledState.BorderRadius = 40;
            this.buttonResult.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.buttonResult.OnDisabledState.BorderThickness = 1;
            this.buttonResult.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.buttonResult.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.buttonResult.OnDisabledState.IconLeftImage = null;
            this.buttonResult.OnDisabledState.IconRightImage = null;
            this.buttonResult.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.buttonResult.onHoverState.BorderRadius = 40;
            this.buttonResult.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.buttonResult.onHoverState.BorderThickness = 1;
            this.buttonResult.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.buttonResult.onHoverState.ForeColor = System.Drawing.Color.White;
            this.buttonResult.onHoverState.IconLeftImage = null;
            this.buttonResult.onHoverState.IconRightImage = null;
            this.buttonResult.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.buttonResult.OnIdleState.BorderRadius = 40;
            this.buttonResult.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.buttonResult.OnIdleState.BorderThickness = 1;
            this.buttonResult.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.buttonResult.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.buttonResult.OnIdleState.IconLeftImage = null;
            this.buttonResult.OnIdleState.IconRightImage = null;
            this.buttonResult.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.buttonResult.OnPressedState.BorderRadius = 40;
            this.buttonResult.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.buttonResult.OnPressedState.BorderThickness = 1;
            this.buttonResult.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.buttonResult.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.buttonResult.OnPressedState.IconLeftImage = null;
            this.buttonResult.OnPressedState.IconRightImage = null;
            this.buttonResult.Size = new System.Drawing.Size(110, 40);
            this.buttonResult.TabIndex = 1;
            this.buttonResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonResult.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.buttonResult.TextMarginLeft = 0;
            this.buttonResult.TextPadding = new System.Windows.Forms.Padding(0);
            this.bunifuToolTip.SetToolTip(this.buttonResult, "Натисніть, щоб отримати готовий результат");
            this.bunifuToolTip.SetToolTipIcon(this.buttonResult, null);
            this.bunifuToolTip.SetToolTipTitle(this.buttonResult, "");
            this.buttonResult.UseDefaultRadiusAndThickness = true;
            this.buttonResult.Click += new System.EventHandler(this.ButtonResult_Click);
            // 
            // panelSetData
            // 
            this.panelSetData.Controls.Add(this.labelXStep);
            this.panelSetData.Controls.Add(this.labelXmax);
            this.panelSetData.Controls.Add(this.labelXmin);
            this.panelSetData.Controls.Add(this.maxX);
            this.panelSetData.Controls.Add(this.minX);
            this.panelSetData.Controls.Add(this.stepX);
            this.panelSetData.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSetData.Location = new System.Drawing.Point(0, 0);
            this.panelSetData.Name = "panelSetData";
            this.panelSetData.Size = new System.Drawing.Size(884, 65);
            this.panelSetData.TabIndex = 11;
            this.bunifuToolTip.SetToolTip(this.panelSetData, "");
            this.bunifuToolTip.SetToolTipIcon(this.panelSetData, null);
            this.bunifuToolTip.SetToolTipTitle(this.panelSetData, "");
            // 
            // labelXStep
            // 
            this.labelXStep.AllowParentOverrides = false;
            this.labelXStep.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelXStep.AutoEllipsis = false;
            this.labelXStep.AutoSize = false;
            this.labelXStep.CursorType = null;
            this.labelXStep.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelXStep.Location = new System.Drawing.Point(675, 7);
            this.labelXStep.Name = "labelXStep";
            this.labelXStep.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelXStep.Size = new System.Drawing.Size(73, 50);
            this.labelXStep.TabIndex = 8;
            this.labelXStep.Text = "Крок";
            this.labelXStep.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelXStep.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.bunifuToolTip.SetToolTip(this.labelXStep, "");
            this.bunifuToolTip.SetToolTipIcon(this.labelXStep, null);
            this.bunifuToolTip.SetToolTipTitle(this.labelXStep, "");
            // 
            // labelXmax
            // 
            this.labelXmax.AllowParentOverrides = false;
            this.labelXmax.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelXmax.AutoEllipsis = false;
            this.labelXmax.AutoSize = false;
            this.labelXmax.CursorType = null;
            this.labelXmax.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelXmax.Location = new System.Drawing.Point(360, 7);
            this.labelXmax.Name = "labelXmax";
            this.labelXmax.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelXmax.Size = new System.Drawing.Size(63, 50);
            this.labelXmax.TabIndex = 7;
            this.labelXmax.Text = "x<sub>max</sub>";
            this.labelXmax.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.labelXmax.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.bunifuToolTip.SetToolTip(this.labelXmax, "");
            this.bunifuToolTip.SetToolTipIcon(this.labelXmax, null);
            this.bunifuToolTip.SetToolTipTitle(this.labelXmax, "");
            // 
            // labelXmin
            // 
            this.labelXmin.AllowParentOverrides = false;
            this.labelXmin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelXmin.AutoEllipsis = false;
            this.labelXmin.AutoSize = false;
            this.labelXmin.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelXmin.CursorType = System.Windows.Forms.Cursors.Default;
            this.labelXmin.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelXmin.Location = new System.Drawing.Point(45, 7);
            this.labelXmin.Name = "labelXmin";
            this.labelXmin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelXmin.Size = new System.Drawing.Size(65, 50);
            this.labelXmin.TabIndex = 6;
            this.labelXmin.Text = "x<sub>min</sub>";
            this.labelXmin.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.labelXmin.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.bunifuToolTip.SetToolTip(this.labelXmin, "");
            this.bunifuToolTip.SetToolTipIcon(this.labelXmin, null);
            this.bunifuToolTip.SetToolTipTitle(this.labelXmin, "");
            // 
            // maxX
            // 
            this.maxX.AcceptsReturn = false;
            this.maxX.AcceptsTab = false;
            this.maxX.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.maxX.AnimationSpeed = 200;
            this.maxX.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.maxX.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.maxX.AutoSizeHeight = true;
            this.maxX.BackColor = System.Drawing.Color.Transparent;
            this.maxX.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("maxX.BackgroundImage")));
            this.maxX.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.maxX.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.maxX.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.maxX.BorderColorIdle = System.Drawing.Color.Silver;
            this.maxX.BorderRadius = 10;
            this.maxX.BorderThickness = 1;
            this.maxX.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.maxX.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.maxX.DefaultFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maxX.DefaultText = "";
            this.maxX.FillColor = System.Drawing.Color.White;
            this.maxX.HideSelection = true;
            this.maxX.IconLeft = null;
            this.maxX.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.maxX.IconPadding = 10;
            this.maxX.IconRight = null;
            this.maxX.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.maxX.Lines = new string[0];
            this.maxX.Location = new System.Drawing.Point(440, 12);
            this.maxX.MaxLength = 6;
            this.maxX.MinimumSize = new System.Drawing.Size(1, 1);
            this.maxX.Modified = false;
            this.maxX.Multiline = false;
            this.maxX.Name = "maxX";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.maxX.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.maxX.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.maxX.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.maxX.OnIdleState = stateProperties4;
            this.maxX.Padding = new System.Windows.Forms.Padding(3);
            this.maxX.PasswordChar = '\0';
            this.maxX.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.maxX.PlaceholderText = "max";
            this.maxX.ReadOnly = false;
            this.maxX.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.maxX.SelectedText = "";
            this.maxX.SelectionLength = 0;
            this.maxX.SelectionStart = 0;
            this.maxX.ShortcutsEnabled = true;
            this.maxX.Size = new System.Drawing.Size(75, 40);
            this.maxX.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.maxX.TabIndex = 5;
            this.maxX.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.maxX.TextMarginBottom = 0;
            this.maxX.TextMarginLeft = 3;
            this.maxX.TextMarginTop = 1;
            this.maxX.TextPlaceholder = "max";
            this.bunifuToolTip.SetToolTip(this.maxX, "Поле для введення максимального значення х");
            this.bunifuToolTip.SetToolTipIcon(this.maxX, null);
            this.bunifuToolTip.SetToolTipTitle(this.maxX, "");
            this.maxX.UseSystemPasswordChar = false;
            this.maxX.WordWrap = true;
            this.maxX.TextChange += new System.EventHandler(this.CheckActive);
            this.maxX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MaxLengthTextBox);
            // 
            // minX
            // 
            this.minX.AcceptsReturn = false;
            this.minX.AcceptsTab = false;
            this.minX.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.minX.AnimationSpeed = 200;
            this.minX.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.minX.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.minX.AutoSizeHeight = true;
            this.minX.BackColor = System.Drawing.Color.Transparent;
            this.minX.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("minX.BackgroundImage")));
            this.minX.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.minX.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.minX.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.minX.BorderColorIdle = System.Drawing.Color.Silver;
            this.minX.BorderRadius = 10;
            this.minX.BorderThickness = 1;
            this.minX.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.minX.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.minX.DefaultFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minX.DefaultText = "";
            this.minX.FillColor = System.Drawing.Color.White;
            this.minX.HideSelection = true;
            this.minX.IconLeft = null;
            this.minX.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.minX.IconPadding = 10;
            this.minX.IconRight = null;
            this.minX.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.minX.Lines = new string[0];
            this.minX.Location = new System.Drawing.Point(120, 12);
            this.minX.MaxLength = 6;
            this.minX.MinimumSize = new System.Drawing.Size(1, 1);
            this.minX.Modified = false;
            this.minX.Multiline = false;
            this.minX.Name = "minX";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.minX.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.minX.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.minX.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.minX.OnIdleState = stateProperties8;
            this.minX.Padding = new System.Windows.Forms.Padding(3);
            this.minX.PasswordChar = '\0';
            this.minX.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.minX.PlaceholderText = "min";
            this.minX.ReadOnly = false;
            this.minX.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.minX.SelectedText = "";
            this.minX.SelectionLength = 0;
            this.minX.SelectionStart = 0;
            this.minX.ShortcutsEnabled = true;
            this.minX.Size = new System.Drawing.Size(75, 40);
            this.minX.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.minX.TabIndex = 4;
            this.minX.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.minX.TextMarginBottom = 0;
            this.minX.TextMarginLeft = 3;
            this.minX.TextMarginTop = 1;
            this.minX.TextPlaceholder = "min";
            this.bunifuToolTip.SetToolTip(this.minX, "Поле для введення мінімального значення х");
            this.bunifuToolTip.SetToolTipIcon(this.minX, null);
            this.bunifuToolTip.SetToolTipTitle(this.minX, "");
            this.minX.UseSystemPasswordChar = false;
            this.minX.WordWrap = true;
            this.minX.TextChange += new System.EventHandler(this.CheckActive);
            this.minX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MaxLengthTextBox);
            // 
            // stepX
            // 
            this.stepX.AcceptsReturn = false;
            this.stepX.AcceptsTab = false;
            this.stepX.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.stepX.AnimationSpeed = 200;
            this.stepX.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.stepX.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.stepX.AutoSizeHeight = true;
            this.stepX.BackColor = System.Drawing.Color.Transparent;
            this.stepX.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("stepX.BackgroundImage")));
            this.stepX.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.stepX.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.stepX.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.stepX.BorderColorIdle = System.Drawing.Color.Silver;
            this.stepX.BorderRadius = 10;
            this.stepX.BorderThickness = 1;
            this.stepX.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.stepX.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.stepX.DefaultFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stepX.DefaultText = "";
            this.stepX.FillColor = System.Drawing.Color.White;
            this.stepX.HideSelection = true;
            this.stepX.IconLeft = null;
            this.stepX.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.stepX.IconPadding = 10;
            this.stepX.IconRight = null;
            this.stepX.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.stepX.Lines = new string[0];
            this.stepX.Location = new System.Drawing.Point(765, 12);
            this.stepX.MaxLength = 6;
            this.stepX.MinimumSize = new System.Drawing.Size(1, 1);
            this.stepX.Modified = false;
            this.stepX.Multiline = false;
            this.stepX.Name = "stepX";
            stateProperties9.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties9.FillColor = System.Drawing.Color.Empty;
            stateProperties9.ForeColor = System.Drawing.Color.Empty;
            stateProperties9.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.stepX.OnActiveState = stateProperties9;
            stateProperties10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties10.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties10.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.stepX.OnDisabledState = stateProperties10;
            stateProperties11.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties11.FillColor = System.Drawing.Color.Empty;
            stateProperties11.ForeColor = System.Drawing.Color.Empty;
            stateProperties11.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.stepX.OnHoverState = stateProperties11;
            stateProperties12.BorderColor = System.Drawing.Color.Silver;
            stateProperties12.FillColor = System.Drawing.Color.White;
            stateProperties12.ForeColor = System.Drawing.Color.Empty;
            stateProperties12.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.stepX.OnIdleState = stateProperties12;
            this.stepX.Padding = new System.Windows.Forms.Padding(3);
            this.stepX.PasswordChar = '\0';
            this.stepX.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.stepX.PlaceholderText = "h";
            this.stepX.ReadOnly = false;
            this.stepX.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.stepX.SelectedText = "";
            this.stepX.SelectionLength = 0;
            this.stepX.SelectionStart = 0;
            this.stepX.ShortcutsEnabled = true;
            this.stepX.Size = new System.Drawing.Size(75, 40);
            this.stepX.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.stepX.TabIndex = 3;
            this.stepX.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.stepX.TextMarginBottom = 0;
            this.stepX.TextMarginLeft = 3;
            this.stepX.TextMarginTop = 1;
            this.stepX.TextPlaceholder = "h";
            this.bunifuToolTip.SetToolTip(this.stepX, "Поле для введення кроку ціиклу");
            this.bunifuToolTip.SetToolTipIcon(this.stepX, null);
            this.bunifuToolTip.SetToolTipTitle(this.stepX, "");
            this.stepX.UseSystemPasswordChar = false;
            this.stepX.WordWrap = true;
            this.stepX.TextChange += new System.EventHandler(this.CheckActive);
            this.stepX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MaxLengthTextBox);
            // 
            // bunifuToolTip
            // 
            this.bunifuToolTip.Active = true;
            this.bunifuToolTip.AlignTextWithTitle = false;
            this.bunifuToolTip.AllowAutoClose = false;
            this.bunifuToolTip.AllowFading = true;
            this.bunifuToolTip.AutoCloseDuration = 5000;
            this.bunifuToolTip.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuToolTip.BorderColor = System.Drawing.Color.Gainsboro;
            this.bunifuToolTip.ClickToShowDisplayControl = false;
            this.bunifuToolTip.ConvertNewlinesToBreakTags = true;
            this.bunifuToolTip.DisplayControl = null;
            this.bunifuToolTip.EntryAnimationSpeed = 350;
            this.bunifuToolTip.ExitAnimationSpeed = 200;
            this.bunifuToolTip.GenerateAutoCloseDuration = false;
            this.bunifuToolTip.IconMargin = 6;
            this.bunifuToolTip.InitialDelay = 0;
            this.bunifuToolTip.Name = "bunifuToolTip";
            this.bunifuToolTip.Opacity = 1D;
            this.bunifuToolTip.OverrideToolTipTitles = false;
            this.bunifuToolTip.Padding = new System.Windows.Forms.Padding(10);
            this.bunifuToolTip.ReshowDelay = 100;
            this.bunifuToolTip.ShowAlways = true;
            this.bunifuToolTip.ShowBorders = false;
            this.bunifuToolTip.ShowIcons = true;
            this.bunifuToolTip.ShowShadows = true;
            this.bunifuToolTip.Tag = null;
            this.bunifuToolTip.TextFont = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuToolTip.TextForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuToolTip.TextMargin = 2;
            this.bunifuToolTip.TitleFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.bunifuToolTip.TitleForeColor = System.Drawing.Color.Black;
            this.bunifuToolTip.ToolTipPosition = new System.Drawing.Point(0, 0);
            this.bunifuToolTip.ToolTipTitle = null;
            // 
            // bunifuSnackbar
            // 
            this.bunifuSnackbar.AllowDragging = false;
            this.bunifuSnackbar.AllowMultipleViews = true;
            this.bunifuSnackbar.ClickToClose = true;
            this.bunifuSnackbar.DoubleClickToClose = true;
            this.bunifuSnackbar.DurationAfterIdle = 3000;
            this.bunifuSnackbar.ErrorOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar.ErrorOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar.ErrorOptions.ActionBorderRadius = 1;
            this.bunifuSnackbar.ErrorOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.bunifuSnackbar.ErrorOptions.ActionForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar.ErrorOptions.BackColor = System.Drawing.Color.White;
            this.bunifuSnackbar.ErrorOptions.BorderColor = System.Drawing.Color.White;
            this.bunifuSnackbar.ErrorOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(199)))));
            this.bunifuSnackbar.ErrorOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.bunifuSnackbar.ErrorOptions.ForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar.ErrorOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon")));
            this.bunifuSnackbar.ErrorOptions.IconLeftMargin = 12;
            this.bunifuSnackbar.FadeCloseIcon = false;
            this.bunifuSnackbar.Host = Bunifu.UI.WinForms.BunifuSnackbar.Hosts.FormOwner;
            this.bunifuSnackbar.InformationOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar.InformationOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar.InformationOptions.ActionBorderRadius = 1;
            this.bunifuSnackbar.InformationOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.bunifuSnackbar.InformationOptions.ActionForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar.InformationOptions.BackColor = System.Drawing.Color.White;
            this.bunifuSnackbar.InformationOptions.BorderColor = System.Drawing.Color.White;
            this.bunifuSnackbar.InformationOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar.InformationOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.bunifuSnackbar.InformationOptions.ForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar.InformationOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon1")));
            this.bunifuSnackbar.InformationOptions.IconLeftMargin = 12;
            this.bunifuSnackbar.Margin = 10;
            this.bunifuSnackbar.MaximumSize = new System.Drawing.Size(0, 0);
            this.bunifuSnackbar.MaximumViews = 7;
            this.bunifuSnackbar.MessageRightMargin = 15;
            this.bunifuSnackbar.MinimumSize = new System.Drawing.Size(0, 0);
            this.bunifuSnackbar.ShowBorders = false;
            this.bunifuSnackbar.ShowCloseIcon = false;
            this.bunifuSnackbar.ShowIcon = true;
            this.bunifuSnackbar.ShowShadows = true;
            this.bunifuSnackbar.SuccessOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar.SuccessOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar.SuccessOptions.ActionBorderRadius = 1;
            this.bunifuSnackbar.SuccessOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.bunifuSnackbar.SuccessOptions.ActionForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar.SuccessOptions.BackColor = System.Drawing.Color.White;
            this.bunifuSnackbar.SuccessOptions.BorderColor = System.Drawing.Color.White;
            this.bunifuSnackbar.SuccessOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(255)))), ((int)(((byte)(237)))));
            this.bunifuSnackbar.SuccessOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.bunifuSnackbar.SuccessOptions.ForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar.SuccessOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon2")));
            this.bunifuSnackbar.SuccessOptions.IconLeftMargin = 12;
            this.bunifuSnackbar.ViewsMargin = 7;
            this.bunifuSnackbar.WarningOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar.WarningOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar.WarningOptions.ActionBorderRadius = 1;
            this.bunifuSnackbar.WarningOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.bunifuSnackbar.WarningOptions.ActionForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar.WarningOptions.BackColor = System.Drawing.Color.White;
            this.bunifuSnackbar.WarningOptions.BorderColor = System.Drawing.Color.White;
            this.bunifuSnackbar.WarningOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(143)))));
            this.bunifuSnackbar.WarningOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.bunifuSnackbar.WarningOptions.ForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar.WarningOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon3")));
            this.bunifuSnackbar.WarningOptions.IconLeftMargin = 12;
            this.bunifuSnackbar.ZoomCloseIcon = true;
            // 
            // FormTaskThree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(895, 542);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelRight);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormTaskThree";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "Завдання №3";
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.panelRight.ResumeLayout(false);
            this.panelButtonActivGraph.ResumeLayout(false);
            this.panelLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataResult)).EndInit();
            this.tableLayoutPanelFunction.ResumeLayout(false);
            this.panelButtonResult.ResumeLayout(false);
            this.panelSetData.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Panel panelButtonActivGraph;
        private Bunifu.UI.WinForms.BunifuButton.BunifuIconButton buttonActiveGraph;
        private System.Windows.Forms.Panel panelLeft;
        private Bunifu.UI.WinForms.BunifuToolTip bunifuToolTip;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelFunction;
        private Bunifu.UI.WinForms.BunifuLabel labelDataX;
        private Bunifu.UI.WinForms.BunifuImageButton buttonFunction1;
        private Bunifu.UI.WinForms.BunifuImageButton buttonFunction2;
        private Bunifu.UI.WinForms.BunifuImageButton buttonFunction3;
        private Bunifu.UI.WinForms.BunifuImageButton buttonFunction4;
        private Bunifu.UI.WinForms.BunifuImageButton buttonFunction5;
        private Bunifu.UI.WinForms.BunifuImageButton buttonFunction6;
        private Bunifu.UI.WinForms.BunifuImageButton buttonFunction7;
        private System.Windows.Forms.Panel panelButtonResult;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 buttonResult;
        private System.Windows.Forms.Panel panelSetData;
        private Bunifu.UI.WinForms.BunifuLabel labelXStep;
        private Bunifu.UI.WinForms.BunifuLabel labelXmax;
        private Bunifu.UI.WinForms.BunifuLabel labelXmin;
        private Bunifu.UI.WinForms.BunifuTextBox maxX;
        private Bunifu.UI.WinForms.BunifuTextBox minX;
        private Bunifu.UI.WinForms.BunifuTextBox stepX;
        private Bunifu.UI.WinForms.BunifuDataGridView dataResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnX;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFunction1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFunction2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFunction3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFunction4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFunction5;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFunction6;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFunction7;
        private Bunifu.UI.WinForms.BunifuLabel labelInfo;
        private Bunifu.UI.WinForms.BunifuSnackbar bunifuSnackbar;
    }
}