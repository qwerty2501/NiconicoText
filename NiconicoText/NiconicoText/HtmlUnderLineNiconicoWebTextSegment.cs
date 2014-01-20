using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiconicoText
{
    internal sealed class HtmlUnderLineNiconicoWebTextSegment:SegmentsProsessionNiconicoWebTextSegmentBase,INiconicoWebTextSegment,INiconicoTextSegment
    {
        internal HtmlUnderLineNiconicoWebTextSegment(NiconicoWebTextSegmentCollection segments) : base(segments) { }

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

        internal static INiconicoWebTextSegment ParseWebText(System.Text.RegularExpressions.Match match, NiconicoWebTextSegmenter segmenter)
        {
            return new HtmlUnderLineNiconicoWebTextSegment(segmenter.GetTokensInternal(match.Groups[NiconicoWebTextPatternIndexs.underLineTextGroupNumber].Value));
        }
    }
}
