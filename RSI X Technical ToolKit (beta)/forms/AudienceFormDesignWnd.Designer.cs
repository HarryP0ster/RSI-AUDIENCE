
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
            this.FormOuter.SuspendLayout();
            this.MainLayout.SuspendLayout();
            this.LeftSidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLogo)).BeginInit();
            this.MiddleLayout.SuspendLayout();
            // 
            // FormOuter
            // 
            this.FormOuter.BackColor = System.Drawing.Color.Fuchsia;
            this.FormOuter.Controls.Add(this.MainLayout);
            this.FormOuter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FormOuter.DrawIcon = false;
            this.FormOuter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormOuter.HeadColor = System.Drawing.Color.Fuchsia;
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
            this.MiddleLayout.ColumnCount = 1;
            this.MiddleLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
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
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.AudienceFormDesignWnd_Load);
            this.FormOuter.ResumeLayout(false);
            this.MainLayout.ResumeLayout(false);
            this.LeftSidePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLogo)).EndInit();
            this.MiddleLayout.ResumeLayout(false);
            this.MiddleLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Forms.NightForm FormOuter;
        private System.Windows.Forms.TableLayoutPanel MainLayout;
        private System.Windows.Forms.TableLayoutPanel LeftSidePanel;
        private System.Windows.Forms.PictureBox PictureBoxLogo;
        private System.Windows.Forms.TableLayoutPanel MiddleLayout;
    }
}