using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiconicoText
{
    internal sealed class HtmlItalicElementNiconicoWebTextSegment:SegmentsProsessionNiconicoWebTextSegmentBase,INiconicoWebTextSegment,INiconicoTextSegment
    {
        internal HtmlItalicElementNiconicoWebTextSegment(INiconicoWebTextSegmentCollection segments) : base(segments) { }

        public new bool AssociatedItalic
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
    }
}
