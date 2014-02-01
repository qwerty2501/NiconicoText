using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Onds.Niconico.Data.Text
{
    internal sealed class HtmlUnderLineNiconicoWebTextSegment<T>:SegmentsProsessionNiconicoWebTextSegmentBase<T>,IReadOnlyNiconicoWebTextSegment,INiconicoTextSegment
        where T : IReadOnlyNiconicoWebTextSegment
    {
        internal HtmlUnderLineNiconicoWebTextSegment( T parent) : base(parent) { }

        public new bool DecoratedUnderLine
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
                return string.Concat("<u>", base.Text, "</u>");
            }
        }

        public override NiconicoWebTextSegmentType SegmentType
        {
            get { return NiconicoWebTextSegmentType.HtmlUnderLineElement; }
        }

        internal static IReadOnlyNiconicoWebTextSegment ParseWebText(System.Text.RegularExpressions.Match match, NiconicoWebTextSegmenter segmenter, T parent)
        {
            var segment = new HtmlUnderLineNiconicoWebTextSegment<T>(parent);
            segment.Segments = segmenter.PartialDivide(match.Groups[NiconicoWebTextPatternIndexs.underLineTextGroupNumber].Value,segment);
            return segment;
        }
    }
}
