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
        internal HtmlFontElementNiconicoWebTextSegment(FontElementSize fontElementSize, INiconicoWebTextSegmentCollection segments) : this(fontElementSize, default(Color), false, segments) { }

        internal HtmlFontElementNiconicoWebTextSegment(Color color, INiconicoWebTextSegmentCollection segments) : this(new FontElementSize(0), color, segments) { }

        internal HtmlFontElementNiconicoWebTextSegment(FontElementSize fontElementSize, Color color, INiconicoWebTextSegmentCollection segments) : this(fontElementSize, color, true, segments) { }

        private HtmlFontElementNiconicoWebTextSegment(FontElementSize fontElementSize,Color color,bool associatedColor, INiconicoWebTextSegmentCollection segments)
            : base(segments)
        {
            this.fontElementSize_ = fontElementSize;
            this.color_ = color;
            this.AssociatedColor = associatedColor;
        }

        public new Color Color
        {
            get
            {
                if (this.AssociatedColor)
                {
                    return this.color_;
                }
                else
                {
                    return base.Color;
                }
            }
        }

        public new bool AssociatedColor
        {
            get;
            private set;
        }


        public override string Text
        {
            get
            {
                var builder = new StringBuilder();

                builder.Append("<font ");

                if (this.AssociatedColor)
                {
                    builder.Append("color=\"");
                    builder.Append(this.color_.ToColorCode());
                    builder.Append("\"");
                }

                if (this.fontElementSize_ != 0)
                {
                    if (this.AssociatedColor)
                    {
                        builder.Append(" ");
                    }
                    builder.Append("size=\"");
                    builder.Append(this.fontElementSize_);
                    builder.Append("\"");
                }

                builder.Append(">");

                builder.Append(base.Text);

                builder.Append("</font>");

                return builder.ToString();
            }
        }

        public new byte FontElementSize
        {
            get
            {
                if (this.fontElementSize_ == 0)
                {
                    return base.FontElementSize;
                }
                else
                {
                    return this.fontElementSize_;
                }
            }
        }

        public override NiconicoWebTextSegmentType SegmentType
        {
            get { return NiconicoWebTextSegmentType.HtmlFontElement; }
        }

        private Color color_;


        
        private FontElementSize fontElementSize_;
    }
}
