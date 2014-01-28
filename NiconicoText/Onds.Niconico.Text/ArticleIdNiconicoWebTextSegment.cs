using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Onds.Niconico.Text
{
    internal sealed  class ArticleIdNiconicoWebTextSegment:IdNiconicoWebTextSegmentBase,IReadOnlyNiconicoWebTextSegment
    {
        internal ArticleIdNiconicoWebTextSegment(string articleId, IReadOnlyNiconicoWebTextSegment parent) : base(articleId,parent) { }

        public override NiconicoWebTextSegmentType SegmentType
        {
            get { return NiconicoWebTextSegmentType.ArticleId; }
        }

        internal static IReadOnlyNiconicoWebTextSegment ParseWebText(System.Text.RegularExpressions.Match match, NiconicoWebTextSegmenter segmenter, IReadOnlyNiconicoWebTextSegment parent)
        {
            return new ArticleIdNiconicoWebTextSegment(match.Groups[NiconicoWebTextPatternIndexs.articleIdGroupNumber].Value,parent);
        }
    }
}
