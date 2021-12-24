﻿using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                MaximumSize = Owner.Size;
                MinimumSize = Owner.Size;
                Size = Owner.Size;
                SetLeftSidePanelRegion();
            };
            ResizeRedraw = true;
            Owner.LocationChanged += delegate { Location = new Point(Owner.Location.X, Owner.Location.Y); };
            SetLeftSidePanelRegion();
            SighnOffToCenter();
            RoomNameLabel.Text = AgoraObject.GetComplexToken().GetRoomName;
            AudioColorUpdate();
            VideoColorUpdate();
            langBox_EnabledChanged(null, null);
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
                Color.FromArgb(150, 150, 150) :
                Color.White;

            audioLabel.ItemAppearance.Normal.BorderColor = AgoraObject.IsAllRemoteAudioMute ?
                Color.FromArgb(185, 185, 185) :
                Color.White;
        }
        private void VideoColorUpdate()
        {
            videoLabel.ItemAppearance.Normal.FillColor = AgoraObject.IsAllRemoteVideoMute ?
                Color.FromArgb(150, 150, 150) :
                Color.White;

            videoLabel.ItemAppearance.Normal.BorderColor = AgoraObject.IsAllRemoteVideoMute ?
                Color.FromArgb(185, 185, 185) :
                Color.White;
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
        internal void mSwitchOriginal_CheckedChanged(object sender, EventArgs e)
        {
            //Включение оригинальной дорожки (floor)
            if (IsOriginal)
            {
                var InterRoom = AgoraObject.GetComplexToken().GetTargetRoomsAt(langBox.SelectedIndex + 1);
                AgoraObject.JoinChannelSrc(InterRoom);
                AgoraObject.MuteHostAudioStream(true);
                AgoraObject.MuteSrcAudioStream(AgoraObject.IsAllRemoteAudioMute);
                langBox.Focus();
                turnOrig.ItemAppearance.Normal.FillColor = Color.WhiteSmoke;
            }
            else
            {
                AgoraObject.MuteHostAudioStream(AgoraObject.IsAllRemoteAudioMute);
                AgoraObject.MuteSrcAudioStream(true);
                turnOrig.ItemAppearance.Normal.FillColor = Color.Empty;
            }
            //mSwitchOriginal.Checked = !IsOriginal;
            langBox.Enabled = !IsOriginal;
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
            AgoraObject.GetWorkForm?.ExitApp();
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
        }

        internal void turnOrig_MouseMove(object sender, MouseEventArgs e)
        {
            turnOrig.ItemAppearance.Normal.BorderThickness = 1;
        }

        internal void turnOrig_MouseLeave(object sender, EventArgs e)
        {
            turnOrig.ItemAppearance.Normal.BorderThickness = 0;
        }

        private void langBox_EnabledChanged(object sender, EventArgs e)
        {
            langBox.ForeColor = langBox.Enabled ? Color.White : Color.FromArgb(180,180,180);
        }

        private void devicesLabel_Click(object sender, EventArgs e)
        {
            (Owner as Audience).Settings_Click(sender, e);
        }

        internal void devicesLabel_MouseMove(object sender, MouseEventArgs e)
        {
            devicesLabel.ItemAppearance.Normal.BorderThickness = 1;
        }

        internal void devicesLabel_MouseLeave(object sender, EventArgs e)
        {
            devicesLabel.ItemAppearance.Normal.BorderThickness = 0;
        }
    }
}