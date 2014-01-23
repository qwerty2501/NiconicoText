using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiconicoText
{
    interface INiconicoWebTextSegmentCollection:IList<INiconicoWebTextSegment>
    {
        /// <summary>
        /// Create a Friendly String.
        /// </summary>
        /// <returns></returns>
        string ToFriendlyString();
    }
}
