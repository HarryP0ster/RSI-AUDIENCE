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

        private void BottomPanelWnd_Load(object sender, EventArgs e)
        {
            Width = Owner.Width;
            Height = 125;
            Location = new Point(Owner.Location.X, Owner.Location.Y + Owner.Height - Height);
            Owner.LocationChanged += delegate { Location = new Point(Owner.Location.X, Owner.Location.Y + Owner.Height - Height); };
            Owner.SizeChanged += delegate {
                Width = Owner.Width;
                Height = 125;
                Location = new Point(Owner.Location.X, Owner.Location.Y + Owner.Height - Height);
            };
        }
    }
}
