using NiconicoText.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiconicoText
{
    internal class LiveIdNiconicoWebTextSegment:IdNiconicoWebTextSegmentBase,IReadOnlyNiconicoWebTextSegment
    {
        internal LiveIdNiconicoWebTextSegment(string liveId) : base(liveId) { }


        public override NiconicoWebTextSegmentType SegmentType
        {
            get { return NiconicoWebTextSegmentType.LiveId; }
        }

        internal static IReadOnlyNiconicoWebTextSegment ParseWebText(System.Text.RegularExpressions.Match match, NiconicoWebTextSegmenter segmenter)
        {
            return new LiveIdNiconicoWebTextSegment(match.Groups[NiconicoWebTextPatternIndexs.liveIdGroupNumber].Value);
        }
    }
}
