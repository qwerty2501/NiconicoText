using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiconicoText
{
    using Color = NiconicoTextColor;

    internal sealed class HtmlFontElementNiconicoWebTextSegment:SegmentsProsessionNiconicoWebTextSegmentBase,INiconicoWebTextSegment,INiconicoTextSegment
    {
        internal HtmlFontElementNiconicoWebTextSegment(FontElementSize fontSize, Color color, INiconicoWebTextSegmentCollection segments)
            : base(segments)
        {
            this.fontSize_ = fontSize;
            this.color_ = color;
        }

        public override NiconicoWebTextSegmentType SegmentType
        {
            get { return NiconicoWebTextSegmentType.HtmlFontElement; }
        }

        private Color color_;

        private FontElementSize fontSize_;
    }
}
