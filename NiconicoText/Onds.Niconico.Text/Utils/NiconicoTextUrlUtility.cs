using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Onds.Niconico.Text.Utils
{
    public static class NiconicoTextUrlUtility
    {
        public static Uri CreateNiconicoVideoWatchUrl(string videoId)
        {
            return new Uri(string.Format(NiconicoWebTextPatterns.niconicoVideoUrlFormat, videoId));
        }

        public static Uri CraeteNiconicoLiveWatchUrl(string liveId)
        {
            return new Uri(string.Format(NiconicoWebTextPatterns.niconicoLiveUrlFormat, liveId));
        }

        public static Uri CreateNiconicoCommunityTopPageUrl(string communityId)
        {
            return new Uri(string.Format(NiconicoWebTextPatterns.niconicoCommunityUrlFormat, communityId));
        }

        public static Uri CreateNiconicoChannelTopPageUrl(string chanelId)
        {
            return new Uri(string.Format(NiconicoWebTextPatterns.niconicoChannelUrlFormat, chanelId));
        }

    }
}
