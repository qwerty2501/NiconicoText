

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

		private const string communityIdPattern = @"\bco\d{1,14}\b" ;

		internal const string communityIdKeyName = "communityId";

		internal const string communityIdGroupPattern = "(?<" + communityIdKeyName + ">" +  communityIdPattern + ")";

		
		public string ChannelIdPattern 
		{
			get
			{
				return channelIdPattern;
			}
		}

		private const string channelIdPattern = @"\bch\d{1,14}\b" ;

		internal const string channelIdKeyName = "channelId";

		internal const string channelIdGroupPattern = "(?<" + channelIdKeyName + ">" +  channelIdPattern + ")";

		
		public string VideoIdPattern 
		{
			get
			{
				return videoIdPattern;
			}
		}

		private const string videoIdPattern = @"(?:sm|nm|so|ca|ax|yo|nl|ig|na|cw|z[a-e]|om|sk|yk)\d{1,14}" ;

		internal const string videoIdKeyName = "videoId";

		internal const string videoIdGroupPattern = "(?<" + videoIdKeyName + ">" +  videoIdPattern + ")";

		
		public string ArticleIdPattern 
		{
			get
			{
				return articleIdPattern;
			}
		}

		private const string articleIdPattern = @"ar\d{1,14}" ;

		internal const string articleIdKeyName = "articleId";

		internal const string articleIdGroupPattern = "(?<" + articleIdKeyName + ">" +  articleIdPattern + ")";

		
		public string MaterialIdPattern 
		{
			get
			{
				return materialIdPattern;
			}
		}

		private const string materialIdPattern = @"nc\d{1,14}" ;

		internal const string materialIdKeyName = "materialId";

		internal const string materialIdGroupPattern = "(?<" + materialIdKeyName + ">" +  materialIdPattern + ")";

		
		public string MarketItemIdPattern 
		{
			get
			{
				return marketItemIdPattern;
			}
		}

		private const string marketItemIdPattern = @"(?:dw\d+|az[A-Z0-9]{10}|ys[a-zA-Z0-9-]+_[a-zA-Z0-9-]|ga\d+|ip[\d_]+|gg[a-zA-Z0-9]+-[a-zA-Z0-9-]+)" ;

		internal const string marketItemIdKeyName = "marketItemId";

		internal const string marketItemIdGroupPattern = "(?<" + marketItemIdKeyName + ">" +  marketItemIdPattern + ")";

		
		public string LiveIdPattern 
		{
			get
			{
				return liveIdPattern;
			}
		}

		private const string liveIdPattern = @"lv\d{1,14}" ;

		internal const string liveIdKeyName = "liveId";

		internal const string liveIdGroupPattern = "(?<" + liveIdKeyName + ">" +  liveIdPattern + ")";

		
		public string WatchStillImageIdPattern 
		{
			get
			{
				return watchStillImageIdPattern;
			}
		}

		private const string watchStillImageIdPattern = @"(?:[sm]g|im)\d{1,14}" ;

		internal const string watchStillImageIdKeyName = "watchStillImageId";

		internal const string watchStillImageIdGroupPattern = "(?<" + watchStillImageIdKeyName + ">" +  watchStillImageIdPattern + ")";

		
		public string StillImageIdPattern 
		{
			get
			{
				return stillImageIdPattern;
			}
		}

		private const string stillImageIdPattern = @"im\d{1,14}" ;

		internal const string stillImageIdKeyName = "stillImageId";

		internal const string stillImageIdGroupPattern = "(?<" + stillImageIdKeyName + ">" +  stillImageIdPattern + ")";

		
		public string UrlPattern 
		{
			get
			{
				return urlPattern;
			}
		}

		private const string urlPattern = @"https?://[\w/:%#\$&\?\(\)~\.=\+\-]+" ;

		internal const string urlKeyName = "url";

		internal const string urlGroupPattern = "(?<" + urlKeyName + ">" +  urlPattern + ")";

		
		public string HtmlAnchorPattern 
		{
			get
			{
				return htmlAnchorPattern;
			}
		}

		private const string htmlAnchorPattern = @"<a\s+?.*?href=\"""+"(?<href>" + urlPattern+")"+@"\""\s*?.*?>(?<anchorText>.*?)</a\s*?>" ;

		internal const string htmlAnchorKeyName = "htmlAnchor";

		internal const string htmlAnchorGroupPattern = "(?<" + htmlAnchorKeyName + ">" +  htmlAnchorPattern + ")";

		
		public string HtmlFontPattern 
		{
			get
			{
				return htmlFontPattern;
			}
		}

		private const string htmlFontPattern = @"<font\s+?(?:color=\""(?<color>#?[A-Za-z0-9]+?)|size=\""(?<size>[0-9]+?))\""\s*?)>(?<fontText>.*?)</font\s*?>" ;

		internal const string htmlFontKeyName = "htmlFont";

		internal const string htmlFontGroupPattern = "(?<" + htmlFontKeyName + ">" +  htmlFontPattern + ")";

		


    }
}
