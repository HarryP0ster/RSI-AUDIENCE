using RSI_X_Desktop.forms;
using System;
using System.Windows.Forms;
using agorartc;
using System.Drawing;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using RSI_X_Desktop.forms.HelpingClass;
using RSI_X_Desktop.other;
using System.Threading;

namespace RSI_X_Desktop
{
    public partial class Audience : Form, IFormHostHolder
    {
        public IntPtr RemoteWnd { get; private set; }
        internal PopUpForm devices;

        private List<string> TarLang;
        private bool IsOriginal = false;
        private bool IsMixerOpen = false;
        public delegate void RefreshRemoteWnd(bool param);
        public RefreshRemoteWnd CallRefresh;
        //Design windows
        internal AudienceDesigner ExternWnd = new();
        BottomPanelWnd bottomPanel = new();
        //Design windows
        private bool AddOrder = false;
        private bool[] TakenPages = new bool[1];
        private Dictionary<uint, PictureBox> hostBroadcasters = new();


        public Audience()
        {
            InitializeComponent();
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
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

            RemotePanel.ColumnStyles[1].Width = 0;
            CallRefresh = new RefreshRemoteWnd(RefreshDelegate);
            
            JoinChannel();
            bottomPanel.Width = Width;
            bottomPanel.Height = Height/7;
            bottomPanel.Location = new Point(Location.X,Location.Y + Height);
            ExternWnd.Size = Size;
            ExternWnd.Location = Location;
            bottomPanel.Show(this);
            bottomPanel.Enabled = false;
            ExternWnd.Show(this);
        }
        private void SignOffToCenter()
        {
            //float width_left = tableLayoutPanel4.Width + labelAudio.Width + labelVideo.Width;
            //float width_right = tableLayoutPanel5.Width + comboBoxPanel.Width;
            //tableLayoutPanel3.ColumnStyles[6].Width = width_left - width_right;
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
            ExternWnd.langBox.Items.Clear();

            foreach (string lang in TarLang)
            {
                // only EN_S_###
                if (lang.Split('_')[1] != "S") continue;
                string lang_short = lang.Split('_')[0];
                ExternWnd.langBox.Items.Add(lang_short);
            }
            ExternWnd.langBox.SelectedIndex = 0;
        }

        public ERROR_CODE JoinChannel()
        {
            ERROR_CODE res = ERROR_CODE.ERR_OK;

            AgoraObject.Rtc.SetChannelProfile(CHANNEL_PROFILE_TYPE.CHANNEL_PROFILE_GAME);
            AgoraObject.Rtc.SetClientRole(CLIENT_ROLE_TYPE.CLIENT_ROLE_AUDIENCE);
            AgoraObject.Rtc.EnableVideo();
            AgoraObject.Rtc.EnableLocalVideo(false);
            AgoraObject.Rtc.EnableLocalAudio(false);
            AgoraObject.SetWndEventHandler(this);

            //pictureBoxRemoteVideo.Width = this.Width;
            //RemoteWnd = PBRemoteVideo.Handle;
            UpdateLangComboBox();

            ExternWnd.mSwitchOriginal_CheckedChanged(null, null);

            AgoraObject.JoinChannelHost(AgoraObject.GetHostName(), AgoraObject.GetHostToken(), 0, "");
            //ExternWnd.labelAudio.ForeColor = Color.Red;
            //ExternWnd.labelVideo.ForeColor = Color.Red;

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
                        AddNewMember(uid, info.userAccount);
                    });
                else
                    AddNewMember(uid, info.userAccount);
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
                        AddNewMember(uid, info.userAccount);
                    });
                else
                    AddNewMember(uid, info.userAccount);
            }
        }
        public void BroadcasterLeave(uint uid)
        {
            //throw new NotImplementedException();
            if (hostBroadcasters.ContainsKey(uid) ||
                UIDChecker.IsPresident(uid) ||
                UIDChecker.IsSecretary(uid))
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

        internal void labelMicrophone_Click(object sender, EventArgs e)
        {
            AgoraObject.MuteAllRemoteAudioStream(!AgoraObject.IsAllRemoteAudioMute);
            //ExternWnd.labelAudio.ForeColor = AgoraObject.IsAllRemoteAudioMute ?
            //    Color.White :
            //    Color.Red;
        }

        internal void labelVideo_Click(object sender, EventArgs e)
        {
            AgoraObject.MuteAllRemoteVideoStream(!AgoraObject.IsAllRemoteVideoMute);
            //ExternWnd.labelVideo.ForeColor = AgoraObject.IsAllRemoteVideoMute ?
            //    Color.White :
            //    Color.Red;
            //PBRemoteVideo.Visible = !AgoraObject.IsAllRemoteVideoMute;
        }

        public void SetTrackBarVolume(int volume) 
        {
            ExternWnd.volumeTrackBar.Value = volume;
        }

        internal void langBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Выпадающий список языков
            if (!IsOriginal)
            {
                var InterRoom = AgoraObject.GetComplexToken().GetTargetRoomsAt(ExternWnd.langBox.SelectedIndex + 1);
                bool ret = AgoraObject.JoinChannelSrc(InterRoom);
                AgoraObject.MuteSrcAudioStream(false);
            }
        }

        internal void mSwitchOriginal_CheckedChanged(object sender, EventArgs e)
        {
            //Включение оригинальной дорожки (floor)
            if (IsOriginal)
            {
                var InterRoom = AgoraObject.GetComplexToken().GetTargetRoomsAt(ExternWnd.langBox.SelectedIndex + 1);
                AgoraObject.JoinChannelSrc(InterRoom);
                AgoraObject.MuteHostAudioStream(true);
                AgoraObject.MuteSrcAudioStream(AgoraObject.IsAllRemoteAudioMute);
                ExternWnd.langBox.Focus();
                //labelOrig.ForeColor = Color.White;
            }
            else
            {
                AgoraObject.MuteHostAudioStream(AgoraObject.IsAllRemoteAudioMute);
                AgoraObject.MuteSrcAudioStream(true);
                //labelOrig.ForeColor = Color.Red;
            }
            //ExternWnd.mSwitchOriginal.Checked = !IsOriginal;
            ExternWnd.langBox.Enabled = IsOriginal;
            IsOriginal = !IsOriginal;
        }
        private void Spectator_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e == null)
                EntranceForm._instance.Show();
            else
                EntranceForm._instance.Dispose();
        }
        private void Audience_FormClosing(object sender, FormClosingEventArgs e)
        {
            AgoraObject.LeaveHostChannel();
            AgoraObject.LeaveSrcChannel();
            AgoraObject.MuteAllRemoteAudioStream(false);
            AgoraObject.MuteAllRemoteVideoStream(false);

            PopUpForm.waveOutSetVolume(IntPtr.Zero, uint.MaxValue);
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
        internal void Settings_Click(object sender, EventArgs e)
        {
            if (devices == null || devices.IsDisposed)
            {
                BlurWnd blur = new();
                devices = new PopUpForm();
                blur.Show(this);
                devices.ShowDialog(this);
                devices.Dispose();
                blur.Dispose();
            }
            else
            {
                devices.Dispose();
            }
        }
        
        public void ExitApp()
        {
            ExternWnd.Hide();
            bottomPanel.Hide();
            Hide();

            AgoraObject.LeaveHostChannel();
            AgoraObject.LeaveSrcChannel();
            AgoraObject.MuteAllRemoteAudioStream(false);
            AgoraObject.MuteAllRemoteVideoStream(false);

            PopUpForm.waveOutSetVolume(IntPtr.Zero, uint.MaxValue);

            Owner.Show();
            Owner.Refresh();
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
                Animator(panel1, -45, 0, 10, 1);
                Wnd.Show();
            }
        }
        public void DevicesClosed(Form Wnd)
        {
            Animator(panel1, 45, 0, 10, 1);
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
                Update();
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
            RebindVideoWnd();
        }
        #region Events
        private void Audience_Resize(object sender, EventArgs e)
        {
            //CenterToScreen();
        }
        #endregion

        #region MembersControl

        private void AddNewMember(uint uid, string username = "")
        {
            PictureBox newPreview = new();

            string channelId = AgoraObject.GetHostName();

            if (NickCenter.IsPresident(username) || NickCenter.IsSecretary(username))
            {
                foreach (var wnd in otherWnd)
                    if (wnd.nUID == uid)
                    {
                        BroadcasterLeave(wnd.nUID);
                        break;
                    }

                InitNewWnd(channelId, uid, username);
                RebindVideoWnd();

                if (NickCenter.IsPresident(username))
                    UIDChecker.NewPresident(uid, username);

                if (NickCenter.IsSecretary(username))
                    UIDChecker.NewSecretary(uid, username);
                return;
            }

            newPreview.Dock = DockStyle.Fill;
            newPreview.BackgroundImage = Properties.Resources.video_call_empty;
            newPreview.BackgroundImageLayout = ImageLayout.Center;
            newPreview.BackColor = Color.FromArgb(85, 85, 85);
            newPreview.Margin = Padding.Empty;
            newPreview.Click += streamsTable_Click;
            newPreview.MouseMove += streamsTable_MouseMove;
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
            if (RemoveWnd(uid))
            {
                RebindVideoWnd();
                return;
            }
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

        private void streamsTable_Click(object sender, EventArgs e)
        {
            if (new System.Drawing.Rectangle(ExternWnd.audioLabel.PointToScreen(Point.Empty).X, ExternWnd.audioLabel.PointToScreen(Point.Empty).Y, ExternWnd.audioLabel.Width, ExternWnd.audioLabel.Height).Contains(Cursor.Position))
                ExternWnd.labelMicrophone_Click(sender, e);
            else if (ExternWnd.LabelVideoRect.Contains(Cursor.Position))
                ExternWnd.labelVideo_Click(sender, e);
            else if (ExternWnd.turnOrigRectangle.Contains(Cursor.Position))
                ExternWnd.mSwitchOriginal_CheckedChanged(sender, e);
            else if (ExternWnd.DevicesLblRect.Contains(Cursor.Position))
                Settings_Click(sender, e);
            else if (ExternWnd.LangBoxRect.Contains(Cursor.Position))
                if (ExternWnd.langBox.Enabled)
                    ExternWnd.langBox.DroppedDown = true;

            if (ExternWnd.HomeBtnRect.Contains(Cursor.Position))
                ExternWnd.HomeBtn_Click(null, null);
        }
        private void streamsTable_MouseMove(object sender, MouseEventArgs e)
        {
            if (Disposing || IsDisposed ||
                ExternWnd.Disposing || ExternWnd.IsDisposed)
            {
                Close();
                return;
            }

            bool cursorUpd = false;
            if (new System.Drawing.Rectangle(ExternWnd.audioLabel.PointToScreen(Point.Empty).X, ExternWnd.audioLabel.PointToScreen(Point.Empty).Y, ExternWnd.audioLabel.Width, ExternWnd.audioLabel.Height).Contains(Cursor.Position))
            {
                ExternWnd.audioLabel_MouseMove(sender, e);
                cursorUpd = true;
            }
            else
                ExternWnd.audioLabel_MouseLeave(sender, e);

            if (new System.Drawing.Rectangle(ExternWnd.videoLabel.PointToScreen(Point.Empty).X, ExternWnd.videoLabel.PointToScreen(Point.Empty).Y, ExternWnd.videoLabel.Width, ExternWnd.videoLabel.Height).Contains(Cursor.Position))
            {
                ExternWnd.videoLabel_MouseMove(sender, e);
                cursorUpd = true;
            }
            else
                ExternWnd.videoLabel_MouseLeave(sender, e);

            if (new System.Drawing.Rectangle(ExternWnd.turnOrig.PointToScreen(Point.Empty).X, ExternWnd.turnOrig.PointToScreen(Point.Empty).Y, ExternWnd.turnOrig.Width, ExternWnd.turnOrig.Height).Contains(Cursor.Position))
            {
                ExternWnd.turnOrig_MouseMove(sender, e);
                cursorUpd = true;
            }
            else
                ExternWnd.turnOrig_MouseLeave(sender, e);

            if (new System.Drawing.Rectangle(ExternWnd.devicesLabel.PointToScreen(Point.Empty).X, ExternWnd.devicesLabel.PointToScreen(Point.Empty).Y, ExternWnd.devicesLabel.Width, ExternWnd.devicesLabel.Height).Contains(Cursor.Position))
            {
                ExternWnd.devicesLabel_MouseMove(sender, e);
                cursorUpd = true;
            }
            else
                ExternWnd.devicesLabel_MouseLeave(sender, e);

            if (new System.Drawing.Rectangle(ExternWnd.langBox.PointToScreen(Point.Empty).X, ExternWnd.langBox.PointToScreen(Point.Empty).Y, ExternWnd.langBox.Width, ExternWnd.langBox.Height).Contains(Cursor.Position))
                if (ExternWnd.langBox.Enabled)
                    cursorUpd = true;
            Cursor.Current = cursorUpd ? Cursors.Hand : Cursors.Default;
        }
    }
}
