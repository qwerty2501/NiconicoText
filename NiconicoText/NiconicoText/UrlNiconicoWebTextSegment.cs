using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiconicoText
{
    internal sealed class UrlNiconicoWebTextSegment:NiconicoWebTextSegmentBase,IReadOnlyNiconicoWebTextSegment,INiconicoTextSegment
    {
        internal UrlNiconicoWebTextSegment(Uri url, IReadOnlyNiconicoWebTextSegment parent):base(parent)
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



        internal static IReadOnlyNiconicoWebTextSegment ParseWebText(System.Text.RegularExpressions.Match match, NiconicoWebTextSegmenter segmenter, IReadOnlyNiconicoWebTextSegment parent)
        {
            return new UrlNiconicoWebTextSegment(new Uri(match.Groups[NiconicoWebTextPatternIndexs.urlGroupNumber].Value),parent);
        }
    }
}
