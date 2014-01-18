using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiconicoText
{

    using Color = NiconicoTextColor;

    /// <summary>
    /// A Segment of Niconico text.
    /// </summary>
    public interface INiconicoTextSegment
    {
        /// <summary>
        /// Full segment of text.
        /// </summary>
        string Text { get; }

        /// <summary>
        /// User friendly segment of text.
        /// </summary>
        string FriendlyText { get; }


        /// <summary>
        /// Color associated with this segment of text.
        /// </summary>
        Color Color { get; }
    }
}
