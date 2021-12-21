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
        private bool IsOriginal = false;
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
            HomeBtn.Click += HomeBtn_Click;
            labelVideo.Click += labelVideo_Click;
            labelAudio.Click += labelMicrophone_Click;
            langBox.SelectedIndexChanged += langBox_SelectedIndexChanged;
            mSwitchOriginal.CheckedChanged += mSwitchOriginal_CheckedChanged;
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
#region EventHabdlers
        private void labelMicrophone_Click(object sender, EventArgs e)
        {
            AgoraObject.MuteAllRemoteAudioStream(!AgoraObject.IsAllRemoteAudioMute);
            labelAudio.ForeColor = AgoraObject.IsAllRemoteAudioMute ?
                Color.White :
                Color.Red;
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
            mSwitchOriginal.Checked = !IsOriginal;
            langBox.Enabled = IsOriginal;
            IsOriginal = !IsOriginal;
        }
        private void labelVideo_Click(object sender, EventArgs e)
        {
            AgoraObject.MuteAllRemoteVideoStream(!AgoraObject.IsAllRemoteVideoMute);
            (Owner as Audience).streamsTable.Visible = !AgoraObject.IsAllRemoteVideoMute;
            labelVideo.ForeColor = AgoraObject.IsAllRemoteVideoMute ?
                Color.White :
                Color.Red;
            //PBRemoteVideo.Visible = !AgoraObject.IsAllRemoteVideoMute;
        }
        private void HomeBtn_Click(object sender, EventArgs e)
        {
            Owner.Close();
        }
        #endregion
    }
}
