using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiconicoText
{
    using Color = NiconicoTextColor;

    internal abstract class NiconicoWebTextSegmentBase:INiconicoWebTextSegment
    {


        private bool hasParent
        {
            get
            {
                return this.Parent != null;
            }
        }

   

        public bool HasUrl
        {
            get { return this.hasParent ? this.Parent.HasUrl : false; }
        }

        public bool HasChild
        {
            get { return this.hasParent ? this.Parent.HasChild : false; }
        }

        public INiconicoWebTextSegmentCollection ChildSegments
        {
            get { return null; }
        }

        public byte FontElementSize
        {
            get { return this.hasParent ? this.Parent.FontElementSize : NiconicoText.FontElementSize.defaultSize; }
        }

        public bool AssociatedUnderLine
        {
            get { return this.hasParent ? this.Parent.AssociatedUnderLine : false; }
        }

        public bool AssociatedStrike
        {
            get { return this.hasParent ? this.Parent.AssociatedStrike : false; }
        }

        public bool AssociatedItalic
        {
            get { return this.hasParent ? this.Parent.AssociatedItalic : false; }
        }

        public Uri Url
        {
            get { return this.hasParent ? this.Parent.Url : null; }
        }

        public INiconicoWebTextSegment Parent
        {
            get;
            internal protected set;
        }

        public string Text
        {
            get { throw new NotImplementedException(); }
        }

        public string FriendlyText
        {
            get { return string.Empty; }
        }

        public Color Color
        {
            get { return this.hasParent ? this.Parent.Color : default(Color); }
        }


        public NiconicoWebTextSegmentType SegmentType
        {
            get { throw new NotImplementedException(); }
        }
    }
}
