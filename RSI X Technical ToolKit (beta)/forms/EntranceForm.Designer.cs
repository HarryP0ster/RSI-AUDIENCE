
namespace RSI_X_Desktop.forms
{
    partial class EntranceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EntranceForm));
            this.formTheme1 = new ReaLTaiizor.Forms.FormTheme();
            this.panel1 = new System.Windows.Forms.Panel();
            this.JoinBtn = new DevExpress.XtraEditors.SvgImageBox();
            this.LoginBackground = new DevExpress.XtraEditors.SvgImageBox();
            this.controlBox1 = new ReaLTaiizor.Controls.ControlBox();
            this.formTheme1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.JoinBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // formTheme1
            // 
            this.formTheme1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.formTheme1.Controls.Add(this.panel1);
            this.formTheme1.Controls.Add(this.controlBox1);
            this.formTheme1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formTheme1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.formTheme1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.formTheme1.Location = new System.Drawing.Point(0, 0);
            this.formTheme1.Margin = new System.Windows.Forms.Padding(0);
            this.formTheme1.Name = "formTheme1";
            this.formTheme1.Padding = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.formTheme1.Sizable = false;
            this.formTheme1.Size = new System.Drawing.Size(1000, 700);
            this.formTheme1.SmartBounds = false;
            this.formTheme1.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.formTheme1.TabIndex = 0;
            this.formTheme1.Text = "RSI EXCHANGE AUDIENCE";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::RSI_X_Desktop.Properties.Resources.RSI_TEXTURE_COMPRESSED;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.JoinBtn);
            this.panel1.Controls.Add(this.LoginBackground);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 675);
            this.panel1.TabIndex = 95;
            // 
            // JoinBtn
            // 
            this.JoinBtn.BackColor = System.Drawing.Color.Transparent;
            this.JoinBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.JoinBtn.Location = new System.Drawing.Point(26, 98);
            this.JoinBtn.Name = "JoinBtn";
            this.JoinBtn.Size = new System.Drawing.Size(236, 222);
            this.JoinBtn.SizeMode = DevExpress.XtraEditors.SvgImageSizeMode.Squeeze;
            this.JoinBtn.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("JoinBtn.SvgImage")));
            this.JoinBtn.TabIndex = 1;
            this.JoinBtn.Text = "svgImageBox1";
            this.JoinBtn.Click += new System.EventHandler(this.JoinBtn_Click);
            // 
            // LoginBackground
            // 
            this.LoginBackground.BackColor = System.Drawing.Color.Transparent;
            this.LoginBackground.Enabled = false;
            this.LoginBackground.ItemAppearance.Normal.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.LoginBackground.Location = new System.Drawing.Point(277, 98);
            this.LoginBackground.Name = "LoginBackground";
            this.LoginBackground.Size = new System.Drawing.Size(500, 490);
            this.LoginBackground.SizeMode = DevExpress.XtraEditors.SvgImageSizeMode.Stretch;
            this.LoginBackground.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("LoginBackground.SvgImage")));
            this.LoginBackground.TabIndex = 0;
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
            this.controlBox1.Location = new System.Drawing.Point(910, -2);
            this.controlBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.controlBox1.MaximizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.controlBox1.MinimizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.controlBox1.Name = "controlBox1";
            this.controlBox1.Size = new System.Drawing.Size(90, 25);
            this.controlBox1.TabIndex = 94;
            this.controlBox1.Text = "controlBox1";
            // 
            // EntranceForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.formTheme1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("EntranceForm.IconOptions.Icon")));
            this.MinimumSize = new System.Drawing.Size(126, 50);
            this.Name = "EntranceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RSI EXCHANGE AUDIENCE";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.EntranceForm_Load);
            this.Shown += new System.EventHandler(this.EntranceForm_Shown);
            this.VisibleChanged += new System.EventHandler(this.EntranceForm_VisibleChanged);
            this.formTheme1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.JoinBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginBackground)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Forms.FormTheme formTheme1;
        private ReaLTaiizor.Controls.ControlBox controlBox1;
        internal DevExpress.XtraEditors.SvgImageBox LoginBackground;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SvgImageBox JoinBtn;
    }
}