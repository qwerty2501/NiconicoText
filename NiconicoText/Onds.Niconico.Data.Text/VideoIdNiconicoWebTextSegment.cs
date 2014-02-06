using Onds.Niconico.Data.Text.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Onds.Niconico.Data.Text
{
    internal sealed class VideoIdNiconicoWebTextSegment<T>:IdNiconicoWebTextSegmentBase<T>,IReadOnlyNiconicoWebTextSegment
        where T : IReadOnlyNiconicoWebTextSegment
    {
        internal VideoIdNiconicoWebTextSegment(string videoId, T parent) : base(videoId,parent) { }


        public override NiconicoWebTextSegmentType SegmentType
        { 
            get { return NiconicoWebTextSegmentType.VideoId; } 
        }



        internal static VideoIdNiconicoWebTextSegment<T> ParseWebText(System.Text.RegularExpressions.Match match, NiconicoWebTextSegmenter segmenter, T parent)
        {
            return new VideoIdNiconicoWebTextSegment<T>(match.Value,parent);
        }
    }
}
