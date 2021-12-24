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
using System.Drawing.Imaging;
using DevExpress.Utils.Svg;
using DevExpress.Utils.Drawing;

namespace RSI_X_Desktop.forms
{
    public partial class AudienceDesigner : DevExpress.XtraEditors.XtraForm
    {
        private bool IsOriginal = false;

        public AudienceDesigner()
        {
            InitializeComponent();
        }

        private void AudienceDesigner_Load(object sender, EventArgs e)
        {
            Owner.SizeChanged += delegate {
                MaximumSize = Owner.MaximumSize;
                MinimumSize = Owner.MinimumSize;
                Size = Owner.Size;
            };
            ResizeRedraw = true;
            Owner.LocationChanged += delegate { Location = new Point(Owner.Location.X, Owner.Location.Y); };
            SetLeftSidePanelRegion();
            SighnOffToCenter();
            RoomNameLabel.Text = AgoraObject.GetComplexToken().GetRoomName;
            AudioColorUpdate();
            VideoColorUpdate();
        }

        private void SetLeftSidePanelRegion()
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            int d = 30;
            System.Drawing.Rectangle r = new System.Drawing.Rectangle(-20, 0, LeftSidePanel.Width, LeftSidePanel.Height);
            path.AddArc(r.X, r.Y, d, d, 180, 90);
            path.AddArc(r.X + r.Width, r.Y, d - 10, d - 15, 270, -90);
            path.AddArc(r.X + r.Width - d, r.Y + r.Height - d, d, d, 0, 90);
            path.AddArc(r.X, r.Y + r.Height - d, d, d, 90, 90);
            LeftSidePanel.Region = new Region(path);
        }

        private void SighnOffToCenter()
        {
            int leftSide = audioLabel.Width + videoLabel.Width + devicesLabel.Width;
            int rightSide = turnOrig.Width + volumeIcon.Width + volumeTrackBar.Width + langBox.Width;
            if (leftSide > rightSide)
            {
                IconsPanel.Columns[5].Width = leftSide - rightSide;
                IconsPanel.Columns[3].Width = 0;
            }
            else
            {
                IconsPanel.Columns[3].Width = rightSide - leftSide;
                IconsPanel.Columns[5].Width = 0;
            }
        }

        #region EventHabdlers
        private void AudienceDesigner_Shown(object sender, EventArgs e)
        {
        }

        internal void labelMicrophone_Click(object sender, EventArgs e)
        {
            AgoraObject.MuteAllRemoteAudioStream(!AgoraObject.IsAllRemoteAudioMute);
            AudioColorUpdate();
        }

        private void AudioColorUpdate()
        {
            audioLabel.ItemAppearance.Normal.FillColor = AgoraObject.IsAllRemoteAudioMute ?
                Color.WhiteSmoke :
                Color.Crimson;

            audioLabel.ItemAppearance.Normal.BorderColor = AgoraObject.IsAllRemoteAudioMute ?
                Color.White :
                Color.Crimson;
        }
        private void VideoColorUpdate()
        {
            videoLabel.ItemAppearance.Normal.FillColor = AgoraObject.IsAllRemoteVideoMute ?
                Color.WhiteSmoke :
                Color.Crimson;

            videoLabel.ItemAppearance.Normal.BorderColor = AgoraObject.IsAllRemoteVideoMute ?
                Color.White :
                Color.Crimson;
        }
        private void langBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Выпадающий список языков
            if (!IsOriginal)
            {
                var InterRoom = AgoraObject.GetComplexToken().GetTargetRoomsAt(langBox.SelectedIndex + 1);
                bool ret = AgoraObject.JoinChannelSrc(InterRoom);
                AgoraObject.MuteSrcAudioStream(false);
                //RoomNameLabel.Focus();
            }
        }
        private void mSwitchOriginal_CheckedChanged(object sender, EventArgs e)
        {
            //Включение оригинальной дорожки (floor)
            if (IsOriginal)
            {
                var InterRoom = AgoraObject.GetComplexToken().GetTargetRoomsAt(langBox.SelectedIndex + 1);
                AgoraObject.JoinChannelSrc(InterRoom);
                AgoraObject.MuteHostAudioStream(true);
                AgoraObject.MuteSrcAudioStream(AgoraObject.IsAllRemoteAudioMute);
                langBox.Focus();
                //labelOrig.ForeColor = Color.White;
            }
            else
            {
                AgoraObject.MuteHostAudioStream(AgoraObject.IsAllRemoteAudioMute);
                AgoraObject.MuteSrcAudioStream(true);
                //labelOrig.ForeColor = Color.Red;
            }
            //mSwitchOriginal.Checked = !IsOriginal;
            langBox.Enabled = IsOriginal;
            IsOriginal = !IsOriginal;
        }
        internal void labelVideo_Click(object sender, EventArgs e)
        {
            AgoraObject.MuteAllRemoteVideoStream(!AgoraObject.IsAllRemoteVideoMute);
            (Owner as Audience).streamsTable.Visible = !AgoraObject.IsAllRemoteVideoMute;
            VideoColorUpdate();
        }
        private void HomeBtn_Click(object sender, EventArgs e)
        {
            Owner.Close();
        }

        private void trackBar1_ValueChanged()
        {
            Devices.SetVolume(volumeTrackBar.Value);
            if ((Owner as Audience).devices != null && (Owner as Audience).devices.IsDisposed == false)
                (Owner as Audience).devices.UpdateSoundTrackBar();

        }


        #endregion

        internal void audioLabel_MouseLeave(object sender, EventArgs e)
        {
            audioLabel.ItemAppearance.Normal.BorderThickness = 0;
        }

        internal void audioLabel_MouseMove(object sender, MouseEventArgs e)
        {
            audioLabel.ItemAppearance.Normal.BorderThickness = 1;
        }

        internal void videoLabel_MouseMove(object sender, MouseEventArgs e)
        {
            videoLabel.ItemAppearance.Normal.BorderThickness = 1;
        }

        internal void videoLabel_MouseLeave(object sender, EventArgs e)
        {
            videoLabel.ItemAppearance.Normal.BorderThickness = 0;
            ImageAttributes img = new ImageAttributes();
            img.SetColorKey(Color.FromArgb(200, 200, 200), Color.FromArgb(240, 240, 240));
        }
    }
}