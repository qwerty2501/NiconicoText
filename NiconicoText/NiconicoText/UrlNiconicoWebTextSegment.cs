using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiconicoText
{
    internal sealed class UrlNiconicoWebTextSegment:PlainNiconicoWebTextSegmentWithUrlBase,INiconicoWebTextSegment
    {
        internal UrlNiconicoWebTextSegment(string url) : base(url) { }

        protected internal override Uri OnCreateUrl()
        {
            return new Uri(this.text_);
        }

        public override NiconicoWebTextSegmentType SegmentType
        {
            get { return NiconicoWebTextSegmentType.Url; }
        }
    }
}
