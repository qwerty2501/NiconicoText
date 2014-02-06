using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Onds.Niconico.Data.Text
{
    using System.Text.RegularExpressions;
    using Color = NiconicoTextColor;

    internal sealed class HtmlFontNiconicoWebTextSegment<T>:SegmentsProsessionNiconicoWebTextSegmentBase<T>,IReadOnlyNiconicoWebTextSegment,INiconicoTextSegment
        where T : IReadOnlyNiconicoWebTextSegment
    {
        internal HtmlFontNiconicoWebTextSegment(FontElementSize fontElementSize,  T parent) : this(fontElementSize, default(Color), false,parent) { }

        internal HtmlFontNiconicoWebTextSegment(Color color,  T parent) : this(new FontElementSize(0), color,parent) { }

        internal HtmlFontNiconicoWebTextSegment(FontElementSize fontElementSize, Color color,T parent) : this(fontElementSize, color, true,parent) { }

        private HtmlFontNiconicoWebTextSegment(FontElementSize fontElementSize, Color color, bool decoratedColor, T parent)
            : base(parent)
        {
            this.fontElementSize_ = fontElementSize;
            this.color_ = color;
            this.DecoratedColor = decoratedColor;
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

        public new bool DecoratedFontElementSize
        {
            get
            {
                if (this.fontElementSize_ > 0)
                {
                    return true;
                }
                else
                {
                    return base.DecoratedFontElementSize;
                }

            }
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
                if (this.fontElementSize_ > 0)
                {
                    return this.fontElementSize_;
                }
                else
                {
                    return base.FontElementSize;
                }
            }
        }

        public override NiconicoWebTextSegmentType SegmentType
        {
            get { return NiconicoWebTextSegmentType.HtmlFontElement; }
        }

        private Color color_;


        
        private FontElementSize fontElementSize_;

        internal static HtmlFontNiconicoWebTextSegment<T> ParseWebText(System.Text.RegularExpressions.Match match, NiconicoWebTextSegmenter segmenter, T parent)
        {
            var segment = ParseWebTextPartial(match, parent);
            segment.Segments = segmenter.PartialDivide(match.Groups[NiconicoWebTextPatternIndexs.fontTextGroupNumber].Value, segment);
            return segment;
        }


        internal static HtmlFontNiconicoWebTextSegment<T> ParseWebTextPartial(Match match, T parent)
        {
            return ParseTextPartial(match, parent, NiconicoWebTextPatternIndexs.sizeGroupNumber, NiconicoWebTextPatternIndexs.colorCodeGroupNumber, NiconicoWebTextPatternIndexs.colorNameGroupNumber);
        }

        internal static HtmlFontNiconicoWebTextSegment<T> ParseTextPartial(Match match, T parent, int sizeGroupNumber, int colorCodeGroupNumber, int colorNameGroupNumber)
        {
            var fontElementSizeGroup = match.Groups[sizeGroupNumber];
            var colorCodeGroup = match.Groups[colorCodeGroupNumber];
            var colorNameGroup = match.Groups[colorNameGroupNumber];
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
                var firstChar = fontElementSizeGroup.Value[0];

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

            HtmlFontNiconicoWebTextSegment<T> segment;

            if (colorCodeGroup.Success)
            {
                segment = new HtmlFontNiconicoWebTextSegment<T>(fontSize, codeColor, parent);
            }
            else if (colorNameGroup.Success)
            {
                segment = new HtmlFontNiconicoWebTextSegment<T>(fontSize, nameColor, parent);
            }
            else
            {
                segment = new HtmlFontNiconicoWebTextSegment<T>(fontSize, parent);
            }

            return segment;
        }
    }
}
