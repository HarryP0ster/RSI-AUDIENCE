using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RSI_X_Desktop.forms.HelpingClass;

namespace RSI_X_Desktop.forms
{
    public partial class EntranceForm : DevExpress.XtraEditors.XtraForm
    {
        LoginWnd loginWnd = new LoginWnd();
        public EntranceForm()
        {
            InitializeComponent();
        }

        private void ShowLogin()
        {
            loginWnd.Show(this);
        }

        private void EntranceForm_Load(object sender, EventArgs e)
        {
            ShowLogin();
            LoginBackground.Location = new Point(Width / 2 - LoginBackground.Width / 2, Height / 2 - LoginBackground.Height / 2);
        }

        private void EntranceForm_VisibleChanged(object sender, EventArgs e)
        {
            loginWnd.Visible = Visible;
            loginWnd.loginInput.Visible = Visible;
        }
    }
}