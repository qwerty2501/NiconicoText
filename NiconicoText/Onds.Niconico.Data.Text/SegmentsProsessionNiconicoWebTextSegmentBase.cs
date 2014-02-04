using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Onds.Niconico.Data.Text
{
    internal abstract class SegmentsProsessionNiconicoWebTextSegmentBase<T> : NiconicoWebTextSegmentBase<T>, IReadOnlyNiconicoWebTextSegment, INiconicoTextSegment
        where T : IReadOnlyNiconicoWebTextSegment
    {
        internal SegmentsProsessionNiconicoWebTextSegmentBase( T parent):base(parent)
        {
            this.Segments = null;
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



        internal NiconicoWebTextSegmentCollection EditableSegments
        {
            get
            {
                if (!(this.Segments is NiconicoWebTextSegmentCollection))
                    new InvalidOperationException("Segments is not editable.");

                return this.Segments as NiconicoWebTextSegmentCollection;
            }
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





        NiconicoWebTextSegmentCollection INiconicoWebTextSegmentTuner.Segments
        {
            get
            {
                return this.EditableSegments;
            }
            set
            {
                this.Segments = value;
            }
        }

        
    }
}
