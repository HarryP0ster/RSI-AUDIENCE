using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using ReaLTaiizor;
using agora.rtc;
using RSI_X_Desktop.forms;
using static System.Environment;

namespace RSI_X_Desktop.forms
{
    public partial class Devices : Form
    {
        [DllImport("winmm.dll")]
        public  static extern int waveOutSetVolume(IntPtr hwo, uint dwVolume); //Контроль громкости
        private static int volume = 100;
        public int Volume { get => volume; }
        private int GetSelectAudioIndex { get => comboBoxAudioOutput.SelectedIndex; }
        
        private IFormHostHolder workForm = AgoraObject.GetWorkForm;
        private IAgoraRtcAudioPlaybackDeviceManager SpeakersManager;
        static List<string> Speakers;

        private static int oldVolumeOut;
        private static string oldSpeaker;

        public Devices()
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

        private void NewDevices_Load(object sender, EventArgs e)
        {
            SpeakersManager = AgoraObject.Rtc.GetAgoraRtcAudioPlaybackDeviceManager();

            oldVolumeOut = Volume;
            trackBarSoundOut.Value = oldVolumeOut;
            
            Speakers = getListAudioOutDevices();
            UpdateComboBoxSpeaker();
            getComputerDescription();
        }
        private void UpdateComboBoxSpeaker()
        {
            bool hasOldSpeaker = Speakers.Any((s) => s == oldSpeaker);

            int index = hasOldSpeaker ?
                Speakers.FindLastIndex((s) => s == oldSpeaker) :
                index = getActiveAudioOutputDevice();

            oldSpeaker = Speakers[index];

            comboBoxAudioOutput.DataSource = Speakers;
            comboBoxAudioOutput.SelectedIndex = index;
        }

        private void getComputerDescription()
        {
            dungeonLabel1.Text = "Версия ОС - " + OSVersion.VersionString;

            if (Is64BitOperatingSystem == true)
            {
                dungeonLabel2.Text = "64 Bit операционная система";
            }
            else
            {
                dungeonLabel2.Text = "32 Bit операционная система";
            }

            dungeonLabel3.Text = "Пользователь - " + UserName;

        }

        private int getActiveAudioOutputDevice()
        {
            int id = -1;

            var device = SpeakersManager.GetPlaybackDeviceInfo();

            foreach (var dev in SpeakersManager.EnumeratePlaybackDevices())
            {
                if (device.deviceId == dev.deviceId)
                    break;
                id++;

            }
            return id;
        }

        #region getDevicesList

        private List<string> getListAudioOutDevices()
        {
            List<string> devicesOut = new();

            foreach (var dev in SpeakersManager.EnumeratePlaybackDevices())
            {
                devicesOut.Add(dev.deviceName);
            }

            return devicesOut;
        }
        #endregion

        #region ComboBoxEventHandlers

        private void comboBoxAudioOutput_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ind = ((ComboBox)sender).SelectedIndex;

            if (ind >= SpeakersManager.EnumeratePlaybackDevices().Count()) 
            {
                UpdateComboBoxSpeaker();
                return;
            }

            var dev = SpeakersManager.EnumeratePlaybackDevices()[ind];
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
            oldSpeaker = Speakers[GetSelectAudioIndex];
            oldVolumeOut = trackBarSoundOut.Value;

            CloseButton_Click(sender, e);
        }

        internal void CloseButton_Click(object sender, EventArgs e)
        {
            trackBarSoundOut.Value = oldVolumeOut;
            trackBarSoundOut_ValueChanged();

            var dev = SpeakersManager.EnumeratePlaybackDevices()[GetSelectAudioIndex];
            SpeakersManager.SetPlaybackDevice(dev.deviceId);

            AgoraObject.GetWorkForm?.DevicesClosed(this);
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
        public void typeOfAlligment(bool sign)
        {
            if (sign == true)
                materialShowTabControl1.Alignment = TabAlignment.Left;
            else
                materialShowTabControl1.Alignment = TabAlignment.Right;
        }
    }
}
