using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSI_X_Desktop
{
    public static class DebugWriter
    {
        public static void WriteTime(string msg, uint line = 0) 
        {
#if DEBUG
            var time = DateTime.Now.ToString("u");
            var tab = "";

            for (int i = 0; i < line; i++)
                tab += "   ";
            
            System.Diagnostics.Debug.WriteLine(
                $"[{time}]:{tab} {msg}"
                );
#endif
        }
        public static void Write(string msg, uint line = 0) 
        {
#if DEBUG
            var tab = "";

            for (int i = 0; i < line; i++)
                tab += "   ";

            System.Diagnostics.Debug.WriteLine($"{tab}{msg}");
#endif
        }
    }
}
