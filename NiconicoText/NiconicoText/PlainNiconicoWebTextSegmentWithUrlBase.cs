using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiconicoText
{
    internal abstract class PlainNiconicoWebTextSegmentWithUrlBase:PlainNiconicoWebTextSegmentBase,INiconicoWebTextSegment
    {
        internal PlainNiconicoWebTextSegmentWithUrlBase(string text):base(text)
        {
            this.url_ = new WeakReference<Uri>(null);
        }

        private WeakReference<Uri> url_;

        public new Uri Url
        {
            get
            {
                Uri url;

                if (this.url_.TryGetTarget(out url))
                {
                    return url;
                }
                else
                {
                    url = OnCreateUrl();
                    this.url_.SetTarget(url);
                    return url;
                }
            }
        }

        internal protected abstract Uri OnCreateUrl();

    }
}
