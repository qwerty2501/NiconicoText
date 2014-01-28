using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onds.Niconico.Text
{
    internal abstract class LineBreakNiconicoWebTextSegmentBase:NiconicoWebTextSegmentBase,IReadOnlyNiconicoWebTextSegment,INiconicoTextSegment
    {
        internal LineBreakNiconicoWebTextSegmentBase(IReadOnlyNiconicoWebTextSegment parent) : base(parent) { }

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

    internal sealed class LineBreakNiconicoWebTextSegment : LineBreakNiconicoWebTextSegmentBase, IReadOnlyNiconicoWebTextSegment, INiconicoTextSegment
    {
        internal LineBreakNiconicoWebTextSegment(IReadOnlyNiconicoWebTextSegment parent) : base(parent) { }

        public override string Text
        {
            get { return Environment.NewLine; }
        }

        internal static IReadOnlyNiconicoWebTextSegment ParseWebText(System.Text.RegularExpressions.Match match, NiconicoWebTextSegmenter segmenter, IReadOnlyNiconicoWebTextSegment parent)
        {
            return new LineBreakNiconicoWebTextSegment(parent);
        }
    }

    internal sealed class HtmlBreakNiconicoWebTextSegment : LineBreakNiconicoWebTextSegmentBase, IReadOnlyNiconicoWebTextSegment, INiconicoTextSegment
    {
        internal HtmlBreakNiconicoWebTextSegment(IReadOnlyNiconicoWebTextSegment parent) : base(parent) { }

        public override string Text
        {
            get { return "<br>"; }
        }

        internal static IReadOnlyNiconicoWebTextSegment ParseWebText(System.Text.RegularExpressions.Match match, NiconicoWebTextSegmenter segmenter, IReadOnlyNiconicoWebTextSegment parent)
        {
            return new HtmlBreakNiconicoWebTextSegment(parent);
        }
    }
}
