using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiconicoText
{
    internal sealed class MarketItemIdNiconicoWebTextSegment:IdNiconicoWebTextSegmentBase,IReadOnlyNiconicoWebTextSegment
    {
        internal MarketItemIdNiconicoWebTextSegment(string marketId, IReadOnlyNiconicoWebTextSegment parent) : base(marketId,parent) { }

        public override NiconicoWebTextSegmentType SegmentType
        {
            get { return NiconicoWebTextSegmentType.MarketId; }
        }

        internal static IReadOnlyNiconicoWebTextSegment ParseWebText(System.Text.RegularExpressions.Match match, NiconicoWebTextSegmenter segmenter, IReadOnlyNiconicoWebTextSegment parent)
        {
            return new MarketItemIdNiconicoWebTextSegment(match.Groups[NiconicoWebTextPatternIndexs.marketItemIdGroupNumber].Value,parent);
        }
    }
}
