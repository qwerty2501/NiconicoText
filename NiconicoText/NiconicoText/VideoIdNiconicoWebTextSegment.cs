using NiconicoText.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiconicoText
{
    internal sealed class VideoIdNiconicoWebTextSegment:IdNiconicoWebTextSegmentBase,IReadOnlyNiconicoWebTextSegment
    {
        internal VideoIdNiconicoWebTextSegment(string videoId) : base(videoId) { }


        public override NiconicoWebTextSegmentType SegmentType
        { 
            get { return NiconicoWebTextSegmentType.VideoId; } 
        }



        internal static IReadOnlyNiconicoWebTextSegment ParseWebText(System.Text.RegularExpressions.Match match, NiconicoWebTextSegmenter segmenter)
        {
            return new VideoIdNiconicoWebTextSegment(match.Groups[NiconicoWebTextPatternIndexs.videoIdGroupNumber].Value);
        }
    }
}
