using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onds.Niconico.Text
{
    using Color = NiconicoTextColor;

    internal sealed class HtmlFontNiconicoWebTextSegment:SegmentsProsessionNiconicoWebTextSegmentBase,IReadOnlyNiconicoWebTextSegment,INiconicoTextSegment
    {
        internal HtmlFontNiconicoWebTextSegment(FontElementSize fontElementSize,  IReadOnlyNiconicoWebTextSegment parent) : this(fontElementSize, default(Color), false,parent) { }

        internal HtmlFontNiconicoWebTextSegment(Color color,  IReadOnlyNiconicoWebTextSegment parent) : this(new FontElementSize(0), color,parent) { }

        internal HtmlFontNiconicoWebTextSegment(FontElementSize fontElementSize, Color color,IReadOnlyNiconicoWebTextSegment parent) : this(fontElementSize, color, true,parent) { }

        private HtmlFontNiconicoWebTextSegment(FontElementSize fontElementSize, Color color, bool associatedColor, IReadOnlyNiconicoWebTextSegment parent)
            : base(parent)
        {
            this.fontElementSize_ = fontElementSize;
            this.color_ = color;
            this.DecoratedColor = associatedColor;
        }

        public new Color Color
        {
            get
            {
                if (this.DecoratedColor)
                {
                    return this.color_;
                }
                else
                {
                    return base.Color;
                }
            }
        }

        public new bool DecoratedColor
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

                if (this.DecoratedColor)
                {
                    builder.Append("color=\"");
                    builder.Append(this.color_.ToColorCode());
                    builder.Append("\"");
                }

                if (this.fontElementSize_ != 0)
                {
                    if (this.DecoratedColor)
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

        internal static IReadOnlyNiconicoWebTextSegment ParseWebText(System.Text.RegularExpressions.Match match, NiconicoWebTextSegmenter segmenter, IReadOnlyNiconicoWebTextSegment parent)
        {
            var fontElementSizeGroup = match.Groups[NiconicoWebTextPatternIndexs.sizeGroupNumber];
            var colorCodeGroup = match.Groups[NiconicoWebTextPatternIndexs.colorCodeGroupNumber];
            var colorNameGroup = match.Groups[NiconicoWebTextPatternIndexs.colorNameGroupNumber];
            var codeColor = new Color();
            var nameColor = new Color();

            if (colorCodeGroup.Success)
            {
                codeColor = NiconicoTextColorExtention.FromColorCode(colorCodeGroup.Value);
            }

            if (colorNameGroup.Success)
            {
                nameColor = NiconicoTextColorExtention.FromColorName(colorNameGroup.Value);
            }
            FontElementSize fontSize = new FontElementSize();

            if (fontElementSizeGroup.Success)
            {
                var firstChar = fontElementSizeGroup.Value.First();

                if (firstChar == '-' || firstChar == '+')
                {
                    var sizeTmp = (sbyte)(sbyte.Parse(fontElementSizeGroup.Value) + 3);
                    if (sizeTmp < 1)
                    {
                        sizeTmp = 1;
                    }
                    else if (sizeTmp > 7)
                    {
                        sizeTmp = 7;
                    }

                    fontSize = new FontElementSize((byte)sizeTmp);
                }
                else
                {
                    fontSize = new FontElementSize(byte.Parse(fontElementSizeGroup.Value));
                }

                

               
            }

            HtmlFontNiconicoWebTextSegment segment;

            if (colorCodeGroup.Success)
            {
                segment = new HtmlFontNiconicoWebTextSegment(fontSize, codeColor,parent);
            }
            else if (colorNameGroup.Success)
            {
                segment = new HtmlFontNiconicoWebTextSegment(fontSize, nameColor,parent);
            }
            else
            {
                segment = new HtmlFontNiconicoWebTextSegment(fontSize,parent);
            }

            segment.Segments = segmenter.PartialDivide(match.Groups[NiconicoWebTextPatternIndexs.fontTextGroupNumber].Value,segment);
            return segment;
        }
    }
}
