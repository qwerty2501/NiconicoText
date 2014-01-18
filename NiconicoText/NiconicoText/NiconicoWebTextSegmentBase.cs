using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiconicoText
{
    internal class NiconicoWebTextSegmentBase:INiconicoWebTextSegment
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

        public byte FontSize
        {
            get { return this.hasParent ? this.Parent.FontSize : defaultFontSize; }
        }

        public bool AssociatedUnderLine
        {
            get { throw new NotImplementedException(); }
        }

        public bool AssociatedStrike
        {
            get { throw new NotImplementedException(); }
        }

        public bool AssociatedItalic
        {
            get { throw new NotImplementedException(); }
        }

        public Uri Url
        {
            get { throw new NotImplementedException(); }
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
            get { throw new NotImplementedException(); }
        }

        public NiconicoTextColor Color
        {
            get { throw new NotImplementedException(); }
        }
    }
}
