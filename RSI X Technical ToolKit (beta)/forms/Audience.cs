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
        private bool IsMixerOpen = false;
        public delegate void RefreshRemoteWnd(bool param);
        public RefreshRemoteWnd CallRefresh;

        private bool AddOrder = false;
        private bool[] TakenPages = new bool[1];
        private Dictionary<uint, PictureBox> hostBroadcasters = new();

        [DllImport("winmm.dll")]
        public static extern int waveOutGetVolume(IntPtr hwo, out uint dwVolume); //Контроль громкости


        public Audience()
        {
            InitializeComponent();
        }


        private void Audience_Load(object sender, EventArgs e)
        {
            RemotePanel.ColumnStyles[1].SizeType = SizeType.Absolute;
            RemotePanel.ColumnStyles[0].Width = 100;
            RemotePanel.ColumnStyles[1].Width = 0;
            this.DoubleBuffered = true;
            SignOffToCenter();
            FormAudience.Parent = this;
            ResizeForm(new Size(1280, 800), this);

            RoomNameLabel.Text = AgoraObject.GetComplexToken().GetRoomName;
            RemotePanel.ColumnStyles[1].Width = 0;
            CallRefresh = new RefreshRemoteWnd(RefreshDelegate);
            
            JoinChannel();
        }
        private void SignOffToCenter()
        {
            float width_left = tableLayoutPanel4.Width + labelAudio.Width + labelVideo.Width;
            float width_right = tableLayoutPanel5.Width + comboBoxPanel.Width;
            tableLayoutPanel3.ColumnStyles[6].Width = width_left - width_right;
        }
        public void RefreshDelegate()
        {
            streamsTable.Visible = !AgoraObject.IsAllRemoteVideoMute;
        }

        public void RefreshDelegate(bool state)
        {
            streamsTable.Visible = state;
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
            //RemoteWnd = PBRemoteVideo.Handle;
            UpdateLangComboBox();
            
            mSwitchOriginal.Checked = true;

            AgoraObject.JoinChannelHost(AgoraObject.GetHostName(), AgoraObject.GetHostToken(), 0, "");
            labelAudio.ForeColor = Color.Red;
            labelVideo.ForeColor = Color.Red;

            return res;
        }

        public void UpdateRemoteWnd()
        {
            AgoraObject.Rtc.StopPreview();
        }
        public void NewBroadcaster(uint uid, UserInfo info)
        {
            //throw new NotImplementedException(); 
            if (NickCenter.IsHost(info.userAccount) &&
                !hostBroadcasters.ContainsKey(uid))
            {
                if (InvokeRequired)
                    Invoke((MethodInvoker)delegate
                    {
                        AddNewMember(uid);
                    });
                else
                    AddNewMember(uid);
            }
        }
        public void BroadcasterUpdateInfo(uint uid, UserInfo info)
        {
            //throw new NotImplementedException(); 
            if (NickCenter.IsHost(info.userAccount) &&
                !hostBroadcasters.ContainsKey(uid))
            {
                if (InvokeRequired)
                    Invoke((MethodInvoker)delegate
                    {
                        AddNewMember(uid);
                    });
                else
                    AddNewMember(uid);
            }
        }
        public void BroadcasterLeave(uint uid)
        {
            //throw new NotImplementedException();
            if (hostBroadcasters.ContainsKey(uid))
            {
                if (InvokeRequired)
                    Invoke((MethodInvoker)delegate
                    {
                        RemoveMember(uid);
                    });
                else
                    RemoveMember(uid);
            }
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
                labelOrig.ForeColor = Color.White;
            }
            else
            {
                AgoraObject.MuteHostAudioStream(AgoraObject.IsAllRemoteAudioMute);
                AgoraObject.MuteSrcAudioStream(true);
                labelOrig.ForeColor = Color.Red;
            }
            mSwitchOriginal.Checked = !IsOriginal;
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
            Owner.Close();
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
            Wnd.TopLevel = false;
            Wnd.Dock = DockStyle.Fill;
            panel1.Controls.Add(Wnd);
            panel1.BringToFront();
            if (panel1.Visible == false || Wnd.Visible == false)
            {
                panel1.Location = new Point(Size.Width, panel1.Location.Y);
                panel1.Show();
                Animator(panel1, -5, 0, 90, 1);
                Wnd.Show();
            }
        }

        public void DevicesClosed(Form Wnd)
        {
            Animator(panel1, 5, 0, 90, 1);
            panel1.Hide();
            Wnd.Close();
            GC.Collect();
        }

        public void Animator(System.Windows.Forms.Panel panel, int offset_x, int offset_y, int itterations, int delay)
        {
            Thread.Sleep(delay);
            panel.SuspendLayout();
            for (int ind = 0; ind < itterations; ind++)
            {
                RemotePanel.ColumnStyles[1].Width = RemotePanel.ColumnStyles[1].Width - offset_x;
            }
            panel.ResumeLayout();
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

        private void langBox_MouseEnter(object sender, EventArgs e)
        {
            langBox.Refresh();
        }

        private void langBox_Click(object sender, EventArgs e)
        {
            langBox.Refresh();
        }


        #region MembersControl

        private void AddNewMember(uint uid)
        {
            PictureBox newPreview = new();

            string channelId = AgoraObject.GetHostName();

            newPreview.Dock = DockStyle.Fill;
            newPreview.BackgroundImage = Properties.Resources.video_call_empty;
            newPreview.BackgroundImageLayout = ImageLayout.Center;
            newPreview.BackColor = Color.FromArgb(85, 85, 85);
            newPreview.Margin = Padding.Empty;
            List<bool> temp_list = new List<bool>(TakenPages);

            streamsTable.BackgroundImage = null;

            if (temp_list.Contains(false) == false)
            {
                if (AddOrder == false)
                {
                    streamsTable.ColumnCount++;
                    streamsTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
                    foreach (ColumnStyle col in streamsTable.ColumnStyles)
                    {
                        col.SizeType = SizeType.Percent;
                        col.Width = 100F;
                    }
                    AddOrder = true;
                }
                else
                {
                    streamsTable.RowCount++;
                    streamsTable.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
                    foreach (RowStyle row in streamsTable.RowStyles)
                    {
                        row.SizeType = SizeType.Percent;
                        row.Height = 100F;
                    }
                    AddOrder = false;
                }
            }
            int index = streamsTable.ColumnCount * streamsTable.RowCount;
            hostBroadcasters.Add(uid, newPreview);
            TakenPages = new bool[index];
            streamsTable.Controls.Clear();

            int current_row = 0;
            int current_col = 0;
            foreach (PictureBox hwnd in hostBroadcasters.Values)
            {
                for (int i = 0; i < TakenPages.Length; i++)
                {
                    if (TakenPages[i] == false)
                    {
                        TakenPages[i] = true;
                        streamsTable.Controls.Add(hwnd, current_col, current_row);
                        current_col++;
                        if (current_col >= streamsTable.ColumnStyles.Count)
                        {
                            current_col = 0;
                            current_row++;
                        }
                        break;
                    }
                }
            }

            var ret = new VideoCanvas((ulong)newPreview.Handle, uid);
            ret.renderMode = (int)RENDER_MODE_TYPE.RENDER_MODE_FIT;
            ret.channelId = channelId;
            ret.uid = uid;

            AgoraObject.Rtc.SetupRemoteVideo(ret);
            streamsTable.Refresh();
        }

        private void RemoveMember(uint uid)
        {
            int index = streamsTable.ColumnCount * streamsTable.RowCount;
            hostBroadcasters.Remove(uid);

            if (hostBroadcasters.Count == 0)
                streamsTable.BackgroundImage = Properties.Resources.logotype_black;

            if (index - hostBroadcasters.Count <= streamsTable.ColumnCount && AddOrder)
            {
                streamsTable.ColumnStyles.RemoveAt(streamsTable.ColumnStyles.Count - 1);
                streamsTable.ColumnCount--;
                foreach (ColumnStyle col in streamsTable.ColumnStyles)
                    col.Width = 100F;
                AddOrder = false;
            }
            else if (index - hostBroadcasters.Count >= streamsTable.RowCount && !AddOrder)
            {
                streamsTable.RowStyles.RemoveAt(streamsTable.RowStyles.Count - 1);
                streamsTable.RowCount--;
                foreach (RowStyle row in streamsTable.RowStyles)
                    row.Height = 100F;
                AddOrder = true;
            }

            index = streamsTable.ColumnCount * streamsTable.RowCount;
            TakenPages = new bool[index];
            streamsTable.Controls.Clear();

            int current_row = 0;
            int current_col = 0;
            foreach (PictureBox hwnd in hostBroadcasters.Values)
            {
                for (int i = 0; i < TakenPages.Length; i++)
                {
                    if (TakenPages[i] == false)
                    {
                        TakenPages[i] = true;
                        streamsTable.Controls.Add(hwnd, current_col, current_row);
                        current_col++;
                        if (current_col >= streamsTable.ColumnStyles.Count)
                        {
                            current_col = 0;
                            current_row++;
                        }
                        break;
                    }
                }
            }
            streamsTable.Refresh();
        }

        internal void UpdateMember(uint uid)
        {
            if (hostBroadcasters.ContainsKey(uid))
            {
                if (InvokeRequired)
                {
                    Invoke((MethodInvoker)delegate
                    {
                        hostBroadcasters[uid].Invalidate();
                    });
                }
                else
                    hostBroadcasters[uid].Invalidate();
            }
        }

        internal void UpdateMember(uint uid, string channelId)
        {
            if (hostBroadcasters.ContainsKey(uid))
            {
                if (InvokeRequired)
                {
                    Invoke((MethodInvoker)delegate
                    {
                        var ret = new VideoCanvas((ulong)hostBroadcasters[uid].Handle, uid);
                        ret.renderMode = (int)RENDER_MODE_TYPE.RENDER_MODE_FIT;
                        ret.channelId = channelId;
                        ret.uid = uid;

                        AgoraObject.Rtc.SetupRemoteVideo(ret);
                    });
                }
                else
                {
                    var ret = new VideoCanvas((ulong)hostBroadcasters[uid].Handle, uid);
                    ret.renderMode = (int)RENDER_MODE_TYPE.RENDER_MODE_FIT;
                    ret.channelId = channelId;
                    ret.uid = uid;

                    AgoraObject.Rtc.SetupRemoteVideo(ret);
                }
            }
        }
        #endregion
    }
}
