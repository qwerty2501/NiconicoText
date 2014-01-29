using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Onds.Niconico.Data.Text
{
    using Color = NiconicoTextColor;


    /// <summary>
    /// A Segment of Niconico web text read only.
    /// </summary>
    public interface IReadOnlyNiconicoWebTextSegment:INiconicoTextSegment
    {
        /// <summary>
        /// Determines wheter Url Associated with this text segment.
        /// </summary>
        bool HasUrl { get; }

        /// <summary>
        /// Determines wheter has children sements.
        /// </summary>
        bool HasSegments { get; }

        /// <summary>
        /// Segment type.
        /// </summary>
        NiconicoWebTextSegmentType SegmentType { get; }

        /// <summary>
        /// children segments of this text segment.
        /// </summary>
        IReadOnlyList<IReadOnlyNiconicoWebTextSegment> Segments { get; }

        /// <summary>
        /// Determines wheter has number anchor.
        /// </summary>
        bool HasNumberAnchor { get; }

        /// <summary>
        /// Gets, number anchor
        /// </summary>
        NiconicoWebTextNumberAnchorRange NumberAnchor { get; }

        /// <summary>
        /// Size attribute of font element
        /// </summary>
        byte FontElementSize { get; }

        /// <summary>
        /// Determines whether decorated text segment by underline.
        /// </summary>
        bool DecoratedUnderLine { get; }

        /// <summary>
        /// Determines whether decorated text segment by bold.
        /// </summary>
        bool DecoratedBold { get; }

        /// <summary>
        /// Determines whether decorated text segment by strike.
        /// </summary>
        bool DecoratedStrike { get; }

        /// <summary>
        /// Determines wheter decorated text segment by italic.
        /// </summary>
        bool DecoratedItalic { get; }

        /// <summary>
        /// Determines whether color associated with this text segment.
        /// </summary>
        bool DecoratedColor { get; }

        /// <summary>
        /// Color associated with this text segment.
        /// </summary>
        Color Color { get; }

        /// <summary>
        /// Url Associated with this text segment.
        /// </summary>
        Uri Url { get; }

        /// <summary>
        /// Parent segment text of this text segment.
        /// </summary>
        IReadOnlyNiconicoWebTextSegment Parent { get; }
    }
}
