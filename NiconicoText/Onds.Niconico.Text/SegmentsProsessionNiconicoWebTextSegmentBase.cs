using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Onds.Niconico.Text
{
    internal abstract class SegmentsProsessionNiconicoWebTextSegmentBase:NiconicoWebTextSegmentBase,IReadOnlyNiconicoWebTextSegment,INiconicoTextSegment
    {
        internal SegmentsProsessionNiconicoWebTextSegmentBase( IReadOnlyNiconicoWebTextSegment parent):base(parent)
        {
        }

        public new bool HasSegments
        {
            get
            {
                return true;
            }
        }


        public new IReadOnlyList<IReadOnlyNiconicoWebTextSegment> Segments
        {
            get;
            internal set;
        }

        public override string Text
        {
            get
            {
                return this.Segments.ToText();
            }
        }

        public new string FriendlyText
        {
            get
            {
                return this.Segments.ToFriendlyText();
            }
        }



    }
}
