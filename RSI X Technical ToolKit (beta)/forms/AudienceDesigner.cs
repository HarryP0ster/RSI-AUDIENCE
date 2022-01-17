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
using DevExpress.Utils.Svg;

namespace RSI_X_Desktop.forms
{
    public partial class AudienceDesigner : DevExpress.XtraEditors.XtraForm
    {
        private bool IsOriginal = false;
        bool canSelect = true;
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
                SighnOffToCenter();
            };

            AllowTransparency = true;
            Owner.LocationChanged += (s, e) => { Location = new Point(Owner.Location.X, Owner.Location.Y); };
            SetLeftSidePanelRegion();
            SighnOffToCenter();
            RoomNameLabel.Text = AgoraObject.GetComplexToken().GetRoomName;
            AudioColorUpdate();
            VideoColorUpdate();
            langBox_EnabledChanged(null, null);

            if (langBox.DeviceDpi >= (int)Constants.DPI.P175)
                langBox.Font = Constants.Bahnschrift12;
            else if (langBox.DeviceDpi >= (int)Constants.DPI.P150)
                langBox.Font = Constants.Bahnschrift14;
            else if (langBox.DeviceDpi >= (int)Constants.DPI.P125)
                langBox.Font = Constants.Bahnschrift16;
            else if (langBox.DeviceDpi >= (int)Constants.DPI.P100)
                langBox.Font = Constants.Bahnschrift22;

            //if (IconsPanel.DeviceDpi >= (int)EntranceForm.DPI.P150) 
            //{
            //var coll = IconsPanel.Columns;
            //coll.BeginUpdate();
            //coll[0].Style = DevExpress.Utils.Layout.TablePanelEntityStyle.Relative;
            //coll[1].Style = DevExpress.Utils.Layout.TablePanelEntityStyle.Relative;
            //coll[2].Style = DevExpress.Utils.Layout.TablePanelEntityStyle.Relative;

            //coll[0].Width = 65F;
            //coll[1].Width = 35F;
            //coll[2].Width = 45F;

            //IconsPanel.Columns.Insert()
            //}
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
            int leftSide = audioLabel.Width + videoLabel.Width + devicesLabel.Width + Record.Width;
            int rightSide = turnOrig.Width + volumeIcon.Width + volumeTrackBar.Width + langBox.Width + langBox.Margin.Left;
            if (leftSide > rightSide)
            {
                IconsPanel.Columns[7].Width = leftSide - rightSide;
                IconsPanel.Columns[5].Width = 0;
            }
            else
            {
                IconsPanel.Columns[5].Width = rightSide - leftSide;
                IconsPanel.Columns[7].Width = 0;
            }
        }

        #region EventHabdlers
        private void AudienceDesigner_Shown(object sender, EventArgs e)
        {
        }

        internal void labelMicrophone_Click(object sender, EventArgs e)
        {
            if (canSelect)
            {
                canSelect = false;
                AgoraObject.MuteAllRemoteAudioStream(!AgoraObject.IsAllRemoteAudioMute);
                timer1.Start();
            }
        }

        private void AudioColorUpdate()
        {
            audioLabel.ItemAppearance.Normal.BorderColor = AgoraObject.IsAllRemoteAudioMute ?
                Color.WhiteSmoke :
                Color.White;

            audioLabel.ItemAppearance.Normal.FillColor = AgoraObject.IsAllRemoteAudioMute ?
                Color.Empty :
                Color.White;

            audioLabel.SvgImage = AgoraObject.IsAllRemoteAudioMute ?
                SvgImage.FromFile("Resources\\aud_muted.svg") :
                SvgImage.FromFile("Resources\\aud_mute.svg");
        }
        private void VideoColorUpdate()
        {
            videoLabel.ItemAppearance.Normal.BorderColor = AgoraObject.IsAllRemoteVideoMute ?
                Color.WhiteSmoke :
                Color.White;

            videoLabel.ItemAppearance.Normal.FillColor = AgoraObject.IsAllRemoteVideoMute ?
                Color.Empty :
                Color.White;

            videoLabel.SvgImage = AgoraObject.IsAllRemoteVideoMute ?
                SvgImage.FromFile("Resources\\Hidden.svg") :
                SvgImage.FromFile("Resources\\video.svg");
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
                turnOrig.ItemAppearance.Normal.FillColor = Color.Empty;
            }
            else
            {
                AgoraObject.MuteHostAudioStream(AgoraObject.IsAllRemoteAudioMute);
                AgoraObject.MuteSrcAudioStream(true);
                turnOrig.ItemAppearance.Normal.FillColor = Color.White;
            }
            //mSwitchOriginal.Checked = !IsOriginal;
            DebugWriter.WriteTime($"change floor channel: {IsOriginal}");

            langBox.Enabled = IsOriginal;
            IsOriginal = !IsOriginal;
        }
        internal void labelVideo_Click(object sender, EventArgs e)
        {
            if (canSelect)
            {
                canSelect = false;
                AgoraObject.MuteAllRemoteVideoStream(!AgoraObject.IsAllRemoteVideoMute);
                (Owner as Audience).streamsTable.Visible = !AgoraObject.IsAllRemoteVideoMute;
                timer1.Start();
            }
        }
        public void HomeBtn_Click(object sender, EventArgs e)
        {
            AgoraObject.GetWorkForm?.ExitApp();
        }

        private void trackBar1_ValueChanged()
        {
            PopUpForm.SetVolume(volumeTrackBar.Value);
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
            langBox.ForeColor = langBox.Enabled ? Color.White : Color.FromArgb(5, 0, 0, 0);
            langBox.TriangleColorA = langBox.Enabled ? Color.White : Color.FromArgb(5, 0, 0, 0);
            langBox.TriangleColorB = langBox.Enabled ? Color.White : Color.FromArgb(5, 0, 0, 0);
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

        public Rectangle HomeBtnRect
        {
            get => new Rectangle(
                signOff.PointToScreen(Point.Empty).X, 
                signOff.PointToScreen(Point.Empty).Y, 
                signOff.Width,
                signOff.Height);
        }
        public Rectangle LangBoxRect
        {
            get => new Rectangle(
                langBox.PointToScreen(Point.Empty).X,
                langBox.PointToScreen(Point.Empty).Y,
                langBox.Width,
                langBox.Height);
        }
        public Rectangle DevicesLblRect
        {
            get => new Rectangle(
                devicesLabel.PointToScreen(Point.Empty).X,
                devicesLabel.PointToScreen(Point.Empty).Y,
                devicesLabel.Width,
                devicesLabel.Height);
        }
        public Rectangle turnOrigRectangle 
        { 
            get => new Rectangle(
                turnOrig.PointToScreen(Point.Empty).X, 
                turnOrig.PointToScreen(Point.Empty).Y, 
                turnOrig.Width, 
                turnOrig.Height); 
        }
        public Rectangle LabelVideoRect 
        {
            get => new Rectangle(
            videoLabel.PointToScreen(Point.Empty).X,
            videoLabel.PointToScreen(Point.Empty).Y,
            videoLabel.Width,
            videoLabel.Height);
        }

        public Rectangle RecordRect
        {
            get => new Rectangle(
            Record.PointToScreen(Point.Empty).X,
            Record.PointToScreen(Point.Empty).Y,
            Record.Width,
            Record.Height);
        }

        private void langBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (!IsOriginal)
            {
                var InterRoom = AgoraObject.GetComplexToken().GetTargetRoomsAt(langBox.SelectedIndex + 1);
                bool ret = AgoraObject.JoinChannelSrc(InterRoom);
                AgoraObject.MuteSrcAudioStream(false);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Point oldPos = Cursor.Position;
            timer1.Stop();
            Cursor.Position = PointToScreen(new Point(Width / 2, Height / 2));
            AudioColorUpdate();
            VideoColorUpdate();
            Cursor.Position = oldPos;
            System.Threading.Thread.Sleep(100);
            canSelect = true;
        }

        internal void Record_MouseMove(object sender, MouseEventArgs e)
        {
            Record.ItemAppearance.Normal.BorderColor = Color.White;
        }

        internal void Record_MouseLeave(object sender, EventArgs e)
        {
            Record.ItemAppearance.Normal.BorderColor = Color.Empty;
        }

        internal void Record_Click(object sender, EventArgs e)
        {
            (Owner as Audience).Record_Click(sender, e);
        }
    }
}