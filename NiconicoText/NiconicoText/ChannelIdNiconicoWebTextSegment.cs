using NiconicoText.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiconicoText
{
    internal sealed class ChannelIdNiconicoWebTextSegment:IdNiconicoWebTextSegmentBase,INiconicoWebTextSegment
    {
        internal ChannelIdNiconicoWebTextSegment(string chanelId) : base(chanelId) { }

        protected internal override Uri OnCreateUrl()
        {
            return NiconicoTextUrlUtility.CreateNiconicoChannelUrl(this.text_);
        }

        public override NiconicoWebTextSegmentType SegmentType
        {
            get { return NiconicoWebTextSegmentType.ChanelId; }
        }
    }
}
