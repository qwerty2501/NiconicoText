using NiconicoText.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiconicoText
{
    internal class LiveIdNiconicoWebTextSegment:IdNiconicoWebTextSegmentBase,INiconicoWebTextSegment
    {
        internal LiveIdNiconicoWebTextSegment(string liveId) : base(liveId) { }

        protected internal override Uri OnCreateUrl()
        {
            return NiconicoTextUrlUtility.CraeteNiconicoLiveUrl(this.text_);
        }

        public override NiconicoWebTextSegmentType SegmentType
        {
            get { return NiconicoWebTextSegmentType.LiveId; }
        }
    }
}
