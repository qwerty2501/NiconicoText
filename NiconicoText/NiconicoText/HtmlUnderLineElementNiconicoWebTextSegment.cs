using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiconicoText
{
    internal sealed class HtmlUnderLineElementNiconicoWebTextSegment:SegmentsProsessionNiconicoWebTextSegmentBase,INiconicoWebTextSegment,INiconicoTextSegment
    {
        internal HtmlUnderLineElementNiconicoWebTextSegment(INiconicoWebTextSegmentCollection segments) : base(segments) { }

        public new bool AssociatedUnderLine
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
    }
}
