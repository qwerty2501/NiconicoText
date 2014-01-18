using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiconicoText
{
    /// <summary>
    /// Niconico web text segment type
    /// </summary>
    public enum NiconicoWebTextSegmentType
    {
        /// <summary>
        /// Plain text.
        /// </summary>
        Plain,

        /// <summary>
        /// Url.
        /// </summary>
        Url,

        /// <summary>
        /// Niconico Video Id.
        /// </summary>
        VideoId,

        /// <summary>
        /// Niconico Live Id.
        /// </summary>
        LiveId,

        /// <summary>
        /// Niconico Community Id.
        /// </summary>
        CommunityId,

        /// <summary>
        /// Niconico Chanel Id.
        /// </summary>
        ChanelId,

        /// <summary>
        /// Niconico Article Id.
        /// </summary>
        ArticleId,

        /// <summary>
        /// Niconico MaterialId.
        /// </summary>
        MaterialId,

        /// <summary>
        /// Niconico Ichiba Id.
        /// </summary>
        MarketId,

        /// <summary>
        /// Niconico Seiga Id.
        /// </summary>
        StillImageId,

        /// <summary>
        /// Line break.
        /// </summary>
        LineBreak,

        /// <summary>
        /// User name.
        /// </summary>
        UserName,



        /// <summary>
        /// Html anchor element.
        /// </summary>
        HtmlAnchorElement,

        /// <summary>
        /// Html font element.
        /// </summary>
        HtmlFontElement,

        /// <summary>
        /// Html italic element.
        /// </summary>
        HtmlItalicElement,

        /// <summary>
        /// Html strike element.
        /// </summary>
        HtmlStrikeElement,

        /// <summary>
        /// Html underLine element.
        /// </summary>
        HtmlUnderLineElement,

        /// <summary>
        /// Html invalid element.
        /// </summary>
        HtmlInvalidElement,
    }
}
