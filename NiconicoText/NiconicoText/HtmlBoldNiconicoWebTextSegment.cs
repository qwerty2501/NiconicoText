using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NiconicoText
{
    internal sealed class HtmlBoldNiconicoWebTextSegment:SegmentsProsessionNiconicoWebTextSegmentBase,IReadOnlyNiconicoWebTextSegment,INiconicoTextSegment
    {
        internal HtmlBoldNiconicoWebTextSegment(IReadOnlyList<IReadOnlyNiconicoWebTextSegment> segments, IReadOnlyNiconicoWebTextSegment parent) : base(segments,parent) { }

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
            return new HtmlBoldNiconicoWebTextSegment(segmenter.Divide(match.Groups[NiconicoWebTextPatternIndexs.boldTextGroupNumber].Value),parent);
        }
    }
}
