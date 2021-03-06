﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Onds.Niconico.Data.Text
{
    /// <summary>
    /// Number anchor range in Niconico web text.
    /// </summary>
    /// <remarks>
    /// If this StartNumber and EndNumber are 0,the number anchor is invalid.
    /// </remarks>
    public struct NiconicoWebTextNumberAnchorRange
    {
        /// <summary>
        /// Start number.
        /// </summary>
        public int StartNumber;

        /// <summary>
        /// End number.
        /// </summary>
        /// <remarks>
        /// If this value only is 0, the number anchor is single anchor.
        /// </remarks>
        public int EndNumber;

    }
}
