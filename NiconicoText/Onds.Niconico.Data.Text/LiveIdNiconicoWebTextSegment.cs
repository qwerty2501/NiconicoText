using Onds.Niconico.Data.Text.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Onds.Niconico.Data.Text
{
    internal class LiveIdNiconicoWebTextSegment<T>:IdNiconicoWebTextSegmentBase<T>,IReadOnlyNiconicoWebTextSegment
        where T:IReadOnlyNiconicoWebTextSegment
    {
        internal LiveIdNiconicoWebTextSegment(string liveId, T parent) : base(liveId,parent) { }


        public override NiconicoWebTextSegmentType SegmentType
        {
            get { return NiconicoWebTextSegmentType.LiveId; }
        }

        internal static LiveIdNiconicoWebTextSegment<T> ParseWebText(System.Text.RegularExpressions.Match match, NiconicoWebTextSegmenter segmenter, T parent)
        {
            return new LiveIdNiconicoWebTextSegment<T>(match.Groups[NiconicoWebTextPatternIndexs.liveIdGroupNumber].Value,parent);
        }
    }
}
