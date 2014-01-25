using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiconicoText
{
    interface INiconicoWebTextSegmentCollection:IList<IReadOnlyNiconicoWebTextSegment>
    {
        /// <summary>
        /// Create a Friendly String.
        /// </summary>
        /// <returns></returns>
        string ToFriendlyString();
    }


    internal static class NiconicoSegmentsExtention
    {
        internal static string ToText(this IEnumerable<IReadOnlyNiconicoWebTextSegment> self)
        {
            return string.Concat(self.Select((item) => item.Text));
        }

        internal static string ToFriendlyText(this IEnumerable<IReadOnlyNiconicoWebTextSegment> self)
        {
            return string.Concat(self.Select((item) => item.FriendlyText));
        }
    }
}
