using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiconicoText
{
    internal abstract class LineBreakNiconicoWebTextSegmentBase:NiconicoWebTextSegmentBase,INiconicoWebTextSegment,INiconicoTextSegment
    {
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

    internal sealed class LineBreakNiconicoWebTextSegment : LineBreakNiconicoWebTextSegmentBase, INiconicoWebTextSegment, INiconicoTextSegment
    {

        public override string Text
        {
            get { return Environment.NewLine; }
        }
    }

    internal sealed class HtmlBreakElementNiconicoWebTextSegment : LineBreakNiconicoWebTextSegmentBase, INiconicoWebTextSegment, INiconicoTextSegment
    {

        public override string Text
        {
            get { return "<br>"; }
        }
    }
}
