using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Onds.Niconico.Data.Text
{
    internal abstract class SegmentsProsessionNiconicoWebTextSegmentBase<T>:NiconicoWebTextSegmentBase<T>,IReadOnlyNiconicoWebTextSegment,INiconicoTextSegment,INiconicoWebTextSegment
        where T : IReadOnlyNiconicoWebTextSegment
    {
        internal SegmentsProsessionNiconicoWebTextSegmentBase( T parent):base(parent)
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




        INiconicoWebTextSegmentCollection INiconicoWebTextSegment.Segments
        {
            get 
            {
                if (!(this.Segments is INiconicoWebTextSegmentCollection))
                    throw new InvalidOperationException("Segments is not writeable");

                return (INiconicoWebTextSegmentCollection)this.Segments;
            }
        }

        
    }
}
