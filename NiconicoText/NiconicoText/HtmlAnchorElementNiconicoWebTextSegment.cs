using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiconicoText
{
    internal sealed class HtmlAnchorElementNiconicoWebTextSegment:SegmentsProsessionNiconicoWebTextSegmentBase,INiconicoWebTextSegment,INiconicoTextSegment
    {

        internal HtmlAnchorElementNiconicoWebTextSegment(Uri url, INiconicoWebTextSegmentCollection segments) : base(segments) 
        {
            this.Url = url;
        }

        public override string Text
        {
            get
            {
                return string.Concat("<a href=\"", this.Url.OriginalString, "\">", base.Text, "</a>");
            }
        }

        public new Uri Url
        {
            get;
            private set;
        }

        public override NiconicoWebTextSegmentType SegmentType
        {
            get { return NiconicoWebTextSegmentType.HtmlAnchorElement; }
        }


    }
}
