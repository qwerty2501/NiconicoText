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
            get
            {
                return this.HasParent ? this.Parent.Root : null;
            }
        }

        internal bool HasParent
        {
            get
            {
                return this.Parent != null;
            }
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
            get 
            {
                if ((this.decorateFlag_ & NiconicoWebTextDecorateFlags.HasUrlFlag) == NiconicoWebTextDecorateFlags.HasUrlFlag)
                    return true;

                return this.HasParent ? this.Parent.HasUrl : false;
            }
        }

        public bool HasSegments
        {
            get { return this.Segments != null; }
        }

        public NiconicoWebTextSegmentType SegmentType
        {
            get;
            private set;
        }

        IReadOnlyList<IReadOnlyNiconicoWebTextSegment> IReadOnlyNiconicoWebTextSegment.Segments
        {
            get { return this.Segments; }
        }

        public bool HasNumberAnchor
        {
            get 
            {
                return ! this.NumberAnchor.Equals(default(NiconicoWebTextNumberAnchorRange));
            }
        }

        public NiconicoWebTextNumberAnchorRange NumberAnchor
        {
            get;
            private set;
        }

        public byte FontElementSize
        {
            get;
            private set;
        }

        public bool DecoratedUnderLine
        {
            get
            {
                if ((this.decorateFlag_ & NiconicoWebTextDecorateFlags.DecoratedUnderLineFlag) == NiconicoWebTextDecorateFlags.DecoratedUnderLineFlag)
                    return true;

                return this.HasParent ? this.Parent.DecoratedUnderLine : false;
            }
        }

        public bool DecoratedBold
        {
            get
            {
                if ((this.decorateFlag_ & NiconicoWebTextDecorateFlags.DecoratedBoldFlag) == NiconicoWebTextDecorateFlags.DecoratedBoldFlag)
                    return true;

                return this.HasParent ? this.Parent.DecoratedBold : false;
                
            }
        }

        public bool DecoratedStrike
        {
            get 
            {
                if ((this.decorateFlag_ & NiconicoWebTextDecorateFlags.DecoratedStrikeFlag) == NiconicoWebTextDecorateFlags.DecoratedStrikeFlag)
                    return true;

                return this.HasParent ? this.Parent.DecoratedStrike : false;
            }
        }

        public bool DecoratedItalic
        {
            get
            {
                if ((this.decorateFlag_ & NiconicoWebTextDecorateFlags.DecoratedItalicFlag) == NiconicoWebTextDecorateFlags.DecoratedItalicFlag)
                    return true;
                return this.HasParent ? this.Parent.DecoratedItalic : false;
            }
        }

        public bool DecoratedColor
        {
            get
            {
                if ((this.decorateFlag_ & NiconicoWebTextDecorateFlags.DecoratedColorFlag) == NiconicoWebTextDecorateFlags.DecoratedColorFlag)
                    return true;

                return this.HasParent ? this.Parent.DecoratedColor : false;
            }
        }

        public bool DecoratedFontElementSize
        {
            get { return this.FontElementSize > 0 ? true : this.HasParent ? this.Parent.DecoratedFontElementSize : false; }
        }

        public NiconicoTextColor Color
        {
            get;
            private set;
        }

        public Uri Url
        {
            get;
            private set;
        }

        IReadOnlyNiconicoWebTextSegment IReadOnlyNiconicoWebTextSegment.Parent
        {
            get { return this.Parent; }
        }

        IReadOnlyNiconicoWebText IReadOnlyNiconicoWebTextSegment.Root
        {
            get { return this.Root; }
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

        private NiconicoWebTextDecorateFlags decorateFlag_;
    }
}
