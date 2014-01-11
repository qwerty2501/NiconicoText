

namespace NiconicoText
{
	

    public static partial class NiconicoTextPatterns
    {

		

        
		internal const string communityIdPattern = @"co\d{1,14}" ;

		internal const string communityIdKeyName = "communityId";

		internal const string communityIdGroupPattern = "(?<" + communityIdKeyName + ">" +  communityIdPattern + ")";

		
		internal const string channelIdPattern = @"ch\d{1,14}" ;

		internal const string channelIdKeyName = "channelId";

		internal const string channelIdGroupPattern = "(?<" + channelIdKeyName + ">" +  channelIdPattern + ")";

		
		internal const string videoIdPattern = @"(?:sm|nm|so|ca|ax|yo|nl|ig|na|cw|z[a-e]|om|sk|yk)\d{1,14}" ;

		internal const string videoIdKeyName = "videoId";

		internal const string videoIdGroupPattern = "(?<" + videoIdKeyName + ">" +  videoIdPattern + ")";

		
		internal const string articleIdPattern = @"ar\d{1,14}" ;

		internal const string articleIdKeyName = "articleId";

		internal const string articleIdGroupPattern = "(?<" + articleIdKeyName + ">" +  articleIdPattern + ")";

		
		internal const string materialIdPattern = @"nc\d{1,14}" ;

		internal const string materialIdKeyName = "materialId";

		internal const string materialIdGroupPattern = "(?<" + materialIdKeyName + ">" +  materialIdPattern + ")";

		
		internal const string marketItemIdPattern = @"(?:dw\d+|az[A-Z0-9]{10}|ys[a-zA-Z0-9-]+_[a-zA-Z0-9-]|ga\d+|ip[\d_]+|gg[a-zA-Z0-9]+-[a-zA-Z0-9-]+)" ;

		internal const string marketItemIdKeyName = "marketItemId";

		internal const string marketItemIdGroupPattern = "(?<" + marketItemIdKeyName + ">" +  marketItemIdPattern + ")";

		
		internal const string liveIdPattern = @"lv\d{1,14}" ;

		internal const string liveIdKeyName = "liveId";

		internal const string liveIdGroupPattern = "(?<" + liveIdKeyName + ">" +  liveIdPattern + ")";

		
		internal const string watchStillImageIdPattern = @"(?:[sm]g|im)\d{1,14}" ;

		internal const string watchStillImageIdKeyName = "watchStillImageId";

		internal const string watchStillImageIdGroupPattern = "(?<" + watchStillImageIdKeyName + ">" +  watchStillImageIdPattern + ")";

		
		internal const string stillImageIdPattern = @"im\d{1,14}" ;

		internal const string stillImageIdKeyName = "stillImageId";

		internal const string stillImageIdGroupPattern = "(?<" + stillImageIdKeyName + ">" +  stillImageIdPattern + ")";

		
		internal const string urlPattern = @"https?://[\w/:%#\$&\?\(\)~\.=\+\-]+" ;

		internal const string urlKeyName = "url";

		internal const string urlGroupPattern = "(?<" + urlKeyName + ">" +  urlPattern + ")";

		
		internal const string htmlAnchorPattern = @"<[aA]\s+?.*?href=\"""+"(?<href>" + urlPattern+")"+@"\""\s*?.*?>(?<anchorText>.*?)</[aA]\s*?>" ;

		internal const string htmlAnchorKeyName = "htmlAnchor";

		internal const string htmlAnchorGroupPattern = "(?<" + htmlAnchorKeyName + ">" +  htmlAnchorPattern + ")";

		
		internal const string htmlFontPattern = @"<(?i)font(?-i)\s+?(?:color=\""(?<color>#?[A-Za-z0-9]+?)|size=\""(?<size>[0-9]+?))\""\s*?)>(?<fontText>.*?)</(?i)font(?-i)\s*?>" ;

		internal const string htmlFontKeyName = "htmlFont";

		internal const string htmlFontGroupPattern = "(?<" + htmlFontKeyName + ">" +  htmlFontPattern + ")";

		
		internal const string singleAnchorPattern = @">>[0-9]+?" ;

		internal const string singleAnchorKeyName = "singleAnchor";

		internal const string singleAnchorGroupPattern = "(?<" + singleAnchorKeyName + ">" +  singleAnchorPattern + ")";

		
		internal const string rangeAnchorPattern = @">>[0-9]+?-[0-9]+?" ;

		internal const string rangeAnchorKeyName = "rangeAnchor";

		internal const string rangeAnchorGroupPattern = "(?<" + rangeAnchorKeyName + ">" +  rangeAnchorPattern + ")";

		
		internal const string lineBreakPattern = @"(?:\r?\n|<(?i)br(?-i)\s*?/?>)" ;

		internal const string lineBreakKeyName = "lineBreak";

		internal const string lineBreakGroupPattern = "(?<" + lineBreakKeyName + ">" +  lineBreakPattern + ")";

		
		internal const string htmlBoldPattern = @"<[bB]\s*?>(?<boldText>.*?)</[bB]\s*?>" ;

		internal const string htmlBoldKeyName = "htmlBold";

		internal const string htmlBoldGroupPattern = "(?<" + htmlBoldKeyName + ">" +  htmlBoldPattern + ")";

		
		internal const string htmlItalicPattern = @"<[iI]\s*?>(?<italicText>.*?)</[iI]\s*?>" ;

		internal const string htmlItalicKeyName = "htmlItalic";

		internal const string htmlItalicGroupPattern = "(?<" + htmlItalicKeyName + ">" +  htmlItalicPattern + ")";

		
		internal const string htmlStrikePattern = @"<[sS]\s*?>(?<strikeText>.*?)</[sS]\s*?>" ;

		internal const string htmlStrikeKeyName = "htmlStrike";

		internal const string htmlStrikeGroupPattern = "(?<" + htmlStrikeKeyName + ">" +  htmlStrikePattern + ")";

		
		internal const string htmlUnderLinePattern = @"<[uU]\s*?>(?<underLineText>.*?)</[uU]\s*?>" ;

		internal const string htmlUnderLineKeyName = "htmlUnderLine";

		internal const string htmlUnderLineGroupPattern = "(?<" + htmlUnderLineKeyName + ">" +  htmlUnderLinePattern + ")";

		
		internal const string invalidHtmlElementPattern = @"</?.*?>" ;

		internal const string invalidHtmlElementKeyName = "invalidHtmlElement";

		internal const string invalidHtmlElementGroupPattern = "(?<" + invalidHtmlElementKeyName + ">" +  invalidHtmlElementPattern + ")";

		


    }
}
