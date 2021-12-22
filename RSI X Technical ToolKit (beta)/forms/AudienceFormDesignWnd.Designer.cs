
namespace RSI_X_Desktop.forms
{
    partial class AudienceFormDesignWnd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AudienceFormDesignWnd));
            this.FormOuter = new ReaLTaiizor.Forms.NightForm();
            this.MainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.LeftSidePanel = new System.Windows.Forms.TableLayoutPanel();
            this.PictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.MiddleLayout = new System.Windows.Forms.TableLayoutPanel();
            this.ControlsTable = new System.Windows.Forms.TableLayoutPanel();
            this.FullScreen = new System.Windows.Forms.Label();
            this.comboBoxPanel = new System.Windows.Forms.TableLayoutPanel();
            this.langBox = new ReaLTaiizor.Controls.MaterialComboBox();
            this.mSwitchOriginal = new MaterialSkin.Controls.MaterialSwitch();
            this.HomeBtn = new ReaLTaiizor.Controls.Button();
            this.labelVideo = new System.Windows.Forms.Label();
            this.labelAudio = new System.Windows.Forms.PictureBox();
            this.FormOuter.SuspendLayout();
            this.MainLayout.SuspendLayout();
            this.LeftSidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLogo)).BeginInit();
            this.MiddleLayout.SuspendLayout();
            this.ControlsTable.SuspendLayout();
            this.comboBoxPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.labelAudio)).BeginInit();
            this.SuspendLayout();
            // 
            // FormOuter
            // 
            this.FormOuter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.FormOuter.Controls.Add(this.MainLayout);
            this.FormOuter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FormOuter.DrawIcon = false;
            this.FormOuter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormOuter.HeadColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.FormOuter.Location = new System.Drawing.Point(0, 0);
            this.FormOuter.MinimumSize = new System.Drawing.Size(100, 42);
            this.FormOuter.Name = "FormOuter";
            this.FormOuter.Padding = new System.Windows.Forms.Padding(0, 22, 0, 0);
            this.FormOuter.Size = new System.Drawing.Size(1280, 800);
            this.FormOuter.TabIndex = 0;
            this.FormOuter.TextAlignment = ReaLTaiizor.Forms.NightForm.Alignment.Left;
            this.FormOuter.TitleBarTextColor = System.Drawing.Color.Gainsboro;
            // 
            // MainLayout
            // 
            this.MainLayout.ColumnCount = 2;
            this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.MainLayout.Controls.Add(this.LeftSidePanel, 0, 0);
            this.MainLayout.Controls.Add(this.MiddleLayout, 1, 0);
            this.MainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainLayout.Location = new System.Drawing.Point(0, 22);
            this.MainLayout.Name = "MainLayout";
            this.MainLayout.RowCount = 1;
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainLayout.Size = new System.Drawing.Size(1280, 778);
            this.MainLayout.TabIndex = 0;
            // 
            // LeftSidePanel
            // 
            this.LeftSidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.LeftSidePanel.ColumnCount = 1;
            this.LeftSidePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LeftSidePanel.Controls.Add(this.PictureBoxLogo, 0, 0);
            this.LeftSidePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LeftSidePanel.Location = new System.Drawing.Point(0, 0);
            this.LeftSidePanel.Margin = new System.Windows.Forms.Padding(0);
            this.LeftSidePanel.Name = "LeftSidePanel";
            this.LeftSidePanel.RowCount = 2;
            this.LeftSidePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.LeftSidePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.LeftSidePanel.Size = new System.Drawing.Size(128, 778);
            this.LeftSidePanel.TabIndex = 0;
            // 
            // PictureBoxLogo
            // 
            this.PictureBoxLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PictureBoxLogo.BackgroundImage")));
            this.PictureBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PictureBoxLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBoxLogo.Location = new System.Drawing.Point(0, 10);
            this.PictureBoxLogo.Margin = new System.Windows.Forms.Padding(0, 10, 20, 10);
            this.PictureBoxLogo.Name = "PictureBoxLogo";
            this.PictureBoxLogo.Size = new System.Drawing.Size(108, 57);
            this.PictureBoxLogo.TabIndex = 1;
            this.PictureBoxLogo.TabStop = false;
            // 
            // MiddleLayout
            // 
            this.MiddleLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.MiddleLayout.ColumnCount = 1;
            this.MiddleLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MiddleLayout.Controls.Add(this.ControlsTable, 0, 1);
            this.MiddleLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MiddleLayout.Location = new System.Drawing.Point(128, 0);
            this.MiddleLayout.Margin = new System.Windows.Forms.Padding(0);
            this.MiddleLayout.Name = "MiddleLayout";
            this.MiddleLayout.RowCount = 2;
            this.MiddleLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.MiddleLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.MiddleLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MiddleLayout.Size = new System.Drawing.Size(1152, 778);
            this.MiddleLayout.TabIndex = 1;
            // 
            // ControlsTable
            // 
            this.ControlsTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ControlsTable.ColumnCount = 6;
            this.ControlsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.ControlsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.ControlsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.ControlsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.ControlsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.ControlsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.ControlsTable.Controls.Add(this.FullScreen, 2, 0);
            this.ControlsTable.Controls.Add(this.comboBoxPanel, 5, 0);
            this.ControlsTable.Controls.Add(this.mSwitchOriginal, 4, 0);
            this.ControlsTable.Controls.Add(this.HomeBtn, 3, 0);
            this.ControlsTable.Controls.Add(this.labelVideo, 1, 0);
            this.ControlsTable.Controls.Add(this.labelAudio, 0, 0);
            this.ControlsTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ControlsTable.Location = new System.Drawing.Point(3, 664);
            this.ControlsTable.Name = "ControlsTable";
            this.ControlsTable.RowCount = 1;
            this.ControlsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ControlsTable.Size = new System.Drawing.Size(1146, 111);
            this.ControlsTable.TabIndex = 0;
            // 
            // FullScreen
            // 
            this.FullScreen.AutoSize = true;
            this.FullScreen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FullScreen.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FullScreen.ForeColor = System.Drawing.Color.White;
            this.FullScreen.Location = new System.Drawing.Point(114, 0);
            this.FullScreen.Margin = new System.Windows.Forms.Padding(0);
            this.FullScreen.Name = "FullScreen";
            this.FullScreen.Size = new System.Drawing.Size(49, 87);
            this.FullScreen.TabIndex = 21;
            this.FullScreen.Text = "Full Screen";
            this.FullScreen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxPanel
            // 
            this.comboBoxPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxPanel.BackColor = System.Drawing.Color.Silver;
            this.comboBoxPanel.ColumnCount = 1;
            this.comboBoxPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.comboBoxPanel.Controls.Add(this.langBox, 0, 0);
            this.comboBoxPanel.Location = new System.Drawing.Point(1029, 30);
            this.comboBoxPanel.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.comboBoxPanel.Name = "comboBoxPanel";
            this.comboBoxPanel.RowCount = 1;
            this.comboBoxPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.comboBoxPanel.Size = new System.Drawing.Size(117, 51);
            this.comboBoxPanel.TabIndex = 43;
            // 
            // langBox
            // 
            this.langBox.AutoResize = false;
            this.langBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.langBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.langBox.Depth = 0;
            this.langBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.langBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.langBox.DropDownHeight = 174;
            this.langBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.langBox.DropDownWidth = 94;
            this.langBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.langBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point);
            this.langBox.ForeColor = System.Drawing.Color.White;
            this.langBox.IntegralHeight = false;
            this.langBox.ItemHeight = 43;
            this.langBox.Items.AddRange(new object[] {
            "ENG"});
            this.langBox.Location = new System.Drawing.Point(3, 3);
            this.langBox.MaxDropDownItems = 4;
            this.langBox.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.langBox.Name = "langBox";
            this.langBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.langBox.Size = new System.Drawing.Size(111, 49);
            this.langBox.StartIndex = 0;
            this.langBox.TabIndex = 43;
            // 
            // mSwitchOriginal
            // 
            this.mSwitchOriginal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.mSwitchOriginal.BackColor = System.Drawing.Color.Fuchsia;
            this.mSwitchOriginal.Depth = 0;
            this.mSwitchOriginal.Font = new System.Drawing.Font("Segoe UI", 2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mSwitchOriginal.ForeColor = System.Drawing.Color.Black;
            this.mSwitchOriginal.Location = new System.Drawing.Point(915, 37);
            this.mSwitchOriginal.Margin = new System.Windows.Forms.Padding(0);
            this.mSwitchOriginal.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mSwitchOriginal.MouseState = MaterialSkin.MouseState.HOVER;
            this.mSwitchOriginal.Name = "mSwitchOriginal";
            this.mSwitchOriginal.Ripple = true;
            this.mSwitchOriginal.Size = new System.Drawing.Size(114, 37);
            this.mSwitchOriginal.TabIndex = 44;
            this.mSwitchOriginal.Text = "Original";
            this.mSwitchOriginal.UseVisualStyleBackColor = false;
            // 
            // HomeBtn
            // 
            this.HomeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.HomeBtn.BackColor = System.Drawing.Color.Fuchsia;
            this.HomeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HomeBtn.EnteredColor = System.Drawing.Color.DarkRed;
            this.HomeBtn.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HomeBtn.Image = null;
            this.HomeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HomeBtn.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.HomeBtn.Location = new System.Drawing.Point(471, 24);
            this.HomeBtn.Margin = new System.Windows.Forms.Padding(300, 3, 300, 10);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.HomeBtn.Size = new System.Drawing.Size(144, 55);
            this.HomeBtn.TabIndex = 45;
            this.HomeBtn.Text = "SIGN OFF";
            this.HomeBtn.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // labelVideo
            // 
            this.labelVideo.AutoSize = true;
            this.labelVideo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelVideo.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelVideo.ForeColor = System.Drawing.Color.White;
            this.labelVideo.Location = new System.Drawing.Point(57, 0);
            this.labelVideo.Margin = new System.Windows.Forms.Padding(0);
            this.labelVideo.Name = "labelVideo";
            this.labelVideo.Size = new System.Drawing.Size(57, 29);
            this.labelVideo.TabIndex = 20;
            this.labelVideo.Text = "VIDEO";
            this.labelVideo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelAudio
            // 
            this.labelAudio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelAudio.Image = global::RSI_X_Desktop.Properties.Resources.RSI_MUTE;
            this.labelAudio.Location = new System.Drawing.Point(3, 3);
            this.labelAudio.Name = "labelAudio";
            this.labelAudio.Size = new System.Drawing.Size(51, 105);
            this.labelAudio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.labelAudio.TabIndex = 46;
            this.labelAudio.TabStop = false;
            // 
            // AudienceFormDesignWnd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1280, 800);
            this.Controls.Add(this.FormOuter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1280, 800);
            this.MinimumSize = new System.Drawing.Size(1280, 800);
            this.Name = "AudienceFormDesignWnd";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "dungeonForm1";
            this.TransparencyKey = System.Drawing.Color.WhiteSmoke;
            this.Load += new System.EventHandler(this.AudienceFormDesignWnd_Load);
            this.FormOuter.ResumeLayout(false);
            this.MainLayout.ResumeLayout(false);
            this.LeftSidePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLogo)).EndInit();
            this.MiddleLayout.ResumeLayout(false);
            this.ControlsTable.ResumeLayout(false);
            this.ControlsTable.PerformLayout();
            this.comboBoxPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.labelAudio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Forms.NightForm FormOuter;
        private System.Windows.Forms.TableLayoutPanel MainLayout;
        private System.Windows.Forms.TableLayoutPanel LeftSidePanel;
        private System.Windows.Forms.PictureBox PictureBoxLogo;
        private System.Windows.Forms.TableLayoutPanel MiddleLayout;
        private System.Windows.Forms.TableLayoutPanel ControlsTable;
        private System.Windows.Forms.TableLayoutPanel comboBoxPanel;
        internal System.Windows.Forms.Label labelVideo;
        internal System.Windows.Forms.Label FullScreen;
        internal ReaLTaiizor.Controls.MaterialComboBox langBox;
        internal MaterialSkin.Controls.MaterialSwitch mSwitchOriginal;
        internal ReaLTaiizor.Controls.Button HomeBtn;
        internal System.Windows.Forms.PictureBox labelAudio;
    }
}