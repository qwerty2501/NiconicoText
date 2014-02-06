using Onds.Niconico.Data.Text.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Onds.Niconico.Data.Text
{
    internal sealed class CommunityIdNiconicoWebTextSegment<T>:IdNiconicoWebTextSegmentBase<T>,IReadOnlyNiconicoWebTextSegment
        where T : IReadOnlyNiconicoWebTextSegment
    {
        internal CommunityIdNiconicoWebTextSegment(string communityId, T parent) : base(communityId,parent) { }

        public override NiconicoWebTextSegmentType SegmentType
        {
            get { return NiconicoWebTextSegmentType.CommunityId; }
        }

        internal static CommunityIdNiconicoWebTextSegment<T> ParseWebText(System.Text.RegularExpressions.Match match, NiconicoWebTextSegmenter segmenter, T parent)
        {
            return new CommunityIdNiconicoWebTextSegment<T>(match.Value,parent);
        }
    }
}
