using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiconicoText
{
    internal sealed  class ArticleIdNiconicoWebTextSegment:IdNiconicoWebTextSegmentBase,INiconicoWebTextSegment
    {
        internal ArticleIdNiconicoWebTextSegment(string articleId) : base(articleId) { }

        public override NiconicoWebTextSegmentType SegmentType
        {
            get { return NiconicoWebTextSegmentType.ArticleId; }
        }

        internal static INiconicoWebTextSegment ParseWebText(System.Text.RegularExpressions.Match match, NiconicoWebTextSegmenter segmenter)
        {
            return new ArticleIdNiconicoWebTextSegment(match.Groups[NiconicoWebTextPatternIndexs.articleIdGroupNumber].Value);
        }
    }
}
