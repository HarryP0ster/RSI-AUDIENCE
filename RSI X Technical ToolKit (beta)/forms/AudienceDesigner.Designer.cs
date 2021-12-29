
namespace RSI_X_Desktop.forms
{
    partial class AudienceDesigner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AudienceDesigner));
            this.MainLayout = new DevExpress.Utils.Layout.TablePanel();
            this.LeftSidePanel = new DevExpress.XtraEditors.SidePanel();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.CenterPanel = new DevExpress.Utils.Layout.TablePanel();
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.RoomNameLabel = new ReaLTaiizor.Controls.SkyLabel();
            this.IconsPanel = new DevExpress.Utils.Layout.TablePanel();
            this.langBox = new ReaLTaiizor.Controls.SkyComboBox();
            this.signOff = new DevExpress.XtraEditors.SvgImageBox();
            this.audioLabel = new DevExpress.XtraEditors.SvgImageBox();
            this.volumeTrackBar = new ReaLTaiizor.Controls.DungeonTrackBar();
            this.volumeIcon = new DevExpress.XtraEditors.SvgImageBox();
            this.turnOrig = new DevExpress.XtraEditors.SvgImageBox();
            this.devicesLabel = new DevExpress.XtraEditors.SvgImageBox();
            this.videoLabel = new DevExpress.XtraEditors.SvgImageBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.MainLayout)).BeginInit();
            this.MainLayout.SuspendLayout();
            this.LeftSidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CenterPanel)).BeginInit();
            this.CenterPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconsPanel)).BeginInit();
            this.IconsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.signOff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.audioLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumeIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.turnOrig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.devicesLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoLabel)).BeginInit();
            this.SuspendLayout();
            // 
            // MainLayout
            // 
            this.MainLayout.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.MainLayout.Appearance.Options.UseBackColor = true;
            this.MainLayout.AutoSize = true;
            this.MainLayout.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 10F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 90F)});
            this.MainLayout.Controls.Add(this.LeftSidePanel);
            this.MainLayout.Controls.Add(this.CenterPanel);
            this.MainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainLayout.Location = new System.Drawing.Point(0, 0);
            this.MainLayout.Name = "MainLayout";
            this.MainLayout.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 22F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 26F)});
            this.MainLayout.Size = new System.Drawing.Size(1280, 800);
            this.MainLayout.TabIndex = 0;
            // 
            // LeftSidePanel
            // 
            this.LeftSidePanel.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.LeftSidePanel.Appearance.Options.UseBackColor = true;
            this.LeftSidePanel.BorderThickness = 0;
            this.MainLayout.SetColumn(this.LeftSidePanel, 0);
            this.LeftSidePanel.Controls.Add(this.Logo);
            this.LeftSidePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LeftSidePanel.Location = new System.Drawing.Point(0, 22);
            this.LeftSidePanel.Margin = new System.Windows.Forms.Padding(0);
            this.LeftSidePanel.Name = "LeftSidePanel";
            this.LeftSidePanel.Padding = new System.Windows.Forms.Padding(5, 35, 20, 0);
            this.MainLayout.SetRow(this.LeftSidePanel, 1);
            this.LeftSidePanel.Size = new System.Drawing.Size(128, 778);
            this.LeftSidePanel.TabIndex = 2;
            // 
            // Logo
            // 
            this.Logo.BackgroundImage = global::RSI_X_Desktop.Properties.Resources.logotype;
            this.Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Logo.Image = global::RSI_X_Desktop.Properties.Resources.logotype;
            this.Logo.Location = new System.Drawing.Point(5, 35);
            this.Logo.Margin = new System.Windows.Forms.Padding(0);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(103, 68);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            // 
            // CenterPanel
            // 
            this.CenterPanel.AutoSize = true;
            this.MainLayout.SetColumn(this.CenterPanel, 1);
            this.CenterPanel.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)});
            this.CenterPanel.Controls.Add(this.tablePanel1);
            this.CenterPanel.Controls.Add(this.IconsPanel);
            this.CenterPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CenterPanel.Location = new System.Drawing.Point(128, 22);
            this.CenterPanel.Margin = new System.Windows.Forms.Padding(0);
            this.CenterPanel.Name = "CenterPanel";
            this.MainLayout.SetRow(this.CenterPanel, 1);
            this.CenterPanel.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 85F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 15F)});
            this.CenterPanel.Size = new System.Drawing.Size(1152, 778);
            this.CenterPanel.TabIndex = 1;
            // 
            // tablePanel1
            // 
            this.tablePanel1.AutoSize = true;
            this.CenterPanel.SetColumn(this.tablePanel1, 0);
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F)});
            this.tablePanel1.Controls.Add(this.RoomNameLabel);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(3, 3);
            this.tablePanel1.Name = "tablePanel1";
            this.CenterPanel.SetRow(this.tablePanel1, 0);
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 7F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 93F)});
            this.tablePanel1.Size = new System.Drawing.Size(1146, 655);
            this.tablePanel1.TabIndex = 1;
            // 
            // RoomNameLabel
            // 
            this.RoomNameLabel.AutoSize = true;
            this.tablePanel1.SetColumn(this.RoomNameLabel, 0);
            this.RoomNameLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.RoomNameLabel.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RoomNameLabel.ForeColor = System.Drawing.Color.White;
            this.RoomNameLabel.Location = new System.Drawing.Point(35, 43);
            this.RoomNameLabel.Margin = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.RoomNameLabel.Name = "RoomNameLabel";
            this.tablePanel1.SetRow(this.RoomNameLabel, 1);
            this.RoomNameLabel.Size = new System.Drawing.Size(168, 39);
            this.RoomNameLabel.TabIndex = 5;
            this.RoomNameLabel.Text = "Room Name";
            this.RoomNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // IconsPanel
            // 
            this.IconsPanel.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.IconsPanel.Appearance.Options.UseBackColor = true;
            this.IconsPanel.AutoSize = true;
            this.CenterPanel.SetColumn(this.IconsPanel, 0);
            this.IconsPanel.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 0F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 0F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 0F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 140F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 40F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 10F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 10F)});
            this.IconsPanel.Controls.Add(this.langBox);
            this.IconsPanel.Controls.Add(this.signOff);
            this.IconsPanel.Controls.Add(this.audioLabel);
            this.IconsPanel.Controls.Add(this.volumeTrackBar);
            this.IconsPanel.Controls.Add(this.volumeIcon);
            this.IconsPanel.Controls.Add(this.turnOrig);
            this.IconsPanel.Controls.Add(this.devicesLabel);
            this.IconsPanel.Controls.Add(this.videoLabel);
            this.IconsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IconsPanel.Location = new System.Drawing.Point(0, 661);
            this.IconsPanel.Margin = new System.Windows.Forms.Padding(0);
            this.IconsPanel.Name = "IconsPanel";
            this.CenterPanel.SetRow(this.IconsPanel, 1);
            this.IconsPanel.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.IconsPanel.Size = new System.Drawing.Size(1152, 117);
            this.IconsPanel.TabIndex = 0;
            // 
            // langBox
            // 
            this.langBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.langBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.langBox.BGColorA = System.Drawing.Color.Transparent;
            this.langBox.BGColorB = System.Drawing.Color.Transparent;
            this.langBox.BorderColorA = System.Drawing.Color.Transparent;
            this.langBox.BorderColorB = System.Drawing.Color.Transparent;
            this.langBox.BorderColorC = System.Drawing.Color.Transparent;
            this.langBox.BorderColorD = System.Drawing.Color.Transparent;
            this.IconsPanel.SetColumn(this.langBox, 11);
            this.langBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.langBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.langBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.langBox.DropDownWidth = 74;
            this.langBox.Enabled = false;
            this.langBox.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.langBox.ForeColor = System.Drawing.Color.White;
            this.langBox.ItemHeight = 22;
            this.langBox.ItemHighlightColor = System.Drawing.Color.Transparent;
            this.langBox.LineColorA = System.Drawing.Color.Transparent;
            this.langBox.LineColorB = System.Drawing.Color.Transparent;
            this.langBox.LineColorC = System.Drawing.Color.Transparent;
            this.langBox.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.langBox.ListBorderColor = System.Drawing.Color.White;
            this.langBox.ListDashType = System.Drawing.Drawing2D.DashStyle.Dot;
            this.langBox.ListForeColor = System.Drawing.Color.Black;
            this.langBox.ListSelectedBackColorA = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.langBox.ListSelectedBackColorB = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.langBox.Location = new System.Drawing.Point(1071, 48);
            this.langBox.Margin = new System.Windows.Forms.Padding(20, 10, 10, 3);
            this.langBox.Name = "langBox";
            this.IconsPanel.SetRow(this.langBox, 0);
            this.langBox.Size = new System.Drawing.Size(71, 28);
            this.langBox.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.None;
            this.langBox.StartIndex = 0;
            this.langBox.TabIndex = 12;
            this.langBox.TriangleColorA = System.Drawing.Color.White;
            this.langBox.TriangleColorB = System.Drawing.Color.White;
            this.langBox.SelectedIndexChanged += new System.EventHandler(this.langBox_SelectedIndexChanged_1);
            this.langBox.EnabledChanged += new System.EventHandler(this.langBox_EnabledChanged);
            // 
            // signOff
            // 
            this.signOff.BackColor = System.Drawing.Color.Transparent;
            this.signOff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.IconsPanel.SetColumn(this.signOff, 4);
            this.signOff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signOff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.signOff.ItemAppearance.Normal.BorderColor = System.Drawing.Color.White;
            this.signOff.ItemAppearance.Normal.BorderThickness = 0F;
            this.signOff.Location = new System.Drawing.Point(382, 0);
            this.signOff.Margin = new System.Windows.Forms.Padding(0);
            this.signOff.Name = "signOff";
            this.IconsPanel.SetRow(this.signOff, 0);
            this.signOff.Size = new System.Drawing.Size(241, 117);
            this.signOff.SizeMode = DevExpress.XtraEditors.SvgImageSizeMode.Squeeze;
            this.signOff.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("signOff.SvgImage")));
            this.signOff.TabIndex = 2;
            this.signOff.Text = "svgImageBox1";
            this.signOff.Click += new System.EventHandler(this.HomeBtn_Click);
            // 
            // audioLabel
            // 
            this.audioLabel.BackColor = System.Drawing.Color.Transparent;
            this.audioLabel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.IconsPanel.SetColumn(this.audioLabel, 0);
            this.audioLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.audioLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.audioLabel.ItemAppearance.Normal.BorderColor = System.Drawing.Color.White;
            this.audioLabel.ItemAppearance.Normal.BorderThickness = 0F;
            this.audioLabel.ItemHitTestType = DevExpress.XtraEditors.ItemHitTestType.BoundingBox;
            this.audioLabel.Location = new System.Drawing.Point(0, 0);
            this.audioLabel.Margin = new System.Windows.Forms.Padding(0);
            this.audioLabel.Name = "audioLabel";
            this.IconsPanel.SetRow(this.audioLabel, 0);
            this.audioLabel.Size = new System.Drawing.Size(80, 117);
            this.audioLabel.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("audioLabel.SvgImage")));
            this.audioLabel.TabIndex = 0;
            this.audioLabel.UseDirectXPaint = DevExpress.Utils.DefaultBoolean.False;
            this.audioLabel.Click += new System.EventHandler(this.labelMicrophone_Click);
            this.audioLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.audioLabel_MouseMove);
            // 
            // volumeTrackBar
            // 
            this.volumeTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.volumeTrackBar.BorderColor = System.Drawing.Color.White;
            this.IconsPanel.SetColumn(this.volumeTrackBar, 10);
            this.volumeTrackBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.volumeTrackBar.DrawValueString = false;
            this.volumeTrackBar.EmptyBackColor = System.Drawing.SystemColors.ScrollBar;
            this.volumeTrackBar.FillBackColor = System.Drawing.Color.White;
            this.volumeTrackBar.JumpToMouse = true;
            this.volumeTrackBar.Location = new System.Drawing.Point(953, 47);
            this.volumeTrackBar.Maximum = 100;
            this.volumeTrackBar.Minimum = 0;
            this.volumeTrackBar.MinimumSize = new System.Drawing.Size(47, 22);
            this.volumeTrackBar.Name = "volumeTrackBar";
            this.IconsPanel.SetRow(this.volumeTrackBar, 0);
            this.volumeTrackBar.Size = new System.Drawing.Size(95, 22);
            this.volumeTrackBar.TabIndex = 5;
            this.volumeTrackBar.ThumbBackColor = System.Drawing.Color.White;
            this.volumeTrackBar.ThumbBorderColor = System.Drawing.Color.White;
            this.volumeTrackBar.Value = 100;
            this.volumeTrackBar.ValueDivison = ReaLTaiizor.Controls.DungeonTrackBar.ValueDivisor.By1;
            this.volumeTrackBar.ValueToSet = 100F;
            this.volumeTrackBar.ValueChanged += new ReaLTaiizor.Controls.DungeonTrackBar.ValueChangedEventHandler(this.trackBar1_ValueChanged);
            // 
            // volumeIcon
            // 
            this.IconsPanel.SetColumn(this.volumeIcon, 8);
            this.volumeIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.volumeIcon.ItemAppearance.Normal.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.volumeIcon.ItemAppearance.Normal.BorderThickness = 0F;
            this.volumeIcon.ItemAppearance.Normal.FillColor = System.Drawing.Color.White;
            this.volumeIcon.Location = new System.Drawing.Point(887, 0);
            this.volumeIcon.Margin = new System.Windows.Forms.Padding(0);
            this.volumeIcon.Name = "volumeIcon";
            this.IconsPanel.SetRow(this.volumeIcon, 0);
            this.volumeIcon.Size = new System.Drawing.Size(51, 117);
            this.volumeIcon.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("volumeIcon.SvgImage")));
            this.volumeIcon.TabIndex = 4;
            // 
            // turnOrig
            // 
            this.IconsPanel.SetColumn(this.turnOrig, 6);
            this.turnOrig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.turnOrig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.turnOrig.ItemAppearance.Normal.BorderColor = System.Drawing.Color.White;
            this.turnOrig.ItemAppearance.Normal.BorderThickness = 0F;
            this.turnOrig.ItemAppearance.Normal.FillColor = System.Drawing.Color.WhiteSmoke;
            this.turnOrig.Location = new System.Drawing.Point(673, 0);
            this.turnOrig.Margin = new System.Windows.Forms.Padding(0);
            this.turnOrig.Name = "turnOrig";
            this.IconsPanel.SetRow(this.turnOrig, 0);
            this.turnOrig.Size = new System.Drawing.Size(202, 117);
            this.turnOrig.SizeMode = DevExpress.XtraEditors.SvgImageSizeMode.Squeeze;
            this.turnOrig.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("turnOrig.SvgImage")));
            this.turnOrig.TabIndex = 3;
            this.turnOrig.Click += new System.EventHandler(this.mSwitchOriginal_CheckedChanged);
            this.turnOrig.MouseMove += new System.Windows.Forms.MouseEventHandler(this.turnOrig_MouseMove);
            // 
            // devicesLabel
            // 
            this.devicesLabel.BackColor = System.Drawing.Color.Transparent;
            this.devicesLabel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.IconsPanel.SetColumn(this.devicesLabel, 2);
            this.devicesLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.devicesLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.devicesLabel.ItemAppearance.Normal.BorderColor = System.Drawing.Color.White;
            this.devicesLabel.ItemAppearance.Normal.BorderThickness = 0F;
            this.devicesLabel.ItemAppearance.Normal.FillColor = System.Drawing.Color.WhiteSmoke;
            this.devicesLabel.ItemHitTestType = DevExpress.XtraEditors.ItemHitTestType.BoundingBox;
            this.devicesLabel.Location = new System.Drawing.Point(229, 0);
            this.devicesLabel.Margin = new System.Windows.Forms.Padding(0);
            this.devicesLabel.Name = "devicesLabel";
            this.IconsPanel.SetRow(this.devicesLabel, 0);
            this.devicesLabel.Size = new System.Drawing.Size(103, 117);
            this.devicesLabel.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("devicesLabel.SvgImage")));
            this.devicesLabel.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.None;
            this.devicesLabel.TabIndex = 1;
            this.devicesLabel.UseDirectXPaint = DevExpress.Utils.DefaultBoolean.False;
            this.devicesLabel.Click += new System.EventHandler(this.devicesLabel_Click);
            this.devicesLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.devicesLabel_MouseMove);
            // 
            // videoLabel
            // 
            this.videoLabel.AutoSizeInLayoutControl = true;
            this.videoLabel.BackColor = System.Drawing.Color.Transparent;
            this.videoLabel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.IconsPanel.SetColumn(this.videoLabel, 1);
            this.videoLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.videoLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.videoLabel.ItemAppearance.Normal.BorderColor = System.Drawing.Color.White;
            this.videoLabel.ItemAppearance.Normal.BorderThickness = 0F;
            this.videoLabel.ItemAppearance.Normal.FillColor = System.Drawing.Color.WhiteSmoke;
            this.videoLabel.ItemHitTestType = DevExpress.XtraEditors.ItemHitTestType.BoundingBox;
            this.videoLabel.Location = new System.Drawing.Point(80, 0);
            this.videoLabel.Margin = new System.Windows.Forms.Padding(0);
            this.videoLabel.Name = "videoLabel";
            this.IconsPanel.SetRow(this.videoLabel, 0);
            this.videoLabel.Size = new System.Drawing.Size(149, 117);
            this.videoLabel.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("videoLabel.SvgImage")));
            this.videoLabel.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.None;
            this.videoLabel.TabIndex = 1;
            this.videoLabel.UseDirectXPaint = DevExpress.Utils.DefaultBoolean.False;
            this.videoLabel.Click += new System.EventHandler(this.labelVideo_Click);
            this.videoLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.videoLabel_MouseMove);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // AudienceDesigner
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1280, 800);
            this.Controls.Add(this.MainLayout);
            this.DoubleBuffered = true;
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1280, 800);
            this.MinimumSize = new System.Drawing.Size(1280, 800);
            this.Name = "AudienceDesigner";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AudienceDesigner";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.Load += new System.EventHandler(this.AudienceDesigner_Load);
            this.Shown += new System.EventHandler(this.AudienceDesigner_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.MainLayout)).EndInit();
            this.MainLayout.ResumeLayout(false);
            this.MainLayout.PerformLayout();
            this.LeftSidePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CenterPanel)).EndInit();
            this.CenterPanel.ResumeLayout(false);
            this.CenterPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            this.tablePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconsPanel)).EndInit();
            this.IconsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.signOff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.audioLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumeIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.turnOrig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.devicesLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoLabel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.Utils.Layout.TablePanel MainLayout;
        private DevExpress.Utils.Layout.TablePanel CenterPanel;
        private DevExpress.Utils.Layout.TablePanel IconsPanel;
        private DevExpress.XtraEditors.SidePanel LeftSidePanel;
        private System.Windows.Forms.PictureBox Logo;
        private DevExpress.XtraEditors.SvgImageBox signOff;
        private DevExpress.XtraEditors.SvgImageBox volumeIcon;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        internal ReaLTaiizor.Controls.SkyComboBox langBox;
        internal ReaLTaiizor.Controls.SkyLabel RoomNameLabel;
        internal ReaLTaiizor.Controls.DungeonTrackBar volumeTrackBar;
        internal DevExpress.XtraEditors.SvgImageBox audioLabel;
        internal DevExpress.XtraEditors.SvgImageBox videoLabel;
        internal DevExpress.XtraEditors.SvgImageBox devicesLabel;
        internal DevExpress.XtraEditors.SvgImageBox turnOrig;
        private System.Windows.Forms.Timer timer1;
    }
}