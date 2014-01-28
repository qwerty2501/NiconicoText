using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Onds.Niconico.Text
{
    internal sealed class WatchPictureIdNiconicoWebTextSegment:IdNiconicoWebTextSegmentBase,IReadOnlyNiconicoWebTextSegment,INiconicoTextSegment
    {
        internal WatchPictureIdNiconicoWebTextSegment(string pictureId, IReadOnlyNiconicoWebTextSegment parent) : base(pictureId,parent) { }

        public override NiconicoWebTextSegmentType SegmentType
        {
            get { return NiconicoWebTextSegmentType.PictureId; }
        }

        internal static IReadOnlyNiconicoWebTextSegment ParseWebText(System.Text.RegularExpressions.Match match, NiconicoWebTextSegmenter segmenter, IReadOnlyNiconicoWebTextSegment parent)
        {
            return new WatchPictureIdNiconicoWebTextSegment(match.Groups[NiconicoWebTextPatternIndexs.watchPictureIdGroupNumber].Value,parent);
        }
    }
}
