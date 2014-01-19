﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiconicoText
{
    internal sealed class UrlNiconicoWebTextSegment:NiconicoWebTextSegmentBase,INiconicoWebTextSegment,INiconicoTextSegment
    {
        internal UrlNiconicoWebTextSegment(Uri url)
        {
            this.Url = url;
        }

        public new Uri Url
        {
            get;
            private set;
        }

        public override NiconicoWebTextSegmentType SegmentType
        {
            get { return NiconicoWebTextSegmentType.Url; }
        }

        public override string Text
        {
            get { return this.Url.OriginalString; }
        }



        internal static INiconicoWebTextSegment ParseWebText(System.Text.RegularExpressions.Match match, NiconicoWebTextSegmenter segmenter)
        {
            return new UrlNiconicoWebTextSegment(new Uri(match.Groups[NiconicoWebTextPatternIndexs.urlGroupNumber].Value));
        }
    }
}
