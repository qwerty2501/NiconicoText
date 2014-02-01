using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Onds.Niconico.Data.Text
{
    internal sealed class PictureIdNiconicoWebTextSegment<T>:IdNiconicoWebTextSegmentBase<T>,IReadOnlyNiconicoWebTextSegment
        where T : IReadOnlyNiconicoWebTextSegment
    {
        internal PictureIdNiconicoWebTextSegment(string pictureId, T parent) : base(pictureId,parent) { }

        public override NiconicoWebTextSegmentType SegmentType
        {
            get { return NiconicoWebTextSegmentType.PictureId; }
        }

        internal static IReadOnlyNiconicoWebTextSegment ParseWebText(System.Text.RegularExpressions.Match match, NiconicoWebTextSegmenter segmenter, T parent)
        {
            return new PictureIdNiconicoWebTextSegment<T>(match.Groups[NiconicoWebTextPatternIndexs.PictureIdGroupNumber].Value,parent);
        }
    }
}
