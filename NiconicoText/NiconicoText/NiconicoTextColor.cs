using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace NiconicoText
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
            return string.Concat("#", Convert.ToString(self.R, 16), Convert.ToString(self.G, 16), Convert.ToString(self.B, 16));
        }

        internal static NiconicoTextColor FromColorCode(string code)
        {
            return new NiconicoTextColor {
                                            R = byte.Parse(code.Substring(1,2),NumberStyles.HexNumber),
                                            G = byte.Parse(code.Substring(3,2),NumberStyles.HexNumber),
                                            B = byte.Parse(code.Substring(5,2),NumberStyles.HexNumber) 
                                        };
        }

        internal static NiconicoTextColor FromeColorName(string name)
        {
            return default(NiconicoTextColor);
        }
    }
}
