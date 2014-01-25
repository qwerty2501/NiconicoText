using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiconicoText
{
    internal sealed class HtmlStrikeNiconicoWebTextSegment:SegmentsProsessionNiconicoWebTextSegmentBase,IReadOnlyNiconicoWebTextSegment,INiconicoTextSegment
    {
        internal HtmlStrikeNiconicoWebTextSegment(IReadOnlyList<IReadOnlyNiconicoWebTextSegment> segments, IReadOnlyNiconicoWebTextSegment parent) : base(segments,parent) { }

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
            return new HtmlStrikeNiconicoWebTextSegment(segmenter.Divide(match.Groups[NiconicoWebTextPatternIndexs.strikeTextGroupNumber].Value),parent);
        }
    }
}
