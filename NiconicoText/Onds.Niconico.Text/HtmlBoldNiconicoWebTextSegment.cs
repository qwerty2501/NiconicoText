using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Onds.Niconico.Data.Text
{
    internal sealed class HtmlBoldNiconicoWebTextSegment:SegmentsProsessionNiconicoWebTextSegmentBase,IReadOnlyNiconicoWebTextSegment,INiconicoTextSegment
    {
        internal HtmlBoldNiconicoWebTextSegment( IReadOnlyNiconicoWebTextSegment parent) : base(parent) { }

        public new bool DecoratedBold
        {
            get
            {
                return true;
            }
        }

        public override string Text
        {
            get
            {
                return string.Concat("<b>", base.Text, "</b>");
            }
        }

        public override NiconicoWebTextSegmentType SegmentType
        {
            get { return NiconicoWebTextSegmentType.HtmlBoldElement; }
        }

        internal static IReadOnlyNiconicoWebTextSegment ParseWebText(System.Text.RegularExpressions.Match match, NiconicoWebTextSegmenter segmenter, IReadOnlyNiconicoWebTextSegment parent)
        {
            var segment = new HtmlBoldNiconicoWebTextSegment(parent);
            segment.Segments = segmenter.PartialDivide(match.Groups[NiconicoWebTextPatternIndexs.boldTextGroupNumber].Value,segment);
            return segment;
        }
    }
}
