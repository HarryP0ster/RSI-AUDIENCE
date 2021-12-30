using System;
using agorartc;
using System.Threading;
using System.Runtime.InteropServices;

namespace ConsoleAppOut
{
    class Program
    {
        static int parentID;
        static System.Diagnostics.Process proc;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args[0]">token</param>
        /// <param name="args[1]">cahnnel</param>
        /// <param name="args[2]">cahnnel lang</param>
        /// <param name="args[3]">Parent PID</param>
        /// <param name="args[4]">path to save</param>
        [DllImport("winmm.dll")]
        public static extern int waveOutSetVolume(IntPtr hwo, uint dwVolume); //Контроль громкости
        static void Main(string[] args)
        {

            //var retInput = XAgoraObject.SetupOutputDevices(args[2]);

            //Console.WriteLine(retInput);

            Console.WriteLine("-----");
            foreach (var item in args) { Console.WriteLine(item); }
            Console.WriteLine("-----");
            
            int NewVolume = ((ushort.MaxValue / 100) * 0);
            uint NewVolumeAllChannels = (((uint)NewVolume & 0x0000ffff) | ((uint)NewVolume << 16));

            waveOutSetVolume(IntPtr.Zero, NewVolumeAllChannels);

            var retPubl = XAgoraObject.Publish(args[0], args[1], args[2], args[4]);


            parentID = System.Convert.ToInt32(args[3]);
            proc = System.Diagnostics.Process.GetProcessById(parentID);
            proc.WaitForExit();
        }

        private static void ParentClose(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
    static class XAgoraObject
    {
        static AgoraRtcEngine Rtc;
        static AgoraAudioRecordingDeviceManager audioInDeviceManager;
        static AgoraAudioPlaybackDeviceManager audioOutDeviceManager;

        const string AppID = "31f0e571a89542b09049087e3283417f";
        static string nameDevice;
        static XAgoraObject()
        {
            Rtc = AgoraRtcEngine.CreateRtcEngine();
            Rtc.MuteLocalVideoStream(true);
            Rtc.Initialize(new RtcEngineContext(AppID));
            audioInDeviceManager = Rtc.CreateAudioRecordingDeviceManager();
            audioOutDeviceManager = Rtc.CreateAudioPlaybackDeviceManager();
        }

        public static ERROR_CODE SetupOutputDevices(string ind)
        {
            return audioOutDeviceManager.SetCurrentDevice(ind);
        }

        public static ERROR_CODE Publish(string token, string name, string postfix, string path)
        {
            Rtc.MuteLocalAudioStream(true);
            Rtc.EnableLocalAudio(false);
            Rtc.MuteLocalVideoStream(true);
            ERROR_CODE res = Rtc.JoinChannel(token, name, "", 0);

            audioOutDeviceManager.GetCurrentDeviceInfo(out string idOUT, out string nameOUT);
            nameDevice = nameOUT;

            Console.WriteLine("\n\n\n\nHello World!");
            RecordAudio(true, path, postfix);
            return res;
        }

        public static void UnPublish()
        {
            RecordAudio(false);
            Rtc.LeaveChannel();
        }
        internal static bool RecordAudio(bool state, string path="", string postfix="")
        {
            string direct = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic) + "\\RSI";
            string filename = $"AudioRecording-{DateTime.Now:dd-MM-yy-HH-mm-ss}_" + postfix + ".wav";

            if (false == System.IO.Directory.Exists(direct))
                System.IO.Directory.CreateDirectory(direct);
            switch (state)
            {
                case true:
                    filename = $"{path}\\{postfix}.wav";
                    Console.WriteLine(filename);

                    if (System.IO.Path.GetDirectoryName(filename) == String.Empty)
                        return false;

                    AUDIO_RECORDING_QUALITY_TYPE quality = System.IO.Path.GetExtension(filename) == ".wav" ?
                        AUDIO_RECORDING_QUALITY_TYPE.AUDIO_RECORDING_QUALITY_MEDIUM :
                        AUDIO_RECORDING_QUALITY_TYPE.AUDIO_RECORDING_QUALITY_LOW;

                    Rtc.StartAudioRecording(filename, quality);
                    break;
                default:
                    Rtc.StopAudioRecording();
                    break;
            }
            return true;
        }
    }
}
