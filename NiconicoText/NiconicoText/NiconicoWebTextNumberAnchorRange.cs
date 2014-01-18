using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiconicoText
{
    /// <summary>
    /// Number anchor range in Niconico web text.
    /// </summary>
    public struct NiconicoWebTextNumberAnchorRange
    {
        /// <summary>
        /// Start number.
        /// </summary>
        public int StartNumber;

        /// <summary>
        /// End number.
        /// If this value is 0, the number anchor is single anchor.
        /// </summary>
        public int EndNumber;

    }
}
