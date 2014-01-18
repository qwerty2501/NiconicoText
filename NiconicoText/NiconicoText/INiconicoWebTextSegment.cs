using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiconicoText
{
    /// <summary>
    /// A Segment of Niconico web text.
    /// </summary>
    public interface INiconicoWebTextSegment:INiconicoTextSegment
    {
        /// <summary>
        /// Determine wheter Url Associated with this segment of text.
        /// </summary>
        bool HasAssociatedUrl { get; }

        /// <summary>
        /// Size attribute of font element
        /// </summary>
        byte FontSize { get; }

        /// <summary>
        /// Url Associated with this sgment of text.
        /// </summary>
        Uri Url { get; }

        /// <summary>
        /// Parent segment text of this segment text
        /// </summary>
        INiconicoWebTextSegment Parent { get; }
    }
}
