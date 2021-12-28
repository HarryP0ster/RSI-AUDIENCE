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
        public enum DPI 
        {
            P100 = 96,
            P125 = 120,
            P150 = 144
        }
        LoginWnd loginWnd;
        
        public EntranceForm()
        {
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            InitializeComponent();
        }

        private void ShowLogin()
        {
            LoginBackground.Visible = true;
            panel1.Controls.Clear();
            panel1.ColumnStyles.Clear();
            panel1.RowStyles.Clear();

            Controls.Remove(LoginBackground);
            panel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
            panel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100));

            panel1.Controls.Add(LoginBackground,0,0);
            LoginBackground.Anchor = AnchorStyles.None;
            panel1.SuspendLayout();

            loginWnd.Show(this);
        }

        private void EntranceForm_Load(object sender, EventArgs e)
        {
            LoginBackground.Visible = false;
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
        }
    }
}