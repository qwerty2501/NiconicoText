using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#if NETFX_CORE

using Color = Windows.UI.Color;

#endif

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
}
