using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSI_X_Desktop
{
    public static class NickCenter
    {
        const string HostStartsWith = "HOST";
        const string AudienceStartsWith = "SPECTRATOR";
        const string SECRETARY = "HOST_SECRETARY";
        const string PRESIDENT = "HOST_PRESIDENT";

        public static string ToHostNick(string nick)
        {
            return HostStartsWith + nick;
        }
        public static string ToAudienceNick()
        {
            return AudienceStartsWith;
        }
        public static string ToInterpreterNick(string nick, string langShort)
        {
            return $"({langShort}) {nick}";
        }
        public static bool IsHost(string nick) 
        {
            return nick.StartsWith(HostStartsWith);
        }
        public static bool IsAudience(string nick)
        {
            return nick.StartsWith(AudienceStartsWith);
        }
        public static bool IsInterpreter(string nick)
        {
            return nick.Split(' ')[0].Contains('(') &&
                   nick.Split(' ')[0].Contains(')');
        }
        internal static bool IsPresident(string username)
        {
            return username.StartsWith(PRESIDENT);
        }

        internal static bool IsSecretary(string username)
        {
            return username.StartsWith(SECRETARY);
        }
    }
}
