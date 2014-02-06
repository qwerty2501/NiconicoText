using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Onds.Niconico.Data.Text
{
    internal abstract class LineBreakNiconicoWebTextSegmentBase<T>:NiconicoWebTextSegmentBase<T>,IReadOnlyNiconicoWebTextSegment,INiconicoTextSegment
        where T:IReadOnlyNiconicoWebTextSegment
    {
        internal LineBreakNiconicoWebTextSegmentBase(T parent) : base(parent) { }

        public new string FriendlyText
        {
            get
            {
                return Environment.NewLine;
            }
        }

        public override NiconicoWebTextSegmentType SegmentType
        {
            get { return NiconicoWebTextSegmentType.LineBreak; }
        }
    }

    internal sealed class LineBreakNiconicoWebTextSegment<T> : LineBreakNiconicoWebTextSegmentBase<T>, IReadOnlyNiconicoWebTextSegment, INiconicoTextSegment
        where T:IReadOnlyNiconicoWebTextSegment
    {
        internal LineBreakNiconicoWebTextSegment(T parent) : base(parent) { }

        public override string Text
        {
            get { return Environment.NewLine; }
        }

        internal static LineBreakNiconicoWebTextSegment<T> ParseWebText(System.Text.RegularExpressions.Match match, NiconicoWebTextSegmenter segmenter, T parent)
        {
            return new LineBreakNiconicoWebTextSegment<T>(parent);
        }
    }

    internal sealed class HtmlBreakNiconicoWebTextSegment<T> : LineBreakNiconicoWebTextSegmentBase<T>, IReadOnlyNiconicoWebTextSegment, INiconicoTextSegment
        where T : IReadOnlyNiconicoWebTextSegment
    {
        internal HtmlBreakNiconicoWebTextSegment(T parent) : base(parent) { }

        public override string Text
        {
            get { return "<br>"; }
        }

        internal static HtmlBreakNiconicoWebTextSegment<T> ParseWebText(System.Text.RegularExpressions.Match match, NiconicoWebTextSegmenter segmenter, T parent)
        {
            return new HtmlBreakNiconicoWebTextSegment<T>(parent);
        }
    }
}
