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
    }
}
