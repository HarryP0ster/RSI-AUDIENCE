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
    public partial class LoginWnd : DevExpress.XtraEditors.XtraForm
    {
        public Font LargeFont = new Font("Bahnschrift Condensed", 22F);
        public Font SmallFont = new Font("Bahnschrift Condensed", 16F);
        internal InputWnd loginInput;
        public LoginWnd()
        {
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            InitializeComponent();
        }

        private void LoginWnd_Load(object sender, EventArgs e)
        {
            Location = new Point(Owner.Location.X + Owner.Width / 2 - Width / 2, Owner.Location.Y + Owner.Height / 2 - 2 * Height / 5);
            Owner.LocationChanged += delegate { Location = new Point(Owner.Location.X + Owner.Width/2 - Width/2, Owner.Location.Y + Owner.Height/2 - 2*Height/5); };
            (loginInput = new()).Show(this);
            SuspendLayout();

            loginInput.NewTextBox.Font = loginInput.DeviceDpi >= (int)EntranceForm.DPI.P125 ? 
                    SmallFont : LargeFont;

            loginInput.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
        }

        private void svgImageBox2_Click(object sender, EventArgs e)
        {
            string code = loginInput.NewTextBox.Text.Remove(4, 1);
            if (AgoraObject.JoinRoom(code))
            {
                loginInput.Hide();
                Owner.Hide();
                Hide();
                Audience Audit = new();
                AgoraObject.CurrentForm = CurForm.FormAudience;
                Audit.Show(Owner);
            }
            else
                loginInput.NewTextBox.Clear();
        }
    }
}