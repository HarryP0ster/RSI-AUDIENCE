
namespace RSI_X_Desktop
{
    partial class Audience
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Audience));
            this.FormAudience = new ReaLTaiizor.Forms.FormTheme();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBoxRemoteVideo = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.RoomNameLabel = new ReaLTaiizor.Controls.SkyLabel();
            this.PictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.mSwitchOriginal = new MaterialSkin.Controls.MaterialSwitch();
            this.labelVideo = new System.Windows.Forms.Label();
            this.labelMicrophone = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.trackBar1 = new ReaLTaiizor.Controls.DungeonTrackBar();
            this.labelVolume = new System.Windows.Forms.Label();
            this.langBox = new MaterialSkin.Controls.MaterialComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FormAudience.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRemoteVideo)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLogo)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // FormAudience
            // 
            this.FormAudience.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.FormAudience.Controls.Add(this.tableLayoutPanel1);
            this.FormAudience.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FormAudience.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormAudience.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.FormAudience.Location = new System.Drawing.Point(0, 0);
            this.FormAudience.MaximumSize = new System.Drawing.Size(1280, 800);
            this.FormAudience.MinimumSize = new System.Drawing.Size(1280, 800);
            this.FormAudience.Name = "FormAudience";
            this.FormAudience.Padding = new System.Windows.Forms.Padding(3, 28, 3, 28);
            this.FormAudience.Sizable = false;
            this.FormAudience.Size = new System.Drawing.Size(1280, 800);
            this.FormAudience.SmartBounds = false;
            this.FormAudience.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormAudience.TabIndex = 0;
            this.FormAudience.Text = "RSI X Desktop Audience";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBoxRemoteVideo, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 28);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1274, 744);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // pictureBoxRemoteVideo
            // 
            this.pictureBoxRemoteVideo.BackColor = System.Drawing.Color.Silver;
            this.pictureBoxRemoteVideo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxRemoteVideo.BackgroundImage")));
            this.pictureBoxRemoteVideo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxRemoteVideo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxRemoteVideo.Location = new System.Drawing.Point(3, 77);
            this.pictureBoxRemoteVideo.Name = "pictureBoxRemoteVideo";
            this.pictureBoxRemoteVideo.Size = new System.Drawing.Size(1268, 589);
            this.pictureBoxRemoteVideo.TabIndex = 0;
            this.pictureBoxRemoteVideo.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.RoomNameLabel, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.PictureBoxLogo, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1268, 68);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // RoomNameLabel
            // 
            this.RoomNameLabel.AutoSize = true;
            this.RoomNameLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.RoomNameLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RoomNameLabel.ForeColor = System.Drawing.Color.White;
            this.RoomNameLabel.Location = new System.Drawing.Point(124, 0);
            this.RoomNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RoomNameLabel.Name = "RoomNameLabel";
            this.RoomNameLabel.Size = new System.Drawing.Size(237, 68);
            this.RoomNameLabel.TabIndex = 4;
            this.RoomNameLabel.Text = "RR (don\'t remove me)";
            this.RoomNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PictureBoxLogo
            // 
            this.PictureBoxLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PictureBoxLogo.BackgroundImage")));
            this.PictureBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PictureBoxLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBoxLogo.Location = new System.Drawing.Point(3, 3);
            this.PictureBoxLogo.Name = "PictureBoxLogo";
            this.PictureBoxLogo.Size = new System.Drawing.Size(114, 62);
            this.PictureBoxLogo.TabIndex = 0;
            this.PictureBoxLogo.TabStop = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 6;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tableLayoutPanel3.Controls.Add(this.mSwitchOriginal, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.labelVideo, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.labelMicrophone, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.langBox, 5, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 672);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1268, 69);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // mSwitchOriginal
            // 
            this.mSwitchOriginal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.mSwitchOriginal.AutoSize = true;
            this.mSwitchOriginal.Depth = 0;
            this.mSwitchOriginal.Location = new System.Drawing.Point(1018, 16);
            this.mSwitchOriginal.Margin = new System.Windows.Forms.Padding(0);
            this.mSwitchOriginal.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mSwitchOriginal.MouseState = MaterialSkin.MouseState.HOVER;
            this.mSwitchOriginal.Name = "mSwitchOriginal";
            this.mSwitchOriginal.Ripple = true;
            this.mSwitchOriginal.Size = new System.Drawing.Size(125, 37);
            this.mSwitchOriginal.TabIndex = 41;
            this.mSwitchOriginal.Text = "Original  ";
            this.mSwitchOriginal.UseVisualStyleBackColor = true;
            this.mSwitchOriginal.CheckedChanged += new System.EventHandler(this.mSwitchOriginal_CheckedChanged);
            // 
            // labelVideo
            // 
            this.labelVideo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelVideo.AutoSize = true;
            this.labelVideo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelVideo.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelVideo.ForeColor = System.Drawing.Color.White;
            this.labelVideo.Location = new System.Drawing.Point(4, 20);
            this.labelVideo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelVideo.Name = "labelVideo";
            this.labelVideo.Size = new System.Drawing.Size(77, 29);
            this.labelVideo.TabIndex = 19;
            this.labelVideo.Text = "VIDEO";
            this.labelVideo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelVideo.Click += new System.EventHandler(this.labelVideo_Click);
            // 
            // labelMicrophone
            // 
            this.labelMicrophone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMicrophone.AutoSize = true;
            this.labelMicrophone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelMicrophone.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMicrophone.ForeColor = System.Drawing.Color.White;
            this.labelMicrophone.Location = new System.Drawing.Point(89, 20);
            this.labelMicrophone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMicrophone.Name = "labelMicrophone";
            this.labelMicrophone.Size = new System.Drawing.Size(77, 29);
            this.labelMicrophone.TabIndex = 18;
            this.labelMicrophone.Text = "AUDIO";
            this.labelMicrophone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelMicrophone.Click += new System.EventHandler(this.labelMicrophone_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.trackBar1, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.labelVolume, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(173, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(164, 63);
            this.tableLayoutPanel4.TabIndex = 20;
            // 
            // trackBar1
            // 
            this.trackBar1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.trackBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(104)))));
            this.trackBar1.BorderColor = System.Drawing.Color.White;
            this.trackBar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBar1.DrawValueString = false;
            this.trackBar1.EmptyBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.trackBar1.FillBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(104)))));
            this.trackBar1.JumpToMouse = true;
            this.trackBar1.Location = new System.Drawing.Point(86, 20);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Minimum = 0;
            this.trackBar1.MinimumSize = new System.Drawing.Size(47, 22);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(74, 22);
            this.trackBar1.TabIndex = 22;
            this.trackBar1.Text = "dungeonTrackBar1";
            this.trackBar1.ThumbBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.trackBar1.ThumbBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.trackBar1.Value = 100;
            this.trackBar1.ValueDivison = ReaLTaiizor.Controls.DungeonTrackBar.ValueDivisor.By1;
            this.trackBar1.ValueToSet = 100F;
            this.trackBar1.Visible = false;
            this.trackBar1.ValueChanged += new ReaLTaiizor.Controls.DungeonTrackBar.ValueChangedEventHandler(this.trackBar1_ValueChanged);
            // 
            // labelVolume
            // 
            this.labelVolume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelVolume.AutoSize = true;
            this.labelVolume.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelVolume.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelVolume.ForeColor = System.Drawing.Color.White;
            this.labelVolume.Location = new System.Drawing.Point(4, 17);
            this.labelVolume.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelVolume.Name = "labelVolume";
            this.labelVolume.Size = new System.Drawing.Size(74, 29);
            this.labelVolume.TabIndex = 21;
            this.labelVolume.Text = "VOLUME";
            this.labelVolume.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelVolume.Click += new System.EventHandler(this.labelVolume_Click);
            // 
            // langBox
            // 
            this.langBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.langBox.AutoResize = false;
            this.langBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.langBox.Depth = 0;
            this.langBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.langBox.DropDownHeight = 174;
            this.langBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.langBox.DropDownWidth = 121;
            this.langBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.langBox.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.langBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.langBox.FormattingEnabled = true;
            this.langBox.IntegralHeight = false;
            this.langBox.ItemHeight = 43;
            this.langBox.Items.AddRange(new object[] {
            "Test",
            "Test",
            "Test"});
            this.langBox.Location = new System.Drawing.Point(1146, 10);
            this.langBox.MaxDropDownItems = 4;
            this.langBox.MouseState = MaterialSkin.MouseState.OUT;
            this.langBox.Name = "langBox";
            this.langBox.Size = new System.Drawing.Size(119, 49);
            this.langBox.StartIndex = 0;
            this.langBox.TabIndex = 42;
            this.langBox.SelectedIndexChanged += new System.EventHandler(this.langBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(259, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 29);
            this.label1.TabIndex = 21;
            this.label1.Text = "VOLUME";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Audience
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 800);
            this.Controls.Add(this.FormAudience);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(126, 50);
            this.Name = "Audience";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RSI X Desktop Audience";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Spectator_FormClosed);
            this.Load += new System.EventHandler(this.Audience_Load);
            this.FormAudience.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRemoteVideo)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLogo)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Forms.FormTheme FormAudience;
        private System.Windows.Forms.PictureBox pictureBoxRemoteVideo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.PictureBox PictureBoxLogo;
        private ReaLTaiizor.Controls.SkyLabel RoomNameLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label labelMicrophone;
        private System.Windows.Forms.Label labelVideo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label labelVolume;
        private ReaLTaiizor.Controls.DungeonTrackBar trackBar1;
        private MaterialSkin.Controls.MaterialSwitch mSwitchOriginal;
        private MaterialSkin.Controls.MaterialComboBox langBox;
    }
}