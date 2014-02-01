using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Onds.Niconico.Data.Text
{
    internal sealed class InvalidHtmlElementNiconicoWebTextSegment<T>:PlainNiconicoWebTextSegmentBase<T>,IReadOnlyNiconicoWebTextSegment,INiconicoTextSegment
        where T : IReadOnlyNiconicoWebTextSegment
    {
        internal InvalidHtmlElementNiconicoWebTextSegment(string text, T parent) : base(text,parent) { }


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

        internal static IReadOnlyNiconicoWebTextSegment ParseWebText(System.Text.RegularExpressions.Match match, NiconicoWebTextSegmenter segmenter, IReadOnlyNiconicoWebTextSegment parent)
        {
            return new InvalidHtmlElementNiconicoWebTextSegment<IReadOnlyNiconicoWebTextSegment>(match.Groups[NiconicoWebTextPatternIndexs.invalidHtmlElementGroupNumber].Value,parent);
        }
    }
}
