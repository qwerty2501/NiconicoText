using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiconicoText
{
    internal static partial class NiconicoTextPatterns
    {
        internal const string partialNiconicoDomain = "nicovideo.jp";

        internal const string worldWideWebNiconicoDomain = "www." + partialNiconicoDomain;

        internal const string communityDomain = "com." + partialNiconicoDomain;

        internal const string liveDomain = "live." + partialNiconicoDomain;

        internal const string channelDomain = "ch." + partialNiconicoDomain;

        internal const string commonsDomain = "commons." + partialNiconicoDomain;

        internal const string marketDomain = "ichiba." + partialNiconicoDomain;

        internal const string stillImageDomain = "seiga." + partialNiconicoDomain;

        private const string httpSchema = "http://";

        private const string watchPathFormat = "/watch/{0}";

        internal const string niconicoVideoIdFormat = httpSchema + worldWideWebNiconicoDomain + watchPathFormat;

        internal const string niconicoLiveIdFormat = httpSchema + liveDomain + watchPathFormat;

    }
}
