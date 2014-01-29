using Onds.Niconico.Data.Text.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Onds.Niconico.Data.Text
{
    internal sealed class CommunityIdNiconicoWebTextSegment:IdNiconicoWebTextSegmentBase,IReadOnlyNiconicoWebTextSegment
    {
        internal CommunityIdNiconicoWebTextSegment(string communityId, IReadOnlyNiconicoWebTextSegment parent) : base(communityId,parent) { }

        public override NiconicoWebTextSegmentType SegmentType
        {
            get { return NiconicoWebTextSegmentType.CommunityId; }
        }

        internal static IReadOnlyNiconicoWebTextSegment ParseWebText(System.Text.RegularExpressions.Match match, NiconicoWebTextSegmenter segmenter, IReadOnlyNiconicoWebTextSegment parent)
        {
            return new CommunityIdNiconicoWebTextSegment(match.Groups[NiconicoWebTextPatternIndexs.communityIdGroupNumber].Value,parent);
        }
    }
}
