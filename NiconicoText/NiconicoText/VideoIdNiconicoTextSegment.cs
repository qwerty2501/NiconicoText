using NiconicoText.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiconicoText
{
    internal sealed class VideoIdNiconicoTextSegment:IdNiconicoWebTextSegmentBase,INiconicoWebTextSegment
    {
        internal VideoIdNiconicoTextSegment(string id) : base(id) { }

        public override NiconicoWebTextSegmentType SegmentType
        {
            get
            {
                return NiconicoWebTextSegmentType.VideoId;
            }
        }

        protected internal override Uri OnCreateUrl()
        {
            return NiconicoTextUrlUtility.CreateNiconicoVideoUrl(this.text_);
        }
    }
}
