﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Onds.Niconico.Data.Text
{
    internal sealed class HtmlInvalidElementNiconicoWebTextSegment<T> : SegmentsProsessionNiconicoWebTextSegmentBase<T>, IReadOnlyNiconicoWebTextSegment, INiconicoTextSegment
        where T : IReadOnlyNiconicoWebTextSegment
    {
        internal HtmlInvalidElementNiconicoWebTextSegment( T parent) : base(parent) { }


        public new string Text
        {
            get
            {
                return string.Concat("<", base.Text, ">");
            }
        }

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
            var invalidHtml = new HtmlInvalidElementNiconicoWebTextSegment<IReadOnlyNiconicoWebTextSegment>(parent);
            var matchValue = match.Value;
            invalidHtml.Segments = segmenter.PartialDivide(matchValue.Substring(1,matchValue.Length - 2), invalidHtml);
            return invalidHtml;
        }
    }
}
