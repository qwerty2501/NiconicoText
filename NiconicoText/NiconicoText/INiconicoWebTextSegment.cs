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
    public interface INiconicoWebTextSegment:IReadOnlyNiconicoWebTextSegment,INiconicoTextSegment
    {

        /// <summary>
        /// children segments of this text segment.
        /// </summary>
        new INiconicoWebTextSegmentObservableCollection Segments { get; }

        /// <summary>
        /// parent, this segment.
        /// </summary>
        new INiconicoWebTextSegment Parent { get; }
    }
}
