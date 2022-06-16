namespace Practice
{
    partial class FormTaskFive
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTaskFive));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonSort = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.label4 = new System.Windows.Forms.Label();
            this.labelAutomatically = new System.Windows.Forms.Label();
            this.labelManually = new System.Windows.Forms.Label();
            this.radioButtonAutomatically = new Bunifu.UI.WinForms.BunifuRadioButton();
            this.radioButtonManually = new Bunifu.UI.WinForms.BunifuRadioButton();
            this.sizeMatrixNow = new System.Windows.Forms.Label();
            this.sizeMatrixMax = new System.Windows.Forms.Label();
            this.sizeMatrixMin = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sizeMatrix = new Bunifu.UI.WinForms.BunifuHSlider();
            this.dataResults = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataSortResults = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataResults)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSortResults)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonSort);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.labelAutomatically);
            this.panel1.Controls.Add(this.labelManually);
            this.panel1.Controls.Add(this.radioButtonAutomatically);
            this.panel1.Controls.Add(this.radioButtonManually);
            this.panel1.Controls.Add(this.sizeMatrixNow);
            this.panel1.Controls.Add(this.sizeMatrixMax);
            this.panel1.Controls.Add(this.sizeMatrixMin);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.sizeMatrix);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 150);
            this.panel1.TabIndex = 1;
            // 
            // buttonSort
            // 
            this.buttonSort.AllowAnimations = true;
            this.buttonSort.AllowMouseEffects = true;
            this.buttonSort.AllowToggling = false;
            this.buttonSort.AnimationSpeed = 200;
            this.buttonSort.AutoGenerateColors = false;
            this.buttonSort.AutoRoundBorders = false;
            this.buttonSort.AutoSizeLeftIcon = true;
            this.buttonSort.AutoSizeRightIcon = true;
            this.buttonSort.BackColor = System.Drawing.Color.Transparent;
            this.buttonSort.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.buttonSort.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSort.BackgroundImage")));
            this.buttonSort.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.buttonSort.ButtonText = "Сортувати";
            this.buttonSort.ButtonTextMarginLeft = 0;
            this.buttonSort.ColorContrastOnClick = 45;
            this.buttonSort.ColorContrastOnHover = 45;
            this.buttonSort.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.buttonSort.CustomizableEdges = borderEdges1;
            this.buttonSort.DialogResult = System.Windows.Forms.DialogResult.None;
            this.buttonSort.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.buttonSort.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.buttonSort.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.buttonSort.Enabled = false;
            this.buttonSort.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.buttonSort.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonSort.ForeColor = System.Drawing.Color.White;
            this.buttonSort.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSort.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.buttonSort.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.buttonSort.IconMarginLeft = 11;
            this.buttonSort.IconPadding = 10;
            this.buttonSort.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSort.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.buttonSort.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.buttonSort.IconSize = 25;
            this.buttonSort.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.buttonSort.IdleBorderRadius = 40;
            this.buttonSort.IdleBorderThickness = 1;
            this.buttonSort.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.buttonSort.IdleIconLeftImage = null;
            this.buttonSort.IdleIconRightImage = null;
            this.buttonSort.IndicateFocus = false;
            this.buttonSort.Location = new System.Drawing.Point(579, 103);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.buttonSort.OnDisabledState.BorderRadius = 40;
            this.buttonSort.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.buttonSort.OnDisabledState.BorderThickness = 1;
            this.buttonSort.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.buttonSort.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.buttonSort.OnDisabledState.IconLeftImage = null;
            this.buttonSort.OnDisabledState.IconRightImage = null;
            this.buttonSort.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.buttonSort.onHoverState.BorderRadius = 40;
            this.buttonSort.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.buttonSort.onHoverState.BorderThickness = 1;
            this.buttonSort.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.buttonSort.onHoverState.ForeColor = System.Drawing.Color.White;
            this.buttonSort.onHoverState.IconLeftImage = null;
            this.buttonSort.onHoverState.IconRightImage = null;
            this.buttonSort.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.buttonSort.OnIdleState.BorderRadius = 40;
            this.buttonSort.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.buttonSort.OnIdleState.BorderThickness = 1;
            this.buttonSort.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.buttonSort.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.buttonSort.OnIdleState.IconLeftImage = null;
            this.buttonSort.OnIdleState.IconRightImage = null;
            this.buttonSort.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.buttonSort.OnPressedState.BorderRadius = 40;
            this.buttonSort.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.buttonSort.OnPressedState.BorderThickness = 1;
            this.buttonSort.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.buttonSort.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.buttonSort.OnPressedState.IconLeftImage = null;
            this.buttonSort.OnPressedState.IconRightImage = null;
            this.buttonSort.Size = new System.Drawing.Size(150, 40);
            this.buttonSort.TabIndex = 10;
            this.buttonSort.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonSort.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.buttonSort.TextMarginLeft = 0;
            this.buttonSort.TextPadding = new System.Windows.Forms.Padding(0);
            this.buttonSort.UseDefaultRadiusAndThickness = true;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(135, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Спосіб заповнення даних";
            // 
            // labelAutomatically
            // 
            this.labelAutomatically.AutoSize = true;
            this.labelAutomatically.Location = new System.Drawing.Point(307, 130);
            this.labelAutomatically.Name = "labelAutomatically";
            this.labelAutomatically.Size = new System.Drawing.Size(73, 13);
            this.labelAutomatically.TabIndex = 8;
            this.labelAutomatically.Text = "Автоматично";
            // 
            // labelManually
            // 
            this.labelManually.AutoSize = true;
            this.labelManually.Location = new System.Drawing.Point(52, 119);
            this.labelManually.Name = "labelManually";
            this.labelManually.Size = new System.Drawing.Size(41, 13);
            this.labelManually.TabIndex = 7;
            this.labelManually.Text = "Вручну";
            // 
            // radioButtonAutomatically
            // 
            this.radioButtonAutomatically.AllowBindingControlLocation = false;
            this.radioButtonAutomatically.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonAutomatically.BindingControlPosition = Bunifu.UI.WinForms.BunifuRadioButton.BindingControlPositions.Right;
            this.radioButtonAutomatically.BorderThickness = 1;
            this.radioButtonAutomatically.Checked = false;
            this.radioButtonAutomatically.Location = new System.Drawing.Point(280, 122);
            this.radioButtonAutomatically.Name = "radioButtonAutomatically";
            this.radioButtonAutomatically.OutlineColor = System.Drawing.Color.DodgerBlue;
            this.radioButtonAutomatically.OutlineColorTabFocused = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.radioButtonAutomatically.OutlineColorUnchecked = System.Drawing.Color.DarkGray;
            this.radioButtonAutomatically.RadioColor = System.Drawing.Color.DodgerBlue;
            this.radioButtonAutomatically.RadioColorTabFocused = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.radioButtonAutomatically.Size = new System.Drawing.Size(21, 21);
            this.radioButtonAutomatically.TabIndex = 6;
            this.radioButtonAutomatically.Text = null;
            this.radioButtonAutomatically.CheckedChanged2 += new System.EventHandler<Bunifu.UI.WinForms.BunifuRadioButton.CheckedChangedEventArgs>(this.RadioButtonAutomatically_CheckedChanged2);
            // 
            // radioButtonManually
            // 
            this.radioButtonManually.AllowBindingControlLocation = false;
            this.radioButtonManually.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonManually.BindingControlPosition = Bunifu.UI.WinForms.BunifuRadioButton.BindingControlPositions.Right;
            this.radioButtonManually.BorderThickness = 1;
            this.radioButtonManually.Checked = true;
            this.radioButtonManually.Location = new System.Drawing.Point(8, 119);
            this.radioButtonManually.Name = "radioButtonManually";
            this.radioButtonManually.OutlineColor = System.Drawing.Color.DodgerBlue;
            this.radioButtonManually.OutlineColorTabFocused = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.radioButtonManually.OutlineColorUnchecked = System.Drawing.Color.DarkGray;
            this.radioButtonManually.RadioColor = System.Drawing.Color.DodgerBlue;
            this.radioButtonManually.RadioColorTabFocused = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.radioButtonManually.Size = new System.Drawing.Size(21, 21);
            this.radioButtonManually.TabIndex = 5;
            this.radioButtonManually.Text = null;
            this.radioButtonManually.CheckedChanged2 += new System.EventHandler<Bunifu.UI.WinForms.BunifuRadioButton.CheckedChangedEventArgs>(this.RadioButtonManually_CheckedChanged2);
            // 
            // sizeMatrixNow
            // 
            this.sizeMatrixNow.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.sizeMatrixNow.AutoSize = true;
            this.sizeMatrixNow.Location = new System.Drawing.Point(387, 43);
            this.sizeMatrixNow.Name = "sizeMatrixNow";
            this.sizeMatrixNow.Size = new System.Drawing.Size(13, 13);
            this.sizeMatrixNow.TabIndex = 4;
            this.sizeMatrixNow.Text = "1";
            // 
            // sizeMatrixMax
            // 
            this.sizeMatrixMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sizeMatrixMax.AutoSize = true;
            this.sizeMatrixMax.Location = new System.Drawing.Point(759, 43);
            this.sizeMatrixMax.Name = "sizeMatrixMax";
            this.sizeMatrixMax.Size = new System.Drawing.Size(13, 13);
            this.sizeMatrixMax.TabIndex = 3;
            this.sizeMatrixMax.Text = "6";
            // 
            // sizeMatrixMin
            // 
            this.sizeMatrixMin.AutoSize = true;
            this.sizeMatrixMin.Location = new System.Drawing.Point(12, 43);
            this.sizeMatrixMin.Name = "sizeMatrixMin";
            this.sizeMatrixMin.Size = new System.Drawing.Size(13, 13);
            this.sizeMatrixMin.TabIndex = 2;
            this.sizeMatrixMin.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(328, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Оберіть розмір матриці (nxn)";
            // 
            // sizeMatrix
            // 
            this.sizeMatrix.AllowCursorChanges = true;
            this.sizeMatrix.AllowHomeEndKeysDetection = false;
            this.sizeMatrix.AllowIncrementalClickMoves = false;
            this.sizeMatrix.AllowMouseDownEffects = false;
            this.sizeMatrix.AllowMouseHoverEffects = false;
            this.sizeMatrix.AllowScrollingAnimations = true;
            this.sizeMatrix.AllowScrollKeysDetection = true;
            this.sizeMatrix.AllowScrollOptionsMenu = false;
            this.sizeMatrix.AllowShrinkingOnFocusLost = false;
            this.sizeMatrix.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sizeMatrix.BackColor = System.Drawing.Color.Transparent;
            this.sizeMatrix.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sizeMatrix.BackgroundImage")));
            this.sizeMatrix.BindingContainer = null;
            this.sizeMatrix.BorderRadius = 2;
            this.sizeMatrix.BorderThickness = 1;
            this.sizeMatrix.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sizeMatrix.DrawThickBorder = false;
            this.sizeMatrix.DurationBeforeShrink = 2000;
            this.sizeMatrix.ElapsedColor = System.Drawing.Color.DodgerBlue;
            this.sizeMatrix.LargeChange = 1;
            this.sizeMatrix.Location = new System.Drawing.Point(12, 59);
            this.sizeMatrix.Maximum = 5;
            this.sizeMatrix.Minimum = 1;
            this.sizeMatrix.MinimumSize = new System.Drawing.Size(0, 31);
            this.sizeMatrix.MinimumThumbLength = 18;
            this.sizeMatrix.Name = "sizeMatrix";
            this.sizeMatrix.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver;
            this.sizeMatrix.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent;
            this.sizeMatrix.OnDisable.ThumbColor = System.Drawing.Color.Silver;
            this.sizeMatrix.ScrollBarBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.sizeMatrix.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.sizeMatrix.ShrinkSizeLimit = 3;
            this.sizeMatrix.Size = new System.Drawing.Size(760, 31);
            this.sizeMatrix.SliderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.sizeMatrix.SliderStyle = Bunifu.UI.WinForms.BunifuHSlider.SliderStyles.Thin;
            this.sizeMatrix.SliderThumbStyle = Utilities.BunifuSlider.BunifuHScrollBar.SliderThumbStyles.Circular;
            this.sizeMatrix.SmallChange = 1;
            this.sizeMatrix.TabIndex = 0;
            this.sizeMatrix.ThumbColor = System.Drawing.Color.DodgerBlue;
            this.sizeMatrix.ThumbFillColor = System.Drawing.SystemColors.Control;
            this.sizeMatrix.ThumbLength = 152;
            this.sizeMatrix.ThumbMargin = 1;
            this.sizeMatrix.ThumbSize = Bunifu.UI.WinForms.BunifuHSlider.ThumbSizes.Medium;
            this.sizeMatrix.ThumbStyle = Bunifu.UI.WinForms.BunifuHSlider.ThumbStyles.Outline;
            this.sizeMatrix.Value = 1;
            this.sizeMatrix.Scroll += new System.EventHandler<Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs>(this.SizeMatrix_Scroll);
            // 
            // dataResults
            // 
            this.dataResults.AllowUserToAddRows = false;
            this.dataResults.AllowUserToDeleteRows = false;
            this.dataResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataResults.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataResults.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataResults.ColumnHeadersHeight = 40;
            this.dataResults.ColumnHeadersVisible = false;
            this.dataResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataResults.EnableHeadersVisualStyles = false;
            this.dataResults.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dataResults.Location = new System.Drawing.Point(3, 3);
            this.dataResults.Name = "dataResults";
            this.dataResults.Size = new System.Drawing.Size(794, 144);
            this.dataResults.TabIndex = 4;
            this.dataResults.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataResults_CellEndEdit);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dataSortResults, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dataResults, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 150);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 300);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // dataSortResult
            // 
            this.dataSortResults.AllowUserToAddRows = false;
            this.dataSortResults.AllowUserToDeleteRows = false;
            this.dataSortResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataSortResults.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataSortResults.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataSortResults.ColumnHeadersHeight = 40;
            this.dataSortResults.ColumnHeadersVisible = false;
            this.dataSortResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataSortResults.EnableHeadersVisualStyles = false;
            this.dataSortResults.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dataSortResults.Location = new System.Drawing.Point(3, 153);
            this.dataSortResults.Name = "dataSortResult";
            this.dataSortResults.Size = new System.Drawing.Size(794, 144);
            this.dataSortResults.TabIndex = 5;
            // 
            // FormTaskFive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormTaskFive";
            this.Text = "Завдання №5";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataResults)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataSortResults)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label sizeMatrixNow;
        private System.Windows.Forms.Label sizeMatrixMax;
        private System.Windows.Forms.Label sizeMatrixMin;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuHSlider sizeMatrix;
        private System.Windows.Forms.DataGridView dataResults;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelAutomatically;
        private System.Windows.Forms.Label labelManually;
        private Bunifu.UI.WinForms.BunifuRadioButton radioButtonAutomatically;
        private Bunifu.UI.WinForms.BunifuRadioButton radioButtonManually;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 buttonSort;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataSortResults;
    }
}