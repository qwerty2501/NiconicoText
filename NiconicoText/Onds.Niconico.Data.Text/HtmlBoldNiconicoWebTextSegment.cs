using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Onds.Niconico.Data.Text
{
    internal sealed class HtmlBoldNiconicoWebTextSegment<T>:SegmentsProsessionNiconicoWebTextSegmentBase<T>,IReadOnlyNiconicoWebTextSegment,INiconicoTextSegment
        where T : IReadOnlyNiconicoWebTextSegment
    {
        internal HtmlBoldNiconicoWebTextSegment( T parent) : base(parent) { }

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

        internal static IReadOnlyNiconicoWebTextSegment ParseWebText(System.Text.RegularExpressions.Match match, NiconicoWebTextSegmenter segmenter, T parent)
        {
            var segment = new HtmlBoldNiconicoWebTextSegment<T>(parent);
            segment.Segments = segmenter.PartialDivide(match.Groups[NiconicoWebTextPatternIndexs.boldTextGroupNumber].Value,segment);
            return segment;
        }
    }
}
