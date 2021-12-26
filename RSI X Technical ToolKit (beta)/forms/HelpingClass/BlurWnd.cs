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
    public partial class BlurWnd : Form
    {
        public BlurWnd()
        {
            InitializeComponent();
            Blur.EnableBlur(this);
        }

        private void BlurWnd_Load(object sender, EventArgs e)
        {
            Size = Owner.Size;
            Location = Owner.Location;
        }
    }
}
