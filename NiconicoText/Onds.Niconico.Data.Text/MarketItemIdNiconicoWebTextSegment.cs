using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Onds.Niconico.Data.Text
{
    internal sealed class MarketItemIdNiconicoWebTextSegment<T>:IdNiconicoWebTextSegmentBase<T>,IReadOnlyNiconicoWebTextSegment
        where T : IReadOnlyNiconicoWebTextSegment
    {
        internal MarketItemIdNiconicoWebTextSegment(string marketId, T parent) : base(marketId,parent) { }

        public override NiconicoWebTextSegmentType SegmentType
        {
            get { return NiconicoWebTextSegmentType.MarketId; }
        }

        internal static MarketItemIdNiconicoWebTextSegment<T> ParseWebText(System.Text.RegularExpressions.Match match, NiconicoWebTextSegmenter segmenter, T parent)
        {
            return new MarketItemIdNiconicoWebTextSegment<T>(match.Value,parent);
        }
    }
}
