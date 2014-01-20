using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiconicoText
{
    internal sealed class HtmlItalicNiconicoWebTextSegment:SegmentsProsessionNiconicoWebTextSegmentBase,INiconicoWebTextSegment,INiconicoTextSegment
    {
        internal HtmlItalicNiconicoWebTextSegment(NiconicoWebTextSegmentCollection segments) : base(segments) { }

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

        internal static INiconicoWebTextSegment ParseWebText(System.Text.RegularExpressions.Match match, NiconicoWebTextSegmenter segmenter)
        {
            return new HtmlItalicNiconicoWebTextSegment(segmenter.GetTokensInternal(match.Groups[NiconicoWebTextPatternIndexs.italicTextGroupNumber].Value));
        }
    }
}
