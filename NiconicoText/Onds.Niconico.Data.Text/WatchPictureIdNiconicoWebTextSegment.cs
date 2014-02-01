using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Onds.Niconico.Data.Text
{
    internal sealed class WatchPictureIdNiconicoWebTextSegment<T>:IdNiconicoWebTextSegmentBase<T>,IReadOnlyNiconicoWebTextSegment,INiconicoTextSegment
        where T : IReadOnlyNiconicoWebTextSegment
    {
        internal WatchPictureIdNiconicoWebTextSegment(string pictureId, T parent) : base(pictureId,parent) { }

        public override NiconicoWebTextSegmentType SegmentType
        {
            get { return NiconicoWebTextSegmentType.PictureId; }
        }

        internal static IReadOnlyNiconicoWebTextSegment ParseWebText(System.Text.RegularExpressions.Match match, NiconicoWebTextSegmenter segmenter, T parent)
        {
            return new WatchPictureIdNiconicoWebTextSegment<T>(match.Groups[NiconicoWebTextPatternIndexs.watchPictureIdGroupNumber].Value,parent);
        }
    }
}
