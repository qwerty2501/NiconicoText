using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Onds.Niconico.Data.Text
{
    /// <summary>
    /// A Segment of Niconico web text.
    /// </summary>
    public interface INiconicoWebTextSegment:IReadOnlyNiconicoWebTextSegment,INiconicoTextSegment
    {

        /// <summary>
        /// children segments of this text segment.
        /// </summary>
        new INiconicoWebTextSegmentCollection Segments { get; }

        /// <summary>
        /// parent, this segment.
        /// </summary>
        new INiconicoWebTextSegment Parent { get; }
    }
}
