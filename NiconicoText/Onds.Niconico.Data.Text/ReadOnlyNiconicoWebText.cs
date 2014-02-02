using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onds.Niconico.Data.Text
{

    using Color = NiconicoTextColor;

    internal class ReadOnlyNiconicoWebText:IReadOnlyNiconicoWebText,IReadOnlyNiconicoWebTextSegment,INiconicoText,INiconicoTextSegment
    {
        public NiconicoTextType TextType
        {
            get { return NiconicoTextType.Web; }
        }

        public bool HasUrl
        {
            get { return false; }
        }

        public bool HasSegments
        {
            get { return true; }
        }

        public NiconicoWebTextSegmentType SegmentType
        {
            get { return NiconicoWebTextSegmentType.FullText; }
        }

        public IReadOnlyList<IReadOnlyNiconicoWebTextSegment> Segments
        {
            get;
            internal set;
        }

        public bool HasNumberAnchor
        {
            get { return false; }
        }

        public NiconicoWebTextNumberAnchorRange NumberAnchor
        {
            get { return default(NiconicoWebTextNumberAnchorRange); }
        }

        public byte FontElementSize
        {
            get { return Onds.Niconico.Data.Text.FontElementSize.defaultSize; }
        }

        public bool DecoratedUnderLine
        {
            get { return false; }
        }

        public bool DecoratedBold
        {
            get { return false; }
        }

        public bool DecoratedStrike
        {
            get { return false; }
        }

        public bool DecoratedItalic
        {
            get { return false; }
        }

        public bool DecoratedColor
        {
            get { return false; }
        }

        public Color Color
        {
            get { return default(Color); }
        }

        public Uri Url
        {
            get { return null; }
        }

        public IReadOnlyNiconicoWebTextSegment Parent
        {
            get { return null; }
        }

        public IReadOnlyNiconicoWebText Root
        {
            get { return this; }
        }

        public string Text
        {
            get { return this.Segments.ToText(); }
        }

        public string FriendlyText
        {
            get { return this.Segments.ToFriendlyText(); }
        }


        public bool DecoratedFontElementSize
        {
            get { return false; }
        }
    }
}
