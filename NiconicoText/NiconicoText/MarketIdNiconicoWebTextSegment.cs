using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiconicoText
{
    internal sealed class MarketIdNiconicoWebTextSegment:IdNiconicoWebTextSegmentBase,INiconicoWebTextSegment
    {
        internal MarketIdNiconicoWebTextSegment(string marketId) : base(marketId) { }

        public override NiconicoWebTextSegmentType SegmentType
        {
            get { return NiconicoWebTextSegmentType.MarketId; }
        }
    }
}
