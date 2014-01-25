using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiconicoText
{
    internal interface INiconicoWebTextSegmentObservableCollection : INiconicoWebTextSegmentCollection,IList<IReadOnlyNiconicoWebTextSegment>, INotifyCollectionChanged
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
