using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using agora.rtc;
using System.Windows.Forms;


namespace RSI_X_Desktop
{
    public enum CHANNEL_TYPE
    {
        CHANNEL_SRC = 255,
        CHANNEL_TRANSL,
        CHANNEL_DEST,
        CHANNEL_HOST,
    };
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
        public override void OnChannelWarning(string channelId, int warn, string msg)
        {
        }

        public override void OnChannelError(string channelId, int err, string msg)
        {
        }

        public override void OnJoinChannelSuccess(string channelId, uint uid, int elapsed)
        {
            switch (chType)
            {
                case CHANNEL_TYPE.CHANNEL_TRANSL:
                case CHANNEL_TYPE.CHANNEL_HOST:
                case CHANNEL_TYPE.CHANNEL_DEST:
                case CHANNEL_TYPE.CHANNEL_SRC:
                default:
                    break;
            }
        }

        public override void OnRejoinChannelSuccess(string channelId, uint uid, int elapsed)
        {
            switch (chType)
            {
                case CHANNEL_TYPE.CHANNEL_TRANSL:
                case CHANNEL_TYPE.CHANNEL_HOST:
                case CHANNEL_TYPE.CHANNEL_DEST:
                case CHANNEL_TYPE.CHANNEL_SRC:
                default:
                    break;
            }
        }


        public override void OnLeaveChannel(string channelId, RtcStats stats)
        {
            switch (chType)
            {
                case CHANNEL_TYPE.CHANNEL_TRANSL:
                case CHANNEL_TYPE.CHANNEL_HOST:
                case CHANNEL_TYPE.CHANNEL_DEST:
                case CHANNEL_TYPE.CHANNEL_SRC:
                default:
                    break;
            }
        }

        public override void OnClientRoleChanged(string channelId, CLIENT_ROLE_TYPE oldRole,
            CLIENT_ROLE_TYPE newRole)
        {
        }

        public override void OnUserJoined(string channelId, uint uid, int elapsed)
        {
            switch (chType) 
            {
                case CHANNEL_TYPE.CHANNEL_TRANSL:
                case CHANNEL_TYPE.CHANNEL_DEST:
                case CHANNEL_TYPE.CHANNEL_HOST:
                    AgoraObject.Rtc.GetUserInfoByUid(uid, out UserInfo user);
                    AgoraObject.NewUserOnHost(uid, user);
                    break;
                case CHANNEL_TYPE.CHANNEL_SRC:
                default:
                    break;
            }
        }

        public override void OnUserOffline(string channelId, uint uid, USER_OFFLINE_REASON_TYPE reason)
        {
            switch (chType)
            {
                case CHANNEL_TYPE.CHANNEL_TRANSL:
                case CHANNEL_TYPE.CHANNEL_DEST:
                case CHANNEL_TYPE.CHANNEL_HOST:
                    AgoraObject.RemoveHostUserInfo(uid);
                    break;
                case CHANNEL_TYPE.CHANNEL_SRC:
                default:
                    break;
            }
        }
        

        public override void OnConnectionLost(string channelId)
        {
        }

        public override void OnRequestToken(string channelId)
        {
        }

        public override void OnTokenPrivilegeWillExpire(string channelId, string token)
        {
        }

        public override void OnRtcStats(string channelId, RtcStats stats)
        {
        }

        public override void OnNetworkQuality(string channelId, uint uid, int txQuality, int rxQuality)
        {
        }


        public override void OnRemoteVideoStats(string channelId, RemoteVideoStats stats)
        {
            //System.Diagnostics.Debug.WriteLine(string.Format("uid:{0} | {1} {2}", stats.uid, stats.height, stats.width));
        }

        public override void OnRemoteAudioStats(string channelId, RemoteAudioStats stats)
        {
        }

        public override void OnRemoteAudioStateChanged(string channelId, uint uid, REMOTE_AUDIO_STATE state,
            REMOTE_AUDIO_STATE_REASON reason, int elapsed)
        {
            
        }

        public override void OnAudioPublishStateChanged(string channelId, STREAM_PUBLISH_STATE oldState,
            STREAM_PUBLISH_STATE newState, int elapseSinceLastState)
        {
        }

        public override void OnVideoPublishStateChanged(string channelId, STREAM_PUBLISH_STATE oldState,
            STREAM_PUBLISH_STATE newState, int elapseSinceLastState)
        {
        }

        public override void OnAudioSubscribeStateChanged(string channelId, uint uid,
            STREAM_SUBSCRIBE_STATE oldState,
            STREAM_SUBSCRIBE_STATE newState, int elapseSinceLastState)
        {
        }

        public override void OnVideoSubscribeStateChanged(string channelId, uint uid,
            STREAM_SUBSCRIBE_STATE oldState,
            STREAM_SUBSCRIBE_STATE newState, int elapseSinceLastState)
        {
        }

        public override void OnUserSuperResolutionEnabled(string channelId, uint uid, bool enabled,
            SUPER_RESOLUTION_STATE_REASON reason)
        {
        }

        public override void OnActiveSpeaker(string channelId, uint uid)
        {
        }

        public override void
            OnVideoSizeChanged(string channelId, uint uid, int width, int height, int rotation)
        {
        }

        public override void OnRemoteVideoStateChanged(string channelId, uint uid, REMOTE_VIDEO_STATE state,
            REMOTE_VIDEO_STATE_REASON reason, int elapsed)
        {
            
            //TODO: добавить очистку окон коллег через state == REMOTE_VIDEO_STATE_STOPPED
            switch (state) {
                case REMOTE_VIDEO_STATE.REMOTE_VIDEO_STATE_DECODING:
                    if (chType == CHANNEL_TYPE.CHANNEL_HOST)
                        (form as Audience).UpdateMember(uid, channelId);
                    break;
                case REMOTE_VIDEO_STATE.REMOTE_VIDEO_STATE_STOPPED:
                    VideoStreamHasStopped(channelId, uid, reason);
                    if (chType == CHANNEL_TYPE.CHANNEL_HOST)
                        (form as Audience).UpdateMember(uid);
                    break;
                case REMOTE_VIDEO_STATE.REMOTE_VIDEO_STATE_FROZEN:
                    if (chType == CHANNEL_TYPE.CHANNEL_HOST)
                        (form as Audience).UpdateMember(uid);
                    break;
                case REMOTE_VIDEO_STATE.REMOTE_VIDEO_STATE_FAILED:
                    if (chType == CHANNEL_TYPE.CHANNEL_HOST)
                        (form as Audience).UpdateMember(uid);
                    break;
                case REMOTE_VIDEO_STATE.REMOTE_VIDEO_STATE_STARTING:
                    break;
                default:
                    break;

            }

        }

        //|ZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZ|
        //|ZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZ|
        private void VideoStreamHasStopped(string channelId, uint uid, REMOTE_VIDEO_STATE_REASON reason)
        {
            UserInfo user;
            AgoraObject.Rtc.GetUserInfoByUid(uid, out user);

            switch (chType)
            {
                case CHANNEL_TYPE.CHANNEL_HOST:
                case CHANNEL_TYPE.CHANNEL_DEST:
                case CHANNEL_TYPE.CHANNEL_TRANSL:
                case CHANNEL_TYPE.CHANNEL_SRC:
                default:
                    break;
            }
        }
        //|ZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZ|
        //|ZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZ|

        public string message = "";

        public override void
            OnStreamMessage(string channelId, uint uid, int streamId, byte[] data, uint length)
        {
        }

        public override void OnStreamMessageError(string channelId, uint uid, int streamId, int code,
            int missed, int cached)
        {
        }

        public override void OnChannelMediaRelayStateChanged(string channelId, CHANNEL_MEDIA_RELAY_STATE state,
            CHANNEL_MEDIA_RELAY_ERROR code)
        {
        }

        public override void OnChannelMediaRelayEvent(string channelId, CHANNEL_MEDIA_RELAY_EVENT code)
        {
        }

        public override void OnRtmpStreamingStateChanged(string channelId, string url,
            RTMP_STREAM_PUBLISH_STATE state, RTMP_STREAM_PUBLISH_ERROR errCode)
        {
        }

        public override void OnRtmpStreamingEvent(string channelId, string url, RTMP_STREAMING_EVENT eventCode)
        {
        }

        public override void OnTranscodingUpdated(string channelId)
        {
        }

        public override void OnStreamInjectedStatus(string channelId, string url, uint uid, int status)
        {
        }

        public override void OnRemoteSubscribeFallbackToAudioOnly(string channelId, uint uid,
            bool isFallbackOrRecover)
        {
        }

        public override void OnConnectionStateChanged(string channelId, CONNECTION_STATE_TYPE state,
            CONNECTION_CHANGED_REASON_TYPE reason)
        {
        }

        public override void OnLocalPublishFallbackToAudioOnly(string channelId, bool isFallbackOrRecover)
        {
        }
    }
}
