using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using RSI_X_Desktop.forms.HelpingClass;

namespace RSI_X_Desktop.forms
{
    public partial class EntranceForm : DevExpress.XtraEditors.XtraForm
    {
        LoginWnd loginWnd;
        
        public EntranceForm()
        {
            InitializeComponent();
        }

        private void ShowLogin()
        {
            panel2.BackgroundImage = null;
            panel1.Controls.Clear();
            panel1.ColumnStyles.Clear();
            panel1.RowStyles.Clear();
            Controls.Remove(LoginBackground);
            panel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
            panel1.RowStyles.Add(new RowStyle(SizeType.Percent, 87));
            panel1.RowStyles.Add(new RowStyle(SizeType.Percent, 13));

            panel1.Controls.Add(LoginBackground,0,0);
            panel1.Controls.Add(backButton,0,1);
            backButton.Dock = DockStyle.Left;
            LoginBackground.Anchor = AnchorStyles.Bottom;

            LoginBackground.Visible = true;
            backButton.Visible = true;

            loginWnd.Show(this);

            panel2.Update();
            panel2.BackgroundImage = Properties.Resources.BckgFade;
        }

        private void EntranceForm_Load(object sender, EventArgs e)
        {
            JoinBtn.Location = new Point(Width/2 - JoinBtn.Width/2, Height - Height / 2);
            JoinBtn.BringToFront();
            timer1.Start();
        }

        private void EntranceForm_VisibleChanged(object sender, EventArgs e)
        {
            if (loginWnd != null)
            {
                loginWnd.Visible = Visible;
                loginWnd.loginInput.Visible = Visible;
            }

            panel2.BackgroundImage = Visible ? Properties.Resources.BckgFade : null;
        }

        private void JoinBtn_Click(object sender, EventArgs e)
        {
            JoinBtn.Hide();
            ShowLogin();
        }

        private void EntranceForm_Shown(object sender, EventArgs e)
        {
            (loginWnd = new LoginWnd()).Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel1.SuspendLayout();
            TimeLabel.Text = DateTime.Now.ToString("HH:mm");
            string i = DateTime.Now.ToString("MM");
            string dm = "";
            switch (i)
            {
                case "01": dm = "January"; break;
                case "02": dm = "February"; break;
                case "03": dm = "March"; break;
                case "04": dm = "April"; break;
                case "05": dm = "May"; break;
                case "06": dm = "June"; break;
                case "07": dm = "July"; break;
                case "08": dm = "August"; break;
                case "09": dm = "September"; break;
                case "10": dm = "October"; break;
                case "11": dm = "November"; break;
                case "12": dm = "December"; break;
            }
            LocalTimeLabel.Text = DateTime.Now.DayOfWeek.ToString() + ", " + dm + " " + DateTime.Now.ToString("dd, yyyy");
            panel1.ResumeLayout(false);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            panel2.BackgroundImage = null;
            loginWnd.Hide();
            LoginBackground.Visible = false;
            backButton.Visible = false;
            panel1.Controls.Clear();
            panel1.ColumnStyles.Clear();
            panel1.RowStyles.Clear();

            this.panel1.ColumnCount = 1;
            this.panel1.RowCount = 4;

            this.panel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));

            this.panel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.panel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));

            this.panel1.Controls.Add(this.LocalTimeLabel, 0, 2);
            this.panel1.Controls.Add(this.TimeLabel, 0, 1);
            this.panel1.Controls.Add(this.tableLayoutPanel1, 0, 3);

            this.tableLayoutPanel1.Controls.Add(this.JoinBtn, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.svgImageBox2, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.backButton, 0, 0);

            JoinBtn.Show();
            panel2.Update();
            panel2.BackgroundImage = Properties.Resources.BckgFade;
        }
    }
}