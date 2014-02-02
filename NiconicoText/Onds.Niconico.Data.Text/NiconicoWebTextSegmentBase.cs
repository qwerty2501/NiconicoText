using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Onds.Niconico.Data.Text
{
    using Color = NiconicoTextColor;

    internal abstract class NiconicoWebTextSegmentBase<T> : INiconicoWebTextSegment, IReadOnlyNiconicoWebTextSegment, INiconicoTextSegment, INiconicoWebTextSegmentTuner
        where T:IReadOnlyNiconicoWebTextSegment
    {

        internal NiconicoWebTextSegmentBase(T parent)
        {
            this.Parent_ = parent;
        }

        internal protected bool HasParent
        {
            get
            {
                return this.Parent != null;
            }
        }

   

        public bool HasUrl
        {
            get { return this.HasParent ? this.Parent.HasUrl : false; }
        }

        public bool HasSegments
        {
            get { return this.HasParent ? this.Parent.HasSegments : false; }
        }

        public IReadOnlyList<IReadOnlyNiconicoWebTextSegment> Segments
        {
            get { return null; }
        }

        public byte FontElementSize
        {
            get { return this.HasParent ? this.Parent.FontElementSize : Onds.Niconico.Data.Text.FontElementSize.defaultSize; }
        }

        public bool DecoratedUnderLine
        {
            get { return this.HasParent ? this.Parent.DecoratedUnderLine : false; }
        }

        public bool DecoratedBold
        {
            get { return this.HasParent ? this.Parent.DecoratedBold : false; }
        }

        public bool DecoratedStrike
        {
            get { return this.HasParent ? this.Parent.DecoratedStrike : false; }
        }

        public bool DecoratedItalic
        {
            get { return this.HasParent ? this.Parent.DecoratedItalic : false; }
        }

        public Uri Url
        {
            get { return this.HasParent ? this.Parent.Url : null; }
        }

        public IReadOnlyNiconicoWebTextSegment Parent
        {
            get
            {
                return this.Parent_;
            }

        }

        internal T Parent_;

        public abstract string Text { get; }


        public string FriendlyText
        {
            get { return this.Text; }
        }

        public Color Color
        {
            get { return this.HasParent ? this.Parent.Color : default(Color); }
        }


        public abstract NiconicoWebTextSegmentType SegmentType { get; }

        public bool HasNumberAnchor
        {
            get { return false; }
        }

        public NiconicoWebTextNumberAnchorRange NumberAnchor
        {
            get { return default(NiconicoWebTextNumberAnchorRange); }
        }

        public override string ToString()
        {
            return this.Text;
        }


        public bool DecoratedColor
        {
            get { return false; }
        }

        INiconicoWebTextSegmentCollection INiconicoWebTextSegment.Segments
        {
            get { return null; }
        }

        INiconicoWebTextSegment INiconicoWebTextSegment.Parent
        {
            get 
            { 
                if(! (this.Parent_ is IReadOnlyNiconicoWebTextSegment))
                    throw new InvalidOperationException("Parent is not writeable.");

                return this.Parent_ as INiconicoWebTextSegment; 
            }
        }

        NiconicoWebTextSegmentCollection INiconicoWebTextSegmentTuner.Segments
        {
            get
            {
                return null;
            }
            set
            {
                throw new InvalidOperationException("This segment does not have Child Segments.");
            }
        }


        public IReadOnlyNiconicoWebText Root
        {
            get { return this.HasParent ? this.Parent.Root : null; }
        }


        INiconicoWebText INiconicoWebTextSegment.Root
        {
            get { return this.HasParent ? (this as INiconicoWebTextSegment).Parent.Root : null; }
        }


        public bool DecoratedFontElementSize
        {
            get { return this.HasParent ? this.Parent.DecoratedFontElementSize : false; }
        }
    }
}
