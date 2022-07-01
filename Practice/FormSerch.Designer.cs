using System.Drawing;

namespace Practice
{
    partial class FormSerch
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
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSerch));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.formDock = new Bunifu.UI.WinForms.BunifuFormDock();
            this.bunifuGradientPanelTitleBar = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.iconSave = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.bunifuButtonMinimized = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuButtonClose = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.labelPathFile = new System.Windows.Forms.Label();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.bunifuToolTip = new Bunifu.UI.WinForms.BunifuToolTip(this.components);
            this.buttonSearch = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.textBoxIndex = new Bunifu.UI.WinForms.BunifuTextBox();
            this.labelTitleResult = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.bunifuSnackbar = new Bunifu.UI.WinForms.BunifuSnackbar(this.components);
            this.bunifuGradientPanelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconSave)).BeginInit();
            this.SuspendLayout();
            // 
            // formDock
            // 
            this.formDock.AllowFormDragging = false;
            this.formDock.AllowFormDropShadow = true;
            this.formDock.AllowFormResizing = false;
            this.formDock.AllowHidingBottomRegion = true;
            this.formDock.AllowOpacityChangesWhileDragging = false;
            this.formDock.BorderOptions.BottomBorder.BorderColor = System.Drawing.Color.Silver;
            this.formDock.BorderOptions.BottomBorder.BorderThickness = 1;
            this.formDock.BorderOptions.BottomBorder.ShowBorder = true;
            this.formDock.BorderOptions.LeftBorder.BorderColor = System.Drawing.Color.Silver;
            this.formDock.BorderOptions.LeftBorder.BorderThickness = 1;
            this.formDock.BorderOptions.LeftBorder.ShowBorder = true;
            this.formDock.BorderOptions.RightBorder.BorderColor = System.Drawing.Color.Silver;
            this.formDock.BorderOptions.RightBorder.BorderThickness = 1;
            this.formDock.BorderOptions.RightBorder.ShowBorder = true;
            this.formDock.BorderOptions.TopBorder.BorderColor = System.Drawing.Color.Silver;
            this.formDock.BorderOptions.TopBorder.BorderThickness = 1;
            this.formDock.BorderOptions.TopBorder.ShowBorder = true;
            this.formDock.ContainerControl = this;
            this.formDock.DockingIndicatorsColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(215)))), ((int)(((byte)(233)))));
            this.formDock.DockingIndicatorsOpacity = 0.5D;
            this.formDock.DockingOptions.DockAll = true;
            this.formDock.DockingOptions.DockBottomLeft = true;
            this.formDock.DockingOptions.DockBottomRight = true;
            this.formDock.DockingOptions.DockFullScreen = true;
            this.formDock.DockingOptions.DockLeft = true;
            this.formDock.DockingOptions.DockRight = true;
            this.formDock.DockingOptions.DockTopLeft = true;
            this.formDock.DockingOptions.DockTopRight = true;
            this.formDock.FormDraggingOpacity = 0.9D;
            this.formDock.ParentForm = this;
            this.formDock.ShowCursorChanges = true;
            this.formDock.ShowDockingIndicators = true;
            this.formDock.TitleBarOptions.AllowFormDragging = true;
            this.formDock.TitleBarOptions.BunifuFormDock = this.formDock;
            this.formDock.TitleBarOptions.DoubleClickToExpandWindow = true;
            this.formDock.TitleBarOptions.TitleBarControl = this.bunifuGradientPanelTitleBar;
            this.formDock.TitleBarOptions.UseBackColorOnDockingIndicators = false;
            // 
            // bunifuGradientPanelTitleBar
            // 
            this.bunifuGradientPanelTitleBar.BackColor = System.Drawing.Color.Transparent;
            this.bunifuGradientPanelTitleBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanelTitleBar.BackgroundImage")));
            this.bunifuGradientPanelTitleBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanelTitleBar.BorderRadius = 0;
            this.bunifuGradientPanelTitleBar.Controls.Add(this.labelTitle);
            this.bunifuGradientPanelTitleBar.Controls.Add(this.iconSave);
            this.bunifuGradientPanelTitleBar.Controls.Add(this.bunifuButtonMinimized);
            this.bunifuGradientPanelTitleBar.Controls.Add(this.bunifuButtonClose);
            this.bunifuGradientPanelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuGradientPanelTitleBar.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(102)))));
            this.bunifuGradientPanelTitleBar.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(102)))));
            this.bunifuGradientPanelTitleBar.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(102)))));
            this.bunifuGradientPanelTitleBar.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(102)))));
            this.bunifuGradientPanelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanelTitleBar.Name = "bunifuGradientPanelTitleBar";
            this.bunifuGradientPanelTitleBar.Quality = 10;
            this.bunifuGradientPanelTitleBar.Size = new System.Drawing.Size(523, 40);
            this.bunifuGradientPanelTitleBar.TabIndex = 35;
            this.bunifuToolTip.SetToolTip(this.bunifuGradientPanelTitleBar, "");
            this.bunifuToolTip.SetToolTipIcon(this.bunifuGradientPanelTitleBar, null);
            this.bunifuToolTip.SetToolTipTitle(this.bunifuGradientPanelTitleBar, "");
            // 
            // labelTitle
            // 
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(60, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(161, 40);
            this.labelTitle.TabIndex = 33;
            this.labelTitle.Text = "Пошук елемента";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuToolTip.SetToolTip(this.labelTitle, "");
            this.bunifuToolTip.SetToolTipIcon(this.labelTitle, null);
            this.bunifuToolTip.SetToolTipTitle(this.labelTitle, "");
            // 
            // iconSave
            // 
            this.iconSave.AllowFocused = false;
            this.iconSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconSave.AutoSizeHeight = true;
            this.iconSave.BorderRadius = 20;
            this.iconSave.Image = global::Practice.Properties.Resources.save_as_50px;
            this.iconSave.IsCircle = true;
            this.iconSave.Location = new System.Drawing.Point(10, 0);
            this.iconSave.Name = "iconSave";
            this.iconSave.Size = new System.Drawing.Size(40, 40);
            this.iconSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconSave.TabIndex = 32;
            this.iconSave.TabStop = false;
            this.bunifuToolTip.SetToolTip(this.iconSave, "");
            this.bunifuToolTip.SetToolTipIcon(this.iconSave, null);
            this.bunifuToolTip.SetToolTipTitle(this.iconSave, "");
            this.iconSave.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // bunifuButtonMinimized
            // 
            this.bunifuButtonMinimized.AllowAnimations = true;
            this.bunifuButtonMinimized.AllowMouseEffects = true;
            this.bunifuButtonMinimized.AllowToggling = false;
            this.bunifuButtonMinimized.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuButtonMinimized.AnimationSpeed = 200;
            this.bunifuButtonMinimized.AutoGenerateColors = false;
            this.bunifuButtonMinimized.AutoRoundBorders = false;
            this.bunifuButtonMinimized.AutoSizeLeftIcon = true;
            this.bunifuButtonMinimized.AutoSizeRightIcon = true;
            this.bunifuButtonMinimized.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButtonMinimized.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.bunifuButtonMinimized.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButtonMinimized.BackgroundImage")));
            this.bunifuButtonMinimized.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButtonMinimized.ButtonText = "";
            this.bunifuButtonMinimized.ButtonTextMarginLeft = 0;
            this.bunifuButtonMinimized.ColorContrastOnClick = 45;
            this.bunifuButtonMinimized.ColorContrastOnHover = 45;
            this.bunifuButtonMinimized.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.bunifuButtonMinimized.CustomizableEdges = borderEdges2;
            this.bunifuButtonMinimized.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuButtonMinimized.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButtonMinimized.DisabledFillColor = System.Drawing.Color.Empty;
            this.bunifuButtonMinimized.DisabledForecolor = System.Drawing.Color.Empty;
            this.bunifuButtonMinimized.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.bunifuButtonMinimized.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuButtonMinimized.ForeColor = System.Drawing.Color.White;
            this.bunifuButtonMinimized.IconLeft = null;
            this.bunifuButtonMinimized.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuButtonMinimized.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuButtonMinimized.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.bunifuButtonMinimized.IconMarginLeft = 11;
            this.bunifuButtonMinimized.IconPadding = 10;
            this.bunifuButtonMinimized.IconRight = global::Practice.Properties.Resources.minimise_32px;
            this.bunifuButtonMinimized.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuButtonMinimized.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuButtonMinimized.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.bunifuButtonMinimized.IconSize = 26;
            this.bunifuButtonMinimized.IdleBorderColor = System.Drawing.Color.Empty;
            this.bunifuButtonMinimized.IdleBorderRadius = 0;
            this.bunifuButtonMinimized.IdleBorderThickness = 0;
            this.bunifuButtonMinimized.IdleFillColor = System.Drawing.Color.Empty;
            this.bunifuButtonMinimized.IdleIconLeftImage = null;
            this.bunifuButtonMinimized.IdleIconRightImage = global::Practice.Properties.Resources.minimise_32px;
            this.bunifuButtonMinimized.IndicateFocus = true;
            this.bunifuButtonMinimized.Location = new System.Drawing.Point(453, 0);
            this.bunifuButtonMinimized.Name = "bunifuButtonMinimized";
            this.bunifuButtonMinimized.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButtonMinimized.OnDisabledState.BorderRadius = 1;
            this.bunifuButtonMinimized.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButtonMinimized.OnDisabledState.BorderThickness = 1;
            this.bunifuButtonMinimized.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButtonMinimized.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButtonMinimized.OnDisabledState.IconLeftImage = null;
            this.bunifuButtonMinimized.OnDisabledState.IconRightImage = null;
            this.bunifuButtonMinimized.onHoverState.BorderColor = System.Drawing.Color.Blue;
            this.bunifuButtonMinimized.onHoverState.BorderRadius = 1;
            this.bunifuButtonMinimized.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButtonMinimized.onHoverState.BorderThickness = 1;
            this.bunifuButtonMinimized.onHoverState.FillColor = System.Drawing.Color.Blue;
            this.bunifuButtonMinimized.onHoverState.ForeColor = System.Drawing.Color.White;
            this.bunifuButtonMinimized.onHoverState.IconLeftImage = null;
            this.bunifuButtonMinimized.onHoverState.IconRightImage = null;
            this.bunifuButtonMinimized.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuButtonMinimized.OnIdleState.BorderRadius = 1;
            this.bunifuButtonMinimized.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButtonMinimized.OnIdleState.BorderThickness = 1;
            this.bunifuButtonMinimized.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.bunifuButtonMinimized.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.bunifuButtonMinimized.OnIdleState.IconLeftImage = null;
            this.bunifuButtonMinimized.OnIdleState.IconRightImage = global::Practice.Properties.Resources.minimise_32px;
            this.bunifuButtonMinimized.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bunifuButtonMinimized.OnPressedState.BorderRadius = 1;
            this.bunifuButtonMinimized.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButtonMinimized.OnPressedState.BorderThickness = 1;
            this.bunifuButtonMinimized.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bunifuButtonMinimized.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.bunifuButtonMinimized.OnPressedState.IconLeftImage = null;
            this.bunifuButtonMinimized.OnPressedState.IconRightImage = null;
            this.bunifuButtonMinimized.Size = new System.Drawing.Size(33, 40);
            this.bunifuButtonMinimized.TabIndex = 2;
            this.bunifuButtonMinimized.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButtonMinimized.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.bunifuButtonMinimized.TextMarginLeft = 0;
            this.bunifuButtonMinimized.TextPadding = new System.Windows.Forms.Padding(0);
            this.bunifuToolTip.SetToolTip(this.bunifuButtonMinimized, "");
            this.bunifuToolTip.SetToolTipIcon(this.bunifuButtonMinimized, null);
            this.bunifuToolTip.SetToolTipTitle(this.bunifuButtonMinimized, "");
            this.bunifuButtonMinimized.UseDefaultRadiusAndThickness = true;
            // 
            // bunifuButtonClose
            // 
            this.bunifuButtonClose.AllowAnimations = true;
            this.bunifuButtonClose.AllowMouseEffects = true;
            this.bunifuButtonClose.AllowToggling = false;
            this.bunifuButtonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuButtonClose.AnimationSpeed = 200;
            this.bunifuButtonClose.AutoGenerateColors = false;
            this.bunifuButtonClose.AutoRoundBorders = false;
            this.bunifuButtonClose.AutoSizeLeftIcon = true;
            this.bunifuButtonClose.AutoSizeRightIcon = true;
            this.bunifuButtonClose.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButtonClose.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.bunifuButtonClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButtonClose.BackgroundImage")));
            this.bunifuButtonClose.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButtonClose.ButtonText = "";
            this.bunifuButtonClose.ButtonTextMarginLeft = 0;
            this.bunifuButtonClose.ColorContrastOnClick = 45;
            this.bunifuButtonClose.ColorContrastOnHover = 45;
            this.bunifuButtonClose.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.bunifuButtonClose.CustomizableEdges = borderEdges3;
            this.bunifuButtonClose.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuButtonClose.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButtonClose.DisabledFillColor = System.Drawing.Color.Empty;
            this.bunifuButtonClose.DisabledForecolor = System.Drawing.Color.Empty;
            this.bunifuButtonClose.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.bunifuButtonClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuButtonClose.ForeColor = System.Drawing.Color.White;
            this.bunifuButtonClose.IconLeft = null;
            this.bunifuButtonClose.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuButtonClose.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuButtonClose.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.bunifuButtonClose.IconMarginLeft = 11;
            this.bunifuButtonClose.IconPadding = 10;
            this.bunifuButtonClose.IconRight = global::Practice.Properties.Resources.Close_32px;
            this.bunifuButtonClose.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuButtonClose.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuButtonClose.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.bunifuButtonClose.IconSize = 26;
            this.bunifuButtonClose.IdleBorderColor = System.Drawing.Color.Empty;
            this.bunifuButtonClose.IdleBorderRadius = 0;
            this.bunifuButtonClose.IdleBorderThickness = 0;
            this.bunifuButtonClose.IdleFillColor = System.Drawing.Color.Empty;
            this.bunifuButtonClose.IdleIconLeftImage = null;
            this.bunifuButtonClose.IdleIconRightImage = global::Practice.Properties.Resources.Close_32px;
            this.bunifuButtonClose.IndicateFocus = true;
            this.bunifuButtonClose.Location = new System.Drawing.Point(488, 0);
            this.bunifuButtonClose.Name = "bunifuButtonClose";
            this.bunifuButtonClose.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButtonClose.OnDisabledState.BorderRadius = 1;
            this.bunifuButtonClose.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButtonClose.OnDisabledState.BorderThickness = 1;
            this.bunifuButtonClose.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButtonClose.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButtonClose.OnDisabledState.IconLeftImage = null;
            this.bunifuButtonClose.OnDisabledState.IconRightImage = null;
            this.bunifuButtonClose.onHoverState.BorderColor = System.Drawing.Color.Red;
            this.bunifuButtonClose.onHoverState.BorderRadius = 1;
            this.bunifuButtonClose.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButtonClose.onHoverState.BorderThickness = 1;
            this.bunifuButtonClose.onHoverState.FillColor = System.Drawing.Color.Red;
            this.bunifuButtonClose.onHoverState.ForeColor = System.Drawing.Color.White;
            this.bunifuButtonClose.onHoverState.IconLeftImage = null;
            this.bunifuButtonClose.onHoverState.IconRightImage = null;
            this.bunifuButtonClose.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuButtonClose.OnIdleState.BorderRadius = 1;
            this.bunifuButtonClose.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButtonClose.OnIdleState.BorderThickness = 1;
            this.bunifuButtonClose.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.bunifuButtonClose.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.bunifuButtonClose.OnIdleState.IconLeftImage = null;
            this.bunifuButtonClose.OnIdleState.IconRightImage = global::Practice.Properties.Resources.Close_32px;
            this.bunifuButtonClose.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(0)))), ((int)(((byte)(51)))));
            this.bunifuButtonClose.OnPressedState.BorderRadius = 1;
            this.bunifuButtonClose.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButtonClose.OnPressedState.BorderThickness = 1;
            this.bunifuButtonClose.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(0)))), ((int)(((byte)(51)))));
            this.bunifuButtonClose.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.bunifuButtonClose.OnPressedState.IconLeftImage = null;
            this.bunifuButtonClose.OnPressedState.IconRightImage = null;
            this.bunifuButtonClose.Size = new System.Drawing.Size(33, 40);
            this.bunifuButtonClose.TabIndex = 3;
            this.bunifuButtonClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButtonClose.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.bunifuButtonClose.TextMarginLeft = 0;
            this.bunifuButtonClose.TextPadding = new System.Windows.Forms.Padding(0);
            this.bunifuToolTip.SetToolTip(this.bunifuButtonClose, "");
            this.bunifuToolTip.SetToolTipIcon(this.bunifuButtonClose, null);
            this.bunifuToolTip.SetToolTipTitle(this.bunifuButtonClose, "");
            this.bunifuButtonClose.UseDefaultRadiusAndThickness = true;
            this.bunifuButtonClose.Click += new System.EventHandler(this.BunifuButtonClose_Click);
            // 
            // labelPathFile
            // 
            this.labelPathFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPathFile.Location = new System.Drawing.Point(12, 52);
            this.labelPathFile.Name = "labelPathFile";
            this.labelPathFile.Size = new System.Drawing.Size(180, 39);
            this.labelPathFile.TabIndex = 5;
            this.labelPathFile.Text = "Номер елемента";
            this.labelPathFile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuToolTip.SetToolTip(this.labelPathFile, "");
            this.bunifuToolTip.SetToolTipIcon(this.labelPathFile, null);
            this.bunifuToolTip.SetToolTipTitle(this.labelPathFile, "");
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
            // buttonSearch
            // 
            this.buttonSearch.AllowAnimations = true;
            this.buttonSearch.AllowMouseEffects = true;
            this.buttonSearch.AllowToggling = false;
            this.buttonSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonSearch.AnimationSpeed = 200;
            this.buttonSearch.AutoGenerateColors = false;
            this.buttonSearch.AutoRoundBorders = false;
            this.buttonSearch.AutoSizeLeftIcon = true;
            this.buttonSearch.AutoSizeRightIcon = true;
            this.buttonSearch.BackColor = System.Drawing.Color.Transparent;
            this.buttonSearch.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.buttonSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSearch.BackgroundImage")));
            this.buttonSearch.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.buttonSearch.ButtonText = "Пошук";
            this.buttonSearch.ButtonTextMarginLeft = 0;
            this.buttonSearch.ColorContrastOnClick = 45;
            this.buttonSearch.ColorContrastOnHover = 45;
            this.buttonSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.buttonSearch.CustomizableEdges = borderEdges1;
            this.buttonSearch.DialogResult = System.Windows.Forms.DialogResult.None;
            this.buttonSearch.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.buttonSearch.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.buttonSearch.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.buttonSearch.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.buttonSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonSearch.ForeColor = System.Drawing.Color.White;
            this.buttonSearch.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSearch.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.buttonSearch.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.buttonSearch.IconMarginLeft = 11;
            this.buttonSearch.IconPadding = 10;
            this.buttonSearch.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSearch.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.buttonSearch.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.buttonSearch.IconSize = 25;
            this.buttonSearch.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.buttonSearch.IdleBorderRadius = 40;
            this.buttonSearch.IdleBorderThickness = 1;
            this.buttonSearch.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.buttonSearch.IdleIconLeftImage = null;
            this.buttonSearch.IdleIconRightImage = null;
            this.buttonSearch.IndicateFocus = false;
            this.buttonSearch.Location = new System.Drawing.Point(176, 161);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.buttonSearch.OnDisabledState.BorderRadius = 40;
            this.buttonSearch.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.buttonSearch.OnDisabledState.BorderThickness = 1;
            this.buttonSearch.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.buttonSearch.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.buttonSearch.OnDisabledState.IconLeftImage = null;
            this.buttonSearch.OnDisabledState.IconRightImage = null;
            this.buttonSearch.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.buttonSearch.onHoverState.BorderRadius = 40;
            this.buttonSearch.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.buttonSearch.onHoverState.BorderThickness = 1;
            this.buttonSearch.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.buttonSearch.onHoverState.ForeColor = System.Drawing.Color.White;
            this.buttonSearch.onHoverState.IconLeftImage = null;
            this.buttonSearch.onHoverState.IconRightImage = null;
            this.buttonSearch.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.buttonSearch.OnIdleState.BorderRadius = 40;
            this.buttonSearch.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.buttonSearch.OnIdleState.BorderThickness = 1;
            this.buttonSearch.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.buttonSearch.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.buttonSearch.OnIdleState.IconLeftImage = null;
            this.buttonSearch.OnIdleState.IconRightImage = null;
            this.buttonSearch.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.buttonSearch.OnPressedState.BorderRadius = 40;
            this.buttonSearch.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.buttonSearch.OnPressedState.BorderThickness = 1;
            this.buttonSearch.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.buttonSearch.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.buttonSearch.OnPressedState.IconLeftImage = null;
            this.buttonSearch.OnPressedState.IconRightImage = null;
            this.buttonSearch.Size = new System.Drawing.Size(185, 40);
            this.buttonSearch.TabIndex = 1;
            this.buttonSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonSearch.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.buttonSearch.TextMarginLeft = 0;
            this.buttonSearch.TextPadding = new System.Windows.Forms.Padding(0);
            this.bunifuToolTip.SetToolTip(this.buttonSearch, "");
            this.bunifuToolTip.SetToolTipIcon(this.buttonSearch, null);
            this.bunifuToolTip.SetToolTipTitle(this.buttonSearch, "");
            this.buttonSearch.UseDefaultRadiusAndThickness = true;
            this.buttonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // textBoxIndex
            // 
            this.textBoxIndex.AcceptsReturn = false;
            this.textBoxIndex.AcceptsTab = false;
            this.textBoxIndex.AnimationSpeed = 200;
            this.textBoxIndex.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.textBoxIndex.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.textBoxIndex.AutoSizeHeight = true;
            this.textBoxIndex.BackColor = System.Drawing.Color.Transparent;
            this.textBoxIndex.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("textBoxIndex.BackgroundImage")));
            this.textBoxIndex.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.textBoxIndex.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.textBoxIndex.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.textBoxIndex.BorderColorIdle = System.Drawing.Color.Silver;
            this.textBoxIndex.BorderRadius = 1;
            this.textBoxIndex.BorderThickness = 1;
            this.textBoxIndex.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.textBoxIndex.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxIndex.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.textBoxIndex.DefaultText = "";
            this.textBoxIndex.FillColor = System.Drawing.Color.White;
            this.textBoxIndex.HideSelection = true;
            this.textBoxIndex.IconLeft = null;
            this.textBoxIndex.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxIndex.IconPadding = 10;
            this.textBoxIndex.IconRight = null;
            this.textBoxIndex.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxIndex.Lines = new string[0];
            this.textBoxIndex.Location = new System.Drawing.Point(198, 52);
            this.textBoxIndex.MaxLength = 32767;
            this.textBoxIndex.MinimumSize = new System.Drawing.Size(1, 1);
            this.textBoxIndex.Modified = false;
            this.textBoxIndex.Multiline = false;
            this.textBoxIndex.Name = "textBoxIndex";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.textBoxIndex.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.textBoxIndex.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.textBoxIndex.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.textBoxIndex.OnIdleState = stateProperties4;
            this.textBoxIndex.Padding = new System.Windows.Forms.Padding(3);
            this.textBoxIndex.PasswordChar = '\0';
            this.textBoxIndex.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.textBoxIndex.PlaceholderText = "Введіть індекс";
            this.textBoxIndex.ReadOnly = false;
            this.textBoxIndex.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxIndex.SelectedText = "";
            this.textBoxIndex.SelectionLength = 0;
            this.textBoxIndex.SelectionStart = 0;
            this.textBoxIndex.ShortcutsEnabled = true;
            this.textBoxIndex.Size = new System.Drawing.Size(234, 39);
            this.textBoxIndex.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.textBoxIndex.TabIndex = 0;
            this.textBoxIndex.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxIndex.TextMarginBottom = 0;
            this.textBoxIndex.TextMarginLeft = 3;
            this.textBoxIndex.TextMarginTop = 1;
            this.textBoxIndex.TextPlaceholder = "Введіть індекс";
            this.bunifuToolTip.SetToolTip(this.textBoxIndex, "");
            this.bunifuToolTip.SetToolTipIcon(this.textBoxIndex, null);
            this.bunifuToolTip.SetToolTipTitle(this.textBoxIndex, "");
            this.textBoxIndex.UseSystemPasswordChar = false;
            this.textBoxIndex.WordWrap = true;
            // 
            // labelTitleResult
            // 
            this.labelTitleResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitleResult.Location = new System.Drawing.Point(12, 100);
            this.labelTitleResult.Name = "labelTitleResult";
            this.labelTitleResult.Size = new System.Drawing.Size(180, 39);
            this.labelTitleResult.TabIndex = 6;
            this.labelTitleResult.Text = "Результат";
            this.labelTitleResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuToolTip.SetToolTip(this.labelTitleResult, "");
            this.bunifuToolTip.SetToolTipIcon(this.labelTitleResult, null);
            this.bunifuToolTip.SetToolTipTitle(this.labelTitleResult, "");
            // 
            // labelResult
            // 
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelResult.Location = new System.Drawing.Point(198, 100);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(313, 39);
            this.labelResult.TabIndex = 4;
            this.labelResult.Text = "Дані відсутні";
            this.labelResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuToolTip.SetToolTip(this.labelResult, "");
            this.bunifuToolTip.SetToolTipIcon(this.labelResult, null);
            this.bunifuToolTip.SetToolTipTitle(this.labelResult, "");
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
            // FormSerch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 224);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.labelTitleResult);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxIndex);
            this.Controls.Add(this.labelPathFile);
            this.Controls.Add(this.bunifuGradientPanelTitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSerch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCreateFiles";
            this.bunifuGradientPanelTitleBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconSave)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuFormDock formDock;
        private Bunifu.UI.WinForms.BunifuGradientPanel bunifuGradientPanelTitleBar;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButtonMinimized;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButtonClose;
        private System.Windows.Forms.Label labelPathFile;
        private Bunifu.UI.WinForms.BunifuTextBox textBoxIndex;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 buttonSearch;
        private Bunifu.UI.WinForms.BunifuPictureBox iconSave;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private Bunifu.UI.WinForms.BunifuToolTip bunifuToolTip;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Label labelTitleResult;
        private Bunifu.UI.WinForms.BunifuSnackbar bunifuSnackbar;
    }
}