using Onds.Niconico.Data.Text.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Onds.Niconico.Data.Text
{
    internal sealed class ChannelIdNiconicoWebTextSegment<T>:IdNiconicoWebTextSegmentBase<T>,IReadOnlyNiconicoWebTextSegment
        where T:IReadOnlyNiconicoWebTextSegment
    {
        internal ChannelIdNiconicoWebTextSegment(string chanelId,T parent) : base(chanelId,parent) { }

        public override NiconicoWebTextSegmentType SegmentType
        {
            get { return NiconicoWebTextSegmentType.ChanelId; }
        }

        internal static ChannelIdNiconicoWebTextSegment<T> ParseWebText(System.Text.RegularExpressions.Match match, NiconicoWebTextSegmenter segmenter, T parent)
        {
            return new ChannelIdNiconicoWebTextSegment<T>(match.Value,parent);
        }
    }
}
