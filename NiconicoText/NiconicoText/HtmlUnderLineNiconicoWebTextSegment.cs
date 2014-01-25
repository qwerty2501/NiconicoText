using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiconicoText
{
    internal sealed class HtmlUnderLineNiconicoWebTextSegment:SegmentsProsessionNiconicoWebTextSegmentBase,IReadOnlyNiconicoWebTextSegment,INiconicoTextSegment
    {
        internal HtmlUnderLineNiconicoWebTextSegment(IReadOnlyList<IReadOnlyNiconicoWebTextSegment> segments, IReadOnlyNiconicoWebTextSegment parent) : base(segments,parent) { }

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

        internal static IReadOnlyNiconicoWebTextSegment ParseWebText(System.Text.RegularExpressions.Match match, NiconicoWebTextSegmenter segmenter, IReadOnlyNiconicoWebTextSegment parent)
        {
            return new HtmlUnderLineNiconicoWebTextSegment(segmenter.Divide(match.Groups[NiconicoWebTextPatternIndexs.underLineTextGroupNumber].Value),parent);
        }
    }
}
