using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onds.Niconico.Data.Text
{
    public sealed class NiconicoWebText:INiconicoText,INiconicoWebText,IReadOnlyNiconicoWebText,IReadOnlyNiconicoWebTextSegment,INiconicoWebTextSegment
    {
        
        public event NiconicoTextUpdateHandler TextUpdated;

        public NiconicoTextType TextType
        {
            get { throw new NotImplementedException(); }
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

        public IReadOnlyList<IReadOnlyNiconicoWebTextSegment> Segments
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

        public IReadOnlyNiconicoWebTextSegment Parent
        {
            get { throw new NotImplementedException(); }
        }

        public IReadOnlyNiconicoWebText Root
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

        INiconicoWebTextSegmentCollection INiconicoWebTextSegment.Segments
        {
            get { throw new NotImplementedException(); }
        }

        INiconicoWebTextSegment INiconicoWebTextSegment.Parent
        {
            get { throw new NotImplementedException(); }
        }

        INiconicoWebText INiconicoWebTextSegment.Root
        {
            get { throw new NotImplementedException(); }
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
    }
}
