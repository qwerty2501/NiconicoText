using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NiconicoText
{
    internal sealed class WatchPictureIdNiconicoWebTextSegment:IdNiconicoWebTextSegmentBase,IReadOnlyNiconicoWebTextSegment,INiconicoTextSegment
    {
        internal WatchPictureIdNiconicoWebTextSegment(string pictureId) : base(pictureId) { }

        public override NiconicoWebTextSegmentType SegmentType
        {
            get { return NiconicoWebTextSegmentType.PictureId; }
        }

        internal static IReadOnlyNiconicoWebTextSegment ParseWebText(System.Text.RegularExpressions.Match match, NiconicoWebTextSegmenter segmenter)
        {
            return new WatchPictureIdNiconicoWebTextSegment(match.Groups[NiconicoWebTextPatternIndexs.watchPictureIdGroupNumber].Value);
        }
    }
}
