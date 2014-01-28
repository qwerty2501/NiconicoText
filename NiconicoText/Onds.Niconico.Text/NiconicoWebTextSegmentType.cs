using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Onds.Niconico.Text
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
        /// Niconico video id.
        /// </summary>
        VideoId,

        /// <summary>
        /// Niconico live id.
        /// </summary>
        LiveId,

        /// <summary>
        /// Niconico commnity id.
        /// </summary>
        CommunityId,

        /// <summary>
        /// Niconico chanel id.
        /// </summary>
        ChanelId,

        /// <summary>
        /// Niconico article id.
        /// </summary>
        ArticleId,

        /// <summary>
        /// Niconico commons's material id.
        /// </summary>
        MaterialId,

        /// <summary>
        /// Niconico ichiba id.
        /// </summary>
        MarketId,

        /// <summary>
        /// Niconico seiga id.
        /// </summary>
        PictureId,

        /// <summary>
        /// Line break.
        /// </summary>
        LineBreak,

        /// <summary>
        /// User name.
        /// </summary>
        UserName,

        /// <summary>
        /// Number anchor.
        /// </summary>
        NumberAnchor,

        /// <summary>
        /// Comment command.
        /// </summary>
        //Command,

        /// <summary>
        /// Comment command arg.
        /// </summary>
        //CommandArg,

        /// <summary>
        /// Html anchor element.
        /// </summary>
        HtmlAnchorElement,

        /// <summary>
        /// Html font element.
        /// </summary>
        HtmlFontElement,

        /// <summary>
        /// Html bold element.
        /// </summary>
        HtmlBoldElement,

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
