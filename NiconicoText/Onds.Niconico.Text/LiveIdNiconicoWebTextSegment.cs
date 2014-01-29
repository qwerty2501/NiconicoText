using Onds.Niconico.Data.Text.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Onds.Niconico.Data.Text
{
    internal class LiveIdNiconicoWebTextSegment:IdNiconicoWebTextSegmentBase,IReadOnlyNiconicoWebTextSegment
    {
        internal LiveIdNiconicoWebTextSegment(string liveId, IReadOnlyNiconicoWebTextSegment parent) : base(liveId,parent) { }


        public override NiconicoWebTextSegmentType SegmentType
        {
            get { return NiconicoWebTextSegmentType.LiveId; }
        }

        internal static IReadOnlyNiconicoWebTextSegment ParseWebText(System.Text.RegularExpressions.Match match, NiconicoWebTextSegmenter segmenter, IReadOnlyNiconicoWebTextSegment parent)
        {
            return new LiveIdNiconicoWebTextSegment(match.Groups[NiconicoWebTextPatternIndexs.liveIdGroupNumber].Value,parent);
        }
    }
}
