using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onds.Niconico.Data.Text
{
    internal sealed class WriteableNiconicoWebTextSegment:INiconicoTextSegment,INiconicoWebTextSegment,IReadOnlyNiconicoWebTextSegment,INiconicoWebTextSegmentTuner
    {
        INiconicoWebTextSegmentCollection INiconicoWebTextSegment.Segments
        {
            get { return this.Segments; }
        }

        public INiconicoWebTextSegment Parent
        {
            get;
            private set;
        }

        public INiconicoWebText Root
        {
            get;
            private set;
        }

        public IReadOnlyList<INiconicoWebTextSegment> ImportText(string text)
        {
            throw new NotImplementedException();
        }

        public IReadOnlyList<INiconicoWebTextSegment> InsertTextBefore(string text, INiconicoWebTextSegment referenceSegment)
        {
            throw new NotImplementedException();
        }

        public INiconicoWebTextSegment ImportSegment(IReadOnlyNiconicoWebTextSegment newSegment)
        {
            throw new NotImplementedException();
        }

        public INiconicoWebTextSegment InsertSegmentBefore(IReadOnlyNiconicoWebTextSegment newSemgment, INiconicoWebTextSegment referenceSegment)
        {
            throw new NotImplementedException();
        }

        public INiconicoWebTextSegment RemoveChildSegment(INiconicoWebTextSegment semgent)
        {
            throw new NotImplementedException();
        }

        public bool HasUrl
        {
            get { throw new NotImplementedException(); }
        }

        public bool HasSegments
        {
            get { throw new NotImplementedException(); }
        }

        public NiconicoWebTextSegmentType SegmentType
        {
            get { throw new NotImplementedException(); }
        }

        IReadOnlyList<IReadOnlyNiconicoWebTextSegment> IReadOnlyNiconicoWebTextSegment.Segments
        {
            get { throw new NotImplementedException(); }
        }

        public bool HasNumberAnchor
        {
            get { throw new NotImplementedException(); }
        }

        public NiconicoWebTextNumberAnchorRange NumberAnchor
        {
            get { throw new NotImplementedException(); }
        }

        public byte FontElementSize
        {
            get { throw new NotImplementedException(); }
        }

        public bool DecoratedUnderLine
        {
            get { throw new NotImplementedException(); }
        }

        public bool DecoratedBold
        {
            get { throw new NotImplementedException(); }
        }

        public bool DecoratedStrike
        {
            get { throw new NotImplementedException(); }
        }

        public bool DecoratedItalic
        {
            get { throw new NotImplementedException(); }
        }

        public bool DecoratedColor
        {
            get { throw new NotImplementedException(); }
        }

        public bool DecoratedFontElementSize
        {
            get { throw new NotImplementedException(); }
        }

        public NiconicoTextColor Color
        {
            get { throw new NotImplementedException(); }
        }

        public Uri Url
        {
            get { throw new NotImplementedException(); }
        }

        IReadOnlyNiconicoWebTextSegment IReadOnlyNiconicoWebTextSegment.Parent
        {
            get { throw new NotImplementedException(); }
        }

        IReadOnlyNiconicoWebText IReadOnlyNiconicoWebTextSegment.Root
        {
            get { throw new NotImplementedException(); }
        }

        public string Text
        {
            get;
            private set;
        }

        public string FriendlyText
        {
            get;
            private set;
        }

        public NiconicoWebTextSegmentCollection Segments
        {
            get;
            set;
        }
    }
}
