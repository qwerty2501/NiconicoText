using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiconicoText
{
    internal sealed class HtmlAnchorNiconicoWebTextSegment:SegmentsProsessionNiconicoWebTextSegmentBase,INiconicoWebTextSegment,INiconicoTextSegment
    {

        internal HtmlAnchorNiconicoWebTextSegment(Uri url, NiconicoWebTextSegmentCollection segments)
            : base(segments) 
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

        public new bool HasUrl
        {
            get { return true; }
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
