using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using agora.rtc;


namespace RSI_X_Desktop
{
    public class AGChannelEventHandler : IAgoraRtcChannelEventHandler
    {
        internal List<uint> hostBroacsters = new();
        private IFormHostHolder form;
        public CHANNEL_TYPE chType { get; private set; }

        public AGChannelEventHandler(IFormHostHolder form_new, CHANNEL_TYPE new_chType)
        {
            form = form_new;
            chType = new_chType;
        }
        public override void OnUserJoined(string channelId, uint uid, int elapsed)
        {
            switch (chType) 
            {
                case CHANNEL_TYPE.TRANSL:
                case CHANNEL_TYPE.DEST:
                case CHANNEL_TYPE.HOST:
                    AgoraObject.Rtc.GetUserInfoByUid(uid, out UserInfo user);
                    AgoraObject.NewUserOnHost(uid, user);
                    break;
                case CHANNEL_TYPE.SRC:
                default:
                    break;
            }

            if (chType is CHANNEL_TYPE.TRANSL)
            {
                //form.ShowRemoteWnd();
            }
        }

        public override void OnUserOffline(string channelId, uint uid, USER_OFFLINE_REASON_TYPE reason)
        {
            switch (chType)
            {
                case CHANNEL_TYPE.TRANSL:
                case CHANNEL_TYPE.DEST:
                case CHANNEL_TYPE.HOST:
                    AgoraObject.RemoveHostUserInfo(uid);
                    break;
                case CHANNEL_TYPE.SRC:
                default:
                    break;
            }
        }
        
        public override void OnRemoteVideoStateChanged(string channelId, uint uid, REMOTE_VIDEO_STATE state,
            REMOTE_VIDEO_STATE_REASON reason, int elapsed)
        {
            string msg = $"{channelId} {uid} \n{state}\n{reason}";

            DebugWriter.WriteTime(msg);
            //MessageBox.Show(msg);

            //TODO: добавить очистку окон коллег через state == REMOTE_VIDEO_STATE_STOPPED
            switch (state) {
                case REMOTE_VIDEO_STATE.REMOTE_VIDEO_STATE_DECODING:
                    if (chType == CHANNEL_TYPE.HOST)
                        (form as Audience).UpdateMember(uid, channelId);
                    break;
                case REMOTE_VIDEO_STATE.REMOTE_VIDEO_STATE_STOPPED:
                    if (chType == CHANNEL_TYPE.HOST)
                        (form as Audience).UpdateMember(uid);
                    break;
                case REMOTE_VIDEO_STATE.REMOTE_VIDEO_STATE_FROZEN:
                    if (chType == CHANNEL_TYPE.HOST)
                        (form as Audience).UpdateMember(uid);
                    break;
                case REMOTE_VIDEO_STATE.REMOTE_VIDEO_STATE_FAILED:
                    if (chType == CHANNEL_TYPE.HOST)
                        (form as Audience).UpdateMember(uid);
                    break;
                case REMOTE_VIDEO_STATE.REMOTE_VIDEO_STATE_STARTING:
                    if (chType == CHANNEL_TYPE.HOST)
                        (form as Audience).UpdateMember(uid, channelId);
                    break;
                default:
                    break;

            }

        }
    }

}
