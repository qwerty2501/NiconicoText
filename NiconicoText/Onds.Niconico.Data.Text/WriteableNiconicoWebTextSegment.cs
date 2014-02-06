using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Onds.Niconico.Data.Text
{
    internal sealed class WriteableNiconicoWebTextSegment:INiconicoTextSegment,INiconicoWebTextSegment,IReadOnlyNiconicoWebTextSegment,INiconicoWebTextSegmentTuner
    {
        internal WriteableNiconicoWebTextSegment(string text, NiconicoWebTextSegmentType segmentType, INiconicoWebTextSegment parent) : this(text, text, segmentType, NiconicoWebTextDecorateFlags.None, parent, null) { }

        internal WriteableNiconicoWebTextSegment(string text, string friendlyText, NiconicoWebTextSegmentType segmentType,NiconicoWebTextDecorateFlags flags, INiconicoWebTextSegment parent, NiconicoWebTextSegmentCollection segments)
        {
            this.Text = text;
            this.FriendlyText = friendlyText;
            this.SegmentType = segmentType;
            this.decorateFlag_ = flags;
            this.Parent = parent;
            this.Segments = segments;
        }

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
                if (this.Url != null)
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

        internal static INiconicoWebTextSegment ParseCommunityIdWebText(Match match, NiconicoWebTextSegmenter segmenter, INiconicoWebTextSegment parent)
        {
            return CommunityIdNiconicoWebTextSegment<INiconicoWebTextSegment>.ParseWebText(match, segmenter, parent);
        }

        internal static INiconicoWebTextSegment ParseChannelIdWebText(Match match, NiconicoWebTextSegmenter segmenter, INiconicoWebTextSegment parent)
        {
            return ChannelIdNiconicoWebTextSegment<INiconicoWebTextSegment>.ParseWebText(match, segmenter, parent);
        }

        internal static INiconicoWebTextSegment ParseVideoIdWebText(Match match, NiconicoWebTextSegmenter segmenter, INiconicoWebTextSegment parent)
        {
            return VideoIdNiconicoWebTextSegment<INiconicoWebTextSegment>.ParseWebText(match, segmenter, parent);
        }

        internal static INiconicoWebTextSegment ParseArticleIdWebText(Match match, NiconicoWebTextSegmenter segmenter, INiconicoWebTextSegment parent)
        {
            return ArticleIdNiconicoWebTextSegment<INiconicoWebTextSegment>.ParseWebText(match, segmenter, parent);
        }

        internal static INiconicoWebTextSegment ParseMaterialIdWebText(Match match, NiconicoWebTextSegmenter segmenter, INiconicoWebTextSegment parent)
        {
            return MaterialIdNiconicoWebTextSegment<INiconicoWebTextSegment>.ParseWebText(match, segmenter, parent);
        }

        internal static INiconicoWebTextSegment ParseMarketItemIdWebText(Match match, NiconicoWebTextSegmenter segmenter, INiconicoWebTextSegment parent)
        {
            return MarketItemIdNiconicoWebTextSegment<INiconicoWebTextSegment>.ParseWebText(match, segmenter, parent);
        }

        internal static INiconicoWebTextSegment ParseLiveIdWebText(Match match, NiconicoWebTextSegmenter segmenter, INiconicoWebTextSegment parent)
        {
            return LiveIdNiconicoWebTextSegment<INiconicoWebTextSegment>.ParseWebText(match, segmenter, parent);
        }

        internal static INiconicoWebTextSegment ParseWatchPictureIdWebText(Match match, NiconicoWebTextSegmenter segmenter, INiconicoWebTextSegment parent)
        {
            return WatchPictureIdNiconicoWebTextSegment<INiconicoWebTextSegment>.ParseWebText(match, segmenter, parent);
        }


        internal static INiconicoWebTextSegment ParsePictureIdWebText(Match match, NiconicoWebTextSegmenter segmenter, INiconicoWebTextSegment parent)
        {
            return PictureIdNiconicoWebTextSegment<INiconicoWebTextSegment>.ParseWebText(match, segmenter, parent);
        }



        internal static INiconicoWebTextSegment ParseUrlWebText(Match match, NiconicoWebTextSegmenter segmenter, INiconicoWebTextSegment parent)
        {
            return UrlNiconicoWebTextSegment<INiconicoWebTextSegment>.ParseWebText(match, segmenter, parent);
        }



        internal static INiconicoWebTextSegment ParseNumberAnchorWebText(Match match, NiconicoWebTextSegmenter segmenter, INiconicoWebTextSegment parent)
        {
            return NumberAnchorNiconicoWebTextSegment<INiconicoWebTextSegment>.ParseWebText(match, segmenter, parent);
        }



        internal static WriteableNiconicoWebTextSegment ParseHtmlFontWebText(Match match, NiconicoWebTextSegmenter segmenter, INiconicoWebTextSegment parent)
        {
            var segment = new WriteableNiconicoWebTextSegment(match.Value,match.Groups[NiconicoWebTextPatternIndexs.fontTextGroupNumber].Value, NiconicoWebTextSegmentType.HtmlFontElement,NiconicoWebTextDecorateFlags.None, parent,null);
            var readOnlySegment = HtmlFontNiconicoWebTextSegment<INiconicoWebTextSegment>.ParseWebTextPartial(match, parent);
            

            
            segment.FontElementSize = readOnlySegment.FontElementSize;

            setSegments(segment, segmenter);
            
            if (readOnlySegment.DecoratedColor)
            {
                segment.Color = readOnlySegment.Color;
                segment.decorateFlag_ |= NiconicoWebTextDecorateFlags.DecoratedColorFlag;
            }

            return segment;
        }


        private  static void setSegments(WriteableNiconicoWebTextSegment segment,NiconicoWebTextSegmenter segmenter)
        {
            segment.Segments = new NiconicoWebTextSegmentCollection(segment, segmenter.WritablePartialDivide(segment.FriendlyText, segment));
        }

        internal static INiconicoWebTextSegment ParseLineBreakWebText(Match match, NiconicoWebTextSegmenter segmenter, INiconicoWebTextSegment parent)
        {
            return new WriteableNiconicoWebTextSegment(match.Value, Environment.NewLine, NiconicoWebTextSegmentType.LineBreak, NiconicoWebTextDecorateFlags.None, parent, null);
        }

        internal static INiconicoWebTextSegment ParseHtmlBreakWebText(Match match, NiconicoWebTextSegmenter segmenter, INiconicoWebTextSegment parent)
        {
            return ParseLineBreakWebText(match, segmenter, parent);
        }

        internal static INiconicoWebTextSegment ParseHtmlBoldWebText(Match match, NiconicoWebTextSegmenter segmenter, INiconicoWebTextSegment parent)
        {
            var segment = new WriteableNiconicoWebTextSegment(match.Value,match.Groups[NiconicoWebTextPatternIndexs.boldTextGroupNumber].Value, NiconicoWebTextSegmentType.HtmlBoldElement,NiconicoWebTextDecorateFlags.DecoratedBoldFlag, parent,null);
            setSegments(segment, segmenter);
            return segment;
        }

        internal static INiconicoWebTextSegment ParseHtmlItalicWebText(Match match, NiconicoWebTextSegmenter segmenter, INiconicoWebTextSegment parent)
        {
            var segment = new WriteableNiconicoWebTextSegment(match.Value, match.Groups[NiconicoWebTextPatternIndexs.italicTextGroupNumber].Value, NiconicoWebTextSegmentType.HtmlItalicElement, NiconicoWebTextDecorateFlags.DecoratedItalicFlag, parent, null);
            setSegments(segment, segmenter);
            return segment;
        }

        internal static INiconicoWebTextSegment ParseHtmlStrikeWebText(Match match, NiconicoWebTextSegmenter segmenter, INiconicoWebTextSegment parent)
        {
            var segment = new WriteableNiconicoWebTextSegment(match.Value, match.Groups[NiconicoWebTextPatternIndexs.strikeTextGroupNumber].Value,NiconicoWebTextSegmentType.HtmlStrikeElement,NiconicoWebTextDecorateFlags.DecoratedStrikeFlag, parent,null);
            setSegments(segment, segmenter);
            return segment;
        }

        internal static INiconicoWebTextSegment ParseHtmlUnderLineWebText(Match match, NiconicoWebTextSegmenter segmenter, INiconicoWebTextSegment parent)
        {
            var segment = new WriteableNiconicoWebTextSegment(match.Value, match.Groups[NiconicoWebTextPatternIndexs.underLineTextGroupNumber].Value, NiconicoWebTextSegmentType.HtmlUnderLineElement, NiconicoWebTextDecorateFlags.DecoratedUnderLineFlag, parent, null);
            setSegments(segment, segmenter);
            return segment;
        }

        internal static INiconicoWebTextSegment ParseHtmlInvalidElementWebText(Match match, NiconicoWebTextSegmenter segmenter, INiconicoWebTextSegment parent)
        {
            var segment = new WriteableNiconicoWebTextSegment(match.Value, string.Empty, NiconicoWebTextSegmentType.HtmlInvalidElement, NiconicoWebTextDecorateFlags.None, parent, null);
            segment.Segments = new NiconicoWebTextSegmentCollection(segment, segmenter.WritablePartialDivide(segment.Text.Substring(1, segment.Text.Length - 1), segment));
            return segment;
        }

        internal static INiconicoWebTextSegment CreatePlainText(string text, INiconicoWebTextSegment parent)
        {
            return new PlainNiconicoWebTextSegment<INiconicoWebTextSegment>(text, parent);
        }
    }
}
