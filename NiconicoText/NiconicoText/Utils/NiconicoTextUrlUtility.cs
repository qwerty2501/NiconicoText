using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiconicoText.Utils
{
    public static class NiconicoTextUrlUtility
    {
        public static Uri CreateNiconicoVideoWatchUrl(string videoId)
        {
            return new Uri(string.Format(NiconicoTextPatterns.niconicoVideoUrlFormat, videoId));
        }

        public static Uri CraeteNiconicoLiveWatchUrl(string liveId)
        {
            return new Uri(string.Format(NiconicoTextPatterns.niconicoLiveUrlFormat, liveId));
        }

        public static Uri CreateNiconicoCommunityTopPageUrl(string communityId)
        {
            return new Uri(string.Format(NiconicoTextPatterns.niconicoCommunityUrlFormat, communityId));
        }

        public static Uri CreateNiconicoChannelTopPageUrl(string chanelId)
        {
            return new Uri(string.Format(NiconicoTextPatterns.niconicoChannelUrlFormat, chanelId));
        }

        internal static Func<string, Uri> CreateNiconicoVideoUrl
        {
            get
            { 
                return CreateNiconicoVideoWatchUrl; 
            }
        }

        internal static Func<string, Uri> CraeteNiconicoLiveUrl
        {
            get 
            { 
                return CraeteNiconicoLiveWatchUrl; 
            }
        }

        internal static Func<string, Uri> CreateNiconicoCommunityUrl
        {
            get
            {
                return CreateNiconicoCommunityTopPageUrl;
            }
        }

        internal static Func<string, Uri> CreateNiconicoChannelUrl
        {
            get
            {
                return CreateNiconicoChannelTopPageUrl;
            }
        }
    }
}
