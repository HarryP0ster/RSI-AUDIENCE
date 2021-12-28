﻿using DevExpress.XtraEditors;
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
        TableLayoutPanel LoginTable = new();
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, Int32 wMsg, bool wParam, Int32 lParam);
        public EntranceForm()
        {
            InitializeComponent();
        }

        private void ShowLogin()
        {
            SendMessage(this.Handle, 11, false, 0);
            Fade.Controls.Remove(panel1);
            Fade.Controls.Add(LoginTable);
            SendMessage(this.Handle, 11, true, 0);
            Refresh();
            loginWnd.Show(this);
        }

        private void EntranceForm_Load(object sender, EventArgs e)
        {
            JoinBtn.Location = new Point(Width/2 - JoinBtn.Width/2, Height - Height / 2);
            JoinBtn.BringToFront();
            timer1.Start();
            Controls.Remove(LoginBackground);
            InitLoginTable();
        }

        private void EntranceForm_VisibleChanged(object sender, EventArgs e)
        {
            if (loginWnd != null)
            {
                loginWnd.Visible = Visible;
                loginWnd.loginInput.Visible = Visible;
            }

            Fade.BackgroundImage = Visible ? Properties.Resources.BckgFade : null;
        }

        private void InitLoginTable()
        {
            LoginTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
            LoginTable.RowStyles.Add(new RowStyle(SizeType.Percent, 87));
            LoginTable.RowStyles.Add(new RowStyle(SizeType.Percent, 13));
            backButton.Dock = DockStyle.Left;
            LoginBackground.Anchor = AnchorStyles.Bottom;
            LoginBackground.Visible = true;
            backButton.Visible = true;
            LoginTable.Controls.Add(LoginBackground, 0, 0);
            LoginTable.Controls.Add(backButton, 0, 1);
            LoginTable.Dock = DockStyle.Fill;
            LoginTable.BackColor = Color.Transparent;
        }

        private void JoinBtn_Click(object sender, EventArgs e)
        {
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
            loginWnd.Hide();
            SendMessage(this.Handle, 11, false, 0);
            Fade.Controls.Remove(LoginTable);
            Fade.Controls.Add(panel1);
            SendMessage(this.Handle, 11, true, 0);
            Refresh();
        }
    }
}