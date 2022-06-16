namespace Practice
{
    partial class FormTaskTwo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTaskTwo));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sizeVectorNow = new System.Windows.Forms.Label();
            this.sizeVectorMax = new System.Windows.Forms.Label();
            this.sizeVectorMin = new System.Windows.Forms.Label();
            this.labelSizeTitle = new System.Windows.Forms.Label();
            this.sizeVector = new Bunifu.UI.WinForms.BunifuHSlider();
            this.panelSetDate = new System.Windows.Forms.Panel();
            this.dataVectorY = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataMatrix = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataVectorX = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelResult = new System.Windows.Forms.Panel();
            this.resultInfo = new Bunifu.UI.WinForms.BunifuLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonResult = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.bunifuSnackbar = new Bunifu.UI.WinForms.BunifuSnackbar(this.components);
            this.bunifuToolTip = new Bunifu.UI.WinForms.BunifuToolTip(this.components);
            this.panel1.SuspendLayout();
            this.panelSetDate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataVectorY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataMatrix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataVectorX)).BeginInit();
            this.panel3.SuspendLayout();
            this.panelResult.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.sizeVectorNow);
            this.panel1.Controls.Add(this.sizeVectorMax);
            this.panel1.Controls.Add(this.sizeVectorMin);
            this.panel1.Controls.Add(this.labelSizeTitle);
            this.panel1.Controls.Add(this.sizeVector);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(637, 90);
            this.panel1.TabIndex = 0;
            this.bunifuToolTip.SetToolTip(this.panel1, "");
            this.bunifuToolTip.SetToolTipIcon(this.panel1, null);
            this.bunifuToolTip.SetToolTipTitle(this.panel1, "");
            // 
            // sizeVectorNow
            // 
            this.sizeVectorNow.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.sizeVectorNow.AutoSize = true;
            this.sizeVectorNow.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sizeVectorNow.Location = new System.Drawing.Point(309, 36);
            this.sizeVectorNow.Name = "sizeVectorNow";
            this.sizeVectorNow.Size = new System.Drawing.Size(17, 19);
            this.sizeVectorNow.TabIndex = 4;
            this.sizeVectorNow.Text = "6";
            this.bunifuToolTip.SetToolTip(this.sizeVectorNow, "Поточне значення для розміру");
            this.bunifuToolTip.SetToolTipIcon(this.sizeVectorNow, null);
            this.bunifuToolTip.SetToolTipTitle(this.sizeVectorNow, "");
            // 
            // sizeVectorMax
            // 
            this.sizeVectorMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sizeVectorMax.AutoSize = true;
            this.sizeVectorMax.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sizeVectorMax.Location = new System.Drawing.Point(600, 36);
            this.sizeVectorMax.Name = "sizeVectorMax";
            this.sizeVectorMax.Size = new System.Drawing.Size(17, 19);
            this.sizeVectorMax.TabIndex = 3;
            this.sizeVectorMax.Text = "6";
            this.bunifuToolTip.SetToolTip(this.sizeVectorMax, "Максимальне доступне значення для розміру");
            this.bunifuToolTip.SetToolTipIcon(this.sizeVectorMax, null);
            this.bunifuToolTip.SetToolTipTitle(this.sizeVectorMax, "");
            // 
            // sizeVectorMin
            // 
            this.sizeVectorMin.AutoSize = true;
            this.sizeVectorMin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sizeVectorMin.Location = new System.Drawing.Point(16, 36);
            this.sizeVectorMin.Name = "sizeVectorMin";
            this.sizeVectorMin.Size = new System.Drawing.Size(17, 19);
            this.sizeVectorMin.TabIndex = 2;
            this.sizeVectorMin.Text = "1";
            this.bunifuToolTip.SetToolTip(this.sizeVectorMin, "Мінімальне доступне значення для розміру");
            this.bunifuToolTip.SetToolTipIcon(this.sizeVectorMin, null);
            this.bunifuToolTip.SetToolTipTitle(this.sizeVectorMin, "");
            // 
            // labelSizeTitle
            // 
            this.labelSizeTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelSizeTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSizeTitle.Location = new System.Drawing.Point(125, 0);
            this.labelSizeTitle.Name = "labelSizeTitle";
            this.labelSizeTitle.Size = new System.Drawing.Size(397, 30);
            this.labelSizeTitle.TabIndex = 1;
            this.labelSizeTitle.Text = "Оберіть розмір матриці (NxN) та векторів (N)";
            this.labelSizeTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuToolTip.SetToolTip(this.labelSizeTitle, "");
            this.bunifuToolTip.SetToolTipIcon(this.labelSizeTitle, null);
            this.bunifuToolTip.SetToolTipTitle(this.labelSizeTitle, "");
            // 
            // sizeVector
            // 
            this.sizeVector.AllowCursorChanges = true;
            this.sizeVector.AllowHomeEndKeysDetection = false;
            this.sizeVector.AllowIncrementalClickMoves = true;
            this.sizeVector.AllowMouseDownEffects = false;
            this.sizeVector.AllowMouseHoverEffects = false;
            this.sizeVector.AllowScrollingAnimations = true;
            this.sizeVector.AllowScrollKeysDetection = true;
            this.sizeVector.AllowScrollOptionsMenu = true;
            this.sizeVector.AllowShrinkingOnFocusLost = false;
            this.sizeVector.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sizeVector.BackColor = System.Drawing.Color.Transparent;
            this.sizeVector.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sizeVector.BackgroundImage")));
            this.sizeVector.BindingContainer = null;
            this.sizeVector.BorderRadius = 2;
            this.sizeVector.BorderThickness = 1;
            this.sizeVector.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sizeVector.DrawThickBorder = false;
            this.sizeVector.DurationBeforeShrink = 2000;
            this.sizeVector.ElapsedColor = System.Drawing.Color.DodgerBlue;
            this.sizeVector.LargeChange = 1;
            this.sizeVector.Location = new System.Drawing.Point(20, 58);
            this.sizeVector.Maximum = 6;
            this.sizeVector.Minimum = 1;
            this.sizeVector.MinimumSize = new System.Drawing.Size(0, 31);
            this.sizeVector.MinimumThumbLength = 18;
            this.sizeVector.Name = "sizeVector";
            this.sizeVector.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver;
            this.sizeVector.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent;
            this.sizeVector.OnDisable.ThumbColor = System.Drawing.Color.Silver;
            this.sizeVector.ScrollBarBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.sizeVector.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.sizeVector.ShrinkSizeLimit = 3;
            this.sizeVector.Size = new System.Drawing.Size(597, 31);
            this.sizeVector.SliderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.sizeVector.SliderStyle = Bunifu.UI.WinForms.BunifuHSlider.SliderStyles.Thin;
            this.sizeVector.SliderThumbStyle = Utilities.BunifuSlider.BunifuHScrollBar.SliderThumbStyles.Circular;
            this.sizeVector.SmallChange = 1;
            this.sizeVector.TabIndex = 0;
            this.sizeVector.ThumbColor = System.Drawing.Color.DodgerBlue;
            this.sizeVector.ThumbFillColor = System.Drawing.SystemColors.Control;
            this.sizeVector.ThumbLength = 99;
            this.sizeVector.ThumbMargin = 1;
            this.sizeVector.ThumbSize = Bunifu.UI.WinForms.BunifuHSlider.ThumbSizes.Medium;
            this.sizeVector.ThumbStyle = Bunifu.UI.WinForms.BunifuHSlider.ThumbStyles.Outline;
            this.bunifuToolTip.SetToolTip(this.sizeVector, "Натисніть та потягніть повзунець або натисніть в біль-якій точці на ньому, щоб ви" +
        "брати необхідний розмір");
            this.bunifuToolTip.SetToolTipIcon(this.sizeVector, null);
            this.bunifuToolTip.SetToolTipTitle(this.sizeVector, "");
            this.sizeVector.Value = 6;
            // 
            // panelSetDate
            // 
            this.panelSetDate.Controls.Add(this.dataVectorY);
            this.panelSetDate.Controls.Add(this.dataMatrix);
            this.panelSetDate.Controls.Add(this.label6);
            this.panelSetDate.Controls.Add(this.label5);
            this.panelSetDate.Controls.Add(this.label4);
            this.panelSetDate.Controls.Add(this.dataVectorX);
            this.panelSetDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSetDate.Location = new System.Drawing.Point(5, 95);
            this.panelSetDate.Name = "panelSetDate";
            this.panelSetDate.Size = new System.Drawing.Size(637, 115);
            this.panelSetDate.TabIndex = 1;
            this.bunifuToolTip.SetToolTip(this.panelSetDate, "");
            this.bunifuToolTip.SetToolTipIcon(this.panelSetDate, null);
            this.bunifuToolTip.SetToolTipTitle(this.panelSetDate, "");
            // 
            // dataVectorY
            // 
            this.dataVectorY.AllowCustomTheming = false;
            this.dataVectorY.AllowUserToAddRows = false;
            this.dataVectorY.AllowUserToDeleteRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black;
            this.dataVectorY.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dataVectorY.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataVectorY.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataVectorY.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataVectorY.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataVectorY.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataVectorY.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dataVectorY.ColumnHeadersHeight = 40;
            this.dataVectorY.ColumnHeadersVisible = false;
            this.dataVectorY.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dataVectorY.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dataVectorY.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dataVectorY.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataVectorY.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dataVectorY.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataVectorY.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dataVectorY.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dataVectorY.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dataVectorY.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dataVectorY.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataVectorY.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dataVectorY.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataVectorY.CurrentTheme.Name = null;
            this.dataVectorY.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataVectorY.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dataVectorY.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataVectorY.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dataVectorY.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataVectorY.Cursor = System.Windows.Forms.Cursors.IBeam;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataVectorY.DefaultCellStyle = dataGridViewCellStyle15;
            this.dataVectorY.EnableHeadersVisualStyles = false;
            this.dataVectorY.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dataVectorY.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dataVectorY.HeaderBgColor = System.Drawing.Color.Empty;
            this.dataVectorY.HeaderForeColor = System.Drawing.Color.White;
            this.dataVectorY.Location = new System.Drawing.Point(360, 15);
            this.dataVectorY.Name = "dataVectorY";
            this.dataVectorY.RowHeadersVisible = false;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataVectorY.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dataVectorY.RowTemplate.Height = 40;
            this.dataVectorY.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataVectorY.ShowCellToolTips = false;
            this.dataVectorY.Size = new System.Drawing.Size(266, 40);
            this.dataVectorY.TabIndex = 7;
            this.dataVectorY.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.bunifuToolTip.SetToolTip(this.dataVectorY, "Вектор Y");
            this.bunifuToolTip.SetToolTipIcon(this.dataVectorY, null);
            this.bunifuToolTip.SetToolTipTitle(this.dataVectorY, "");
            this.dataVectorY.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.CheckCellValueChanged);
            this.dataVectorY.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.Data_EditingControlShowing);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Column1";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Column2";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataMatrix
            // 
            this.dataMatrix.AllowCustomTheming = false;
            this.dataMatrix.AllowUserToAddRows = false;
            this.dataMatrix.AllowUserToDeleteRows = false;
            this.dataMatrix.AllowUserToResizeColumns = false;
            this.dataMatrix.AllowUserToResizeRows = false;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.Black;
            this.dataMatrix.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle17;
            this.dataMatrix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dataMatrix.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataMatrix.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataMatrix.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataMatrix.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataMatrix.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dataMatrix.ColumnHeadersHeight = 40;
            this.dataMatrix.ColumnHeadersVisible = false;
            this.dataMatrix.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dataMatrix.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dataMatrix.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dataMatrix.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataMatrix.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dataMatrix.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataMatrix.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dataMatrix.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dataMatrix.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dataMatrix.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dataMatrix.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataMatrix.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dataMatrix.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataMatrix.CurrentTheme.Name = null;
            this.dataMatrix.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataMatrix.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dataMatrix.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataMatrix.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dataMatrix.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataMatrix.Cursor = System.Windows.Forms.Cursors.IBeam;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataMatrix.DefaultCellStyle = dataGridViewCellStyle19;
            this.dataMatrix.EnableHeadersVisualStyles = false;
            this.dataMatrix.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dataMatrix.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dataMatrix.HeaderBgColor = System.Drawing.Color.Empty;
            this.dataMatrix.HeaderForeColor = System.Drawing.Color.White;
            this.dataMatrix.Location = new System.Drawing.Point(78, 65);
            this.dataMatrix.Name = "dataMatrix";
            this.dataMatrix.RowHeadersVisible = false;
            this.dataMatrix.RowHeadersWidth = 40;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataMatrix.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.dataMatrix.RowTemplate.Height = 40;
            this.dataMatrix.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataMatrix.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataMatrix.ShowCellToolTips = false;
            this.dataMatrix.Size = new System.Drawing.Size(520, 40);
            this.dataMatrix.TabIndex = 6;
            this.dataMatrix.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.bunifuToolTip.SetToolTip(this.dataMatrix, "Матриця A");
            this.bunifuToolTip.SetToolTipIcon(this.dataMatrix, null);
            this.bunifuToolTip.SetToolTipTitle(this.dataMatrix, "");
            this.dataMatrix.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.CheckCellValueChanged);
            this.dataMatrix.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.Data_EditingControlShowing);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Column1";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Column2";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(51, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "A";
            this.bunifuToolTip.SetToolTip(this.label6, "");
            this.bunifuToolTip.SetToolTipIcon(this.label6, null);
            this.bunifuToolTip.SetToolTipTitle(this.label6, "");
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(334, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 22);
            this.label5.TabIndex = 3;
            this.label5.Text = "Y";
            this.bunifuToolTip.SetToolTip(this.label5, "");
            this.bunifuToolTip.SetToolTipIcon(this.label5, null);
            this.bunifuToolTip.SetToolTipTitle(this.label5, "");
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(10, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 22);
            this.label4.TabIndex = 1;
            this.label4.Text = "X";
            this.bunifuToolTip.SetToolTip(this.label4, "");
            this.bunifuToolTip.SetToolTipIcon(this.label4, null);
            this.bunifuToolTip.SetToolTipTitle(this.label4, "");
            // 
            // dataVectorX
            // 
            this.dataVectorX.AllowCustomTheming = false;
            this.dataVectorX.AllowUserToAddRows = false;
            this.dataVectorX.AllowUserToDeleteRows = false;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.Black;
            this.dataVectorX.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle21;
            this.dataVectorX.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataVectorX.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataVectorX.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataVectorX.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataVectorX.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataVectorX.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.dataVectorX.ColumnHeadersHeight = 40;
            this.dataVectorX.ColumnHeadersVisible = false;
            this.dataVectorX.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataVectorX.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dataVectorX.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dataVectorX.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataVectorX.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dataVectorX.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataVectorX.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dataVectorX.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dataVectorX.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dataVectorX.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dataVectorX.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataVectorX.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dataVectorX.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataVectorX.CurrentTheme.Name = null;
            this.dataVectorX.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataVectorX.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dataVectorX.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataVectorX.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dataVectorX.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataVectorX.Cursor = System.Windows.Forms.Cursors.IBeam;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataVectorX.DefaultCellStyle = dataGridViewCellStyle23;
            this.dataVectorX.EnableHeadersVisualStyles = false;
            this.dataVectorX.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dataVectorX.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dataVectorX.HeaderBgColor = System.Drawing.Color.Empty;
            this.dataVectorX.HeaderForeColor = System.Drawing.Color.White;
            this.dataVectorX.Location = new System.Drawing.Point(35, 15);
            this.dataVectorX.Name = "dataVectorX";
            this.dataVectorX.RowHeadersVisible = false;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataVectorX.RowsDefaultCellStyle = dataGridViewCellStyle24;
            this.dataVectorX.RowTemplate.Height = 40;
            this.dataVectorX.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataVectorX.ShowCellToolTips = false;
            this.dataVectorX.Size = new System.Drawing.Size(275, 40);
            this.dataVectorX.TabIndex = 0;
            this.dataVectorX.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.bunifuToolTip.SetToolTip(this.dataVectorX, "Вектор X");
            this.bunifuToolTip.SetToolTipIcon(this.dataVectorX, null);
            this.bunifuToolTip.SetToolTipTitle(this.dataVectorX, "");
            this.dataVectorX.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.CheckCellValueChanged);
            this.dataVectorX.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.Data_EditingControlShowing);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panelResult);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(5, 210);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.panel3.Size = new System.Drawing.Size(637, 327);
            this.panel3.TabIndex = 2;
            this.bunifuToolTip.SetToolTip(this.panel3, "");
            this.bunifuToolTip.SetToolTipIcon(this.panel3, null);
            this.bunifuToolTip.SetToolTipTitle(this.panel3, "");
            // 
            // panelResult
            // 
            this.panelResult.AutoScroll = true;
            this.panelResult.Controls.Add(this.resultInfo);
            this.panelResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelResult.Location = new System.Drawing.Point(0, 55);
            this.panelResult.Name = "panelResult";
            this.panelResult.Size = new System.Drawing.Size(637, 272);
            this.panelResult.TabIndex = 9;
            this.bunifuToolTip.SetToolTip(this.panelResult, "");
            this.bunifuToolTip.SetToolTipIcon(this.panelResult, null);
            this.bunifuToolTip.SetToolTipTitle(this.panelResult, "");
            // 
            // resultInfo
            // 
            this.resultInfo.AllowParentOverrides = false;
            this.resultInfo.AutoEllipsis = false;
            this.resultInfo.AutoSize = false;
            this.resultInfo.Cursor = System.Windows.Forms.Cursors.Default;
            this.resultInfo.CursorType = System.Windows.Forms.Cursors.Default;
            this.resultInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultInfo.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultInfo.Location = new System.Drawing.Point(0, 0);
            this.resultInfo.Name = "resultInfo";
            this.resultInfo.Padding = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.resultInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.resultInfo.Size = new System.Drawing.Size(637, 272);
            this.resultInfo.TabIndex = 8;
            this.resultInfo.Text = "Поле для виведення результату";
            this.resultInfo.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.resultInfo.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.bunifuToolTip.SetToolTip(this.resultInfo, "");
            this.bunifuToolTip.SetToolTipIcon(this.resultInfo, null);
            this.bunifuToolTip.SetToolTipTitle(this.resultInfo, "");
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonResult);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(637, 50);
            this.panel2.TabIndex = 2;
            this.bunifuToolTip.SetToolTip(this.panel2, "");
            this.bunifuToolTip.SetToolTipIcon(this.panel2, null);
            this.bunifuToolTip.SetToolTipTitle(this.panel2, "");
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
            this.buttonResult.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
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
            this.buttonResult.Location = new System.Drawing.Point(268, 5);
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
            this.buttonResult.Size = new System.Drawing.Size(100, 40);
            this.buttonResult.TabIndex = 0;
            this.buttonResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonResult.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.buttonResult.TextMarginLeft = 0;
            this.buttonResult.TextPadding = new System.Windows.Forms.Padding(0);
            this.bunifuToolTip.SetToolTip(this.buttonResult, "Натисніть, щоб отримати готовий результат");
            this.bunifuToolTip.SetToolTipIcon(this.buttonResult, null);
            this.bunifuToolTip.SetToolTipTitle(this.buttonResult, "");
            this.buttonResult.UseDefaultRadiusAndThickness = true;
            this.buttonResult.Click += new System.EventHandler(this.Result_Click);
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
            // FormTaskTwo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(647, 542);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelSetDate);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormTaskTwo";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "Завдання №2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelSetDate.ResumeLayout(false);
            this.panelSetDate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataVectorY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataMatrix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataVectorX)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panelResult.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label sizeVectorNow;
        private System.Windows.Forms.Label sizeVectorMax;
        private System.Windows.Forms.Label sizeVectorMin;
        private System.Windows.Forms.Label labelSizeTitle;
        private Bunifu.UI.WinForms.BunifuHSlider sizeVector;
        private System.Windows.Forms.Panel panelSetDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.UI.WinForms.BunifuDataGridView dataVectorX;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private Bunifu.UI.WinForms.BunifuDataGridView dataMatrix;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private Bunifu.UI.WinForms.BunifuDataGridView dataVectorY;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 buttonResult;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.UI.WinForms.BunifuLabel resultInfo;
        private System.Windows.Forms.Panel panelResult;
        private Bunifu.UI.WinForms.BunifuSnackbar bunifuSnackbar;
        private Bunifu.UI.WinForms.BunifuToolTip bunifuToolTip;
    }
}