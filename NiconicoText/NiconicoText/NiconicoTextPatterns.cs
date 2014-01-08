

namespace NiconicoText
{
    public static partial class NiconicoTextPatterns
    {
        			



		
		
		public string CommunityIdPattern 
		{
			get
			{
				return communityIdPattern;
			}
		}

		private const string communityIdPattern = @"co\d{1,14}" ;

		internal const string communityIdGroupPattern = "(?<communityId>" +  communityIdPattern + ")";

		
		public string ChannelIdPattern 
		{
			get
			{
				return channelIdPattern;
			}
		}

		private const string channelIdPattern = @"ch\d{1,14}" ;

		internal const string channelIdGroupPattern = "(?<channelId>" +  channelIdPattern + ")";

		
		public string VideoIdPattern 
		{
			get
			{
				return videoIdPattern;
			}
		}

		private const string videoIdPattern = @"(?:sm|nm|so|ca|ax|yo|nl|ig|na|cw|z[a-e]|om|sk|yk)\d{1,14}" ;

		internal const string videoIdGroupPattern = "(?<videoId>" +  videoIdPattern + ")";

		


    }
}
