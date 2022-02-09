
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EntranceForm));
            this.formTheme1 = new ReaLTaiizor.Forms.FormTheme();
            this.panel1 = new System.Windows.Forms.TableLayoutPanel();
            this.LocalTimeLabel = new ReaLTaiizor.Controls.MoonLabel();
            this.TimeLabel = new ReaLTaiizor.Controls.MoonLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.JoinBtn = new DevExpress.XtraEditors.SvgImageBox();
            this.svgImageBox2 = new DevExpress.XtraEditors.SvgImageBox();
            this.backButton = new DevExpress.XtraEditors.SvgImageBox();
            this.controlBox1 = new ReaLTaiizor.Controls.ControlBox();
            this.LoginBackground = new DevExpress.XtraEditors.SvgImageBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.formTheme1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.JoinBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // formTheme1
            // 
            this.formTheme1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.formTheme1.Controls.Add(this.panel1);
            this.formTheme1.Controls.Add(this.controlBox1);
            this.formTheme1.Controls.Add(this.LoginBackground);
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
            this.formTheme1.Text = "RSI EXCHANGE RECORDER";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(54)))), ((int)(((byte)(79)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.ColumnCount = 1;
            this.panel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panel1.Controls.Add(this.LocalTimeLabel, 0, 2);
            this.panel1.Controls.Add(this.TimeLabel, 0, 1);
            this.panel1.Controls.Add(this.tableLayoutPanel1, 0, 3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.RowCount = 4;
            this.panel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.panel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.panel1.Size = new System.Drawing.Size(1000, 675);
            this.panel1.TabIndex = 95;
            // 
            // LocalTimeLabel
            // 
            this.LocalTimeLabel.AutoSize = true;
            this.LocalTimeLabel.BackColor = System.Drawing.Color.Transparent;
            this.LocalTimeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LocalTimeLabel.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LocalTimeLabel.ForeColor = System.Drawing.Color.White;
            this.LocalTimeLabel.Location = new System.Drawing.Point(4, 216);
            this.LocalTimeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LocalTimeLabel.Name = "LocalTimeLabel";
            this.LocalTimeLabel.Size = new System.Drawing.Size(992, 42);
            this.LocalTimeLabel.TabIndex = 94;
            this.LocalTimeLabel.Text = "Local Time";
            this.LocalTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.BackColor = System.Drawing.Color.Transparent;
            this.TimeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TimeLabel.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TimeLabel.ForeColor = System.Drawing.Color.White;
            this.TimeLabel.Location = new System.Drawing.Point(4, 139);
            this.TimeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(992, 77);
            this.TimeLabel.TabIndex = 93;
            this.TimeLabel.Text = "12:00";
            this.TimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.JoinBtn, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.svgImageBox2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.backButton, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 261);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(994, 411);
            this.tableLayoutPanel1.TabIndex = 95;
            // 
            // JoinBtn
            // 
            this.JoinBtn.BackColor = System.Drawing.Color.Transparent;
            this.JoinBtn.BackgroundImage = global::RSI_X_Desktop.Properties.Resources.ButtonShadow;
            this.JoinBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.JoinBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.JoinBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.JoinBtn.Location = new System.Drawing.Point(312, 65);
            this.JoinBtn.Margin = new System.Windows.Forms.Padding(3, 65, 3, 65);
            this.JoinBtn.Name = "JoinBtn";
            this.JoinBtn.Size = new System.Drawing.Size(182, 281);
            this.JoinBtn.SizeMode = DevExpress.XtraEditors.SvgImageSizeMode.Squeeze;
            this.JoinBtn.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("JoinBtn.SvgImage")));
            this.JoinBtn.TabIndex = 1;
            this.JoinBtn.Text = "svgImageBox1";
            this.JoinBtn.Click += new System.EventHandler(this.JoinBtn_Click);
            // 
            // svgImageBox2
            // 
            this.svgImageBox2.BackgroundImage = global::RSI_X_Desktop.Properties.Resources.ButtonShadow;
            this.svgImageBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.svgImageBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.svgImageBox2.Location = new System.Drawing.Point(500, 65);
            this.svgImageBox2.Margin = new System.Windows.Forms.Padding(3, 65, 3, 65);
            this.svgImageBox2.Name = "svgImageBox2";
            this.svgImageBox2.Size = new System.Drawing.Size(182, 281);
            this.svgImageBox2.SizeMode = DevExpress.XtraEditors.SvgImageSizeMode.Squeeze;
            this.svgImageBox2.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageBox2.SvgImage")));
            this.svgImageBox2.TabIndex = 3;
            this.svgImageBox2.Text = "svgImageBox2";
            this.svgImageBox2.Visible = false;
            // 
            // backButton
            // 
            this.backButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.backButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backButton.ItemAppearance.Hovered.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.backButton.ItemAppearance.Normal.FillColor = System.Drawing.Color.Silver;
            this.backButton.ItemHitTestType = DevExpress.XtraEditors.ItemHitTestType.BoundingBox;
            this.backButton.Location = new System.Drawing.Point(3, 288);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(120, 120);
            this.backButton.SizeMode = DevExpress.XtraEditors.SvgImageSizeMode.Squeeze;
            this.backButton.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("backButton.SvgImage")));
            this.backButton.TabIndex = 4;
            this.backButton.Text = "svgImageBox1";
            this.backButton.Visible = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
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
            // LoginBackground
            // 
            this.LoginBackground.BackColor = System.Drawing.Color.Transparent;
            this.LoginBackground.Enabled = false;
            this.LoginBackground.ItemAppearance.Normal.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.LoginBackground.Location = new System.Drawing.Point(373, -16);
            this.LoginBackground.Name = "LoginBackground";
            this.LoginBackground.Size = new System.Drawing.Size(500, 490);
            this.LoginBackground.SizeMode = DevExpress.XtraEditors.SvgImageSizeMode.Stretch;
            this.LoginBackground.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("LoginBackground.SvgImage")));
            this.LoginBackground.TabIndex = 0;
            this.LoginBackground.UseDirectXPaint = DevExpress.Utils.DefaultBoolean.True;
            this.LoginBackground.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
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
            this.Text = "RSI EXCHANGE RECORDER";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.EntranceForm_Load);
            this.Shown += new System.EventHandler(this.EntranceForm_Shown);
            this.VisibleChanged += new System.EventHandler(this.EntranceForm_VisibleChanged);
            this.formTheme1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.JoinBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginBackground)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Forms.FormTheme formTheme1;
        private ReaLTaiizor.Controls.ControlBox controlBox1;
        private DevExpress.XtraEditors.SvgImageBox JoinBtn;
        private System.Windows.Forms.Timer timer1;
        private ReaLTaiizor.Controls.MoonLabel TimeLabel;
        private ReaLTaiizor.Controls.MoonLabel LocalTimeLabel;
        private System.Windows.Forms.TableLayoutPanel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.SvgImageBox svgImageBox2;
        private DevExpress.XtraEditors.SvgImageBox LoginBackground;
        private DevExpress.XtraEditors.SvgImageBox backButton;
    }
}