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
            Location = Owner.Location;
            Owner.LocationChanged += delegate { Location = Owner.Location; };
        }

        private void NewTextBox_Click(object sender, EventArgs e)
        {
        }

        private void InputWnd_Shown(object sender, EventArgs e)
        {
            NewTextBox.Focus();
        }
    }
}