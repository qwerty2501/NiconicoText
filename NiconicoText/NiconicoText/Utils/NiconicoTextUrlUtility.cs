using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiconicoText.Utils
{
    public static class NiconicoTextUrlUtility
    {
        public static Uri CreateNiconicoVideoUrl(string videoId)
        {
            return new Uri(string.Format(NiconicoTextPatterns.niconicoVideoUrlFormat, videoId));
        }

        public static Uri CraeteNiconicoLiveUrl(string liveId)
        {
            return new Uri(string.Format(NiconicoTextPatterns.niconicoLiveUrlFormat, liveId));
        }

        public static Uri CreateNiconicoCommunityUrl(string communityId)
        {
            return new Uri(string.Format(NiconicoTextPatterns.niconicoCommunityUrlFormat, communityId));
        }
    }
}
