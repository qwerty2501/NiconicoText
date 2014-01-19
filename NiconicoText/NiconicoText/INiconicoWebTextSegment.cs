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
        /// Determine wheter Url Associated with this text segment.
        /// </summary>
        bool HasUrl { get; }

        /// <summary>
        /// Determine wheter has children sements.
        /// </summary>
        bool HasSegments { get; }

        /// <summary>
        /// this text segment type.
        /// </summary>
        NiconicoWebTextSegmentType SegmentType { get; }

        /// <summary>
        /// children segments of this text segment.
        /// </summary>
        INiconicoWebTextSegmentCollection Segments { get; }

        /// <summary>
        /// Determine wheter has number anchor.
        /// </summary>
        bool HasNumberAnchor { get; }

        /// <summary>
        /// Get, number anchor
        /// </summary>
        NiconicoWebTextNumberAnchorRange NumberAnchor { get; }

        /// <summary>
        /// Size attribute of font element
        /// </summary>
        byte FontElementSize { get; }

        /// <summary>
        /// Determine wheter decorated text segment by underline.
        /// </summary>
        bool AssociatedUnderLine { get; }

        /// <summary>
        /// Determine wheter decorated text segment by strike.
        /// </summary>
        bool AssociatedStrike { get; }

        /// <summary>
        /// Determine wheter decorated text segment by italic.
        /// </summary>
        bool AssociatedItalic { get; }

        /// <summary>
        /// Url Associated with this text segment.
        /// </summary>
        Uri Url { get; }

        /// <summary>
        /// Parent segment text of this text segment.
        /// </summary>
        INiconicoWebTextSegment Parent { get; }
    }
}
