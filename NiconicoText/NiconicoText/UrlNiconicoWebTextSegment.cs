using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiconicoText
{
    internal sealed class UrlNiconicoWebTextSegment:PlainNiconicoWebTextSegmentBase,INiconicoWebTextSegment
    {
        internal UrlNiconicoWebTextSegment(string url) : base(url) 
        { 
            this.urlRef_ = new WeakReference<Uri>(null);
        }

        public new Uri Url
        {
            get
            {
                Uri url;
                if (this.urlRef_.TryGetTarget(out url))
                {
                    return url;
                }
                else
                {
                    url = new Uri(this.text_);
                    this.urlRef_.SetTarget(url);
                    return url;
                }
            }
        }

        public override NiconicoWebTextSegmentType SegmentType
        {
            get { return NiconicoWebTextSegmentType.Url; }
        }


        private WeakReference<Uri> urlRef_;
    }
}
