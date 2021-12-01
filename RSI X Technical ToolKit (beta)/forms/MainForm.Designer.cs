
namespace RSI_X_Desktop.forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.formTheme1 = new ReaLTaiizor.Forms.FormTheme();
            this.controlBox1 = new ReaLTaiizor.Controls.ControlBox();
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.VersionLabel = new ReaLTaiizor.Controls.MoonLabel();
            this.LocalTimeLabel = new ReaLTaiizor.Controls.MoonLabel();
            this.TimeLabel = new ReaLTaiizor.Controls.MoonLabel();
            this.tableLayoutPanelButtons = new System.Windows.Forms.TableLayoutPanel();
            this.ResetButton = new ReaLTaiizor.Controls.Button();
            this.CloseButton = new ReaLTaiizor.Controls.Button();
            this.JoinButton = new ReaLTaiizor.Controls.Button();
            this.tableLayoutPanelInput = new System.Windows.Forms.TableLayoutPanel();
            this.dungeonHeaderLabel1 = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            this.NewTextBox = new System.Windows.Forms.MaskedTextBox();
            this.tableLayoutPanelLogo = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelVersions = new System.Windows.Forms.TableLayoutPanel();
            this.labelVersion = new System.Windows.Forms.Label();
            this.labelBeta = new System.Windows.Forms.Label();
            this.labelLogo = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.formTheme1.SuspendLayout();
            this.tableLayoutPanelMain.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanelButtons.SuspendLayout();
            this.tableLayoutPanelInput.SuspendLayout();
            this.tableLayoutPanelLogo.SuspendLayout();
            this.tableLayoutPanelVersions.SuspendLayout();
            this.SuspendLayout();
            // 
            // formTheme1
            // 
            this.formTheme1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.formTheme1.Controls.Add(this.controlBox1);
            this.formTheme1.Controls.Add(this.tableLayoutPanelMain);
            this.formTheme1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formTheme1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.formTheme1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.formTheme1.Location = new System.Drawing.Point(0, 0);
            this.formTheme1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.formTheme1.Name = "formTheme1";
            this.formTheme1.Padding = new System.Windows.Forms.Padding(5, 37, 5, 37);
            this.formTheme1.Sizable = false;
            this.formTheme1.Size = new System.Drawing.Size(914, 600);
            this.formTheme1.SmartBounds = false;
            this.formTheme1.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
            this.formTheme1.TabIndex = 0;
            this.formTheme1.Text = "RSI EXCHANGE AUDIENCE";
            this.formTheme1.Click += new System.EventHandler(this.formTheme1_Click);
            // 
            // controlBox1
            // 
            this.controlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.controlBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.controlBox1.CloseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.controlBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.controlBox1.DefaultLocation = false;
            this.controlBox1.EnableHoverHighlight = true;
            this.controlBox1.EnableMaximizeButton = false;
            this.controlBox1.EnableMinimizeButton = true;
            this.controlBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.controlBox1.Location = new System.Drawing.Point(811, 0);
            this.controlBox1.MaximizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.controlBox1.MinimizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.controlBox1.Name = "controlBox1";
            this.controlBox1.Size = new System.Drawing.Size(90, 25);
            this.controlBox1.TabIndex = 93;
            this.controlBox1.Text = "controlBox1";
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 3;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanelMain.Controls.Add(this.tableLayoutPanel1, 1, 3);
            this.tableLayoutPanelMain.Controls.Add(this.tableLayoutPanelButtons, 1, 2);
            this.tableLayoutPanelMain.Controls.Add(this.tableLayoutPanelInput, 1, 1);
            this.tableLayoutPanelMain.Controls.Add(this.tableLayoutPanelLogo, 1, 0);
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(8, 39);
            this.tableLayoutPanelMain.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 4;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(898, 520);
            this.tableLayoutPanelMain.TabIndex = 92;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel1.Controls.Add(this.VersionLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.LocalTimeLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.TimeLabel, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(30, 483);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(838, 34);
            this.tableLayoutPanel1.TabIndex = 93;
            // 
            // VersionLabel
            // 
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.BackColor = System.Drawing.Color.Transparent;
            this.VersionLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.VersionLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VersionLabel.ForeColor = System.Drawing.Color.Gray;
            this.VersionLabel.Location = new System.Drawing.Point(5, 0);
            this.VersionLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(173, 34);
            this.VersionLabel.TabIndex = 94;
            this.VersionLabel.Text = "RSI X Software (NET.CORE 5.0)";
            this.VersionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LocalTimeLabel
            // 
            this.LocalTimeLabel.AutoSize = true;
            this.LocalTimeLabel.BackColor = System.Drawing.Color.Transparent;
            this.LocalTimeLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.LocalTimeLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LocalTimeLabel.ForeColor = System.Drawing.Color.Gray;
            this.LocalTimeLabel.Location = new System.Drawing.Point(710, 0);
            this.LocalTimeLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LocalTimeLabel.Name = "LocalTimeLabel";
            this.LocalTimeLabel.Size = new System.Drawing.Size(69, 34);
            this.LocalTimeLabel.TabIndex = 93;
            this.LocalTimeLabel.Text = "Local Time";
            this.LocalTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.BackColor = System.Drawing.Color.Transparent;
            this.TimeLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.TimeLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TimeLabel.ForeColor = System.Drawing.Color.Gray;
            this.TimeLabel.Location = new System.Drawing.Point(794, 0);
            this.TimeLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(39, 34);
            this.TimeLabel.TabIndex = 92;
            this.TimeLabel.Text = "12:00";
            this.TimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanelButtons
            // 
            this.tableLayoutPanelButtons.ColumnCount = 3;
            this.tableLayoutPanelButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanelButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanelButtons.Controls.Add(this.ResetButton, 0, 0);
            this.tableLayoutPanelButtons.Controls.Add(this.CloseButton, 1, 0);
            this.tableLayoutPanelButtons.Controls.Add(this.JoinButton, 2, 0);
            this.tableLayoutPanelButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelButtons.Location = new System.Drawing.Point(32, 340);
            this.tableLayoutPanelButtons.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tableLayoutPanelButtons.Name = "tableLayoutPanelButtons";
            this.tableLayoutPanelButtons.RowCount = 1;
            this.tableLayoutPanelButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelButtons.Size = new System.Drawing.Size(834, 136);
            this.tableLayoutPanelButtons.TabIndex = 91;
            // 
            // ResetButton
            // 
            this.ResetButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ResetButton.BackColor = System.Drawing.Color.Transparent;
            this.ResetButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ResetButton.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.ResetButton.Font = new System.Drawing.Font("Bahnschrift Condensed", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ResetButton.Image = null;
            this.ResetButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ResetButton.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.ResetButton.Location = new System.Drawing.Point(241, 41);
            this.ResetButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.ResetButton.Size = new System.Drawing.Size(87, 53);
            this.ResetButton.TabIndex = 81;
            this.ResetButton.Text = "Reset";
            this.ResetButton.TextAlignment = System.Drawing.StringAlignment.Center;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CloseButton.BackColor = System.Drawing.Color.Transparent;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.CloseButton.Font = new System.Drawing.Font("Bahnschrift Condensed", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CloseButton.Image = null;
            this.CloseButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CloseButton.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.CloseButton.Location = new System.Drawing.Point(373, 41);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.CloseButton.Size = new System.Drawing.Size(86, 53);
            this.CloseButton.TabIndex = 80;
            this.CloseButton.Text = "Close";
            this.CloseButton.TextAlignment = System.Drawing.StringAlignment.Center;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // JoinButton
            // 
            this.JoinButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.JoinButton.BackColor = System.Drawing.Color.Transparent;
            this.JoinButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.JoinButton.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.JoinButton.Font = new System.Drawing.Font("Bahnschrift Condensed", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.JoinButton.Image = null;
            this.JoinButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.JoinButton.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.JoinButton.Location = new System.Drawing.Point(504, 41);
            this.JoinButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.JoinButton.Name = "JoinButton";
            this.JoinButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.JoinButton.Size = new System.Drawing.Size(87, 53);
            this.JoinButton.TabIndex = 79;
            this.JoinButton.Text = "Join";
            this.JoinButton.TextAlignment = System.Drawing.StringAlignment.Center;
            this.JoinButton.Click += new System.EventHandler(this.JoinButton_Click);
            // 
            // tableLayoutPanelInput
            // 
            this.tableLayoutPanelInput.ColumnCount = 1;
            this.tableLayoutPanelInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelInput.Controls.Add(this.dungeonHeaderLabel1, 0, 0);
            this.tableLayoutPanelInput.Controls.Add(this.NewTextBox, 0, 1);
            this.tableLayoutPanelInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelInput.Location = new System.Drawing.Point(32, 196);
            this.tableLayoutPanelInput.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tableLayoutPanelInput.Name = "tableLayoutPanelInput";
            this.tableLayoutPanelInput.RowCount = 2;
            this.tableLayoutPanelInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanelInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanelInput.Size = new System.Drawing.Size(834, 136);
            this.tableLayoutPanelInput.TabIndex = 92;
            // 
            // dungeonHeaderLabel1
            // 
            this.dungeonHeaderLabel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.dungeonHeaderLabel1.AutoSize = true;
            this.dungeonHeaderLabel1.BackColor = System.Drawing.Color.Transparent;
            this.dungeonHeaderLabel1.Font = new System.Drawing.Font("Bahnschrift Condensed", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dungeonHeaderLabel1.ForeColor = System.Drawing.Color.White;
            this.dungeonHeaderLabel1.Location = new System.Drawing.Point(308, 7);
            this.dungeonHeaderLabel1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.dungeonHeaderLabel1.Name = "dungeonHeaderLabel1";
            this.dungeonHeaderLabel1.Size = new System.Drawing.Size(218, 33);
            this.dungeonHeaderLabel1.TabIndex = 82;
            this.dungeonHeaderLabel1.Text = "Enter conference code:";
            this.dungeonHeaderLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NewTextBox
            // 
            this.NewTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NewTextBox.Font = new System.Drawing.Font("Bahnschrift Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NewTextBox.Location = new System.Drawing.Point(315, 60);
            this.NewTextBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.NewTextBox.Mask = "0000-0000";
            this.NewTextBox.Name = "NewTextBox";
            this.NewTextBox.Size = new System.Drawing.Size(204, 56);
            this.NewTextBox.TabIndex = 91;
            this.NewTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NewTextBox.Click += new System.EventHandler(this.NewTextBox_Click);
            // 
            // tableLayoutPanelLogo
            // 
            this.tableLayoutPanelLogo.ColumnCount = 1;
            this.tableLayoutPanelLogo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelLogo.Controls.Add(this.tableLayoutPanelVersions, 0, 1);
            this.tableLayoutPanelLogo.Controls.Add(this.labelLogo, 0, 0);
            this.tableLayoutPanelLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelLogo.Location = new System.Drawing.Point(32, 4);
            this.tableLayoutPanelLogo.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tableLayoutPanelLogo.Name = "tableLayoutPanelLogo";
            this.tableLayoutPanelLogo.RowCount = 2;
            this.tableLayoutPanelLogo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanelLogo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanelLogo.Size = new System.Drawing.Size(834, 184);
            this.tableLayoutPanelLogo.TabIndex = 94;
            // 
            // tableLayoutPanelVersions
            // 
            this.tableLayoutPanelVersions.ColumnCount = 5;
            this.tableLayoutPanelVersions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tableLayoutPanelVersions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.94295F));
            this.tableLayoutPanelVersions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 97F));
            this.tableLayoutPanelVersions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.05704F));
            this.tableLayoutPanelVersions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanelVersions.Controls.Add(this.labelVersion, 1, 0);
            this.tableLayoutPanelVersions.Controls.Add(this.labelBeta, 3, 0);
            this.tableLayoutPanelVersions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelVersions.Location = new System.Drawing.Point(5, 132);
            this.tableLayoutPanelVersions.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tableLayoutPanelVersions.Name = "tableLayoutPanelVersions";
            this.tableLayoutPanelVersions.RowCount = 1;
            this.tableLayoutPanelVersions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelVersions.Size = new System.Drawing.Size(824, 48);
            this.tableLayoutPanelVersions.TabIndex = 79;
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelVersion.Font = new System.Drawing.Font("Bahnschrift Condensed", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelVersion.ForeColor = System.Drawing.Color.White;
            this.labelVersion.Location = new System.Drawing.Point(230, 0);
            this.labelVersion.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(160, 48);
            this.labelVersion.TabIndex = 0;
            this.labelVersion.Text = "DESKTOP VERSION";
            this.labelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelBeta
            // 
            this.labelBeta.AutoSize = true;
            this.labelBeta.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelBeta.Font = new System.Drawing.Font("Bahnschrift Condensed", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelBeta.ForeColor = System.Drawing.Color.White;
            this.labelBeta.Location = new System.Drawing.Point(497, 0);
            this.labelBeta.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelBeta.Name = "labelBeta";
            this.labelBeta.Size = new System.Drawing.Size(88, 48);
            this.labelBeta.TabIndex = 1;
            this.labelBeta.Text = "AUDIENCE";
            this.labelBeta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelLogo
            // 
            this.labelLogo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelLogo.AutoSize = true;
            this.labelLogo.Font = new System.Drawing.Font("Bahnschrift Condensed", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelLogo.ForeColor = System.Drawing.Color.White;
            this.labelLogo.Location = new System.Drawing.Point(167, 8);
            this.labelLogo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelLogo.Name = "labelLogo";
            this.labelLogo.Size = new System.Drawing.Size(499, 120);
            this.labelLogo.TabIndex = 80;
            this.labelLogo.Text = "RSI EXCAHNGE";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.formTheme1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MinimumSize = new System.Drawing.Size(144, 67);
            this.Name = "MainForm";
            this.Text = "RSI EXCHANGE AUDIENCE";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.formTheme1.ResumeLayout(false);
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanelButtons.ResumeLayout(false);
            this.tableLayoutPanelInput.ResumeLayout(false);
            this.tableLayoutPanelInput.PerformLayout();
            this.tableLayoutPanelLogo.ResumeLayout(false);
            this.tableLayoutPanelLogo.PerformLayout();
            this.tableLayoutPanelVersions.ResumeLayout(false);
            this.tableLayoutPanelVersions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Forms.FormTheme formTheme1;
        private ReaLTaiizor.Controls.Button JoinButton;
        private ReaLTaiizor.Controls.Button CloseButton;
        private ReaLTaiizor.Controls.Button ResetButton;
        private ReaLTaiizor.Controls.DungeonHeaderLabel dungeonHeaderLabel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MaskedTextBox NewTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelButtons;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelInput;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelLogo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelVersions;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Label labelBeta;
        private System.Windows.Forms.Label labelLogo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private ReaLTaiizor.Controls.MoonLabel VersionLabel;
        private ReaLTaiizor.Controls.MoonLabel LocalTimeLabel;
        private ReaLTaiizor.Controls.MoonLabel TimeLabel;
        private ReaLTaiizor.Controls.ControlBox controlBox1;
    }
}