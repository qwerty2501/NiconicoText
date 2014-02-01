using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Onds.Niconico.Data.Text
{
    internal sealed class HtmlAnchorNiconicoWebTextSegment<T>:SegmentsProsessionNiconicoWebTextSegmentBase<T>,IReadOnlyNiconicoWebTextSegment,INiconicoTextSegment
        where T : IReadOnlyNiconicoWebTextSegment
    {

        internal HtmlAnchorNiconicoWebTextSegment(Uri url,  T parent)
            : base(parent) 
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
