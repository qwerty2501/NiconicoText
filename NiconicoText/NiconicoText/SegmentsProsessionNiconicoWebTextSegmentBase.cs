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
            this.Segments = segments;
        }

        public new bool HasSegments
        {
            get
            {
                return true;
            }
        }

        public new INiconicoWebTextSegmentCollection Segments
        {
            get;
            private set;
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
