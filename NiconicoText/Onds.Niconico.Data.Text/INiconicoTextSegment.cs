﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Onds.Niconico.Data.Text
{

    
    /// <summary>
    /// A Segment of Niconico text.
    /// </summary>
    public interface INiconicoTextSegment
    {
        /// <summary>
        /// Full text segment.
        /// </summary>
        string Text { get; }

        /// <summary>
        /// User friendly text segment.
        /// </summary>
        string FriendlyText { get; }

        
    }
}
