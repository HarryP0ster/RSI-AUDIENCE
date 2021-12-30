using System;

using agora.rtc;

namespace RSI_X_Desktop
{
    internal class AGEngineEventHandler : IAgoraRtcEngineEventHandler
    {
        private IFormHostHolder form;
        public AGEngineEventHandler(IFormHostHolder form) 
        {
            this.form = form;
        }
        public override void OnUserJoined(uint uid, int elapsed)
        {
            Console.WriteLine("OnUserJoined");

            if (form.RemoteWnd == IntPtr.Zero) return;
            var ret = new VideoCanvas(
                (ulong)form.RemoteWnd, 
                RENDER_MODE_TYPE.RENDER_MODE_FIT,
                uid:uid);

            AgoraObject.Rtc.SetupRemoteVideo(ret);
        }
        public override void OnUserInfoUpdated(uint uid, UserInfo info)
        {
            AgoraObject.UpdateHostUserInfo(uid, info);
        }
    }
}
