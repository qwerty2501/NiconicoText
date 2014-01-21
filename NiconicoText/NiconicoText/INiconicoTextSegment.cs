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
        /// Full text segment.
        /// </summary>
        string Text { get; }

        /// <summary>
        /// User friendly text segment.
        /// </summary>
        string FriendlyText { get; }

        /// <summary>
        /// Determine whether color associated with this text segment.
        /// </summary>
        bool DecoratedColor { get; }

        /// <summary>
        /// Color associated with this text segment.
        /// </summary>
        Color Color { get; }
    }
}
