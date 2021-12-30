using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;
using System.Runtime.InteropServices;
using agora.rtc;
using Un4seen.Bass;
using System.IO;

namespace RSI_X_Desktop.forms
{
    public partial class PopUpForm : DevExpress.XtraEditors.XtraForm
    {
        [DllImport("winmm.dll")]
        public static extern int waveOutSetVolume(IntPtr hwo, uint dwVolume); //Контроль громкости
        private static int volume = 100;
        public int Volume { get => volume; }

        private IFormHostHolder workForm = AgoraObject.GetWorkForm;
        private static IAgoraRtcAudioPlaybackDeviceManager SpeakersManager;
        static List<DeviceInfo> Speakers;

        private static int oldVolumeOut;
        private static DeviceInfo oldSpeaker;
        public DeviceInfo SelectedSpeaker { get; private set; }

        Padding DefaultMargin = new Padding(15);
        Padding Hovered = new Padding(13);

        public PopUpForm()
        {
            InitializeComponent();
        }
        public static void SetVolume(int value)
        {
            volume = value;
            int NewVolume = ((ushort.MaxValue / 100) * value);
            uint NewVolumeAllChannels = (((uint)NewVolume & 0x0000ffff) | ((uint)NewVolume << 16));

            waveOutSetVolume(IntPtr.Zero, NewVolumeAllChannels);
        }

        private void PopUpForm_Load(object sender, EventArgs e)
        {
            SetWndRegion();
            SpeakersManager = AgoraObject.Rtc.GetAgoraRtcAudioPlaybackDeviceManager();

            oldVolumeOut = (Owner as Audience).ExternWnd.volumeTrackBar.Value;
            trackBarSoundOut.Value = oldVolumeOut;

            Speakers = getListAudioOutDevices();
            UpdateComboBoxSpeaker();
            getComputerDescription();
        }

        private void SetWndRegion()
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            int d = 45;
            System.Drawing.Rectangle r = new System.Drawing.Rectangle(0, 0, Width, Height);
            path.AddArc(r.X, r.Y, d, d, 180, 90);
            path.AddArc(r.X + r.Width - d, r.Y, d, d, 270, 90);
            path.AddArc(r.X + r.Width - d, r.Y + r.Height - d, d, d, 0, 90);
            path.AddArc(r.X , r.Y + r.Height - d, d, d, 90, 90);
            this.Region = new Region(path);
        }
        private void UpdateComboBoxSpeaker()
        {
            Speakers = getListAudioOutDevices();
            bool hasoldSpeaker = Speakers.Any((s) => s.deviceId == oldSpeaker.deviceId);

            int index = (oldSpeaker.deviceId != null) ?
                Speakers.FindLastIndex((s) => s.deviceId == oldSpeaker.deviceId) :
                getActiveAudioOutputDevice();

            if (Speakers.Count == 0)
            {
                comboBoxAudioOutput.DataSource = new List<string> { "Playback Devices Error" };
                return;
            }

            if (index < 0)
                index = 0;

            oldSpeaker = Speakers[index];
            comboBoxAudioOutput.DataSource = Speakers;
            comboBoxAudioOutput.SelectedIndex = index;
        }

        private void getComputerDescription()
        {
            //dungeonLabel1.Text = "Версия ОС - " + OSVersion.VersionString;

            //if (Is64BitOperatingSystem == true)
            //{
            //    dungeonLabel2.Text = "64 Bit операционная система";
            //}
            //else
            //{
            //    dungeonLabel2.Text = "32 Bit операционная система";
            //}

            //dungeonLabel3.Text = "Пользователь - " + UserName;

        }

        private int getActiveAudioOutputDevice()
        {
            bool found = false;
            int id = 0;
            var device = SpeakersManager.GetPlaybackDevice();

            foreach (var dev in SpeakersManager.EnumeratePlaybackDevices())
            {
                if (device == dev.deviceId) { found = true; break; };
                id += 1;
            }

            if (!found)
                id = -1;

            return id;
        }

        #region getDevicesList

        private List<DeviceInfo> getListAudioOutDevices()
        {
            List<DeviceInfo> devicesOut = new();
            devicesOut.AddRange(SpeakersManager.EnumeratePlaybackDevices());

            return devicesOut;
        }

        #region ComboBoxEventHandlers

        private void comboBoxAudioOutput_SelectedIndexChanged(object sender, EventArgs e)
        {
            DeviceInfo dev;
            int ind = (sender as System.Windows.Forms.ComboBox).SelectedIndex;
            var RecorderList = SpeakersManager.EnumeratePlaybackDevices();

            if (RecorderList.Length > ind)
                dev = RecorderList[ind];

            SelectedSpeaker = dev;
            SpeakersManager.SetPlaybackDevice(dev.deviceId);
        }

        #endregion

        private void NewDevices_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (AgoraObject.CurrentForm != CurForm.FormAudience)
            {
                Dispose();
            }
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            var aout = comboBoxAudioOutput.SelectedIndex;

            if (Speakers.Count() < aout) oldSpeaker = Speakers[aout];

            oldVolumeOut = trackBarSoundOut.Value;

            CloseButton_Click(sender, e);
        }

        internal void CloseButton_Click(object sender, EventArgs e)
        {
            trackBarSoundOut.Value = oldVolumeOut;
            trackBarSoundOut_ValueChanged();

            if (oldSpeaker.deviceId != null)
                SpeakersManager.SetPlaybackDevice(oldSpeaker.deviceId);

            Close();
        }

        private void trackBarSoundOut_ValueChanged()
        {
            SetVolume(trackBarSoundOut.Value);
            if (workForm != null)
                workForm.SetTrackBarVolume(trackBarSoundOut.Value);
        }
        public void UpdateSoundTrackBar()
        {
            trackBarSoundOut.Value = volume;
        }

        private void ApplyBtn_Click(object sender, EventArgs e)
        {
            var aout = comboBoxAudioOutput.SelectedIndex;

            if (Speakers.Count() < aout) oldSpeaker = Speakers[aout];

            oldVolumeOut = trackBarSoundOut.Value;
        }

        private void SpeakerTestBtn_Click(object sender, EventArgs e) //Plays a simple beep sound to indicate selected speaker
        {

            int device_index = GetDeviceIndex(comboBoxAudioOutput.Text);

            Bass.BASS_Init(device_index, 44100, BASSInit.BASS_DEVICE_SPEAKERS, IntPtr.Zero);
            Bass.BASS_SetDevice(device_index);
            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
            string File = projectDirectory + "\\Resources\\OutputBeep.wav";
            int stream = Bass.BASS_StreamCreateFile(File, 0, Properties.Resources.OutputBeep.Length, BASSFlag.BASS_SAMPLE_FLOAT | BASSFlag.BASS_STREAM_PRESCAN);
            Bass.BASS_ChannelSetDevice(stream, device_index);
            Bass.BASS_ChannelSetAttribute(stream, BASSAttribute.BASS_ATTRIB_VOL, (float)trackBarSoundOut.Value/100f);
            if (stream != 0)
                Bass.BASS_ChannelPlay(stream, true);
        }
        #endregion
        private int GetDeviceIndex(string devicename)
        {
            var devices = Bass.BASS_GetDeviceInfos();
            int device_index = 0;
            foreach (BASS_DEVICEINFO device in devices)
            {
                if (device.name == devicename)
                    return device_index;
                else
                    device_index++;
            }
            return -1;
        }

        private void ApplyBtn_MouseEnter(object sender, EventArgs e)
        {
            ApplyBtn.Margin = Hovered;
            ApplyBtn.Focus();
        }

        private void ApplyBtn_MouseLeave(object sender, EventArgs e)
        {
            ApplyBtn.Margin = DefaultMargin;
        }

        private void ConfirmBtn_MouseEnter(object sender, EventArgs e)
        {
            ConfirmBtn.Margin = Hovered;
            ConfirmBtn.Focus();
        }

        private void ConfirmBtn_MouseLeave(object sender, EventArgs e)
        {
            ConfirmBtn.Margin = DefaultMargin;
        }

        private void CancelBtn_MouseEnter(object sender, EventArgs e)
        {
            CancelBtn.Margin = Hovered;
            CancelBtn.Focus();
        }

        private void CancelBtn_MouseLeave(object sender, EventArgs e)
        {
            CancelBtn.Margin = DefaultMargin;
        }
    }
}