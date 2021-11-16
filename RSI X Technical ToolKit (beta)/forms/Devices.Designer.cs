
namespace RSI_X_Desktop.forms
{
    partial class Devices
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
            this.materialShowTabControl1 = new ReaLTaiizor.Controls.MaterialShowTabControl();
            this.General = new System.Windows.Forms.TabPage();
            this.BtnCloseGeneral = new ReaLTaiizor.Controls.Button();
            this.dungeonLabel3 = new ReaLTaiizor.Controls.DungeonLabel();
            this.dungeonLabel2 = new ReaLTaiizor.Controls.DungeonLabel();
            this.dungeonLabel1 = new ReaLTaiizor.Controls.DungeonLabel();
            this.bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            this.Sound = new System.Windows.Forms.TabPage();
            this.BtnAcceptSound = new ReaLTaiizor.Controls.Button();
            this.BtnCloseSound = new ReaLTaiizor.Controls.Button();
            this.Dynamic = new ReaLTaiizor.Controls.DungeonLabel();
            this.trackBarSoundOut = new ReaLTaiizor.Controls.DungeonTrackBar();
            this.comboBoxAudioOutput = new ReaLTaiizor.Controls.AloneComboBox();
            this.materialShowTabControl1.SuspendLayout();
            this.General.SuspendLayout();
            this.Sound.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialShowTabControl1
            // 
            this.materialShowTabControl1.Controls.Add(this.General);
            this.materialShowTabControl1.Controls.Add(this.Sound);
            this.materialShowTabControl1.Depth = 0;
            this.materialShowTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialShowTabControl1.Font = new System.Drawing.Font("Bahnschrift Condensed", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.materialShowTabControl1.Location = new System.Drawing.Point(0, 0);
            this.materialShowTabControl1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialShowTabControl1.Multiline = true;
            this.materialShowTabControl1.Name = "materialShowTabControl1";
            this.materialShowTabControl1.SelectedIndex = 0;
            this.materialShowTabControl1.Size = new System.Drawing.Size(321, 541);
            this.materialShowTabControl1.TabIndex = 2;
            // 
            // General
            // 
            this.General.BackColor = System.Drawing.Color.White;
            this.General.CausesValidation = false;
            this.General.Controls.Add(this.BtnCloseGeneral);
            this.General.Controls.Add(this.dungeonLabel3);
            this.General.Controls.Add(this.dungeonLabel2);
            this.General.Controls.Add(this.dungeonLabel1);
            this.General.Controls.Add(this.bigLabel1);
            this.General.Font = new System.Drawing.Font("Bahnschrift Condensed", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.General.Location = new System.Drawing.Point(4, 33);
            this.General.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.General.Name = "General";
            this.General.Size = new System.Drawing.Size(313, 504);
            this.General.TabIndex = 4;
            this.General.Text = "General";
            // 
            // BtnCloseGeneral
            // 
            this.BtnCloseGeneral.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BtnCloseGeneral.BackColor = System.Drawing.Color.Transparent;
            this.BtnCloseGeneral.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCloseGeneral.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.BtnCloseGeneral.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnCloseGeneral.Image = null;
            this.BtnCloseGeneral.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCloseGeneral.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.BtnCloseGeneral.Location = new System.Drawing.Point(225, 466);
            this.BtnCloseGeneral.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.BtnCloseGeneral.Name = "BtnCloseGeneral";
            this.BtnCloseGeneral.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.BtnCloseGeneral.Size = new System.Drawing.Size(80, 28);
            this.BtnCloseGeneral.TabIndex = 4;
            this.BtnCloseGeneral.Text = "Close";
            this.BtnCloseGeneral.TextAlignment = System.Drawing.StringAlignment.Center;
            this.BtnCloseGeneral.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // dungeonLabel3
            // 
            this.dungeonLabel3.AutoSize = true;
            this.dungeonLabel3.BackColor = System.Drawing.Color.Transparent;
            this.dungeonLabel3.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dungeonLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.dungeonLabel3.Location = new System.Drawing.Point(16, 118);
            this.dungeonLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dungeonLabel3.Name = "dungeonLabel3";
            this.dungeonLabel3.Size = new System.Drawing.Size(89, 19);
            this.dungeonLabel3.TabIndex = 3;
            this.dungeonLabel3.Text = "dungeonLabel3";
            // 
            // dungeonLabel2
            // 
            this.dungeonLabel2.AutoSize = true;
            this.dungeonLabel2.BackColor = System.Drawing.Color.Transparent;
            this.dungeonLabel2.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dungeonLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.dungeonLabel2.Location = new System.Drawing.Point(16, 87);
            this.dungeonLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dungeonLabel2.Name = "dungeonLabel2";
            this.dungeonLabel2.Size = new System.Drawing.Size(89, 19);
            this.dungeonLabel2.TabIndex = 2;
            this.dungeonLabel2.Text = "dungeonLabel2";
            // 
            // dungeonLabel1
            // 
            this.dungeonLabel1.AutoSize = true;
            this.dungeonLabel1.BackColor = System.Drawing.Color.Transparent;
            this.dungeonLabel1.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dungeonLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.dungeonLabel1.Location = new System.Drawing.Point(16, 55);
            this.dungeonLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dungeonLabel1.Name = "dungeonLabel1";
            this.dungeonLabel1.Size = new System.Drawing.Size(87, 19);
            this.dungeonLabel1.TabIndex = 1;
            this.dungeonLabel1.Text = "dungeonLabel1";
            // 
            // bigLabel1
            // 
            this.bigLabel1.AutoSize = true;
            this.bigLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel1.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bigLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.bigLabel1.Location = new System.Drawing.Point(16, 10);
            this.bigLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bigLabel1.Name = "bigLabel1";
            this.bigLabel1.Size = new System.Drawing.Size(109, 29);
            this.bigLabel1.TabIndex = 0;
            this.bigLabel1.Text = "Your system";
            // 
            // Sound
            // 
            this.Sound.BackColor = System.Drawing.Color.White;
            this.Sound.Controls.Add(this.BtnAcceptSound);
            this.Sound.Controls.Add(this.BtnCloseSound);
            this.Sound.Controls.Add(this.Dynamic);
            this.Sound.Controls.Add(this.trackBarSoundOut);
            this.Sound.Controls.Add(this.comboBoxAudioOutput);
            this.Sound.Font = new System.Drawing.Font("Bahnschrift Condensed", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Sound.Location = new System.Drawing.Point(4, 33);
            this.Sound.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Sound.Name = "Sound";
            this.Sound.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Sound.Size = new System.Drawing.Size(313, 504);
            this.Sound.TabIndex = 7;
            this.Sound.Text = "Sound";
            // 
            // BtnAcceptSound
            // 
            this.BtnAcceptSound.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BtnAcceptSound.BackColor = System.Drawing.Color.Transparent;
            this.BtnAcceptSound.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAcceptSound.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.BtnAcceptSound.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnAcceptSound.Image = null;
            this.BtnAcceptSound.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAcceptSound.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.BtnAcceptSound.Location = new System.Drawing.Point(140, 466);
            this.BtnAcceptSound.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.BtnAcceptSound.Name = "BtnAcceptSound";
            this.BtnAcceptSound.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.BtnAcceptSound.Size = new System.Drawing.Size(80, 28);
            this.BtnAcceptSound.TabIndex = 7;
            this.BtnAcceptSound.Text = "Accept";
            this.BtnAcceptSound.TextAlignment = System.Drawing.StringAlignment.Center;
            this.BtnAcceptSound.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // BtnCloseSound
            // 
            this.BtnCloseSound.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BtnCloseSound.BackColor = System.Drawing.Color.Transparent;
            this.BtnCloseSound.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCloseSound.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.BtnCloseSound.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnCloseSound.Image = null;
            this.BtnCloseSound.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCloseSound.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.BtnCloseSound.Location = new System.Drawing.Point(225, 466);
            this.BtnCloseSound.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.BtnCloseSound.Name = "BtnCloseSound";
            this.BtnCloseSound.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.BtnCloseSound.Size = new System.Drawing.Size(80, 28);
            this.BtnCloseSound.TabIndex = 6;
            this.BtnCloseSound.Text = "Close";
            this.BtnCloseSound.TextAlignment = System.Drawing.StringAlignment.Center;
            this.BtnCloseSound.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // Dynamic
            // 
            this.Dynamic.AutoSize = true;
            this.Dynamic.BackColor = System.Drawing.Color.Transparent;
            this.Dynamic.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Dynamic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.Dynamic.Location = new System.Drawing.Point(7, 3);
            this.Dynamic.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Dynamic.Name = "Dynamic";
            this.Dynamic.Size = new System.Drawing.Size(49, 18);
            this.Dynamic.TabIndex = 5;
            this.Dynamic.Text = "Speaker";
            // 
            // trackBarSoundOut
            // 
            this.trackBarSoundOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.trackBarSoundOut.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.trackBarSoundOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBarSoundOut.DrawValueString = false;
            this.trackBarSoundOut.EmptyBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.trackBarSoundOut.FillBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(99)))), ((int)(((byte)(50)))));
            this.trackBarSoundOut.JumpToMouse = false;
            this.trackBarSoundOut.Location = new System.Drawing.Point(3, 54);
            this.trackBarSoundOut.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.trackBarSoundOut.Maximum = 100;
            this.trackBarSoundOut.Minimum = 0;
            this.trackBarSoundOut.MinimumSize = new System.Drawing.Size(34, 21);
            this.trackBarSoundOut.Name = "trackBarSoundOut";
            this.trackBarSoundOut.Size = new System.Drawing.Size(302, 22);
            this.trackBarSoundOut.TabIndex = 3;
            this.trackBarSoundOut.Text = "dungeonTrackBar1";
            this.trackBarSoundOut.ThumbBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.trackBarSoundOut.ThumbBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.trackBarSoundOut.Value = 100;
            this.trackBarSoundOut.ValueDivison = ReaLTaiizor.Controls.DungeonTrackBar.ValueDivisor.By100;
            this.trackBarSoundOut.ValueToSet = 1F;
            this.trackBarSoundOut.ValueChanged += new ReaLTaiizor.Controls.DungeonTrackBar.ValueChangedEventHandler(this.trackBarSoundOut_ValueChanged);
            // 
            // comboBoxAudioOutput
            // 
            this.comboBoxAudioOutput.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxAudioOutput.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxAudioOutput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAudioOutput.EnabledCalc = true;
            this.comboBoxAudioOutput.FormattingEnabled = true;
            this.comboBoxAudioOutput.ItemHeight = 20;
            this.comboBoxAudioOutput.Location = new System.Drawing.Point(3, 24);
            this.comboBoxAudioOutput.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.comboBoxAudioOutput.Name = "comboBoxAudioOutput";
            this.comboBoxAudioOutput.Size = new System.Drawing.Size(302, 26);
            this.comboBoxAudioOutput.TabIndex = 0;
            this.comboBoxAudioOutput.SelectedIndexChanged += new System.EventHandler(this.comboBoxAudioOutput_SelectedIndexChanged);
            // 
            // NewDevices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 541);
            this.Controls.Add(this.materialShowTabControl1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Bahnschrift Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MinimumSize = new System.Drawing.Size(90, 47);
            this.Name = "NewDevices";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Settings";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NewDevices_FormClosed);
            this.Load += new System.EventHandler(this.NewDevices_Load);
            this.materialShowTabControl1.ResumeLayout(false);
            this.General.ResumeLayout(false);
            this.General.PerformLayout();
            this.Sound.ResumeLayout(false);
            this.Sound.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.MaterialShowTabControl materialShowTabControl1;
        private System.Windows.Forms.TabPage General;
        private ReaLTaiizor.Controls.Button BtnCloseGeneral;
        private ReaLTaiizor.Controls.DungeonLabel dungeonLabel3;
        private ReaLTaiizor.Controls.DungeonLabel dungeonLabel2;
        private ReaLTaiizor.Controls.DungeonLabel dungeonLabel1;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private System.Windows.Forms.TabPage Sound;
        private ReaLTaiizor.Controls.Button BtnAcceptSound;
        private ReaLTaiizor.Controls.Button BtnCloseSound;
        private ReaLTaiizor.Controls.DungeonLabel Dynamic;
        private ReaLTaiizor.Controls.DungeonTrackBar trackBarSoundOut;
        private ReaLTaiizor.Controls.AloneComboBox comboBoxAudioOutput;
    }
}