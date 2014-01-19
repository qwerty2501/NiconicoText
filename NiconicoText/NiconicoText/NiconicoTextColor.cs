using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


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
    }
}
