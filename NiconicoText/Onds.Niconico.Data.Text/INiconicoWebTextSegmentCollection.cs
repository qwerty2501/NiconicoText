using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;


namespace Onds.Niconico.Data.Text
{
    public interface INiconicoWebTextSegmentCollection : IList<INiconicoWebTextSegment>, INotifyCollectionChanged
    {
        /// <summary>
        /// Create a Friendly String.
        /// </summary>
        /// <returns></returns>
        string ToFriendlyString();
    }

    internal static class NiconicoSegmentsExtention
    {
        internal static string ToText<T>(this IReadOnlyList<T> self)
            where T:IReadOnlyNiconicoWebTextSegment
        {
            return string.Concat(self.Select((item) => item.Text));
        }

        internal static string ToFriendlyText<T>(this IReadOnlyList<T> self)
            where T:IReadOnlyNiconicoWebTextSegment
        {
            return string.Concat(self.Select((item) => item.FriendlyText));
        }
    }
}
