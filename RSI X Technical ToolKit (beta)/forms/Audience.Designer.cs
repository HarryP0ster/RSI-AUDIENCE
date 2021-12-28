
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
            this.RemotePanel = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Nothing = new System.Windows.Forms.Panel();
            this.streamsTable = new System.Windows.Forms.TableLayoutPanel();
            this.nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new ReaLTaiizor.Controls.Button();
            this.airTabPage1 = new ReaLTaiizor.Controls.AirTabPage();
            this.FormAudience.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.RemotePanel.SuspendLayout();
            this.Nothing.SuspendLayout();
            this.SuspendLayout();
            // 
            // FormAudience
            // 
            this.FormAudience.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.FormAudience.Controls.Add(this.tableLayoutPanel1);
            this.FormAudience.Controls.Add(this.nightControlBox1);
            this.FormAudience.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FormAudience.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormAudience.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.FormAudience.Location = new System.Drawing.Point(0, 0);
            this.FormAudience.MaximumSize = new System.Drawing.Size(1280, 800);
            this.FormAudience.MinimumSize = new System.Drawing.Size(1280, 800);
            this.FormAudience.Name = "FormAudience";
            this.FormAudience.Padding = new System.Windows.Forms.Padding(0, 22, 0, 0);
            this.FormAudience.Sizable = false;
            this.FormAudience.Size = new System.Drawing.Size(1280, 800);
            this.FormAudience.SmartBounds = false;
            this.FormAudience.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormAudience.TabIndex = 0;
            this.FormAudience.Text = "RSI X DESKTOP AUDIENCE";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 92F));
            this.tableLayoutPanel1.Controls.Add(this.RemotePanel, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 22);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1280, 778);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // RemotePanel
            // 
            this.RemotePanel.ColumnCount = 2;
            this.RemotePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.58074F));
            this.RemotePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.41926F));
            this.RemotePanel.Controls.Add(this.panel1, 1, 0);
            this.RemotePanel.Controls.Add(this.Nothing, 0, 0);
            this.RemotePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RemotePanel.Location = new System.Drawing.Point(102, 0);
            this.RemotePanel.Margin = new System.Windows.Forms.Padding(0);
            this.RemotePanel.Name = "RemotePanel";
            this.RemotePanel.RowCount = 1;
            this.RemotePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.RemotePanel.Size = new System.Drawing.Size(1178, 778);
            this.RemotePanel.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(987, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(188, 772);
            this.panel1.TabIndex = 1;
            // 
            // Nothing
            // 
            this.Nothing.BackColor = System.Drawing.Color.Silver;
            this.Nothing.BackgroundImage = global::RSI_X_Desktop.Properties.Resources.logotype_black;
            this.Nothing.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Nothing.Controls.Add(this.streamsTable);
            this.Nothing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Nothing.Location = new System.Drawing.Point(0, 0);
            this.Nothing.Margin = new System.Windows.Forms.Padding(0);
            this.Nothing.Name = "Nothing";
            this.Nothing.Size = new System.Drawing.Size(984, 778);
            this.Nothing.TabIndex = 2;
            this.Nothing.Click += new System.EventHandler(this.streamsTable_Click);
            this.Nothing.MouseMove += new System.Windows.Forms.MouseEventHandler(this.streamsTable_MouseMove);
            // 
            // streamsTable
            // 
            this.streamsTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.streamsTable.BackColor = System.Drawing.Color.Transparent;
            this.streamsTable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.streamsTable.ColumnCount = 1;
            this.streamsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.streamsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.streamsTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.streamsTable.Location = new System.Drawing.Point(0, 0);
            this.streamsTable.Margin = new System.Windows.Forms.Padding(0);
            this.streamsTable.Name = "streamsTable";
            this.streamsTable.RowCount = 1;
            this.streamsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.streamsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.streamsTable.Size = new System.Drawing.Size(984, 778);
            this.streamsTable.TabIndex = 2;
            this.streamsTable.Click += new System.EventHandler(this.streamsTable_Click);
            this.streamsTable.MouseMove += new System.Windows.Forms.MouseEventHandler(this.streamsTable_MouseMove);
            // 
            // nightControlBox1
            // 
            this.nightControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nightControlBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.nightControlBox1.CloseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.nightControlBox1.CloseHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nightControlBox1.DefaultLocation = false;
            this.nightControlBox1.DisableMaximizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.nightControlBox1.DisableMinimizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.nightControlBox1.EnableCloseColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox1.EnableMaximizeButton = true;
            this.nightControlBox1.EnableMaximizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox1.EnableMinimizeButton = true;
            this.nightControlBox1.EnableMinimizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox1.Location = new System.Drawing.Point(1137, -5);
            this.nightControlBox1.MaximizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nightControlBox1.MaximizeHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.MinimizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nightControlBox1.MinimizeHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.Name = "nightControlBox1";
            this.nightControlBox1.Size = new System.Drawing.Size(139, 31);
            this.nightControlBox1.TabIndex = 5;
            this.nightControlBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.nightControlBox1_MouseClick);
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Image = null;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.button1.Size = new System.Drawing.Size(120, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // airTabPage1
            // 
            this.airTabPage1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.airTabPage1.ItemSize = new System.Drawing.Size(30, 115);
            this.airTabPage1.Location = new System.Drawing.Point(0, 0);
            this.airTabPage1.Multiline = true;
            this.airTabPage1.Name = "airTabPage1";
            this.airTabPage1.SelectedIndex = 0;
            this.airTabPage1.ShowOuterBorders = false;
            this.airTabPage1.Size = new System.Drawing.Size(200, 100);
            this.airTabPage1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.airTabPage1.SquareColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(87)))), ((int)(((byte)(100)))));
            this.airTabPage1.TabIndex = 5;
            // 
            // Audience
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1117, 637);
            this.Controls.Add(this.FormAudience);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(126, 50);
            this.Name = "Audience";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RSI X DESKTOP AUDIENCE";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Audience_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Spectator_FormClosed);
            this.Load += new System.EventHandler(this.Audience_Load);
            this.Resize += new System.EventHandler(this.Audience_Resize);
            this.FormAudience.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.RemotePanel.ResumeLayout(false);
            this.Nothing.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Forms.FormTheme FormAudience;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private ReaLTaiizor.Controls.Button button1;
        private ReaLTaiizor.Controls.AirTabPage airTabPage1;
        private ReaLTaiizor.Controls.Button button2;
        private System.Windows.Forms.TableLayoutPanel RemotePanel;
        private System.Windows.Forms.Panel panel1;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        internal System.Windows.Forms.TableLayoutPanel streamsTable;
        private System.Windows.Forms.Panel Nothing;
    }
}