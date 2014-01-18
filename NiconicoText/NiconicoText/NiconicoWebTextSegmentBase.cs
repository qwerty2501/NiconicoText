using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiconicoText
{
    internal class NiconicoWebTextSegmentBase:INiconicoWebTextSegment
    {



        public bool HasUrl
        {
            get { throw new NotImplementedException(); }
        }

        public bool HasChild
        {
            get { throw new NotImplementedException(); }
        }

        public INiconicoWebTextSegmentCollection ChildSegments
        {
            get { throw new NotImplementedException(); }
        }

        public byte FontSize
        {
            get { throw new NotImplementedException(); }
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
            get { throw new NotImplementedException(); }
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
