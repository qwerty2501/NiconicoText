using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Onds.Niconico.Data.Text
{
    internal sealed class HtmlItalicNiconicoWebTextSegment<T>:SegmentsProsessionNiconicoWebTextSegmentBase<T>,IReadOnlyNiconicoWebTextSegment,INiconicoTextSegment
        where T:IReadOnlyNiconicoWebTextSegment
    {
        internal HtmlItalicNiconicoWebTextSegment( T parent) : base(parent) { }

        public new bool DecoratedItalic
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
                return string.Concat("<i>", base.Text, "</i>");
            }
        }

        public override NiconicoWebTextSegmentType SegmentType
        {
            get { return NiconicoWebTextSegmentType.HtmlItalicElement; }
        }

        internal static IReadOnlyNiconicoWebTextSegment ParseWebText(System.Text.RegularExpressions.Match match, NiconicoWebTextSegmenter segmenter, T parent)
        {
            var segment = new HtmlItalicNiconicoWebTextSegment<T>(parent);
            segment.Segments = segmenter.PartialDivide(match.Groups[NiconicoWebTextPatternIndexs.italicTextGroupNumber].Value,segment);
            return segment;
        }
    }
}
