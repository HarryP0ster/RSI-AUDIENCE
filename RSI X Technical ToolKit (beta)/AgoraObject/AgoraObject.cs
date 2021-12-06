using System;
using agorartc;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using HWND = System.IntPtr;

namespace RSI_X_Desktop
{
    public enum CHANNEL_TYPE
    {
        SRC = 255,
        TRANSL,
        DEST,
        HOST,
        UNKNOWN
    };
    enum CurForm 
    {
        FormTransLater,
        FormBroadcaster,
        FormAudience,
        FormEngineer,
        FormEngineer2,
        None
    }
    static class AgoraObject
    {
        
        public const string AppID = "31f0e571a89542b09049087e3283417f";

        public static bool IsJoin { get; private set; }


        public static bool IsAllRemoteAudioMute { get; private set; }
        public static bool IsHostAudioMute { get; private set; }
        public static bool IsSrcAudioMute { get; private set; }
        public static bool IsAllRemoteVideoMute { get; private set; }
        public static bool IsAudioRecordActive { get; private set; }
        public static bool IsAllTransLatersAudioMute { get; private set; }

        public static string CodeRoom { get; private set; } = "";
        public static string RoomLang { get => RoomName.Split('_')[0]; }
        public static string RoomName { get; private set; } = ""; //Full name of the interpreters room without 8 digits
        public static string RoomTarg { get; private set; } = ""; //Full name of the target room without 8 digits
        public static CurForm CurrentForm = CurForm.None;

        //TODO: DELETE LATER
        //private static Random rnd = new Random();
        //DELETE LATER

        internal static AgoraRtcEngine Rtc;

        internal static Tokens room = new Tokens();

        internal static AgoraRtcChannel m_channelSrc;
        internal static AgoraRtcChannel m_channelHost;

        internal static AGChannelEventHandler srcHandler;
        internal static AGChannelEventHandler hostHandler;
        private static IFormHostHolder workForm;
        public static IFormHostHolder GetWorkForm { get => workForm; }
        public static bool m_channelSrcJoin     { get; private set; } = false;
        public static bool m_channelHostJoin    { get; private set; } = false;

        public readonly static System.Text.UTF8Encoding utf8enc = new();

        internal static Dictionary<uint, UserInfo> hostBroacsters = new();

        [DllImport("USER32.DLL")]
        static extern bool GetWindowRect(IntPtr hWnd, out System.Drawing.Rectangle lpRect);

        static AgoraObject() 
        {
            Rtc = AgoraRtcEngine.CreateRtcEngine();
            Rtc.Initialize(new RtcEngineContext(AppID));
        }
        #region token logic
        static public bool JoinRoom(string code)
        {
            CodeRoom = code;
            return room.TakeToken(code);
        }

        public static Tokens GetComplexToken()          => room;
        public static string GetHostToken()             => room.GetToken;
        public static string GetHostName()              => room.GetHostName;
        public static List<string> GetLangCollection()  => room.GetLanguages.Keys.ToList();
        #endregion
        
        #region  mute remote video\audio
        static public void MuteAllRemoteAudioStream(bool mute)
        {
            Rtc.MuteAllRemoteAudioStreams(mute);
            m_channelHost?.MuteAllRemoteAudioStreams(mute);
            m_channelSrc?.MuteAllRemoteAudioStreams(mute);

            IsAllRemoteAudioMute = mute;
        }

        static public void MuteAllRemoteVideoStream(bool mute) 
        {
            Rtc.MuteAllRemoteVideoStreams(mute);
            m_channelHost?.MuteAllRemoteVideoStreams(mute);

            IsAllRemoteVideoMute = mute;
        }
        static public void MuteHostAudioStream(bool mute)
        {
            m_channelHost?.MuteAllRemoteAudioStreams(mute);

            IsHostAudioMute = m_channelHost != null &&
                                        mute;
        }
        static public void MuteSrcAudioStream(bool mute)
        {
            m_channelSrc?.MuteAllRemoteAudioStreams(mute);

            IsSrcAudioMute = m_channelSrc != null &&
                                        mute;
        }
        #endregion

        static public void SetWndEventHandler(IFormHostHolder form)
        {
            Rtc.InitEventHandler(new AGEngineEventHandler(form));
            srcHandler = new AGChannelEventHandler(form, CHANNEL_TYPE.SRC);
            hostHandler = new AGChannelEventHandler(form, CHANNEL_TYPE.HOST);
            workForm = form;
        }
        
        #region Channel src
        public static bool JoinChannelSrc(langHolder lh_holder)
        {
            return JoinChannelSrc(lh_holder.langFull, lh_holder.token, 0, "");
        }
        public static bool JoinChannelSrc(string lpChannelName, string token, uint nUID, string info)
        {
            LeaveSrcChannel();

            m_channelSrc = Rtc.CreateChannel(lpChannelName);
            m_channelSrc.InitChannelEventHandler(srcHandler);
            m_channelSrc.SetClientRole(CLIENT_ROLE_TYPE.CLIENT_ROLE_AUDIENCE);

            ChannelMediaOptions options = new();
            options.autoSubscribeAudio = !IsAllRemoteAudioMute;
            options.autoSubscribeVideo = false;

            ERROR_CODE ret = m_channelSrc.JoinChannel(token, info, nUID, options);

            m_channelSrcJoin = (0 == ret);

            return 0 == ret;
        }
        public static void LeaveSrcChannel()
        {
            if (m_channelSrcJoin)
                m_channelSrc?.LeaveChannel();
            m_channelSrcJoin = false;

        }
        #endregion

        #region Channel host
        public static bool JoinChannelHost(string lpChannelName, string token, uint nUID, string info)
        {
            LeaveHostChannel();

            m_channelHost = Rtc.CreateChannel(lpChannelName);
            m_channelHost.InitChannelEventHandler(hostHandler);
            m_channelHost.SetClientRole(CLIENT_ROLE_TYPE.CLIENT_ROLE_AUDIENCE);
            m_channelHost.SetDefaultMuteAllRemoteVideoStreams(false);

            ChannelMediaOptions options = new();
            options.autoSubscribeAudio = !IsAllRemoteAudioMute;
            options.autoSubscribeVideo = !IsAllRemoteVideoMute;


            //ERROR_CODE ret = m_channelHost.JoinChannel(token, info, nUID, options);
            ERROR_CODE ret = m_channelHost.JoinChannelWithUserAccount(token, NickCenter.ToAudienceNick(), options);


            m_channelHostJoin = (0 == ret);

            return 0 == ret;
        }
        public static void LeaveHostChannel()
        {
            if (m_channelHostJoin)
                m_channelHost?.LeaveChannel();
            m_channelHostJoin = false;
        }
        #endregion
        internal static void NewUserOnHost(uint uid, UserInfo user)
        {
            if (hostBroacsters.ContainsKey(uid))
                hostBroacsters[uid] = user; 
            else
                hostBroacsters.Add(uid, user);
            workForm.NewBroadcaster(uid, user);
            System.Diagnostics.Debug.WriteLine($"{DateTime.Now.ToString("HH:mm:ss")}: New user {user.userAccount} {uid}");
        }
        internal static void UpdateHostUserInfo(uint uid, UserInfo user)
        {
            if (hostBroacsters.ContainsKey(uid))
            {
                hostBroacsters[uid] = user;
                workForm.BroadcasterUpdateInfo(uid, user);
                System.Diagnostics.Debug.WriteLine($"{DateTime.Now.ToString("HH:mm:ss")}: update user {user.userAccount} {uid}");
            }
        }
        internal static void RemoveHostUserInfo(uint uid)
        {
            if (hostBroacsters.ContainsKey(uid))
            {
                hostBroacsters.Remove(uid);
                workForm.BroadcasterLeave(uid);
                System.Diagnostics.Debug.WriteLine($"{DateTime.Now.ToString("HH:mm:ss")}: remove conf {uid}");
            }
        }
        internal static bool RecordAudio(bool state)
        {
            string direct = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic) + "\\RSI";
            string filename = $"AudioRecording-{DateTime.Now.ToString("dd-MM-yy-HH-mm-ss")}.wav";

            if (false == System.IO.Directory.Exists(direct))
                System.IO.Directory.CreateDirectory(direct);

            SaveFileDialog fd = new() { 
                DefaultExt="wav",
                Filter = "Audio files(*.wav)|*.wav|Audio files(*.acc)|*.acc",
                InitialDirectory = direct,
                FileName = filename,
            };

            switch (state)
            {
                case true:
                    fd.ShowDialog();

                    filename = fd.FileName;

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
            IsAudioRecordActive = state;
            return true;
        }


    }
}