using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Onds.Niconico.Data.Text
{
    internal sealed class UrlNiconicoWebTextSegment<T>:NiconicoWebTextSegmentBase<T>,IReadOnlyNiconicoWebTextSegment,INiconicoTextSegment
        where T:IReadOnlyNiconicoWebTextSegment
    {
        internal UrlNiconicoWebTextSegment(Uri url, T parent):base(parent)
        {
            this.Url = url;
        }

        public new bool HasUrl
        {
            get
            {
                return true;
            }
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



        internal static IReadOnlyNiconicoWebTextSegment ParseWebText(System.Text.RegularExpressions.Match match, NiconicoWebTextSegmenter segmenter, T parent)
        {
            return new UrlNiconicoWebTextSegment<T>(new Uri(match.Groups[NiconicoWebTextPatternIndexs.urlGroupNumber].Value),parent);
        }
    }
}
