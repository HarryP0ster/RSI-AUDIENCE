using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSI_X_Desktop.other
{
    public class UIDChecker
    {
        // dict uid - lang
        public static Dictionary<uint, string> UidLangToCheck = new();
        public static HashSet<uint> UidsToStopStream = new();

        public static HashSet<uint> Spectrators = new();
        public static HashSet<uint> Broadcasters = new();
        public static (uint Uid, string Name) President = new();
        public static (uint Uid, string Name) Secretary = new();

        // dict uid - lang
        public static Dictionary<uint, string> StreamInterpreters = new();
        public static HashSet<uint> InterpretersInMyBoth = new();

        // dict uid - name
        public static Dictionary<uint, string> InterpretersNick = new();
        internal static Dictionary<uint, string> GetStreamers { get => StreamInterpreters; }

        public static void AddNewUIDtoCheck(uint uid, string lang)
        {
            if (Spectrators.Contains(uid) == false &&
                Broadcasters.Contains(uid) == false &&
                InterpretersNick.ContainsKey(uid) == false)
            {
                DebugWriter.WriteTime($"UIDChecker. {uid} is unknown");

                if (UidLangToCheck.ContainsKey(uid) == false)
                    UidLangToCheck.Add(uid, lang);
                else
                    UidLangToCheck[uid] = lang;
            }
            else
            {
                DebugWriter.WriteTime($"UIDChecker. {uid} " +
                    $"is Spectrator {Spectrators.Contains(uid) }, " +
                    $"is Broadcaster {Broadcasters.Contains(uid)}, " +
                    $"is Interpreter {InterpretersNick.ContainsKey(uid)}");
            }
        }
        public static void MoveUIDtoSpectrators(uint uid)
        {
            RemoveFromCheckList(uid);
            DebugWriter.WriteTime($"UIDChecker. [{uid}] is Spectrator");
            Spectrators.Add(uid);
        }
        public static void MoveUIDtoBroadcasters(uint uid)
        {
            DebugWriter.WriteTime($"UIDChecker. [{uid}] is Broadcaster");
            RemoveFromCheckList(uid);
            Broadcasters.Add(uid);
        }

        public static void MoveUIDtoInterpreters(uint uid, string lang = "", string name = "")
        {
            if (UidLangToCheck.ContainsKey(uid))
                lang = UidLangToCheck[uid];

            RemoveFromCheckList(uid);
            if (InterpretersNick.ContainsKey(uid) == false)
            {
                DebugWriter.WriteTime($"UIDChecker. {uid} now is Interpreter [{name}] [{lang}]");
                InterpretersNick.Add(uid, name);
            }
            else
            {
                name = name == "" ? InterpretersNick[uid] : name;

                DebugWriter.WriteTime($"UIDChecker. update {uid} Interpreter with [{name}] [{lang}]");
                InterpretersNick[uid] = name;
            }
        }
        public static void UpdateInterpretersUID(uint uid, string name = "")
        {
            if (InterpretersNick.ContainsKey(uid) == false)
                InterpretersNick.Add(uid, name);
            name = (name == "") ? InterpretersNick[uid] : name;

            InterpretersNick[uid] = name;
        }

        public static void NewInterpInMyBoth(uint uid)
        {
            RemoveFromCheckList(uid);
            InterpretersInMyBoth.Add(uid);
        }
        public static void RemoveInterpFromMyBoth(uint uid)
        {
            RemoveFromCheckList(uid);
            InterpretersInMyBoth.Remove(uid);
        }

        public static void ToStopStream(uint uid)
        {
            UidsToStopStream.Add(uid);
            DebugWriter.WriteTime($"UIDChecker. streamer [{uid}] will be stopped");
        }
        public static void RemoveFromStopStream(uint uid)
        {
            if (UidsToStopStream.Contains(uid))
                UidsToStopStream.Remove(uid);
            DebugWriter.WriteTime($"UIDChecker. streamer [{uid}] has been stopped");
        }
        public static bool IsReadyToStopStream(uint uid)
        {
            DebugWriter.WriteTime($"UIDChecker. streamer [{uid}] in stoplist");
            return UidsToStopStream.Contains(uid);
        }

        public static void NewStreamerInterp(uint uid, string lang)
        {
            RemoveFromCheckList(uid);

            if (StreamInterpreters.ContainsKey(uid))
                StreamInterpreters[uid] = lang;
            else
                StreamInterpreters.Add(uid, lang);

            DebugWriter.WriteTime($"UIDChecker. new streamer [{uid}][{lang}]");
        }
        public static void RemoveStreamerInterp(uint uid)
        {
            RemoveFromCheckList(uid);
            StreamInterpreters.Remove(uid);

            DebugWriter.WriteTime($"UIDChecker. streamer [{uid}] has leaving ");
        }

        public static void RemoveFromCheckList(uint uid)
        {
            if (UidLangToCheck.ContainsKey(uid))
                UidLangToCheck.Remove(uid);
        }

        public static bool? IsAuidience(uint uid)
        {
            if (Spectrators.Contains(uid))
                return true;
            else
            {
                if (UidLangToCheck.ContainsKey(uid))
                    return null;
                else
                    return false;
            }
        }
        public static bool IsInterpreter(uint uid)
        {
            return InterpretersNick.ContainsKey(uid);
        }
        public static bool IsInterpreterInMyBoth(uint uid)
        {
            return InterpretersInMyBoth.Contains(uid);
        }
        public static bool IsStreaemer(uint uid)
        {
            return StreamInterpreters.ContainsKey(uid);
        }
        public static bool IsPresident(uint uid)
        { return President.Uid == uid; }
        public static bool IsSecretary(uint uid)
        { return Secretary.Uid == uid; }

        public static void NewPresident(uint uid, string name = "")
        {
            RemovePresident();
            President = (uid, name);
            DebugWriter.WriteTime($"UIDChecker. New president [{name}][{uid}]");
        }
        public static void RemovePresident()
        {
            DebugWriter.WriteTime($"UIDChecker. remove president [{President}]");
            President = (0, "");
        }
        internal static void NewSecretary(uint uid, string name = "")
        {
            RemoveSecretary();
            Secretary = (uid, name);
            DebugWriter.WriteTime($"UIDChecker. New seretary [{name}][{uid}]");
        }
        private static void RemoveSecretary()
        {
            DebugWriter.WriteTime($"UIDChecker. remove seretary [{Secretary}]");
            Secretary = (0, "");
        }

        public static string GetUidLang(uint uid)
        {
            string lang = "";

            if (UidLangToCheck.ContainsKey(uid))
                lang = UidLangToCheck[uid];
            if (StreamInterpreters.ContainsKey(uid))
                lang = StreamInterpreters[uid];

            return lang;
        }
        public static void UpdateUidLang(uint uid, string lang)
        {
            if (UidLangToCheck.ContainsKey(uid))
                UidLangToCheck[uid] = lang;
            if (StreamInterpreters.ContainsKey(uid))
                StreamInterpreters[uid] = lang;
            else
                StreamInterpreters.Add(uid, lang);
        }
        public static string GetUidName(uint uid)
        {
            string name = "";

            if (President.Uid == uid)
                name = President.Name;
            if (InterpretersNick.ContainsKey(uid))
                name = InterpretersNick[uid];

            return name;
        }

    }
}
