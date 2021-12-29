using System.Drawing;

namespace RSI_X_Desktop.forms
{
    public class Constants
    {
        public enum DPI
        {
            P100 = 96,
            P125 = 120,
            P150 = 144,
            P175 = 168
        }
        public static Font Bahnschrift24 { get => new Font("Bahnschrift Condensed", 24F); }
        public static Font Bahnschrift22 { get => new Font("Bahnschrift Condensed", 22F); }
        public static Font Bahnschrift20 { get => new Font("Bahnschrift Condensed", 20F); }
        public static Font Bahnschrift18 { get => new Font("Bahnschrift Condensed", 18F); }
        public static Font Bahnschrift16 { get => new Font("Bahnschrift Condensed", 16F); }
        public static Font Bahnschrift14 { get => new Font("Bahnschrift Condensed", 14F); }
        public static Font Bahnschrift12 { get => new Font("Bahnschrift Condensed", 12F); }
    }
}
