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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTaskFive));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            this.panel1 = new System.Windows.Forms.Panel();
            this.imageButtonNegative = new Bunifu.UI.WinForms.BunifuImageButton();
            this.imageButtonPositive = new Bunifu.UI.WinForms.BunifuImageButton();
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
            this.bunifuSnackbar = new Bunifu.UI.WinForms.BunifuSnackbar(this.components);
            this.bunifuToolTip = new Bunifu.UI.WinForms.BunifuToolTip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataResults)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSortResults)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.imageButtonNegative);
            this.panel1.Controls.Add(this.imageButtonPositive);
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
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(885, 220);
            this.panel1.TabIndex = 1;
            this.bunifuToolTip.SetToolTip(this.panel1, "");
            this.bunifuToolTip.SetToolTipIcon(this.panel1, null);
            this.bunifuToolTip.SetToolTipTitle(this.panel1, "");
            // 
            // imageButtonNegative
            // 
            this.imageButtonNegative.ActiveImage = global::Practice.Properties.Resources.zoom_out_64px;
            this.imageButtonNegative.AllowAnimations = true;
            this.imageButtonNegative.AllowBuffering = false;
            this.imageButtonNegative.AllowToggling = false;
            this.imageButtonNegative.AllowZooming = true;
            this.imageButtonNegative.AllowZoomingOnFocus = false;
            this.imageButtonNegative.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imageButtonNegative.BackColor = System.Drawing.Color.Transparent;
            this.imageButtonNegative.DialogResult = System.Windows.Forms.DialogResult.None;
            this.imageButtonNegative.Enabled = false;
            this.imageButtonNegative.ErrorImage = ((System.Drawing.Image)(resources.GetObject("imageButtonNegative.ErrorImage")));
            this.imageButtonNegative.FadeWhenInactive = false;
            this.imageButtonNegative.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.imageButtonNegative.Image = global::Practice.Properties.Resources.zoom_out_64px;
            this.imageButtonNegative.ImageActive = global::Practice.Properties.Resources.zoom_out_64px;
            this.imageButtonNegative.ImageLocation = null;
            this.imageButtonNegative.ImageMargin = 20;
            this.imageButtonNegative.ImageSize = new System.Drawing.Size(30, 30);
            this.imageButtonNegative.ImageZoomSize = new System.Drawing.Size(50, 50);
            this.imageButtonNegative.InitialImage = ((System.Drawing.Image)(resources.GetObject("imageButtonNegative.InitialImage")));
            this.imageButtonNegative.Location = new System.Drawing.Point(751, 150);
            this.imageButtonNegative.Name = "imageButtonNegative";
            this.imageButtonNegative.Rotation = 0;
            this.imageButtonNegative.ShowActiveImage = true;
            this.imageButtonNegative.ShowCursorChanges = true;
            this.imageButtonNegative.ShowImageBorders = true;
            this.imageButtonNegative.ShowSizeMarkers = false;
            this.imageButtonNegative.Size = new System.Drawing.Size(50, 50);
            this.imageButtonNegative.TabIndex = 12;
            this.imageButtonNegative.Tag = "true";
            this.bunifuToolTip.SetToolTip(this.imageButtonNegative, "Натисніть, щоб відобразити всі числа, які менші нуля");
            this.bunifuToolTip.SetToolTipIcon(this.imageButtonNegative, null);
            this.imageButtonNegative.ToolTipText = "";
            this.bunifuToolTip.SetToolTipTitle(this.imageButtonNegative, "");
            this.imageButtonNegative.WaitOnLoad = false;
            this.imageButtonNegative.Zoom = 20;
            this.imageButtonNegative.ZoomSpeed = 10;
            this.imageButtonNegative.Click += new System.EventHandler(this.ImageButtonNegative);
            // 
            // imageButtonPositive
            // 
            this.imageButtonPositive.ActiveImage = global::Practice.Properties.Resources.zoom_in_64px;
            this.imageButtonPositive.AllowAnimations = true;
            this.imageButtonPositive.AllowBuffering = false;
            this.imageButtonPositive.AllowToggling = false;
            this.imageButtonPositive.AllowZooming = true;
            this.imageButtonPositive.AllowZoomingOnFocus = false;
            this.imageButtonPositive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imageButtonPositive.BackColor = System.Drawing.Color.Transparent;
            this.imageButtonPositive.DialogResult = System.Windows.Forms.DialogResult.None;
            this.imageButtonPositive.Enabled = false;
            this.imageButtonPositive.ErrorImage = ((System.Drawing.Image)(resources.GetObject("imageButtonPositive.ErrorImage")));
            this.imageButtonPositive.FadeWhenInactive = false;
            this.imageButtonPositive.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.imageButtonPositive.Image = global::Practice.Properties.Resources.zoom_in_64px;
            this.imageButtonPositive.ImageActive = global::Practice.Properties.Resources.zoom_in_64px;
            this.imageButtonPositive.ImageLocation = null;
            this.imageButtonPositive.ImageMargin = 20;
            this.imageButtonPositive.ImageSize = new System.Drawing.Size(30, 30);
            this.imageButtonPositive.ImageZoomSize = new System.Drawing.Size(50, 50);
            this.imageButtonPositive.InitialImage = ((System.Drawing.Image)(resources.GetObject("imageButtonPositive.InitialImage")));
            this.imageButtonPositive.Location = new System.Drawing.Point(807, 150);
            this.imageButtonPositive.Name = "imageButtonPositive";
            this.imageButtonPositive.Rotation = 0;
            this.imageButtonPositive.ShowActiveImage = true;
            this.imageButtonPositive.ShowCursorChanges = true;
            this.imageButtonPositive.ShowImageBorders = true;
            this.imageButtonPositive.ShowSizeMarkers = false;
            this.imageButtonPositive.Size = new System.Drawing.Size(50, 50);
            this.imageButtonPositive.TabIndex = 11;
            this.imageButtonPositive.Tag = "true";
            this.bunifuToolTip.SetToolTip(this.imageButtonPositive, "Натисніть, щоб відобразити всі числа, які включно більші нуля");
            this.bunifuToolTip.SetToolTipIcon(this.imageButtonPositive, null);
            this.imageButtonPositive.ToolTipText = "";
            this.bunifuToolTip.SetToolTipTitle(this.imageButtonPositive, "");
            this.imageButtonPositive.WaitOnLoad = false;
            this.imageButtonPositive.Zoom = 20;
            this.imageButtonPositive.ZoomSpeed = 10;
            this.imageButtonPositive.Click += new System.EventHandler(this.ImageButtonPositive);
            // 
            // buttonSort
            // 
            this.buttonSort.AllowAnimations = true;
            this.buttonSort.AllowMouseEffects = true;
            this.buttonSort.AllowToggling = false;
            this.buttonSort.Anchor = System.Windows.Forms.AnchorStyles.Top;
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
            this.buttonSort.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.buttonSort.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
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
            this.buttonSort.Location = new System.Drawing.Point(367, 160);
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
            this.bunifuToolTip.SetToolTip(this.buttonSort, "Відсортувати таблицю");
            this.bunifuToolTip.SetToolTipIcon(this.buttonSort, null);
            this.bunifuToolTip.SetToolTipTitle(this.buttonSort, "");
            this.buttonSort.UseDefaultRadiusAndThickness = true;
            this.buttonSort.Click += new System.EventHandler(this.ButtonSort_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(331, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(223, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Спосіб заповнення даних";
            this.bunifuToolTip.SetToolTip(this.label4, "");
            this.bunifuToolTip.SetToolTipIcon(this.label4, null);
            this.bunifuToolTip.SetToolTipTitle(this.label4, "");
            // 
            // labelAutomatically
            // 
            this.labelAutomatically.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelAutomatically.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAutomatically.Location = new System.Drawing.Point(547, 120);
            this.labelAutomatically.Name = "labelAutomatically";
            this.labelAutomatically.Size = new System.Drawing.Size(100, 21);
            this.labelAutomatically.TabIndex = 8;
            this.labelAutomatically.Text = "Автоматично";
            this.labelAutomatically.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuToolTip.SetToolTip(this.labelAutomatically, "Заповнення даних таблиці відбувається автоматично в діапазоні від -1000 до 1000");
            this.bunifuToolTip.SetToolTipIcon(this.labelAutomatically, null);
            this.bunifuToolTip.SetToolTipTitle(this.labelAutomatically, "");
            // 
            // labelManually
            // 
            this.labelManually.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelManually.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelManually.Location = new System.Drawing.Point(287, 120);
            this.labelManually.Name = "labelManually";
            this.labelManually.Size = new System.Drawing.Size(85, 21);
            this.labelManually.TabIndex = 7;
            this.labelManually.Text = "Вручну";
            this.labelManually.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuToolTip.SetToolTip(this.labelManually, "Необхідно власноруч заповнити таблицю даними, щоб продовжити роботу");
            this.bunifuToolTip.SetToolTipIcon(this.labelManually, null);
            this.bunifuToolTip.SetToolTipTitle(this.labelManually, "");
            // 
            // radioButtonAutomatically
            // 
            this.radioButtonAutomatically.AllowBindingControlLocation = false;
            this.radioButtonAutomatically.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radioButtonAutomatically.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonAutomatically.BindingControlPosition = Bunifu.UI.WinForms.BunifuRadioButton.BindingControlPositions.Right;
            this.radioButtonAutomatically.BorderThickness = 1;
            this.radioButtonAutomatically.Checked = false;
            this.radioButtonAutomatically.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonAutomatically.Location = new System.Drawing.Point(520, 120);
            this.radioButtonAutomatically.Name = "radioButtonAutomatically";
            this.radioButtonAutomatically.OutlineColor = System.Drawing.Color.DodgerBlue;
            this.radioButtonAutomatically.OutlineColorTabFocused = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.radioButtonAutomatically.OutlineColorUnchecked = System.Drawing.Color.DarkGray;
            this.radioButtonAutomatically.RadioColor = System.Drawing.Color.DodgerBlue;
            this.radioButtonAutomatically.RadioColorTabFocused = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.radioButtonAutomatically.Size = new System.Drawing.Size(21, 21);
            this.radioButtonAutomatically.TabIndex = 6;
            this.radioButtonAutomatically.Text = null;
            this.bunifuToolTip.SetToolTip(this.radioButtonAutomatically, "Заповнення даних таблиці відбувається автоматично в діапазоні від -1000 до 1000");
            this.bunifuToolTip.SetToolTipIcon(this.radioButtonAutomatically, null);
            this.bunifuToolTip.SetToolTipTitle(this.radioButtonAutomatically, "");
            this.radioButtonAutomatically.CheckedChanged2 += new System.EventHandler<Bunifu.UI.WinForms.BunifuRadioButton.CheckedChangedEventArgs>(this.RadioButtonAutomatically_CheckedChanged2);
            // 
            // radioButtonManually
            // 
            this.radioButtonManually.AllowBindingControlLocation = false;
            this.radioButtonManually.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radioButtonManually.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonManually.BindingControlPosition = Bunifu.UI.WinForms.BunifuRadioButton.BindingControlPositions.Right;
            this.radioButtonManually.BorderThickness = 1;
            this.radioButtonManually.Checked = true;
            this.radioButtonManually.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonManually.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonManually.Location = new System.Drawing.Point(260, 120);
            this.radioButtonManually.Name = "radioButtonManually";
            this.radioButtonManually.OutlineColor = System.Drawing.Color.DodgerBlue;
            this.radioButtonManually.OutlineColorTabFocused = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.radioButtonManually.OutlineColorUnchecked = System.Drawing.Color.DarkGray;
            this.radioButtonManually.RadioColor = System.Drawing.Color.DodgerBlue;
            this.radioButtonManually.RadioColorTabFocused = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.radioButtonManually.Size = new System.Drawing.Size(21, 21);
            this.radioButtonManually.TabIndex = 5;
            this.radioButtonManually.Text = null;
            this.bunifuToolTip.SetToolTip(this.radioButtonManually, "Необхідно власноруч заповнити таблицю даними, щоб продовжити роботу");
            this.bunifuToolTip.SetToolTipIcon(this.radioButtonManually, null);
            this.bunifuToolTip.SetToolTipTitle(this.radioButtonManually, "");
            this.radioButtonManually.CheckedChanged2 += new System.EventHandler<Bunifu.UI.WinForms.BunifuRadioButton.CheckedChangedEventArgs>(this.RadioButtonManually_CheckedChanged2);
            // 
            // sizeMatrixNow
            // 
            this.sizeMatrixNow.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.sizeMatrixNow.AutoSize = true;
            this.sizeMatrixNow.Location = new System.Drawing.Point(429, 43);
            this.sizeMatrixNow.Name = "sizeMatrixNow";
            this.sizeMatrixNow.Size = new System.Drawing.Size(13, 13);
            this.sizeMatrixNow.TabIndex = 4;
            this.sizeMatrixNow.Text = "1";
            this.bunifuToolTip.SetToolTip(this.sizeMatrixNow, "");
            this.bunifuToolTip.SetToolTipIcon(this.sizeMatrixNow, null);
            this.bunifuToolTip.SetToolTipTitle(this.sizeMatrixNow, "");
            // 
            // sizeMatrixMax
            // 
            this.sizeMatrixMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sizeMatrixMax.AutoSize = true;
            this.sizeMatrixMax.Location = new System.Drawing.Point(844, 43);
            this.sizeMatrixMax.Name = "sizeMatrixMax";
            this.sizeMatrixMax.Size = new System.Drawing.Size(13, 13);
            this.sizeMatrixMax.TabIndex = 3;
            this.sizeMatrixMax.Text = "6";
            this.bunifuToolTip.SetToolTip(this.sizeMatrixMax, "");
            this.bunifuToolTip.SetToolTipIcon(this.sizeMatrixMax, null);
            this.bunifuToolTip.SetToolTipTitle(this.sizeMatrixMax, "");
            // 
            // sizeMatrixMin
            // 
            this.sizeMatrixMin.AutoSize = true;
            this.sizeMatrixMin.Location = new System.Drawing.Point(12, 43);
            this.sizeMatrixMin.Name = "sizeMatrixMin";
            this.sizeMatrixMin.Size = new System.Drawing.Size(13, 13);
            this.sizeMatrixMin.TabIndex = 2;
            this.sizeMatrixMin.Text = "1";
            this.bunifuToolTip.SetToolTip(this.sizeMatrixMin, "");
            this.bunifuToolTip.SetToolTipIcon(this.sizeMatrixMin, null);
            this.bunifuToolTip.SetToolTipTitle(this.sizeMatrixMin, "");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(321, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Оберіть розмір матриці (nxn)";
            this.bunifuToolTip.SetToolTip(this.label1, "");
            this.bunifuToolTip.SetToolTipIcon(this.label1, null);
            this.bunifuToolTip.SetToolTipTitle(this.label1, "");
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
            this.sizeMatrix.Size = new System.Drawing.Size(845, 31);
            this.sizeMatrix.SliderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.sizeMatrix.SliderStyle = Bunifu.UI.WinForms.BunifuHSlider.SliderStyles.Thin;
            this.sizeMatrix.SliderThumbStyle = Utilities.BunifuSlider.BunifuHScrollBar.SliderThumbStyles.Circular;
            this.sizeMatrix.SmallChange = 1;
            this.sizeMatrix.TabIndex = 0;
            this.sizeMatrix.ThumbColor = System.Drawing.Color.DodgerBlue;
            this.sizeMatrix.ThumbFillColor = System.Drawing.SystemColors.Control;
            this.sizeMatrix.ThumbLength = 169;
            this.sizeMatrix.ThumbMargin = 1;
            this.sizeMatrix.ThumbSize = Bunifu.UI.WinForms.BunifuHSlider.ThumbSizes.Medium;
            this.sizeMatrix.ThumbStyle = Bunifu.UI.WinForms.BunifuHSlider.ThumbStyles.Outline;
            this.bunifuToolTip.SetToolTip(this.sizeMatrix, "Натисніть та потягніть повзунець або натисніть в бідь-якій точці на ньому, щоб ви" +
        "брати необхідний розмір");
            this.bunifuToolTip.SetToolTipIcon(this.sizeMatrix, null);
            this.bunifuToolTip.SetToolTipTitle(this.sizeMatrix, "");
            this.sizeMatrix.Value = 1;
            // 
            // dataResults
            // 
            this.dataResults.AllowUserToAddRows = false;
            this.dataResults.AllowUserToDeleteRows = false;
            this.dataResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataResults.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataResults.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataResults.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataResults.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataResults.ColumnHeadersHeight = 40;
            this.dataResults.ColumnHeadersVisible = false;
            this.dataResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataResults.EnableHeadersVisualStyles = false;
            this.dataResults.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dataResults.Location = new System.Drawing.Point(3, 3);
            this.dataResults.Name = "dataResults";
            this.dataResults.RowHeadersVisible = false;
            this.dataResults.RowTemplate.Height = 40;
            this.dataResults.Size = new System.Drawing.Size(436, 304);
            this.dataResults.TabIndex = 4;
            this.bunifuToolTip.SetToolTip(this.dataResults, "");
            this.bunifuToolTip.SetToolTipIcon(this.dataResults, null);
            this.bunifuToolTip.SetToolTipTitle(this.dataResults, "");
            this.dataResults.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataResults_CellEndEdit);
            this.dataResults.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.Data_EditingControlShowing);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dataResults, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataSortResults, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 225);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(885, 310);
            this.tableLayoutPanel1.TabIndex = 5;
            this.bunifuToolTip.SetToolTip(this.tableLayoutPanel1, "");
            this.bunifuToolTip.SetToolTipIcon(this.tableLayoutPanel1, null);
            this.bunifuToolTip.SetToolTipTitle(this.tableLayoutPanel1, "");
            // 
            // dataSortResults
            // 
            this.dataSortResults.AllowUserToAddRows = false;
            this.dataSortResults.AllowUserToDeleteRows = false;
            this.dataSortResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataSortResults.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataSortResults.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataSortResults.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataSortResults.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataSortResults.ColumnHeadersHeight = 40;
            this.dataSortResults.ColumnHeadersVisible = false;
            this.dataSortResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataSortResults.EnableHeadersVisualStyles = false;
            this.dataSortResults.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dataSortResults.Location = new System.Drawing.Point(445, 3);
            this.dataSortResults.Name = "dataSortResults";
            this.dataSortResults.RowHeadersVisible = false;
            this.dataSortResults.RowTemplate.Height = 40;
            this.dataSortResults.Size = new System.Drawing.Size(437, 304);
            this.dataSortResults.TabIndex = 5;
            this.bunifuToolTip.SetToolTip(this.dataSortResults, "");
            this.bunifuToolTip.SetToolTipIcon(this.dataSortResults, null);
            this.bunifuToolTip.SetToolTipTitle(this.dataSortResults, "");
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
            // FormTaskFive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(895, 540);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormTaskFive";
            this.Padding = new System.Windows.Forms.Padding(5);
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
        private Bunifu.UI.WinForms.BunifuImageButton imageButtonNegative;
        private Bunifu.UI.WinForms.BunifuImageButton imageButtonPositive;
        private Bunifu.UI.WinForms.BunifuSnackbar bunifuSnackbar;
        private Bunifu.UI.WinForms.BunifuToolTip bunifuToolTip;
    }
}