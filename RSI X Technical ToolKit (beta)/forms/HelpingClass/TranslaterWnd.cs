using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using RSI_X_Desktop.forms;
using agorartc;

namespace RSI_X_Desktop
{
    partial class Audience
    {
        public static List<_AGVIDEO_WNDINFO> otherWnd = new();
        private Region regWnd;
        public struct _AGVIDEO_WNDINFO
        {
            public event EventHandler OnVolumeChange;

            public uint UID { get { return nUID; } }
            public string ChannelID { get { return channelID; } }

            internal uint nUID;
            internal int nIndex;

            internal PictureBox HWnd;
            internal TableLayoutPanel ctrlPanel;

            internal string channelID;

            internal bool IsMuted;
            internal bool IsHidden;
            internal Label nameLabel;
            internal int Page;


            internal void ShowPanel(object sender, EventArgs e)
            {
                nameLabel.Show();
                ctrlPanel.Show();
            }
            internal void HidePanel(object sender, EventArgs e)
            {
                Point p = HWnd.PointToClient(Cursor.Position);
                if (!HWnd.ClientRectangle.Contains(p))
                {
                    nameLabel.Hide();
                    ctrlPanel.Hide();
                }
            }
        }

        #region Interpreter Wnd controls

        public void RebindVideoWndInvoke()
        {
            if (InvokeRequired)
                Invoke((MethodInvoker)delegate { RebindVideoWnd(); });
            else
                RebindVideoWnd();
        }
        protected void RebindVideoWnd()
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            int d = 10;
            System.Drawing.Rectangle r = new System.Drawing.Rectangle(0, 0, 180, 120);
            //Init wnd region
            path.AddArc(r.X, r.Y, d, d, 180, 90);
            path.AddArc(r.X + r.Width - d, r.Y, d, d, 270, 90);
            path.AddArc(r.X + r.Width - d, r.Y + r.Height - d, d, d, 0, 90);
            path.AddArc(r.X, r.Y + r.Height - d, d, d, 90, 90);
            regWnd = new Region(path);

            int loc = 1;
            string userName;

            HideAllWnd();

            loc = 1;
            foreach (_AGVIDEO_WNDINFO curWnd in otherWnd)
            {
                userName = other.UIDChecker.GetUidName(curWnd.nUID);

                curWnd.HWnd.Location = new Point(Nothing.Width - (curWnd.HWnd.Width + 40) * loc, 60);
                curWnd.HWnd.Parent = Nothing;
                curWnd.HWnd.BringToFront();
                curWnd.HWnd.Region = regWnd;
                curWnd.HWnd.Show();
                curWnd.nameLabel.Font = NameLabelFont;

                var ret = new VideoCanvas((ulong)curWnd.HWnd.Handle, curWnd.nUID);
                ret.renderMode = (int)RENDER_MODE_TYPE.RENDER_MODE_FILL;
                ret.channelId = curWnd.channelID;
                ret.uid = curWnd.nUID;
                loc++;

                AgoraObject.Rtc.SetupRemoteVideo(ret);
            }
            panel1.BringToFront();
        }


        public _AGVIDEO_WNDINFO InitNewWnd(string channelId, uint uid, string username = "")
        {
            Color DefColor = Color.FromArgb(35, 35, 35);
            int size = 30;
            //New user has joined
            _AGVIDEO_WNDINFO newWnd = new _AGVIDEO_WNDINFO();
            newWnd.nIndex = otherWnd.Count;
            newWnd.nUID = uid;
            newWnd.channelID = channelId;
            newWnd.Page = -1;
            //if (newWnd.name != "test")
            //    newWnd.Page = 0;

            #region Wnd
            newWnd.HWnd = new PictureBox();
            newWnd.HWnd.Size = new Size(180, 120);
            newWnd.HWnd.BackgroundImageLayout = ImageLayout.Stretch;
            newWnd.HWnd.BackgroundImage = Properties.Resources.video_call_empty;
            newWnd.HWnd.BackColor = Color.FromArgb(15, 15, 15);
            newWnd.HWnd.Anchor = AnchorStyles.Bottom;
            #endregion

            #region NameLabel
            newWnd.nameLabel = new Label();
            newWnd.nameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            newWnd.nameLabel.TextAlign = ContentAlignment.MiddleCenter;
            newWnd.nameLabel.Size = new Size(100, size);
            //newWnd.nameLabel.Font = NameLabelFont; // = new Font("Bahnschrift Condensed", 14);
            newWnd.nameLabel.ForeColor = Color.White;
            newWnd.nameLabel.Parent = newWnd.HWnd;
            newWnd.nameLabel.BackColor = DefColor;
            newWnd.nameLabel.Location = new Point(0, newWnd.HWnd.Bottom - size);
            newWnd.nameLabel.Dock = DockStyle.Bottom;
            if (username != "")
                newWnd.nameLabel.Text = username.Substring(username.IndexOf('_') + 1, username.LastIndexOf('_') - username.IndexOf('_') - 1);
            newWnd.nameLabel.Invalidate();
            //newWnd.nameLabel.Hide();
            #endregion

            #region Panel
            newWnd.ctrlPanel = new TableLayoutPanel();
            newWnd.ctrlPanel.Parent = newWnd.HWnd;
            newWnd.ctrlPanel.Size = new Size(180, size);
            newWnd.ctrlPanel.BackColor = DefColor;
            newWnd.ctrlPanel.Location = new Point(newWnd.HWnd.Left, newWnd.HWnd.Bottom - size);
            //newWnd.ctrlPanel.Hide();
            #endregion

            otherWnd.Add(newWnd);
            return newWnd;
        }

        public bool RemoveWnd(uint uid)
        {
            foreach (_AGVIDEO_WNDINFO curWnd in otherWnd)
            {
                if (curWnd.nUID == uid)
                {
                    otherWnd.Remove(curWnd);
                    Invoke((MethodInvoker)delegate { curWnd.HWnd.Dispose(); });

                    GC.Collect();
                    return true;
                }
            }
            return false;
        }

        private void HideAllWnd()
        {
            foreach (_AGVIDEO_WNDINFO curWnd in otherWnd)
            {
                curWnd.HWnd.Hide();
            }
        }
        public void ClearWnd()
        {
            foreach (_AGVIDEO_WNDINFO curWnd in otherWnd)
            {
                try
                {
                    if (curWnd.HWnd.IsHandleCreated && !curWnd.HWnd.IsDisposed)
                        Invoke((MethodInvoker)delegate { curWnd.HWnd.Dispose(); });
                }
                catch
                {

                }
            }
            otherWnd.Clear();
            GC.Collect();
        }

        #endregion

        private static Font NameLabelFont = forms.Constants.GetBanshiftCondesed(14);
        //private void AdjustDpiInterpreterWnd()
        //{

        //    int dpi = this.DeviceDpi;
        //    if (dpi >= (int)Constants.DPI.P175)
        //    {
        //        NameLabelFont = Constants.GetBanshiftLightSemiCondensed(8);
        //    }
        //    else if (dpi >= (int)Constants.DPI.P150)
        //    {
        //        NameLabelFont = Constants.GetBanshiftLightSemiCondensed(10);
        //    }
        //    else if (dpi >= (int)Constants.DPI.P125)
        //    {
        //        NameLabelFont = Constants.GetBanshiftLightSemiCondensed(12);
        //    }
        //    else if (dpi >= (int)Constants.DPI.P100)
        //    {
        //        NameLabelFont = Constants.GetBanshiftLightSemiCondensed(14);
        //    }
        //}
        //public Dictionary<uint, string> GetAllInterpreterWindowUID_Nick()
        //{
        //    Dictionary<uint, string> dict = new();

        //    foreach (var wnd in agvideoWnd)
        //        dict.Add(wnd.UID, wnd.nameLabel.Text);

        //    return dict;
        //}

        internal void MuteAll()
        {
            if (AgoraObject.IsAllRemoteVideoMute)
            {
                foreach (_AGVIDEO_WNDINFO curWnd in otherWnd)
                {
                    var ret = new VideoCanvas(0, 0);
                    ret.renderMode = (int)RENDER_MODE_TYPE.RENDER_MODE_FILL;
                    ret.channelId = curWnd.channelID;
                    ret.uid = curWnd.nUID;

                    AgoraObject.Rtc.SetupRemoteVideo(ret);
                    curWnd.HWnd.Refresh();
                }
            }
            else
                RebindVideoWnd();
        }
    }
}
