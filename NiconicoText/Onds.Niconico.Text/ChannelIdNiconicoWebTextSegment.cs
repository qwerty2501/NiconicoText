using Onds.Niconico.Text.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Onds.Niconico.Text
{
    internal sealed class ChannelIdNiconicoWebTextSegment:IdNiconicoWebTextSegmentBase,IReadOnlyNiconicoWebTextSegment
    {
        internal ChannelIdNiconicoWebTextSegment(string chanelId,IReadOnlyNiconicoWebTextSegment parent) : base(chanelId,parent) { }

        public override NiconicoWebTextSegmentType SegmentType
        {
            get { return NiconicoWebTextSegmentType.ChanelId; }
        }

        internal static IReadOnlyNiconicoWebTextSegment ParseWebText(System.Text.RegularExpressions.Match match, NiconicoWebTextSegmenter segmenter, IReadOnlyNiconicoWebTextSegment parent)
        {
            return new ChannelIdNiconicoWebTextSegment(match.Groups[NiconicoWebTextPatternIndexs.channelIdGroupNumber].Value,parent);
        }
    }
}
