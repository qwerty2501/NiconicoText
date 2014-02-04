using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onds.Niconico.Data.Text
{
    using Color = NiconicoTextColor;

    public sealed class NiconicoWebText:INiconicoText,INiconicoWebText,IReadOnlyNiconicoWebText,IReadOnlyNiconicoWebTextSegment,INiconicoWebTextSegment,INiconicoTextSegment
    {
        public NiconicoWebText()
        {
            this.segments_ = new NiconicoWebTextSegmentCollection();
        }
        
        public event NiconicoTextUpdateHandler TextUpdated;

        public NiconicoTextType TextType
        {
            get { return NiconicoTextType.Web; }
        }

        bool IReadOnlyNiconicoWebTextSegment.HasUrl
        {
            get { return false; }
        }

        public bool HasSegments
        {
            get { return true; }
        }

        NiconicoWebTextSegmentType IReadOnlyNiconicoWebTextSegment.SegmentType
        {
            get { return NiconicoWebTextSegmentType.FullText; }
        }

        IReadOnlyList<IReadOnlyNiconicoWebTextSegment> IReadOnlyNiconicoWebTextSegment.Segments
        {
            get { return this.segments_; }
        }

        private NiconicoWebTextSegmentCollection segments_;

        bool IReadOnlyNiconicoWebTextSegment.HasNumberAnchor
        {
            get { return false; }
        }

        NiconicoWebTextNumberAnchorRange IReadOnlyNiconicoWebTextSegment.NumberAnchor
        {
            get { return default(NiconicoWebTextNumberAnchorRange); }
        }

        byte IReadOnlyNiconicoWebTextSegment.FontElementSize
        {
            get { return FontElementSize.defaultSize; }
        }

        bool IReadOnlyNiconicoWebTextSegment.DecoratedUnderLine
        {
            get { return false; }
        }

        bool IReadOnlyNiconicoWebTextSegment.DecoratedBold
        {
            get { return false; }
        }

        bool IReadOnlyNiconicoWebTextSegment.DecoratedStrike
        {
            get { return false; }
        }

         bool IReadOnlyNiconicoWebTextSegment.DecoratedItalic
        {
            get { return false; }
        }

         bool IReadOnlyNiconicoWebTextSegment.DecoratedColor
        {
            get { return false; }
        }

         bool IReadOnlyNiconicoWebTextSegment.DecoratedFontElementSize
        {
            get { return false; }
        }

         Color IReadOnlyNiconicoWebTextSegment.Color
        {
            get { return default(Color); }
        }

         Uri IReadOnlyNiconicoWebTextSegment.Url
        {
            get { return null; }
        }

         IReadOnlyNiconicoWebTextSegment IReadOnlyNiconicoWebTextSegment.Parent
        {
            get { return null; }
        }

         IReadOnlyNiconicoWebText IReadOnlyNiconicoWebTextSegment.Root
        {
            get { return null; }
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

        INiconicoWebTextSegmentCollection INiconicoWebTextSegment.Segments
        {
            get { return this.segments_; }
        }

        INiconicoWebTextSegment INiconicoWebTextSegment.Parent
        {
            get { return null; }
        }

        INiconicoWebText INiconicoWebTextSegment.Root
        {
            get { return null; }
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


        public void RaiseTextUpdate()
        {
            if (this.TextUpdated != null)
                this.TextUpdated();
        }
    }
}
