using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Onds.Niconico.Data.Text
{
    internal sealed class HtmlStrikeNiconicoWebTextSegment:SegmentsProsessionNiconicoWebTextSegmentBase,IReadOnlyNiconicoWebTextSegment,INiconicoTextSegment
    {
        internal HtmlStrikeNiconicoWebTextSegment( IReadOnlyNiconicoWebTextSegment parent) : base(parent) { }

        public new bool DecoratedStrike
        {
            get { return true; }
        }

        public override string Text
        {
            get
            {
                return string.Concat("<s>", base.Text, "</s>");
            }
        }

        public override NiconicoWebTextSegmentType SegmentType
        {
            get { return NiconicoWebTextSegmentType.HtmlStrikeElement; }
        }

        internal static IReadOnlyNiconicoWebTextSegment ParseWebText(System.Text.RegularExpressions.Match match, NiconicoWebTextSegmenter segmenter, IReadOnlyNiconicoWebTextSegment parent)
        {
            var segment = new HtmlStrikeNiconicoWebTextSegment(parent);
            segment.Segments = segmenter.PartialDivide(match.Groups[NiconicoWebTextPatternIndexs.strikeTextGroupNumber].Value,segment);
            return segment;
        }
    }
}
