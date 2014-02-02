using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Globalization;

namespace Onds.Niconico.Data.Text
{
    /// <summary>
    /// Niconico text's color.
    /// </summary>
    public struct NiconicoTextColor
    {
        /// <summary>
        /// Red
        /// </summary>
        public byte R;

        /// <summary>
        /// Green
        /// </summary>
        public byte G;

        /// <summary>
        /// Blue
        /// </summary>
        public byte B;

    }

    public static class NiconicoTextColorExtention
    {
        public static string ToColorCode(this NiconicoTextColor self)
        {
            return string.Format("#{0,0:X2}{1,0:X2}{2,0:X2}", self.R, self.G, self.B);

        }

        public static NiconicoTextColor CommentColorWhite
        {
            get { return new NiconicoTextColor { R = 0xFF, G = 0xFF, B = 0xFF }; }
        }

        public static NiconicoTextColor CommentColorBlack
        {
            get { return new NiconicoTextColor { R = 0x00, G = 0x00, B = 0x00 }; }
        }

        public static NiconicoTextColor CommentColorRed
        {
            get { return new NiconicoTextColor { R = 0xFF, G = 0x00, B = 0x00 }; }
        }

        public static NiconicoTextColor CommentColorPink
        {
            get { return new NiconicoTextColor { R = 0xFF, G = 0x80, B = 0x80 }; }
        }

        public static NiconicoTextColor CommentColorOrange
        {
            get { return new NiconicoTextColor { R = 0xFF, G = 0xC0, B = 0x00 }; }
        }

        public static NiconicoTextColor CommentColorYellow
        {
            get{return new NiconicoTextColor{ R=0xFF , G=0xFF , B=0x00 }; }   
        }

        public static NiconicoTextColor CommentColorGreen
        {
            get { return new NiconicoTextColor { R = 0x00, G = 0xFF, B = 0x00 }; }
        }

        public static NiconicoTextColor CommentColorCyan
        {
            get { return new NiconicoTextColor { R = 0x00, G = 0xFF, B = 0xFF }; }
        }

        public static NiconicoTextColor CommentColorBlue
        {
            get { return new NiconicoTextColor { R = 0x00, G = 0x00, B = 0xFF }; }
        }

        public static NiconicoTextColor CommentColorPurple
        {
            get { return new NiconicoTextColor { R = 0xC0, G = 0x00, B = 0xFF }; }
        }

        public static NiconicoTextColor CommentColorWhite2
        {
            get { return new NiconicoTextColor { R = 0xCC, G = 0xCC, B = 0x99 }; }
        }

        public static NiconicoTextColor CommentColorRed2
        {
            get { return new NiconicoTextColor { R = 0xCC, G = 0x00, B = 0x33 }; }
        }

        public static NiconicoTextColor CommentColorPink2
        {
            get { return new NiconicoTextColor { R = 0xFF, G = 0x33, B = 0xCC }; }
        }

        public static NiconicoTextColor CommentColorOrange2
        {
            get { return new NiconicoTextColor { R = 0xFF, G = 0x66, B = 0x00 }; }
        }

        public static NiconicoTextColor CommentColorYellow2
        {
            get { return new NiconicoTextColor { R = 0x99, G = 0x99, B = 0x00 }; }
        }

        public static NiconicoTextColor CommentColorGreen2
        {
            get { return new NiconicoTextColor { R = 0x00, G = 0xCC, B = 0x66 }; }
        }

        public static NiconicoTextColor CommentColorCyan2
        {
            get { return new NiconicoTextColor { R = 0x00, G = 0xCC, B = 0xCC }; }
        }

        public static NiconicoTextColor CommentColorBlue2
        {
            get { return new NiconicoTextColor { R = 0x33, G = 0x99, B = 0xFF }; }
        }

        public static NiconicoTextColor CommentColorPurple2
        {
            get { return new NiconicoTextColor { R = 0x66, G = 0x33, B = 0xCC }; }
        }

        public static NiconicoTextColor CommentColorBlack2
        {
            get { return new NiconicoTextColor { R = 0x66, G = 0x66, B = 0x66 }; }
        }



        internal static NiconicoTextColor FromColorCode(string code)
        {
            return new NiconicoTextColor {
                                            R = byte.Parse(code.Substring(1,2),NumberStyles.HexNumber),
                                            G = byte.Parse(code.Substring(3,2),NumberStyles.HexNumber),
                                            B = byte.Parse(code.Substring(5,2),NumberStyles.HexNumber) 
                                        };
        }

        internal static NiconicoTextColor FromCommentColorName(string name)
        {
            switch (name.ToLower())
            {
                case "black":
                    return CommentColorBlack;

                case "white":
                    return CommentColorWhite;

                case "red":
                    return CommentColorOrange;

                case "pink":
                    return CommentColorPink;

                case "yellow":
                    return CommentColorYellow;

                case "green":
                    return CommentColorGreen;

                case "cyan":
                    return CommentColorCyan;

                case "purple":
                    return CommentColorPurple;

                case "white2":
                case "niconicowhite":
                    return CommentColorWhite2;

                case "red2":
                case "truered":
                    return CommentColorRed2;

                case "pink2":
                    return CommentColorPink2;

                case "orange2":
                case "passionorange":
                    return CommentColorOrange2;

                case "green2":
                case "elementalgreen":
                    return CommentColorGreen2;

                case "cyan2":
                    return CommentColorCyan2;

                case "blue2":
                    return CommentColorBlue2;

                case "purple2":
                case "nobleviolet":
                    return CommentColorPurple2;

                case "black2":
                    return CommentColorBlack2;

                default:
                    return CommentColorWhite;

            }
        }

        internal static NiconicoTextColor FromColorName(string name)
        {
            switch (name.ToLower())
            {
                case "aliceblue":
                    return new NiconicoTextColor { R = 240, G = 248, B = 255 };
                case "antiquewhite":
                    return new NiconicoTextColor { R = 250, G = 235, B = 215 };
                case "aqua":
                    return new NiconicoTextColor { R = 0, G = 255, B = 255 };
                case "aquamarine":
                    return new NiconicoTextColor { R = 127, G = 255, B = 212 };
                case "azure":
                    return new NiconicoTextColor { R = 240, G = 255, B = 255 };
                case "beige":
                    return new NiconicoTextColor { R = 245, G = 245, B = 220 };
                case "bisque":
                    return new NiconicoTextColor { R = 255, G = 228, B = 196 };
                case "black":
                    return new NiconicoTextColor { R = 0, G = 0, B = 0 };
                case "blanchedalmond":
                    return new NiconicoTextColor { R = 255, G = 235, B = 205 };
                case "blue":
                    return new NiconicoTextColor { R = 0, G = 0, B = 255 };
                case "blueviolet":
                    return new NiconicoTextColor { R = 138, G = 43, B = 226 };
                case "brown":
                    return new NiconicoTextColor { R = 165, G = 42, B = 42 };
                case "burlywood":
                    return new NiconicoTextColor { R = 222, G = 184, B = 135 };
                case "cadetblue":
                    return new NiconicoTextColor { R = 95, G = 158, B = 160 };
                case "chartreuse":
                    return new NiconicoTextColor { R = 127, G = 255, B = 0 };
                case "chocolate":
                    return new NiconicoTextColor { R = 210, G = 105, B = 30 };
                case "coral":
                    return new NiconicoTextColor { R = 255, G = 127, B = 80 };
                case "cornflowerblue":
                    return new NiconicoTextColor { R = 100, G = 149, B = 237 };
                case "cornsilk":
                    return new NiconicoTextColor { R = 255, G = 248, B = 220 };
                case "crimson":
                    return new NiconicoTextColor { R = 220, G = 20, B = 60 };
                case "cyan":
                    return new NiconicoTextColor { R = 0, G = 255, B = 255 };
                case "darkblue":
                    return new NiconicoTextColor { R = 0, G = 0, B = 139 };
                case "darkcyan":
                    return new NiconicoTextColor { R = 0, G = 139, B = 139 };
                case "darkgoldenrod":
                    return new NiconicoTextColor { R = 184, G = 134, B = 11 };
                case "darkgray":
                    return new NiconicoTextColor { R = 169, G = 169, B = 169 };
                case "darkgreen":
                    return new NiconicoTextColor { R = 0, G = 100, B = 0 };
                case "darkkhaki":
                    return new NiconicoTextColor { R = 189, G = 183, B = 107 };
                case "darkmagenta":
                    return new NiconicoTextColor { R = 139, G = 0, B = 139 };
                case "darkolivegreen":
                    return new NiconicoTextColor { R = 85, G = 107, B = 47 };
                case "darkorange":
                    return new NiconicoTextColor { R = 255, G = 140, B = 0 };
                case "darkorchid":
                    return new NiconicoTextColor { R = 153, G = 50, B = 204 };
                case "darkred":
                    return new NiconicoTextColor { R = 139, G = 0, B = 0 };
                case "darksalmon":
                    return new NiconicoTextColor { R = 233, G = 150, B = 122 };
                case "darkseagreen":
                    return new NiconicoTextColor { R = 143, G = 188, B = 143 };
                case "darkslateblue":
                    return new NiconicoTextColor { R = 72, G = 61, B = 139 };
                case "darkslategray":
                    return new NiconicoTextColor { R = 47, G = 79, B = 79 };
                case "darkturquoise":
                    return new NiconicoTextColor { R = 0, G = 206, B = 209 };
                case "darkviolet":
                    return new NiconicoTextColor { R = 148, G = 0, B = 211 };
                case "deeppink":
                    return new NiconicoTextColor { R = 255, G = 20, B = 147 };
                case "deepskyblue":
                    return new NiconicoTextColor { R = 0, G = 191, B = 255 };
                case "dimgray":
                    return new NiconicoTextColor { R = 105, G = 105, B = 105 };
                case "dodgerblue":
                    return new NiconicoTextColor { R = 30, G = 144, B = 255 };
                case "firebrick":
                    return new NiconicoTextColor { R = 178, G = 34, B = 34 };
                case "floralwhite":
                    return new NiconicoTextColor { R = 255, G = 250, B = 240 };
                case "forestgreen":
                    return new NiconicoTextColor { R = 34, G = 139, B = 34 };
                case "fuchsia":
                    return new NiconicoTextColor { R = 255, G = 0, B = 255 };
                case "gainsboro":
                    return new NiconicoTextColor { R = 220, G = 220, B = 220 };
                case "ghostwhite":
                    return new NiconicoTextColor { R = 248, G = 248, B = 255 };
                case "gold":
                    return new NiconicoTextColor { R = 255, G = 215, B = 0 };
                case "goldenrod":
                    return new NiconicoTextColor { R = 218, G = 165, B = 32 };
                case "gray":
                    return new NiconicoTextColor { R = 128, G = 128, B = 128 };
                case "green":
                    return new NiconicoTextColor { R = 0, G = 128, B = 0 };
                case "greenyellow":
                    return new NiconicoTextColor { R = 173, G = 255, B = 47 };
                case "honeydew":
                    return new NiconicoTextColor { R = 240, G = 255, B = 240 };
                case "hotpink":
                    return new NiconicoTextColor { R = 255, G = 105, B = 180 };
                case "indianred":
                    return new NiconicoTextColor { R = 205, G = 92, B = 92 };
                case "indigo":
                    return new NiconicoTextColor { R = 75, G = 0, B = 130 };
                case "ivory":
                    return new NiconicoTextColor { R = 255, G = 255, B = 240 };
                case "khaki":
                    return new NiconicoTextColor { R = 240, G = 230, B = 140 };
                case "lavender":
                    return new NiconicoTextColor { R = 230, G = 230, B = 250 };
                case "lavenderblush":
                    return new NiconicoTextColor { R = 255, G = 240, B = 245 };
                case "lawngreen":
                    return new NiconicoTextColor { R = 124, G = 252, B = 0 };
                case "lemonchiffon":
                    return new NiconicoTextColor { R = 255, G = 250, B = 205 };
                case "lightblue":
                    return new NiconicoTextColor { R = 173, G = 216, B = 230 };
                case "lightcoral":
                    return new NiconicoTextColor { R = 240, G = 128, B = 128 };
                case "lightcyan":
                    return new NiconicoTextColor { R = 224, G = 255, B = 255 };
                case "lightgoldenrodyellow":
                    return new NiconicoTextColor { R = 250, G = 250, B = 210 };
                case "lightgray":
                    return new NiconicoTextColor { R = 211, G = 211, B = 211 };
                case "lightgreen":
                    return new NiconicoTextColor { R = 144, G = 238, B = 144 };
                case "lightpink":
                    return new NiconicoTextColor { R = 255, G = 182, B = 193 };
                case "lightsalmon":
                    return new NiconicoTextColor { R = 255, G = 160, B = 122 };
                case "lightseagreen":
                    return new NiconicoTextColor { R = 32, G = 178, B = 170 };
                case "lightskyblue":
                    return new NiconicoTextColor { R = 135, G = 206, B = 250 };
                case "lightslategray":
                    return new NiconicoTextColor { R = 119, G = 136, B = 153 };
                case "lightsteelblue":
                    return new NiconicoTextColor { R = 176, G = 196, B = 222 };
                case "lightyellow":
                    return new NiconicoTextColor { R = 255, G = 255, B = 224 };
                case "lime":
                    return new NiconicoTextColor { R = 0, G = 255, B = 0 };
                case "limegreen":
                    return new NiconicoTextColor { R = 50, G = 205, B = 50 };
                case "linen":
                    return new NiconicoTextColor { R = 250, G = 240, B = 230 };
                case "magenta":
                    return new NiconicoTextColor { R = 255, G = 0, B = 255 };
                case "maroon":
                    return new NiconicoTextColor { R = 128, G = 0, B = 0 };
                case "mediumaquamarine":
                    return new NiconicoTextColor { R = 102, G = 205, B = 170 };
                case "mediumblue":
                    return new NiconicoTextColor { R = 0, G = 0, B = 205 };
                case "mediumorchid":
                    return new NiconicoTextColor { R = 186, G = 85, B = 211 };
                case "mediumpurple":
                    return new NiconicoTextColor { R = 147, G = 112, B = 219 };
                case "mediumseagreen":
                    return new NiconicoTextColor { R = 60, G = 179, B = 113 };
                case "mediumslateblue":
                    return new NiconicoTextColor { R = 123, G = 104, B = 238 };
                case "mediumspringgreen":
                    return new NiconicoTextColor { R = 0, G = 250, B = 154 };
                case "mediumturquoise":
                    return new NiconicoTextColor { R = 72, G = 209, B = 204 };
                case "mediumvioletred":
                    return new NiconicoTextColor { R = 199, G = 21, B = 133 };
                case "midnightblue":
                    return new NiconicoTextColor { R = 25, G = 25, B = 112 };
                case "mintcream":
                    return new NiconicoTextColor { R = 245, G = 255, B = 250 };
                case "mistyrose":
                    return new NiconicoTextColor { R = 255, G = 228, B = 225 };
                case "moccasin":
                    return new NiconicoTextColor { R = 255, G = 228, B = 181 };
                case "navajowhite":
                    return new NiconicoTextColor { R = 255, G = 222, B = 173 };
                case "navy":
                    return new NiconicoTextColor { R = 0, G = 0, B = 128 };
                case "oldlace":
                    return new NiconicoTextColor { R = 253, G = 245, B = 230 };
                case "olive":
                    return new NiconicoTextColor { R = 128, G = 128, B = 0 };
                case "olivedrab":
                    return new NiconicoTextColor { R = 107, G = 142, B = 35 };
                case "orange":
                    return new NiconicoTextColor { R = 255, G = 165, B = 0 };
                case "orangered":
                    return new NiconicoTextColor { R = 255, G = 69, B = 0 };
                case "orchid":
                    return new NiconicoTextColor { R = 218, G = 112, B = 214 };
                case "palegoldenrod":
                    return new NiconicoTextColor { R = 238, G = 232, B = 170 };
                case "palegreen":
                    return new NiconicoTextColor { R = 152, G = 251, B = 152 };
                case "paleturquoise":
                    return new NiconicoTextColor { R = 175, G = 238, B = 238 };
                case "palevioletred":
                    return new NiconicoTextColor { R = 219, G = 112, B = 147 };
                case "papayawhip":
                    return new NiconicoTextColor { R = 255, G = 239, B = 213 };
                case "peachpuff":
                    return new NiconicoTextColor { R = 255, G = 218, B = 185 };
                case "peru":
                    return new NiconicoTextColor { R = 205, G = 133, B = 63 };
                case "pink":
                    return new NiconicoTextColor { R = 255, G = 192, B = 203 };
                case "plum":
                    return new NiconicoTextColor { R = 221, G = 160, B = 221 };
                case "powderblue":
                    return new NiconicoTextColor { R = 176, G = 224, B = 230 };
                case "purple":
                    return new NiconicoTextColor { R = 128, G = 0, B = 128 };
                case "red":
                    return new NiconicoTextColor { R = 255, G = 0, B = 0 };
                case "rosybrown":
                    return new NiconicoTextColor { R = 188, G = 143, B = 143 };
                case "royalblue":
                    return new NiconicoTextColor { R = 65, G = 105, B = 225 };
                case "saddlebrown":
                    return new NiconicoTextColor { R = 139, G = 69, B = 19 };
                case "salmon":
                    return new NiconicoTextColor { R = 250, G = 128, B = 114 };
                case "sandybrown":
                    return new NiconicoTextColor { R = 244, G = 164, B = 96 };
                case "seagreen":
                    return new NiconicoTextColor { R = 46, G = 139, B = 87 };
                case "seashell":
                    return new NiconicoTextColor { R = 255, G = 245, B = 238 };
                case "sienna":
                    return new NiconicoTextColor { R = 160, G = 82, B = 45 };
                case "silver":
                    return new NiconicoTextColor { R = 192, G = 192, B = 192 };
                case "skyblue":
                    return new NiconicoTextColor { R = 135, G = 206, B = 235 };
                case "slateblue":
                    return new NiconicoTextColor { R = 106, G = 90, B = 205 };
                case "slategray":
                    return new NiconicoTextColor { R = 112, G = 128, B = 144 };
                case "snow":
                    return new NiconicoTextColor { R = 255, G = 250, B = 250 };
                case "springgreen":
                    return new NiconicoTextColor { R = 0, G = 255, B = 127 };
                case "steelblue":
                    return new NiconicoTextColor { R = 70, G = 130, B = 180 };
                case "tan":
                    return new NiconicoTextColor { R = 210, G = 180, B = 140 };
                case "teal":
                    return new NiconicoTextColor { R = 0, G = 128, B = 128 };
                case "thistle":
                    return new NiconicoTextColor { R = 216, G = 191, B = 216 };
                case "tomato":
                    return new NiconicoTextColor { R = 255, G = 99, B = 71 };
                case "transparent":
                    return new NiconicoTextColor { R = 255, G = 255, B = 255 };
                case "turquoise":
                    return new NiconicoTextColor { R = 64, G = 224, B = 208 };
                case "violet":
                    return new NiconicoTextColor { R = 238, G = 130, B = 238 };
                case "wheat":
                    return new NiconicoTextColor { R = 245, G = 222, B = 179 };
                case "white":
                    return new NiconicoTextColor { R = 255, G = 255, B = 255 };
                case "whitesmoke":
                    return new NiconicoTextColor { R = 245, G = 245, B = 245 };
                case "yellow":
                    return new NiconicoTextColor { R = 255, G = 255, B = 0 };
                case "yellowgreen":
                    return new NiconicoTextColor { R = 154, G = 205, B = 50 };

                default:
                    return default(NiconicoTextColor);
            }
		
        }

        
    }
}
