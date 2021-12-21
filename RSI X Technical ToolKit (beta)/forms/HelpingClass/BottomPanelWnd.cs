using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace RSI_X_Desktop.forms.HelpingClass
{

    public partial class BottomPanelWnd : Form
    {
        public BottomPanelWnd()
        {
            InitializeComponent();
            Blur.EnableBlur(this);
        }

        private void Owner_LocationChanged(object sender, EventArgs e)
        {
            Location = new Point(Owner.Location.X, Owner.Location.Y + Owner.Height - Height);
        }

        private void BottomPanelWnd_Load(object sender, EventArgs e)
        {
            Owner.LocationChanged += Owner_LocationChanged;
        }
    }
}
