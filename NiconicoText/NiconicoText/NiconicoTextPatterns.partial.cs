using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiconicoText
{
    public static partial class NiconicoTextPatterns
    {
        internal const string partialNiconicoDomain = "nicovideo.jp";

        internal const string communityDomain = "com." + partialNiconicoDomain;

        internal const string channelDomain = "ch." + partialNiconicoDomain;

        internal const string commonsDomain = "commons." + partialNiconicoDomain;

        internal const string marketDomain = "ichiba." + partialNiconicoDomain;

        internal const string stillImageDomain = "seiga." + partialNiconicoDomain;

        internal const string niconicoTextParsePattern = "(?:" + videoIdGroupPattern + "|" +
                                                         liveIdGroupPattern + "|" +
                                                         channelIdGroupPattern + "|" +
                                                         communityIdGroupPattern + "|" +
                                                         lineBreakGroupPattern + "|" +
                                                         articleIdGroupPattern + "|" +
                                                         materialIdGroupPattern + "|" +
                                                         marketItemIdGroupPattern + "|" +
                                                         watchStillImageIdGroupPattern + "|" +
                                                         stillImageIdGroupPattern + "|" +
                                                         htmlAnchorGroupPattern + "|" +
                                                         urlGroupPattern + "|" +
                                                         htmlFontGroupPattern + "|" +
                                                         lineBreakGroupPattern + "|" +
                                                         htmlBoldGroupPattern + "|" +
                                                         htmlItalicGroupPattern + "|" +
                                                         htmlStrikeGroupPattern + "|" +
                                                         htmlUnderLineGroupPattern + "|" +
                                                         invalidHtmlElementGroupPattern + ")";


    }
}
