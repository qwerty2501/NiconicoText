using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiconicoText
{
    using Color = NiconicoTextColor;

    internal sealed class HtmlFontNiconicoWebTextSegment:SegmentsProsessionNiconicoWebTextSegmentBase,INiconicoWebTextSegment,INiconicoTextSegment
    {
        internal HtmlFontNiconicoWebTextSegment(FontElementSize fontElementSize, NiconicoWebTextSegmentCollection segments) : this(fontElementSize, default(Color), false, segments) { }

        internal HtmlFontNiconicoWebTextSegment(Color color, NiconicoWebTextSegmentCollection segments) : this(new FontElementSize(0), color, segments) { }

        internal HtmlFontNiconicoWebTextSegment(FontElementSize fontElementSize, Color color, NiconicoWebTextSegmentCollection segments) : this(fontElementSize, color, true, segments) { }

        private HtmlFontNiconicoWebTextSegment(FontElementSize fontElementSize, Color color, bool associatedColor, NiconicoWebTextSegmentCollection segments)
            : base(segments)
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

        internal static INiconicoWebTextSegment ParseWebText(System.Text.RegularExpressions.Match match,NiconicoWebTextSegmenter segmenter)
        {
            var fontElementSizeGroup = match.Groups[NiconicoWebTextPatternIndexs.sizeGroupNumber];
            var colorCodeGroup = match.Groups[NiconicoWebTextPatternIndexs.colorCodeGroupNumber];
            var colorNameGroup = match.Groups[NiconicoWebTextPatternIndexs.colorNameGroupNumber];
            var codeColor = new Color();
            var nameColor = new Color();
            var segments = segmenter.GetTokensInternal(match.Groups[NiconicoWebTextPatternIndexs.fontTextGroupNumber].Value);
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

            if (colorCodeGroup.Success)
            {
                return new HtmlFontNiconicoWebTextSegment(fontSize, codeColor, segments);
            }
            else if (colorNameGroup.Success)
            {
                return new HtmlFontNiconicoWebTextSegment(fontSize, nameColor, segments);
            }
            else
            {
                return new HtmlFontNiconicoWebTextSegment(fontSize, segments);
            }
            


        }
    }
}
