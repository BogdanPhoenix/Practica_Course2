namespace Practice
{
    partial class FormTaskFour
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
            if(formSerch != null)
            {
                formSerch.Close();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTaskFour));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.labelPathFile = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.imageButtonSearch = new Bunifu.UI.WinForms.BunifuImageButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButtonMaxIndex = new Bunifu.UI.WinForms.BunifuRadioButton();
            this.radioButtonMaxValue = new Bunifu.UI.WinForms.BunifuRadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.imageButtonDownload = new Bunifu.UI.WinForms.BunifuImageButton();
            this.imageButtonCreate = new Bunifu.UI.WinForms.BunifuImageButton();
            this.buttonDuplication = new Bunifu.UI.WinForms.BunifuImageButton();
            this.buttonError = new Bunifu.UI.WinForms.BunifuImageButton();
            this.buttonWarning = new Bunifu.UI.WinForms.BunifuImageButton();
            this.textBoxPathFile = new Bunifu.UI.WinForms.BunifuTextBox();
            this.buttonResult = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.textBoxMaxNumber = new Bunifu.UI.WinForms.BunifuTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataResults = new System.Windows.Forms.DataGridView();
            this.labelErrorData = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.bunifuToolTip = new Bunifu.UI.WinForms.BunifuToolTip(this.components);
            this.bunifuSnackbar = new Bunifu.UI.WinForms.BunifuSnackbar(this.components);
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataResults)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPathFile
            // 
            this.labelPathFile.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelPathFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPathFile.Location = new System.Drawing.Point(30, 10);
            this.labelPathFile.Name = "labelPathFile";
            this.labelPathFile.Size = new System.Drawing.Size(195, 40);
            this.labelPathFile.TabIndex = 2;
            this.labelPathFile.Text = "Шлях до файла";
            this.labelPathFile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuToolTip.SetToolTip(this.labelPathFile, "");
            this.bunifuToolTip.SetToolTipIcon(this.labelPathFile, null);
            this.bunifuToolTip.SetToolTipTitle(this.labelPathFile, "");
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.imageButtonSearch);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.radioButtonMaxIndex);
            this.panel2.Controls.Add(this.radioButtonMaxValue);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.imageButtonDownload);
            this.panel2.Controls.Add(this.imageButtonCreate);
            this.panel2.Controls.Add(this.buttonDuplication);
            this.panel2.Controls.Add(this.buttonError);
            this.panel2.Controls.Add(this.buttonWarning);
            this.panel2.Controls.Add(this.textBoxPathFile);
            this.panel2.Controls.Add(this.labelPathFile);
            this.panel2.Controls.Add(this.buttonResult);
            this.panel2.Controls.Add(this.textBoxMaxNumber);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(5, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(885, 205);
            this.panel2.TabIndex = 5;
            this.bunifuToolTip.SetToolTip(this.panel2, "");
            this.bunifuToolTip.SetToolTipIcon(this.panel2, null);
            this.bunifuToolTip.SetToolTipTitle(this.panel2, "");
            // 
            // imageButtonSearch
            // 
            this.imageButtonSearch.ActiveImage = global::Practice.Properties.Resources.search_more_64px;
            this.imageButtonSearch.AllowAnimations = true;
            this.imageButtonSearch.AllowBuffering = false;
            this.imageButtonSearch.AllowToggling = false;
            this.imageButtonSearch.AllowZooming = true;
            this.imageButtonSearch.AllowZoomingOnFocus = false;
            this.imageButtonSearch.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.imageButtonSearch.BackColor = System.Drawing.Color.Transparent;
            this.imageButtonSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imageButtonSearch.DialogResult = System.Windows.Forms.DialogResult.None;
            this.imageButtonSearch.ErrorImage = ((System.Drawing.Image)(resources.GetObject("imageButtonSearch.ErrorImage")));
            this.imageButtonSearch.FadeWhenInactive = false;
            this.imageButtonSearch.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.imageButtonSearch.Image = global::Practice.Properties.Resources.search_more_64px;
            this.imageButtonSearch.ImageActive = global::Practice.Properties.Resources.search_more_64px;
            this.imageButtonSearch.ImageLocation = null;
            this.imageButtonSearch.ImageMargin = 20;
            this.imageButtonSearch.ImageSize = new System.Drawing.Size(30, 30);
            this.imageButtonSearch.ImageZoomSize = new System.Drawing.Size(50, 50);
            this.imageButtonSearch.InitialImage = ((System.Drawing.Image)(resources.GetObject("imageButtonSearch.InitialImage")));
            this.imageButtonSearch.Location = new System.Drawing.Point(90, 149);
            this.imageButtonSearch.Name = "imageButtonSearch";
            this.imageButtonSearch.Rotation = 0;
            this.imageButtonSearch.ShowActiveImage = true;
            this.imageButtonSearch.ShowCursorChanges = true;
            this.imageButtonSearch.ShowImageBorders = true;
            this.imageButtonSearch.ShowSizeMarkers = false;
            this.imageButtonSearch.Size = new System.Drawing.Size(50, 50);
            this.imageButtonSearch.TabIndex = 16;
            this.bunifuToolTip.SetToolTip(this.imageButtonSearch, "");
            this.bunifuToolTip.SetToolTipIcon(this.imageButtonSearch, null);
            this.imageButtonSearch.ToolTipText = "Пошук елемента за індексом";
            this.bunifuToolTip.SetToolTipTitle(this.imageButtonSearch, "");
            this.imageButtonSearch.Visible = false;
            this.imageButtonSearch.WaitOnLoad = false;
            this.imageButtonSearch.Zoom = 20;
            this.imageButtonSearch.ZoomSpeed = 10;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(30, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 40);
            this.label4.TabIndex = 15;
            this.label4.Text = "Варіант побудови";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuToolTip.SetToolTip(this.label4, "");
            this.bunifuToolTip.SetToolTipIcon(this.label4, null);
            this.bunifuToolTip.SetToolTipTitle(this.label4, "");
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(262, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(229, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "за максимальним значенням";
            this.bunifuToolTip.SetToolTip(this.label3, "Виведення ряду Фібоначчі відбувається до вказананого числа користувачем");
            this.bunifuToolTip.SetToolTipIcon(this.label3, null);
            this.bunifuToolTip.SetToolTipTitle(this.label3, "");
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(572, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "за номером";
            this.bunifuToolTip.SetToolTip(this.label2, "Виведення ряду Фібоначчі відбувається  включно до вказаного номеру в ряді");
            this.bunifuToolTip.SetToolTipIcon(this.label2, null);
            this.bunifuToolTip.SetToolTipTitle(this.label2, "");
            // 
            // radioButtonMaxIndex
            // 
            this.radioButtonMaxIndex.AllowBindingControlLocation = false;
            this.radioButtonMaxIndex.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radioButtonMaxIndex.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonMaxIndex.BindingControlPosition = Bunifu.UI.WinForms.BunifuRadioButton.BindingControlPositions.Right;
            this.radioButtonMaxIndex.BorderThickness = 1;
            this.radioButtonMaxIndex.Checked = false;
            this.radioButtonMaxIndex.Location = new System.Drawing.Point(545, 70);
            this.radioButtonMaxIndex.Name = "radioButtonMaxIndex";
            this.radioButtonMaxIndex.OutlineColor = System.Drawing.Color.DodgerBlue;
            this.radioButtonMaxIndex.OutlineColorTabFocused = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.radioButtonMaxIndex.OutlineColorUnchecked = System.Drawing.Color.DarkGray;
            this.radioButtonMaxIndex.RadioColor = System.Drawing.Color.DodgerBlue;
            this.radioButtonMaxIndex.RadioColorTabFocused = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.radioButtonMaxIndex.Size = new System.Drawing.Size(21, 21);
            this.radioButtonMaxIndex.TabIndex = 12;
            this.radioButtonMaxIndex.Text = null;
            this.bunifuToolTip.SetToolTip(this.radioButtonMaxIndex, "Виведення ряду Фібоначчі відбувається  включно до вказаного номеру в ряді");
            this.bunifuToolTip.SetToolTipIcon(this.radioButtonMaxIndex, null);
            this.bunifuToolTip.SetToolTipTitle(this.radioButtonMaxIndex, "");
            // 
            // radioButtonMaxValue
            // 
            this.radioButtonMaxValue.AllowBindingControlLocation = false;
            this.radioButtonMaxValue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radioButtonMaxValue.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonMaxValue.BindingControlPosition = Bunifu.UI.WinForms.BunifuRadioButton.BindingControlPositions.Right;
            this.radioButtonMaxValue.BorderThickness = 1;
            this.radioButtonMaxValue.Checked = true;
            this.radioButtonMaxValue.Location = new System.Drawing.Point(235, 71);
            this.radioButtonMaxValue.Name = "radioButtonMaxValue";
            this.radioButtonMaxValue.OutlineColor = System.Drawing.Color.DodgerBlue;
            this.radioButtonMaxValue.OutlineColorTabFocused = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.radioButtonMaxValue.OutlineColorUnchecked = System.Drawing.Color.DarkGray;
            this.radioButtonMaxValue.RadioColor = System.Drawing.Color.DodgerBlue;
            this.radioButtonMaxValue.RadioColorTabFocused = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.radioButtonMaxValue.Size = new System.Drawing.Size(21, 21);
            this.radioButtonMaxValue.TabIndex = 11;
            this.radioButtonMaxValue.Text = null;
            this.bunifuToolTip.SetToolTip(this.radioButtonMaxValue, "Виведення ряду Фібоначчі відбувається  включно до вказаного номеру в ряді");
            this.bunifuToolTip.SetToolTipIcon(this.radioButtonMaxValue, null);
            this.bunifuToolTip.SetToolTipTitle(this.radioButtonMaxValue, "");
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(30, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 40);
            this.label1.TabIndex = 10;
            this.label1.Text = "Дані";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuToolTip.SetToolTip(this.label1, "");
            this.bunifuToolTip.SetToolTipIcon(this.label1, null);
            this.bunifuToolTip.SetToolTipTitle(this.label1, "");
            // 
            // imageButtonDownload
            // 
            this.imageButtonDownload.ActiveImage = null;
            this.imageButtonDownload.AllowAnimations = true;
            this.imageButtonDownload.AllowBuffering = false;
            this.imageButtonDownload.AllowToggling = false;
            this.imageButtonDownload.AllowZooming = true;
            this.imageButtonDownload.AllowZoomingOnFocus = false;
            this.imageButtonDownload.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.imageButtonDownload.BackColor = System.Drawing.Color.Transparent;
            this.imageButtonDownload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imageButtonDownload.DialogResult = System.Windows.Forms.DialogResult.None;
            this.imageButtonDownload.ErrorImage = ((System.Drawing.Image)(resources.GetObject("imageButtonDownload.ErrorImage")));
            this.imageButtonDownload.FadeWhenInactive = false;
            this.imageButtonDownload.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.imageButtonDownload.Image = global::Practice.Properties.Resources.downloading_updates_64px;
            this.imageButtonDownload.ImageActive = null;
            this.imageButtonDownload.ImageLocation = null;
            this.imageButtonDownload.ImageMargin = 20;
            this.imageButtonDownload.ImageSize = new System.Drawing.Size(30, 30);
            this.imageButtonDownload.ImageZoomSize = new System.Drawing.Size(50, 50);
            this.imageButtonDownload.InitialImage = ((System.Drawing.Image)(resources.GetObject("imageButtonDownload.InitialImage")));
            this.imageButtonDownload.Location = new System.Drawing.Point(800, 5);
            this.imageButtonDownload.Name = "imageButtonDownload";
            this.imageButtonDownload.Rotation = 0;
            this.imageButtonDownload.ShowActiveImage = true;
            this.imageButtonDownload.ShowCursorChanges = true;
            this.imageButtonDownload.ShowImageBorders = true;
            this.imageButtonDownload.ShowSizeMarkers = false;
            this.imageButtonDownload.Size = new System.Drawing.Size(50, 50);
            this.imageButtonDownload.TabIndex = 9;
            this.bunifuToolTip.SetToolTip(this.imageButtonDownload, "Натисніть, щоб обрати файл з даними");
            this.bunifuToolTip.SetToolTipIcon(this.imageButtonDownload, null);
            this.imageButtonDownload.ToolTipText = "";
            this.bunifuToolTip.SetToolTipTitle(this.imageButtonDownload, "");
            this.imageButtonDownload.WaitOnLoad = false;
            this.imageButtonDownload.Zoom = 20;
            this.imageButtonDownload.ZoomSpeed = 10;
            this.imageButtonDownload.Click += new System.EventHandler(this.ImageButtonDownload_Click);
            // 
            // imageButtonCreate
            // 
            this.imageButtonCreate.ActiveImage = global::Practice.Properties.Resources.upload_64px;
            this.imageButtonCreate.AllowAnimations = true;
            this.imageButtonCreate.AllowBuffering = false;
            this.imageButtonCreate.AllowToggling = false;
            this.imageButtonCreate.AllowZooming = true;
            this.imageButtonCreate.AllowZoomingOnFocus = false;
            this.imageButtonCreate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.imageButtonCreate.BackColor = System.Drawing.Color.Transparent;
            this.imageButtonCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imageButtonCreate.DialogResult = System.Windows.Forms.DialogResult.None;
            this.imageButtonCreate.ErrorImage = ((System.Drawing.Image)(resources.GetObject("imageButtonCreate.ErrorImage")));
            this.imageButtonCreate.FadeWhenInactive = false;
            this.imageButtonCreate.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.imageButtonCreate.Image = global::Practice.Properties.Resources.upload_64px;
            this.imageButtonCreate.ImageActive = global::Practice.Properties.Resources.upload_64px;
            this.imageButtonCreate.ImageLocation = null;
            this.imageButtonCreate.ImageMargin = 20;
            this.imageButtonCreate.ImageSize = new System.Drawing.Size(30, 30);
            this.imageButtonCreate.ImageZoomSize = new System.Drawing.Size(50, 50);
            this.imageButtonCreate.InitialImage = ((System.Drawing.Image)(resources.GetObject("imageButtonCreate.InitialImage")));
            this.imageButtonCreate.Location = new System.Drawing.Point(34, 149);
            this.imageButtonCreate.Name = "imageButtonCreate";
            this.imageButtonCreate.Rotation = 0;
            this.imageButtonCreate.ShowActiveImage = true;
            this.imageButtonCreate.ShowCursorChanges = true;
            this.imageButtonCreate.ShowImageBorders = true;
            this.imageButtonCreate.ShowSizeMarkers = false;
            this.imageButtonCreate.Size = new System.Drawing.Size(50, 50);
            this.imageButtonCreate.TabIndex = 8;
            this.bunifuToolTip.SetToolTip(this.imageButtonCreate, "");
            this.bunifuToolTip.SetToolTipIcon(this.imageButtonCreate, null);
            this.imageButtonCreate.ToolTipText = "Зберегти дані";
            this.bunifuToolTip.SetToolTipTitle(this.imageButtonCreate, "");
            this.imageButtonCreate.Visible = false;
            this.imageButtonCreate.WaitOnLoad = false;
            this.imageButtonCreate.Zoom = 20;
            this.imageButtonCreate.ZoomSpeed = 10;
            this.imageButtonCreate.Click += new System.EventHandler(this.ImageButtonCreate_Click);
            // 
            // buttonDuplication
            // 
            this.buttonDuplication.ActiveImage = global::Practice.Properties.Resources.duplication_warning_48px;
            this.buttonDuplication.AllowAnimations = true;
            this.buttonDuplication.AllowBuffering = false;
            this.buttonDuplication.AllowToggling = false;
            this.buttonDuplication.AllowZooming = true;
            this.buttonDuplication.AllowZoomingOnFocus = false;
            this.buttonDuplication.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonDuplication.BackColor = System.Drawing.Color.Transparent;
            this.buttonDuplication.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDuplication.DialogResult = System.Windows.Forms.DialogResult.None;
            this.buttonDuplication.ErrorImage = ((System.Drawing.Image)(resources.GetObject("buttonDuplication.ErrorImage")));
            this.buttonDuplication.FadeWhenInactive = false;
            this.buttonDuplication.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.buttonDuplication.Image = global::Practice.Properties.Resources.duplication_warning_48px;
            this.buttonDuplication.ImageActive = global::Practice.Properties.Resources.duplication_warning_48px;
            this.buttonDuplication.ImageLocation = null;
            this.buttonDuplication.ImageMargin = 20;
            this.buttonDuplication.ImageSize = new System.Drawing.Size(30, 30);
            this.buttonDuplication.ImageZoomSize = new System.Drawing.Size(50, 50);
            this.buttonDuplication.InitialImage = ((System.Drawing.Image)(resources.GetObject("buttonDuplication.InitialImage")));
            this.buttonDuplication.Location = new System.Drawing.Point(744, 149);
            this.buttonDuplication.Name = "buttonDuplication";
            this.buttonDuplication.Rotation = 0;
            this.buttonDuplication.ShowActiveImage = true;
            this.buttonDuplication.ShowCursorChanges = true;
            this.buttonDuplication.ShowImageBorders = true;
            this.buttonDuplication.ShowSizeMarkers = false;
            this.buttonDuplication.Size = new System.Drawing.Size(50, 50);
            this.buttonDuplication.TabIndex = 7;
            this.bunifuToolTip.SetToolTip(this.buttonDuplication, "");
            this.bunifuToolTip.SetToolTipIcon(this.buttonDuplication, null);
            this.buttonDuplication.ToolTipText = "Числа у файлі розташовані в неправильному порядку. Натисніть, щоб відсортувати їх" +
    ".";
            this.bunifuToolTip.SetToolTipTitle(this.buttonDuplication, "");
            this.buttonDuplication.Visible = false;
            this.buttonDuplication.WaitOnLoad = false;
            this.buttonDuplication.Zoom = 20;
            this.buttonDuplication.ZoomSpeed = 10;
            // 
            // buttonError
            // 
            this.buttonError.ActiveImage = global::Practice.Properties.Resources.error_48px;
            this.buttonError.AllowAnimations = true;
            this.buttonError.AllowBuffering = false;
            this.buttonError.AllowToggling = false;
            this.buttonError.AllowZooming = true;
            this.buttonError.AllowZoomingOnFocus = false;
            this.buttonError.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonError.BackColor = System.Drawing.Color.Transparent;
            this.buttonError.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonError.DialogResult = System.Windows.Forms.DialogResult.None;
            this.buttonError.ErrorImage = ((System.Drawing.Image)(resources.GetObject("buttonError.ErrorImage")));
            this.buttonError.FadeWhenInactive = false;
            this.buttonError.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.buttonError.Image = global::Practice.Properties.Resources.error_48px;
            this.buttonError.ImageActive = global::Practice.Properties.Resources.error_48px;
            this.buttonError.ImageLocation = null;
            this.buttonError.ImageMargin = 20;
            this.buttonError.ImageSize = new System.Drawing.Size(30, 30);
            this.buttonError.ImageZoomSize = new System.Drawing.Size(50, 50);
            this.buttonError.InitialImage = ((System.Drawing.Image)(resources.GetObject("buttonError.InitialImage")));
            this.buttonError.Location = new System.Drawing.Point(688, 149);
            this.buttonError.Name = "buttonError";
            this.buttonError.Rotation = 0;
            this.buttonError.ShowActiveImage = true;
            this.buttonError.ShowCursorChanges = true;
            this.buttonError.ShowImageBorders = true;
            this.buttonError.ShowSizeMarkers = false;
            this.buttonError.Size = new System.Drawing.Size(50, 50);
            this.buttonError.TabIndex = 6;
            this.bunifuToolTip.SetToolTip(this.buttonError, "");
            this.bunifuToolTip.SetToolTipIcon(this.buttonError, null);
            this.buttonError.ToolTipText = "";
            this.bunifuToolTip.SetToolTipTitle(this.buttonError, "");
            this.buttonError.Visible = false;
            this.buttonError.WaitOnLoad = false;
            this.buttonError.Zoom = 20;
            this.buttonError.ZoomSpeed = 10;
            // 
            // buttonWarning
            // 
            this.buttonWarning.ActiveImage = global::Practice.Properties.Resources.warning_48px;
            this.buttonWarning.AllowAnimations = true;
            this.buttonWarning.AllowBuffering = false;
            this.buttonWarning.AllowToggling = false;
            this.buttonWarning.AllowZooming = true;
            this.buttonWarning.AllowZoomingOnFocus = false;
            this.buttonWarning.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonWarning.BackColor = System.Drawing.Color.Transparent;
            this.buttonWarning.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonWarning.DialogResult = System.Windows.Forms.DialogResult.None;
            this.buttonWarning.ErrorImage = ((System.Drawing.Image)(resources.GetObject("buttonWarning.ErrorImage")));
            this.buttonWarning.FadeWhenInactive = false;
            this.buttonWarning.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.buttonWarning.Image = global::Practice.Properties.Resources.warning_48px;
            this.buttonWarning.ImageActive = global::Practice.Properties.Resources.warning_48px;
            this.buttonWarning.ImageLocation = null;
            this.buttonWarning.ImageMargin = 20;
            this.buttonWarning.ImageSize = new System.Drawing.Size(30, 30);
            this.buttonWarning.ImageZoomSize = new System.Drawing.Size(50, 50);
            this.buttonWarning.InitialImage = ((System.Drawing.Image)(resources.GetObject("buttonWarning.InitialImage")));
            this.buttonWarning.Location = new System.Drawing.Point(800, 149);
            this.buttonWarning.Name = "buttonWarning";
            this.buttonWarning.Rotation = 0;
            this.buttonWarning.ShowActiveImage = true;
            this.buttonWarning.ShowCursorChanges = true;
            this.buttonWarning.ShowImageBorders = true;
            this.buttonWarning.ShowSizeMarkers = false;
            this.buttonWarning.Size = new System.Drawing.Size(50, 50);
            this.buttonWarning.TabIndex = 5;
            this.bunifuToolTip.SetToolTip(this.buttonWarning, "");
            this.bunifuToolTip.SetToolTipIcon(this.buttonWarning, null);
            this.buttonWarning.ToolTipText = "Числа у файлі розташовані в неправильному порядку. Натисніть, щоб відсортувати їх" +
    ".";
            this.bunifuToolTip.SetToolTipTitle(this.buttonWarning, "");
            this.buttonWarning.Visible = false;
            this.buttonWarning.WaitOnLoad = false;
            this.buttonWarning.Zoom = 20;
            this.buttonWarning.ZoomSpeed = 10;
            this.buttonWarning.Click += new System.EventHandler(this.ButtonWarning_Click);
            // 
            // textBoxPathFile
            // 
            this.textBoxPathFile.AcceptsReturn = false;
            this.textBoxPathFile.AcceptsTab = false;
            this.textBoxPathFile.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxPathFile.AnimationSpeed = 200;
            this.textBoxPathFile.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.textBoxPathFile.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.textBoxPathFile.AutoSizeHeight = true;
            this.textBoxPathFile.BackColor = System.Drawing.Color.Transparent;
            this.textBoxPathFile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("textBoxPathFile.BackgroundImage")));
            this.textBoxPathFile.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.textBoxPathFile.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.textBoxPathFile.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.textBoxPathFile.BorderColorIdle = System.Drawing.Color.Silver;
            this.textBoxPathFile.BorderRadius = 1;
            this.textBoxPathFile.BorderThickness = 1;
            this.textBoxPathFile.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.textBoxPathFile.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxPathFile.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.textBoxPathFile.DefaultText = "";
            this.textBoxPathFile.FillColor = System.Drawing.Color.White;
            this.textBoxPathFile.HideSelection = true;
            this.textBoxPathFile.IconLeft = null;
            this.textBoxPathFile.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxPathFile.IconPadding = 10;
            this.textBoxPathFile.IconRight = null;
            this.textBoxPathFile.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxPathFile.Lines = new string[0];
            this.textBoxPathFile.Location = new System.Drawing.Point(235, 10);
            this.textBoxPathFile.MaxLength = 32767;
            this.textBoxPathFile.MinimumSize = new System.Drawing.Size(1, 1);
            this.textBoxPathFile.Modified = false;
            this.textBoxPathFile.Multiline = false;
            this.textBoxPathFile.Name = "textBoxPathFile";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.textBoxPathFile.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.textBoxPathFile.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.textBoxPathFile.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.textBoxPathFile.OnIdleState = stateProperties4;
            this.textBoxPathFile.Padding = new System.Windows.Forms.Padding(3);
            this.textBoxPathFile.PasswordChar = '\0';
            this.textBoxPathFile.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.textBoxPathFile.PlaceholderText = "Введіть шлях";
            this.textBoxPathFile.ReadOnly = false;
            this.textBoxPathFile.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxPathFile.SelectedText = "";
            this.textBoxPathFile.SelectionLength = 0;
            this.textBoxPathFile.SelectionStart = 0;
            this.textBoxPathFile.ShortcutsEnabled = true;
            this.textBoxPathFile.Size = new System.Drawing.Size(540, 39);
            this.textBoxPathFile.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.textBoxPathFile.TabIndex = 0;
            this.textBoxPathFile.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxPathFile.TextMarginBottom = 0;
            this.textBoxPathFile.TextMarginLeft = 3;
            this.textBoxPathFile.TextMarginTop = 1;
            this.textBoxPathFile.TextPlaceholder = "Введіть шлях";
            this.bunifuToolTip.SetToolTip(this.textBoxPathFile, "");
            this.bunifuToolTip.SetToolTipIcon(this.textBoxPathFile, null);
            this.bunifuToolTip.SetToolTipTitle(this.textBoxPathFile, "");
            this.textBoxPathFile.UseSystemPasswordChar = false;
            this.textBoxPathFile.WordWrap = true;
            this.textBoxPathFile.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MaxLengthTextBox);
            // 
            // buttonResult
            // 
            this.buttonResult.AllowAnimations = true;
            this.buttonResult.AllowMouseEffects = true;
            this.buttonResult.AllowToggling = false;
            this.buttonResult.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonResult.AnimationSpeed = 200;
            this.buttonResult.AutoGenerateColors = false;
            this.buttonResult.AutoRoundBorders = false;
            this.buttonResult.AutoSizeLeftIcon = true;
            this.buttonResult.AutoSizeRightIcon = true;
            this.buttonResult.BackColor = System.Drawing.Color.Transparent;
            this.buttonResult.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.buttonResult.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonResult.BackgroundImage")));
            this.buttonResult.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.buttonResult.ButtonText = "Обчислити";
            this.buttonResult.ButtonTextMarginLeft = 0;
            this.buttonResult.ColorContrastOnClick = 45;
            this.buttonResult.ColorContrastOnHover = 45;
            this.buttonResult.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.buttonResult.CustomizableEdges = borderEdges1;
            this.buttonResult.DialogResult = System.Windows.Forms.DialogResult.None;
            this.buttonResult.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.buttonResult.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.buttonResult.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.buttonResult.Enabled = false;
            this.buttonResult.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.buttonResult.Font = new System.Drawing.Font("Segoe UI", 9F);
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
            this.buttonResult.Location = new System.Drawing.Point(481, 110);
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
            this.buttonResult.Size = new System.Drawing.Size(150, 40);
            this.buttonResult.TabIndex = 3;
            this.buttonResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonResult.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.buttonResult.TextMarginLeft = 0;
            this.buttonResult.TextPadding = new System.Windows.Forms.Padding(0);
            this.bunifuToolTip.SetToolTip(this.buttonResult, "");
            this.bunifuToolTip.SetToolTipIcon(this.buttonResult, null);
            this.bunifuToolTip.SetToolTipTitle(this.buttonResult, "");
            this.buttonResult.UseDefaultRadiusAndThickness = true;
            // 
            // textBoxMaxNumber
            // 
            this.textBoxMaxNumber.AcceptsReturn = false;
            this.textBoxMaxNumber.AcceptsTab = false;
            this.textBoxMaxNumber.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxMaxNumber.AnimationSpeed = 200;
            this.textBoxMaxNumber.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.textBoxMaxNumber.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.textBoxMaxNumber.AutoSizeHeight = true;
            this.textBoxMaxNumber.BackColor = System.Drawing.Color.Transparent;
            this.textBoxMaxNumber.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("textBoxMaxNumber.BackgroundImage")));
            this.textBoxMaxNumber.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.textBoxMaxNumber.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.textBoxMaxNumber.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.textBoxMaxNumber.BorderColorIdle = System.Drawing.Color.Silver;
            this.textBoxMaxNumber.BorderRadius = 1;
            this.textBoxMaxNumber.BorderThickness = 1;
            this.textBoxMaxNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.textBoxMaxNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxMaxNumber.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.textBoxMaxNumber.DefaultText = "";
            this.textBoxMaxNumber.FillColor = System.Drawing.Color.White;
            this.textBoxMaxNumber.HideSelection = true;
            this.textBoxMaxNumber.IconLeft = null;
            this.textBoxMaxNumber.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxMaxNumber.IconPadding = 10;
            this.textBoxMaxNumber.IconRight = null;
            this.textBoxMaxNumber.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxMaxNumber.Lines = new string[0];
            this.textBoxMaxNumber.Location = new System.Drawing.Point(235, 110);
            this.textBoxMaxNumber.MaxLength = 30;
            this.textBoxMaxNumber.MinimumSize = new System.Drawing.Size(1, 1);
            this.textBoxMaxNumber.Modified = false;
            this.textBoxMaxNumber.Multiline = false;
            this.textBoxMaxNumber.Name = "textBoxMaxNumber";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.textBoxMaxNumber.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.textBoxMaxNumber.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.textBoxMaxNumber.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.textBoxMaxNumber.OnIdleState = stateProperties8;
            this.textBoxMaxNumber.Padding = new System.Windows.Forms.Padding(3);
            this.textBoxMaxNumber.PasswordChar = '\0';
            this.textBoxMaxNumber.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.textBoxMaxNumber.PlaceholderText = "Введіть число";
            this.textBoxMaxNumber.ReadOnly = false;
            this.textBoxMaxNumber.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxMaxNumber.SelectedText = "";
            this.textBoxMaxNumber.SelectionLength = 0;
            this.textBoxMaxNumber.SelectionStart = 0;
            this.textBoxMaxNumber.ShortcutsEnabled = true;
            this.textBoxMaxNumber.Size = new System.Drawing.Size(210, 40);
            this.textBoxMaxNumber.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.textBoxMaxNumber.TabIndex = 2;
            this.textBoxMaxNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxMaxNumber.TextMarginBottom = 0;
            this.textBoxMaxNumber.TextMarginLeft = 3;
            this.textBoxMaxNumber.TextMarginTop = 1;
            this.textBoxMaxNumber.TextPlaceholder = "Введіть число";
            this.bunifuToolTip.SetToolTip(this.textBoxMaxNumber, "");
            this.bunifuToolTip.SetToolTipIcon(this.textBoxMaxNumber, null);
            this.bunifuToolTip.SetToolTipTitle(this.textBoxMaxNumber, "");
            this.textBoxMaxNumber.UseSystemPasswordChar = false;
            this.textBoxMaxNumber.WordWrap = true;
            this.textBoxMaxNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MaxLengthTextBox);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataResults);
            this.panel3.Controls.Add(this.labelErrorData);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(5, 210);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(885, 327);
            this.panel3.TabIndex = 7;
            this.bunifuToolTip.SetToolTip(this.panel3, "");
            this.bunifuToolTip.SetToolTipIcon(this.panel3, null);
            this.bunifuToolTip.SetToolTipTitle(this.panel3, "");
            // 
            // dataResults
            // 
            this.dataResults.AllowUserToAddRows = false;
            this.dataResults.AllowUserToDeleteRows = false;
            this.dataResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataResults.BackgroundColor = System.Drawing.Color.White;
            this.dataResults.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataResults.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataResults.ColumnHeadersHeight = 40;
            this.dataResults.ColumnHeadersVisible = false;
            this.dataResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataResults.EnableHeadersVisualStyles = false;
            this.dataResults.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dataResults.Location = new System.Drawing.Point(0, 180);
            this.dataResults.Name = "dataResults";
            this.dataResults.ReadOnly = true;
            this.dataResults.RowHeadersVisible = false;
            this.dataResults.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataResults.RowTemplate.Height = 40;
            this.dataResults.Size = new System.Drawing.Size(885, 147);
            this.dataResults.TabIndex = 3;
            this.bunifuToolTip.SetToolTip(this.dataResults, "");
            this.bunifuToolTip.SetToolTipIcon(this.dataResults, null);
            this.bunifuToolTip.SetToolTipTitle(this.dataResults, "");
            // 
            // labelErrorData
            // 
            this.labelErrorData.BackColor = System.Drawing.Color.White;
            this.labelErrorData.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelErrorData.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelErrorData.Location = new System.Drawing.Point(0, 0);
            this.labelErrorData.Name = "labelErrorData";
            this.labelErrorData.Size = new System.Drawing.Size(885, 180);
            this.labelErrorData.TabIndex = 2;
            this.labelErrorData.Text = "Дані відсутні";
            this.labelErrorData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuToolTip.SetToolTip(this.labelErrorData, "");
            this.bunifuToolTip.SetToolTipIcon(this.labelErrorData, null);
            this.bunifuToolTip.SetToolTipTitle(this.labelErrorData, "");
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
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
            // FormTaskFour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(895, 542);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormTaskFour";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "Завдання №4";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataResults)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuTextBox textBoxPathFile;
        private Bunifu.UI.WinForms.BunifuTextBox textBoxMaxNumber;
        private System.Windows.Forms.Label labelPathFile;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 buttonResult;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelErrorData;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.DataGridView dataResults;
        private Bunifu.UI.WinForms.BunifuImageButton buttonError;
        private Bunifu.UI.WinForms.BunifuImageButton buttonWarning;
        private Bunifu.UI.WinForms.BunifuImageButton buttonDuplication;
        private Bunifu.UI.WinForms.BunifuImageButton imageButtonDownload;
        private Bunifu.UI.WinForms.BunifuImageButton imageButtonCreate;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuRadioButton radioButtonMaxIndex;
        private Bunifu.UI.WinForms.BunifuRadioButton radioButtonMaxValue;
        private Bunifu.UI.WinForms.BunifuToolTip bunifuToolTip;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Bunifu.UI.WinForms.BunifuImageButton imageButtonSearch;
        private Bunifu.UI.WinForms.BunifuSnackbar bunifuSnackbar;
    }
}