using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiconicoText
{
    internal sealed class UrlNiconicoWebTextSegment:NiconicoWebTextSegmentBase,INiconicoWebTextSegment,INiconicoTextSegment
    {
        internal UrlNiconicoWebTextSegment(Uri url)
        {
            this.url_ = url;
        }

        public new Uri Url
        {
            get
            {
                return this.url_;
            }
        }

        public override NiconicoWebTextSegmentType SegmentType
        {
            get { return NiconicoWebTextSegmentType.Url; }
        }

        public override string Text
        {
            get { return this.url_.OriginalString; }
        }

        private Uri url_;

    }
}
