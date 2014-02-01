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

        internal static IReadOnlyNiconicoWebTextSegment ParseWebText(System.Text.RegularExpressions.Match match, NiconicoWebTextSegmenter segmenter, IReadOnlyNiconicoWebTextSegment parent)
        {
            return new LineBreakNiconicoWebTextSegment<IReadOnlyNiconicoWebTextSegment>(parent);
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

        internal static IReadOnlyNiconicoWebTextSegment ParseWebText(System.Text.RegularExpressions.Match match, NiconicoWebTextSegmenter segmenter, IReadOnlyNiconicoWebTextSegment parent)
        {
            return new HtmlBreakNiconicoWebTextSegment<IReadOnlyNiconicoWebTextSegment>(parent);
        }
    }
}
