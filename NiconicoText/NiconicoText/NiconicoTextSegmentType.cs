using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiconicoText
{
    public enum NiconicoTextSegmentType
    {
        Plain,
        Url,
        VideoId,
        LiveId,
        CommunityId,
        ChanelId,
        ArticleId,
        MaterialId,
        MarketId,
        StillImageId,
        LineBreak,
        UserName,
        Command,
        HtmlAnchorElement,
        HtmlFontElement,
        HtmlItalicElement,
        HtmlStrikeElement,
        HtmlUnderLineElement,
        HtmlInvalidElement,
    }
}
