using RSI_X_Desktop.forms;
using System;
using System.Windows.Forms;
using agorartc;
using System.Drawing;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using MaterialSkin;
using MaterialSkin.Controls;

namespace RSI_X_Desktop
{
    public partial class Audience : Form, IFormHostHolder
    {
        public IntPtr RemoteWnd { get; private set; }
        private DevicesForm devices;

        private List<string> TarLang;
        private bool IsOriginal = false;
        private string AppCID = string.Empty;
        private string ChToken = string.Empty;
        private string HostName = string.Empty;
        private bool IsMixerOpen = false;
        private int audioLastVolume;

        [DllImport("winmm.dll")]
        public static extern int waveOutGetVolume(IntPtr hwo, out uint dwVolume); //Контроль громкости

        [DllImport("winmm.dll")]
        public static extern int waveOutSetVolume(IntPtr hwo, uint dwVolume); //Контроль громкости

        public Audience()
        {
            InitializeComponent();
        }

        private void Audience_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;
            RoomNameLabel.Text = AgoraObject.GetComplexToken().GetRoomName;

            //Spectator_SizeChanged(this, new EventArgs());
            JoinChannel();
        }

        private void UpdateLangComboBox()
        {
            TarLang = AgoraObject.GetLangCollection();
            List<string> test = TarLang;
            langBox.Items.Clear();
            foreach (string lang in TarLang)
            {
                // only EN_S_###
                if (lang.Split('_')[1] != "S") continue;
                string lang_short = lang.Split('_')[0];
                langBox.Items.Add(lang_short);
            }
            langBox.SelectedIndex = 0;
        }

        public ERROR_CODE JoinChannel()
        {
            ERROR_CODE res = ERROR_CODE.ERR_OK;

            AgoraObject.Rtc.SetChannelProfile(CHANNEL_PROFILE_TYPE.CHANNEL_PROFILE_COMMUNICATION);
            AgoraObject.Rtc.SetClientRole(CLIENT_ROLE_TYPE.CLIENT_ROLE_AUDIENCE);
            AgoraObject.Rtc.EnableVideo();
            AgoraObject.Rtc.EnableLocalVideo(false);
            AgoraObject.Rtc.EnableLocalAudio(false);
            AgoraObject.SetWndEventHandler(this);

            //pictureBoxRemoteVideo.Width = this.Width;
            RemoteWnd = pictureBoxRemoteVideo.Handle;
            UpdateLangComboBox();

            mSwitchOriginal.Checked = true;

            pictureBoxRemoteVideo.Invalidate();
            labelMicrophone.ForeColor = Color.Red;
            labelVideo.ForeColor = Color.Red;

            return res;
        }

        public void UpdateRemoteWnd()
        {
            AgoraObject.Rtc.StopPreview();
            pictureBoxRemoteVideo.Invalidate();
        }

        private void labelMicrophone_Click(object sender, EventArgs e)
        {
            AgoraObject.MuteAllRemoteAudioStream(!AgoraObject.IsAllRemoteAudioMute);
            labelMicrophone.ForeColor = AgoraObject.IsAllRemoteAudioMute ?
                 Color.White :
                 Color.Red;
        }

        private void labelVideo_Click(object sender, EventArgs e)
        {
            AgoraObject.MuteAllRemoteVideoStream(!AgoraObject.IsAllRemoteVideoMute);
            labelVideo.ForeColor = AgoraObject.IsAllRemoteVideoMute ?
                Color.White :
                Color.Red;
        }

        private void labelVolume_Click(object sender, EventArgs e)
        {
            IsMixerOpen = !IsMixerOpen;
            labelVolume.ForeColor = IsMixerOpen ?
                Color.Red :
                Color.White;
            trackBar1.Visible = IsMixerOpen;
        }

        private void trackBar1_ValueChanged()
        {
            int NewVolume = ((ushort.MaxValue / 100) * trackBar1.Value);
            uint NewVolumeAllChannels = (((uint)NewVolume & 0x0000ffff) | ((uint)NewVolume << 16));

            waveOutSetVolume(IntPtr.Zero, NewVolumeAllChannels);
        }

        private void langBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Выпадающий список языков
            if (!IsOriginal)
            {
                var InterRoom = AgoraObject.GetComplexToken().GetTargetRoomsAt(langBox.SelectedIndex + 1);
                bool ret = AgoraObject.JoinChannelSrc(InterRoom);
                AgoraObject.MuteSrcAudioStream(false);
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
                AgoraObject.MuteSrcAudioStream(false);
                mSwitchOriginal.Checked = false;
            }
            else
            {
                //AgoraObject.LeaveSrcChannel();
                if (ChToken == string.Empty)
                    AgoraObject.JoinChannelHost(AgoraObject.GetHostName(), AgoraObject.GetHostToken(), 0, "");
                else
                    AgoraObject.JoinChannelHost(HostName, ChToken, 0, "");
                AgoraObject.MuteHostAudioStream(false);
                AgoraObject.MuteSrcAudioStream(true);
                mSwitchOriginal.Checked = true;
            }
            langBox.Enabled = IsOriginal;
            IsOriginal = !IsOriginal;
        }
        private void Spectator_FormClosed(object sender, FormClosedEventArgs e)
        {
            AgoraObject.LeaveHostChannel();
            AgoraObject.LeaveSrcChannel();
            AgoraObject.MuteAllRemoteAudioStream(false);
            AgoraObject.MuteAllRemoteVideoStream(false);

            waveOutSetVolume(IntPtr.Zero, uint.MaxValue);

            Owner.Show();
            Owner.Refresh();
        }
    }
}
