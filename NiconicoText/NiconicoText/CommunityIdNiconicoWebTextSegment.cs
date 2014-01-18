using NiconicoText.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiconicoText
{
    internal sealed class CommunityIdNiconicoWebTextSegment:IdNiconicoWebTextSegmentBase,INiconicoWebTextSegment
    {
        internal CommunityIdNiconicoWebTextSegment(string communityId) : base(communityId) { }

        protected internal override Uri OnCreateUrl()
        {
            return NiconicoTextUrlUtility.CreateNiconicoVideoUrl(this.text_);
        }

        public override NiconicoWebTextSegmentType SegmentType
        {
            get { return NiconicoWebTextSegmentType.CommunityId; }
        }
    }
}
