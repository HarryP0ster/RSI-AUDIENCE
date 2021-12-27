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

namespace RSI_X_Desktop.forms.HelpingClass
{
    public partial class InputWnd : DevExpress.XtraEditors.XtraForm
    {
        internal string RoomCode
        {
            get => NewTextBox.Text;
        }
        public InputWnd()
        {
            InitializeComponent();
        }

        private void InputWnd_Load(object sender, EventArgs e)
        {
            //NewTextBox.Mask = "";
            //NewTextBox.Font = new Font("Bahnschrift Condensed", 16);
            //NewTextBox.Text = "Code of conference";
            Owner.LocationChanged += delegate { Location = Owner.Location; };
        }

        private void NewTextBox_Click(object sender, EventArgs e)
        {
            //NewTextBox.Font = new Font("Bahnschrift Condensed", 22);
            //NewTextBox.Mask = "0000-0000";
            //NewTextBox.Text = "";
            //NewTextBox.SelectionStart = 0;
        }

        private void InputWnd_Shown(object sender, EventArgs e)
        {
            NewTextBox.Focus();
        }
    }
}