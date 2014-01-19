using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiconicoText
{
    internal abstract class SegmentsProsessionNiconicoWebTextSegmentBase:NiconicoWebTextSegmentBase,INiconicoWebTextSegment,INiconicoTextSegment
    {
        internal SegmentsProsessionNiconicoWebTextSegmentBase(INiconicoWebTextSegmentCollection segments)
        {
            this.segments_ = segments;
        }


        public new INiconicoWebTextSegmentCollection Segments
        {
            get
            {
                return this.segments_;
            }
        }

        public override string Text
        {
            get
            {
                return this.segments_.ToString();
            }
        }

        public new string FriendlyText
        {
            get
            {
                return this.segments_.ToFriendlyString();
            }
        }

        private INiconicoWebTextSegmentCollection segments_;



    }
}
