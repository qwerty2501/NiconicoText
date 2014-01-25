using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiconicoText
{
    internal sealed class PictureIdNiconicoWebTextSegment:IdNiconicoWebTextSegmentBase,IReadOnlyNiconicoWebTextSegment
    {
        internal PictureIdNiconicoWebTextSegment(string pictureId) : base(pictureId) { }

        public override NiconicoWebTextSegmentType SegmentType
        {
            get { return NiconicoWebTextSegmentType.PictureId; }
        }

        internal static IReadOnlyNiconicoWebTextSegment ParseWebText(System.Text.RegularExpressions.Match match, NiconicoWebTextSegmenter segmenter)
        {
            return new PictureIdNiconicoWebTextSegment(match.Groups[NiconicoWebTextPatternIndexs.PictureIdGroupNumber].Value);
        }
    }
}
