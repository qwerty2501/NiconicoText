using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiconicoText
{
    internal sealed class InvalidHtmlElementNiconicoWebTextSegment:PlainNiconicoWebTextSegmentBase,IReadOnlyNiconicoWebTextSegment,INiconicoTextSegment
    {
        internal InvalidHtmlElementNiconicoWebTextSegment(string text) : base(text) { }


        public new string FriendlyText
        {
            get
            {
                return string.Empty;
            }
        }

        public override NiconicoWebTextSegmentType SegmentType
        {
            get { return NiconicoWebTextSegmentType.HtmlInvalidElement; }
        }

        internal static IReadOnlyNiconicoWebTextSegment ParseWebText(System.Text.RegularExpressions.Match match, NiconicoWebTextSegmenter segmenter)
        {
            return new InvalidHtmlElementNiconicoWebTextSegment(match.Groups[NiconicoWebTextPatternIndexs.invalidHtmlElementGroupNumber].Value);
        }
    }
}
