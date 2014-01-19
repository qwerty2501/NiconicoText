using NiconicoText.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiconicoText
{
    internal sealed class CommunityIdNiconicoWebTextSegment:IdNiconicoWebTextSegmentBase,INiconicoWebTextSegment
    {
        internal CommunityIdNiconicoWebTextSegment(string communityId) : base(communityId) { }

        public override NiconicoWebTextSegmentType SegmentType
        {
            get { return NiconicoWebTextSegmentType.CommunityId; }
        }

        internal static INiconicoWebTextSegment ParseWebText(System.Text.RegularExpressions.Match match,NiconicoWebTextSegmenter segmenter)
        {
            return new CommunityIdNiconicoWebTextSegment(match.Groups[NiconicoWebTextPatterns.communityIdGroupNumber].Value);
        }
    }
}
