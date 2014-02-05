using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onds.Niconico.Data.Text
{

    using Color = NiconicoTextColor;

    public sealed class RestrictedNiconicoWebText:IReadOnlyNiconicoWebText,IReadOnlyNiconicoWebTextSegment,INiconicoText,INiconicoTextSegment
    {
        public NiconicoTextType TextType
        {
            get { return NiconicoTextType.Web; }
        }

        bool IReadOnlyNiconicoWebTextSegment.HasUrl
        {
            get { return false; }
        }

        bool IReadOnlyNiconicoWebTextSegment.HasSegments
        {
            get { return true; }
        }

        NiconicoWebTextSegmentType IReadOnlyNiconicoWebTextSegment.SegmentType
        {
            get { return NiconicoWebTextSegmentType.FullText; }
        }

        public IReadOnlyList<IReadOnlyNiconicoWebTextSegment> Segments
        {
            get;
            internal set;
        }

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
            get { return Onds.Niconico.Data.Text.FontElementSize.defaultSize; }
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
            get { return this; }
        }

        string INiconicoTextSegment.Text
        {
            get { return this.Segments.ToText(); }
        }

        string INiconicoTextSegment.FriendlyText
        {
            get { return this.Segments.ToFriendlyText(); }
        }


        bool IReadOnlyNiconicoWebTextSegment.DecoratedFontElementSize
        {
            get { return false; }
        }
    }
}
