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
        /// Determine wheter Url Associated with this text.
        /// </summary>
        bool HasAssociatedUrl { get; }

        /// <summary>
        /// Url Associated with this text.
        /// </summary>
        Uri AssociatedUrl { get; }
    }
}
