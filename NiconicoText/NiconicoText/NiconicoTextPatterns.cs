
namespace NiconicoText
{
	

    internal static partial class NiconicoTextPatterns
    {

		

        

		
		internal const string communityIdPattern=@"co\d{1,14}";


		internal const string communityId="communityId";


		internal const string communityIdGroupPattern=@"(?<communityId>co\d{1,14})";


			
		internal const string channelIdPattern=@"ch\d{1,14}";


		internal const string channelId="channelId";


		internal const string channelIdGroupPattern=@"(?<channelId>ch\d{1,14})";


			
		internal const string videoIdPattern=@"(?:sm|nm|so|ca|ax|yo|nl|ig|na|cw|z[a-e]|om|sk|yk)\d{1,14}";


		internal const string videoId="videoId";


		internal const string videoIdGroupPattern=@"(?<videoId>(?:sm|nm|so|ca|ax|yo|nl|ig|na|cw|z[a-e]|om|sk|yk)\d{1,14})";


			
		internal const string articleIdPattern=@"ar\d{1,14}";


		internal const string articleId="articleId";


		internal const string articleIdGroupPattern=@"(?<articleId>ar\d{1,14})";


			
		internal const string materialIdPattern=@"nc\d{1,14}";


		internal const string materialId="materialId";


		internal const string materialIdGroupPattern=@"(?<materialId>nc\d{1,14})";


			
		internal const string marketItemIdPattern=@"(?:dw\d+|az[A-Z0-9]{10}|ys[a-zA-Z0-9-]+_[a-zA-Z0-9-]|ga\d+|ip[\d_]+|gg[a-zA-Z0-9]+-[a-zA-Z0-9-]+)";


		internal const string marketItemId="marketItemId";


		internal const string marketItemIdGroupPattern=@"(?<marketItemId>(?:dw\d+|az[A-Z0-9]{10}|ys[a-zA-Z0-9-]+_[a-zA-Z0-9-]|ga\d+|ip[\d_]+|gg[a-zA-Z0-9]+-[a-zA-Z0-9-]+))";


			
		internal const string liveIdPattern=@"lv\d{1,14}";


		internal const string liveId="liveId";


		internal const string liveIdGroupPattern=@"(?<liveId>lv\d{1,14})";


			
		internal const string watchStillImageIdPattern=@"(?:[sm]g|im)\d{1,14}";


		internal const string watchStillImageId="watchStillImageId";


		internal const string watchStillImageIdGroupPattern=@"(?<watchStillImageId>(?:[sm]g|im)\d{1,14})";


			
		internal const string stillImageIdPattern=@"im\d{1,14}";


		internal const string stillImageId="stillImageId";


		internal const string stillImageIdGroupPattern=@"(?<stillImageId>im\d{1,14})";


			
		internal const string urlPattern=@"https?://[\w/:%#\$&\?\(\)~\.=\+\-]+";


		internal const string url="url";


		internal const string urlGroupPattern=@"(?<url>https?://[\w/:%#\$&\?\(\)~\.=\+\-]+)";


			
		internal const string htmlFontPattern=@"<(?i:font)\s+?(?:(?:(?i:color)=\""(?:(?<colorCode>#?[a-fA-F0-9]{6})|(?<colorName>[a-zA-Z]{1,25}))|(?i:size)=\""(?<size>[+-]?[1-7]))\""\s*?)*?>(?<fontText>.*?)</(?i:font)\s*?>";


		internal const string htmlFont="htmlFont";


		internal const string htmlFontGroupPattern=@"(?<htmlFont><(?i:font)\s+?(?:(?:(?i:color)=\""(?:(?<colorCode>#?[a-fA-F0-9]{6})|(?<colorName>[a-zA-Z]{1,25}))|(?i:size)=\""(?<size>[+-]?[1-7]))\""\s*?)*?>(?<fontText>.*?)</(?i:font)\s*?>)";


			
		internal const string lineBreakPattern=@"(?:\r?\n|<(?i:br)\s*?/?>)";


		internal const string lineBreak="lineBreak";


		internal const string lineBreakGroupPattern=@"(?<lineBreak>(?:\r?\n|<(?i:br)\s*?/?>))";


			
		internal const string htmlBoldPattern=@"<[bB]\s*?>(?<boldText>.*?)</[bB]\s*?>";


		internal const string htmlBold="htmlBold";


		internal const string htmlBoldGroupPattern=@"(?<htmlBold><[bB]\s*?>(?<boldText>.*?)</[bB]\s*?>)";


			
		internal const string htmlItalicPattern=@"<[iI]\s*?>(?<italicText>.*?)</[iI]\s*?>";


		internal const string htmlItalic="htmlItalic";


		internal const string htmlItalicGroupPattern=@"(?<htmlItalic><[iI]\s*?>(?<italicText>.*?)</[iI]\s*?>)";


			
		internal const string htmlStrikePattern=@"<[sS]\s*?>(?<strikeText>.*?)</[sS]\s*?>";


		internal const string htmlStrike="htmlStrike";


		internal const string htmlStrikeGroupPattern=@"(?<htmlStrike><[sS]\s*?>(?<strikeText>.*?)</[sS]\s*?>)";


			
		internal const string htmlUnderLinePattern=@"<[uU]\s*?>(?<underLineText>.*?)</[uU]\s*?>";


		internal const string htmlUnderLine="htmlUnderLine";


		internal const string htmlUnderLineGroupPattern=@"(?<htmlUnderLine><[uU]\s*?>(?<underLineText>.*?)</[uU]\s*?>)";


			
		internal const string invalidHtmlElementPattern=@"</?.*?>";


		internal const string invalidHtmlElement="invalidHtmlElement";


		internal const string invalidHtmlElementGroupPattern=@"(?<invalidHtmlElement></?.*?>)";


			
		internal const string niconicoTextParsePattern = @"(?:(?<communityId>co\d{1,14})|(?<channelId>ch\d{1,14})|(?<videoId>(?:sm|nm|so|ca|ax|yo|nl|ig|na|cw|z[a-e]|om|sk|yk)\d{1,14})|(?<articleId>ar\d{1,14})|(?<materialId>nc\d{1,14})|(?<marketItemId>(?:dw\d+|az[A-Z0-9]{10}|ys[a-zA-Z0-9-]+_[a-zA-Z0-9-]|ga\d+|ip[\d_]+|gg[a-zA-Z0-9]+-[a-zA-Z0-9-]+))|(?<liveId>lv\d{1,14})|(?<watchStillImageId>(?:[sm]g|im)\d{1,14})|(?<stillImageId>im\d{1,14})|(?<url>https?://[\w/:%#\$&\?\(\)~\.=\+\-]+)|(?<htmlFont><(?i:font)\s+?(?:(?:(?i:color)=\""(?:(?<colorCode>#?[a-fA-F0-9]{6})|(?<colorName>[a-zA-Z]{1,25}))|(?i:size)=\""(?<size>[+-]?[1-7]))\""\s*?)*?>(?<fontText>.*?)</(?i:font)\s*?>)|(?<lineBreak>(?:\r?\n|<(?i:br)\s*?/?>))|(?<htmlBold><[bB]\s*?>(?<boldText>.*?)</[bB]\s*?>)|(?<htmlItalic><[iI]\s*?>(?<italicText>.*?)</[iI]\s*?>)|(?<htmlStrike><[sS]\s*?>(?<strikeText>.*?)</[sS]\s*?>)|(?<htmlUnderLine><[uU]\s*?>(?<underLineText>.*?)</[uU]\s*?>)|(?<invalidHtmlElement></?.*?>))";


		internal const int communityIdGroupNumber=1;


				
		internal const int channelIdGroupNumber=2;


				
		internal const int videoIdGroupNumber=3;


				
		internal const int articleIdGroupNumber=4;


				
		internal const int materialIdGroupNumber=5;


				
		internal const int marketItemIdGroupNumber=6;


				
		internal const int liveIdGroupNumber=7;


				
		internal const int watchStillImageIdGroupNumber=8;


				
		internal const int stillImageIdGroupNumber=9;


				
		internal const int urlGroupNumber=10;


				
		internal const int htmlFontGroupNumber=11;


				
		internal const int colorCodeGroupNumber=12;


				
		internal const int colorNameGroupNumber=13;


				
		internal const int sizeGroupNumber=14;


				
		internal const int fontTextGroupNumber=15;


				
		internal const int lineBreakGroupNumber=16;


				
		internal const int htmlBoldGroupNumber=17;


				
		internal const int boldTextGroupNumber=18;


				
		internal const int htmlItalicGroupNumber=19;


				
		internal const int italicTextGroupNumber=20;


				
		internal const int htmlStrikeGroupNumber=21;


				
		internal const int strikeTextGroupNumber=22;


				
		internal const int htmlUnderLineGroupNumber=23;


				
		internal const int underLineTextGroupNumber=24;


				
		internal const int invalidHtmlElementGroupNumber=25;


				    }

	namespace Comments{
		internal static class NiconicoCommentTextPatterns
		{
			
	
		internal const string numberAnchorPattern=@">>[0-9]+?(?:-(?<secondAnchor>[0-9]+?))?";


		internal const string numberAnchor="numberAnchor";


		internal const string numberAnchorGroupPattern=@"(?<numberAnchor>>>[0-9]+?(?:-(?<secondAnchor>[0-9]+?))?)";


			
		internal const string htmlAnchorPattern=@"<[aA]\s+?.*?href=\""(?<href>https?://[\w/:%#\$&\?\(\)~\.=\+\-]+)\""\s*?.*?>(?<anchorText>.*?)</[aA]\s*?>";


		internal const string htmlAnchor="htmlAnchor";


		internal const string htmlAnchorGroupPattern=@"(?<htmlAnchor><[aA]\s+?.*?href=\""(?<href>https?://[\w/:%#\$&\?\(\)~\.=\+\-]+)\""\s*?.*?>(?<anchorText>.*?)</[aA]\s*?>)";


					internal const string niconicoCommentTextParsePattern = @"(?:(?<numberAnchor>>>[0-9]+?(?:-(?<secondAnchor>[0-9]+?))?)|(?<htmlAnchor><[aA]\s+?.*?href=\""(?<href>https?://[\w/:%#\$&\?\(\)~\.=\+\-]+)\""\s*?.*?>(?<anchorText>.*?)</[aA]\s*?>))|(?:(?<communityId>co\d{1,14})|(?<channelId>ch\d{1,14})|(?<videoId>(?:sm|nm|so|ca|ax|yo|nl|ig|na|cw|z[a-e]|om|sk|yk)\d{1,14})|(?<articleId>ar\d{1,14})|(?<materialId>nc\d{1,14})|(?<marketItemId>(?:dw\d+|az[A-Z0-9]{10}|ys[a-zA-Z0-9-]+_[a-zA-Z0-9-]|ga\d+|ip[\d_]+|gg[a-zA-Z0-9]+-[a-zA-Z0-9-]+))|(?<liveId>lv\d{1,14})|(?<watchStillImageId>(?:[sm]g|im)\d{1,14})|(?<stillImageId>im\d{1,14})|(?<url>https?://[\w/:%#\$&\?\(\)~\.=\+\-]+)|(?<htmlFont><(?i:font)\s+?(?:(?:(?i:color)=\""(?:(?<colorCode>#?[a-fA-F0-9]{6})|(?<colorName>[a-zA-Z]{1,25}))|(?i:size)=\""(?<size>[+-]?[1-7]))\""\s*?)*?>(?<fontText>.*?)</(?i:font)\s*?>)|(?<lineBreak>(?:\r?\n|<(?i:br)\s*?/?>))|(?<htmlBold><[bB]\s*?>(?<boldText>.*?)</[bB]\s*?>)|(?<htmlItalic><[iI]\s*?>(?<italicText>.*?)</[iI]\s*?>)|(?<htmlStrike><[sS]\s*?>(?<strikeText>.*?)</[sS]\s*?>)|(?<htmlUnderLine><[uU]\s*?>(?<underLineText>.*?)</[uU]\s*?>)|(?<invalidHtmlElement></?.*?>))";


		internal const int numberAnchorGroupNumber=1;


				
		internal const int secondAnchorGroupNumber=2;


				
		internal const int htmlAnchorGroupNumber=3;


				
		internal const int hrefGroupNumber=4;


				
		internal const int anchorTextGroupNumber=5;


				
		internal const int communityIdGroupNumber=6;


				
		internal const int channelIdGroupNumber=7;


				
		internal const int videoIdGroupNumber=8;


				
		internal const int articleIdGroupNumber=9;


				
		internal const int materialIdGroupNumber=10;


				
		internal const int marketItemIdGroupNumber=11;


				
		internal const int liveIdGroupNumber=12;


				
		internal const int watchStillImageIdGroupNumber=13;


				
		internal const int stillImageIdGroupNumber=14;


				
		internal const int urlGroupNumber=15;


				
		internal const int htmlFontGroupNumber=16;


				
		internal const int colorCodeGroupNumber=17;


				
		internal const int colorNameGroupNumber=18;


				
		internal const int sizeGroupNumber=19;


				
		internal const int fontTextGroupNumber=20;


				
		internal const int lineBreakGroupNumber=21;


				
		internal const int htmlBoldGroupNumber=22;


				
		internal const int boldTextGroupNumber=23;


				
		internal const int htmlItalicGroupNumber=24;


				
		internal const int italicTextGroupNumber=25;


				
		internal const int htmlStrikeGroupNumber=26;


				
		internal const int strikeTextGroupNumber=27;


				
		internal const int htmlUnderLineGroupNumber=28;


				
		internal const int underLineTextGroupNumber=29;


				
		internal const int invalidHtmlElementGroupNumber=30;


						}
	}
}
