using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiconicoText
{
    using Color = NiconicoTextColor;

    internal abstract class NiconicoWebTextSegmentBase:INiconicoWebTextSegment,INiconicoTextSegment
    {


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

        public INiconicoWebTextSegmentCollection Segments
        {
            get { return null; }
        }

        public byte FontElementSize
        {
            get { return this.HasParent ? this.Parent.FontElementSize : NiconicoText.FontElementSize.defaultSize; }
        }

        public bool AssociatedUnderLine
        {
            get { return this.HasParent ? this.Parent.AssociatedUnderLine : false; }
        }

        public bool AssociatedStrike
        {
            get { return this.HasParent ? this.Parent.AssociatedStrike : false; }
        }

        public bool AssociatedItalic
        {
            get { return this.HasParent ? this.Parent.AssociatedItalic : false; }
        }

        public Uri Url
        {
            get { return this.HasParent ? this.Parent.Url : null; }
        }

        public INiconicoWebTextSegment Parent
        {
            get;
            internal protected set;
        }

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


        public bool AssociatedColor
        {
            get { return false; }
        }
    }
}
