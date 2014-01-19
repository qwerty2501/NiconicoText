using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiconicoText
{
    internal sealed class MarketItemIdNiconicoWebTextSegment:IdNiconicoWebTextSegmentBase,INiconicoWebTextSegment
    {
        internal MarketItemIdNiconicoWebTextSegment(string marketId) : base(marketId) { }

        public override NiconicoWebTextSegmentType SegmentType
        {
            get { return NiconicoWebTextSegmentType.MarketId; }
        }

        internal static INiconicoWebTextSegment ParseWebText(System.Text.RegularExpressions.Match match, NiconicoWebTextSegmenter segmenter)
        {
            return new MarketItemIdNiconicoWebTextSegment(match.Groups[NiconicoWebTextPatternIndexs.marketItemIdGroupNumber].Value);
        }
    }
}
