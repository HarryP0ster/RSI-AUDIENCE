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
using RSI_X_Desktop.forms.HelpingClass;

namespace RSI_X_Desktop.forms
{

    public partial class AudienceFormDesignWnd : Form
    {
        public AudienceFormDesignWnd()
        {
            InitializeComponent();
        }

        private void AudienceFormDesignWnd_Load(object sender, EventArgs e)
        {
            Owner.LocationChanged += Owner_LocationChanged;
            SetLeftSidePanelRegion(); //cuts the edge of the column with logotype
        }

        private void Owner_LocationChanged(object sender, EventArgs e) //Initial loading
        {
            this.Location = Owner.Location;
        }

        private void SetLeftSidePanelRegion()
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            int d = 25;
            System.Drawing.Rectangle r = new System.Drawing.Rectangle(-20, 0, LeftSidePanel.Width, LeftSidePanel.Height);
            path.AddArc(r.X, r.Y, d, d, 180, 90);
            path.AddArc(r.X + r.Width - d, r.Y, d, d, 270, 90);
            path.AddArc(r.X + r.Width - d, r.Y + r.Height - d, d, d, 0, 90);
            path.AddArc(r.X, r.Y + r.Height - d, d, d, 90, 90);
            LeftSidePanel.Region = new Region(path);
        }
    }
}
