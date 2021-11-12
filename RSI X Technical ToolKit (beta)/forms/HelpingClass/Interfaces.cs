using System;

namespace RSI_X_Desktop
{
    public interface IFormHostHolder
    {
        public IntPtr RemoteWnd { get; }
        public void UpdateRemoteWnd();
    }
    public interface IFormInterpreterHolder 
    { }
}
