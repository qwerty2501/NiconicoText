using Onds.Niconico.Data.Text.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Onds.Niconico.Data.Text
{
    internal sealed class VideoIdNiconicoWebTextSegment:IdNiconicoWebTextSegmentBase,IReadOnlyNiconicoWebTextSegment
    {
        internal VideoIdNiconicoWebTextSegment(string videoId, IReadOnlyNiconicoWebTextSegment parent) : base(videoId,parent) { }


        public override NiconicoWebTextSegmentType SegmentType
        { 
            get { return NiconicoWebTextSegmentType.VideoId; } 
        }



        internal static IReadOnlyNiconicoWebTextSegment ParseWebText(System.Text.RegularExpressions.Match match, NiconicoWebTextSegmenter segmenter, IReadOnlyNiconicoWebTextSegment parent)
        {
            return new VideoIdNiconicoWebTextSegment(match.Groups[NiconicoWebTextPatternIndexs.videoIdGroupNumber].Value,parent);
        }
    }
}
