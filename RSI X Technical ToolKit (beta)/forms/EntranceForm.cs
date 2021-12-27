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
        private const int WM_SETREDRAW = 0x000B;
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, Int32 wMsg, bool wParam, Int32 lParam);
        LoginWnd loginWnd;
        public EntranceForm()
        {
            InitializeComponent();
        }

        private void ShowLogin()
        {
            SendMessage(panel1.Handle, WM_SETREDRAW, false, 0);
            LoginBackground.Location = new Point(Width / 2 - LoginBackground.Width / 2, Height / 2 - LoginBackground.Height / 2);
            loginWnd.Show(this);
            SendMessage(panel1.Handle, WM_SETREDRAW, true, 0);
            LoginBackground.Visible = true;
        }

        private void EntranceForm_Load(object sender, EventArgs e)
        {
            JoinBtn.Location = new Point(Width/2 - JoinBtn.Width/2, Height - Height / 2);
            LoginBackground.Visible = false;
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
    }
}