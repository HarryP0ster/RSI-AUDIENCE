using RSI_X_Desktop.forms;
using System;
using System.Windows.Forms;
using agorartc;
using System.Drawing;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;

namespace RSI_X_Desktop
{
    public partial class Audience : Form, IFormHostHolder
    {
        public IntPtr RemoteWnd { get; private set; }
        private Devices devices;

        private List<string> TarLang;
        private bool IsOriginal = false;
        private string AppCID = string.Empty;
        private string ChToken = string.Empty;
        private string HostName = string.Empty;
        private bool IsMixerOpen = false;
        public delegate void RefreshRemoteWnd(bool param);
        public RefreshRemoteWnd CallRefresh;

        [DllImport("winmm.dll")]
        public static extern int waveOutGetVolume(IntPtr hwo, out uint dwVolume); //Контроль громкости


        public Audience()
        {
            InitializeComponent();
        }


        private void Audience_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;
            RoomNameLabel.Text = AgoraObject.GetComplexToken().GetRoomName;
            FormAudience.Parent = this;
            RemotePanel.ColumnStyles[1].Width = 0;
            ResizeForm(new Size(1280, 800), this);
            //Spectator_SizeChanged(this, new EventArgs());
            CallRefresh = new RefreshRemoteWnd(RefreshDelegate);
            JoinChannel();
            //foxLabel1.Parent = langBox;
            //panel3.Parent = langBox;
        }

        public void RefreshDelegate()
        {
            PBRemoteVideo.Visible = !AgoraObject.IsAllRemoteVideoMute;
        }

        public void RefreshDelegate(bool state)
        {
            PBRemoteVideo.Visible = state;
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
            AgoraObject.MuteLocalAudioStream(true);
            AgoraObject.MuteLocalVideoStream(true);

            //pictureBoxRemoteVideo.Width = this.Width;
            RemoteWnd = PBRemoteVideo.Handle;
            UpdateLangComboBox();

            mSwitchOriginal.Checked = true;

            PBRemoteVideo.Invalidate();
            labelAudio.ForeColor = Color.Red;
            labelVideo.ForeColor = Color.Red;

            return res;
        }

        public void UpdateRemoteWnd()
        {
            AgoraObject.Rtc.StopPreview();
            PBRemoteVideo.Invalidate();
        }

        private void labelMicrophone_Click(object sender, EventArgs e)
        {
            AgoraObject.MuteAllRemoteAudioStream(!AgoraObject.IsAllRemoteAudioMute);
            labelAudio.ForeColor = AgoraObject.IsAllRemoteAudioMute ?
                Color.White :
                Color.Red;
        }

        private void labelVideo_Click(object sender, EventArgs e)
        {
            AgoraObject.MuteAllRemoteVideoStream(!AgoraObject.IsAllRemoteVideoMute);
            labelVideo.ForeColor = AgoraObject.IsAllRemoteVideoMute ?
                Color.White :
                Color.Red;
            //PBRemoteVideo.Visible = !AgoraObject.IsAllRemoteVideoMute;
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
            Devices.SetVolume(trackBar1.Value);
            if (devices != null && devices.IsDisposed == false)
                devices.UpdateSoundTrackBar();

        }
        public void SetTrackBarVolume(int volume) 
        {
            trackBar1.Value = volume;
        }

        private void langBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Выпадающий список языков
            if (!IsOriginal)
            {
                var InterRoom = AgoraObject.GetComplexToken().GetTargetRoomsAt(langBox.SelectedIndex + 1);
                bool ret = AgoraObject.JoinChannelSrc(InterRoom);
                AgoraObject.MuteSrcAudioStream(false);
                RoomNameLabel.Focus();
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
                mSwitchOriginal.Checked = false;
            }
            else
            {
                //AgoraObject.LeaveSrcChannel();
                if (ChToken == string.Empty)
                    AgoraObject.JoinChannelHost(AgoraObject.GetHostName(), AgoraObject.GetHostToken(), 0, "");
                else
                    AgoraObject.JoinChannelHost(HostName, ChToken, 0, "");
                AgoraObject.MuteHostAudioStream(AgoraObject.IsAllRemoteAudioMute);
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

            Devices.waveOutSetVolume(IntPtr.Zero, uint.MaxValue);

            Owner.Show();
            Owner.Refresh();
        }

        private void ResizeForm(Size size, Form target)
        {
            target.MaximumSize = size;
            target.MinimumSize = size;
            target.Size = size;
        }
        private void ResizeForm(Size size, ReaLTaiizor.Forms.FormTheme target)
        {
            target.MaximumSize = size;
            target.MinimumSize = size;
            target.Size = size;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            if (devices == null || devices.IsDisposed)
            {
                devices = new Devices();
                CallSidePanel(devices);
                devices.typeOfAlligment(true);
            }
            else
            {
                DevicesClosed(devices);
            }
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CallSidePanel(Form Wnd)
        {
            panel1.SuspendLayout();
            Wnd.Size = panel1.Size;
            Wnd.Location = panel1.Location;
            Wnd.TopLevel = false;
            Wnd.Dock = DockStyle.Fill;
            panel1.Controls.Add(Wnd);
            panel1.BringToFront();
            if (panel1.Visible == false || Wnd.Visible == false)
            {
                panel1.ResumeLayout();
                //panel1.Location = new Point(Size.Width, panel1.Location.Y);
                panel1.Show();
                Animator(panel1, -2, 0, 25, 1);
                Wnd.Show();
            }
        }

        public void DevicesClosed(Form Wnd)
        {
            Wnd.Close();
            Animator(panel1, 2, 0, 25, 1);
            panel1.Hide();
            GC.Collect();
        }

        public void Animator(Panel panel, int offset_x, int offset_y, int itterations, int delay)
        {
            PBRemoteVideo.Refresh();
            PBRemoteVideo.SuspendLayout();
            for (int ind = 0; ind < itterations; ind++)
            {
                RemotePanel.ColumnStyles[1].Width = RemotePanel.ColumnStyles[1].Width - offset_x;
                PBRemoteVideo.Size = new Size(PBRemoteVideo.Size.Width - offset_x, PBRemoteVideo.Size.Height);
                //Thread.Sleep(1);
            }
            PBRemoteVideo.ResumeLayout();
        }

        private void nightControlBox1_MouseClick(object sender, MouseEventArgs e)
        {
            Point ptn = e.Location;
            if (!(ptn.X > 46 && ptn.X < 94)) return;
            this.BringToFront();
            if (this.Size.Width == 1280)
            {
                ResizeForm(Screen.PrimaryScreen.WorkingArea.Size, this);
                ResizeForm(Screen.PrimaryScreen.WorkingArea.Size, FormAudience);
            }
            else
            {
                ResizeForm(new Size(1280, 800), this);
                ResizeForm(new Size(1280, 800), FormAudience);
            }
        }
        #region Events
        private void Audience_Resize(object sender, EventArgs e)
        {
            //CenterToScreen();
        }
        #endregion
    }
}
