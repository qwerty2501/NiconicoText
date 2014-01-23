using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiconicoText
{
    internal abstract class SegmentsProsessionNiconicoWebTextSegmentBase:NiconicoWebTextSegmentBase,INiconicoWebTextSegment,INiconicoTextSegment
    {
        internal SegmentsProsessionNiconicoWebTextSegmentBase(NiconicoWebTextSegmentObservableCollection segments)
        {
            this.segments_ = segments;
            this.segments_.Owner = this;
        }

        public new bool HasSegments
        {
            get
            {
                return true;
            }
        }

        private NiconicoWebTextSegmentObservableCollection segments_;

        public new INiconicoWebTextSegmentObservableCollection Segments
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
                return this.Segments.ToString();
            }
        }

        public new string FriendlyText
        {
            get
            {
                return this.Segments.ToFriendlyString();
            }
        }



    }
}
