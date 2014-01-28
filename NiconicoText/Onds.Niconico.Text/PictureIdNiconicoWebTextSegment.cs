using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onds.Niconico.Text
{
    internal sealed class PictureIdNiconicoWebTextSegment:IdNiconicoWebTextSegmentBase,IReadOnlyNiconicoWebTextSegment
    {
        internal PictureIdNiconicoWebTextSegment(string pictureId, IReadOnlyNiconicoWebTextSegment parent) : base(pictureId,parent) { }

        public override NiconicoWebTextSegmentType SegmentType
        {
            get { return NiconicoWebTextSegmentType.PictureId; }
        }

        internal static IReadOnlyNiconicoWebTextSegment ParseWebText(System.Text.RegularExpressions.Match match, NiconicoWebTextSegmenter segmenter, IReadOnlyNiconicoWebTextSegment parent)
        {
            return new PictureIdNiconicoWebTextSegment(match.Groups[NiconicoWebTextPatternIndexs.PictureIdGroupNumber].Value,parent);
        }
    }
}
