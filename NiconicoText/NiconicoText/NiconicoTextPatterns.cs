
namespace NiconicoText
{
	using System.Text.RegularExpressions;
	using System.Linq;

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


			
		internal const string watchPictureIdPattern=@"(?:[sm]g|im)\d{1,14}";


		internal const string watchPictureId="watchPictureId";


		internal const string watchPictureIdGroupPattern=@"(?<watchPictureId>(?:[sm]g|im)\d{1,14})";


			
		internal const string pictureIdPattern=@"im\d{1,14}";


		internal const string PictureId="PictureId";


		internal const string PictureIdGroupPattern=@"(?<PictureId>im\d{1,14})";


			
		internal const string urlPattern=@"https?://[\w-](?:\.?[\w-]+)+(?:[0-9]*?)?(?:/[\w- ./?%&=]*)?";


		internal const string url="url";


		internal const string urlGroupPattern=@"(?<url>https?://[\w-](?:\.?[\w-]+)+(?:[0-9]*?)?(?:/[\w- ./?%&=]*)?)";


			
		internal const string numberAnchorPattern=@">>[0-9]+?(?:-(?<secondAnchor>[0-9]+?))?";


		internal const string numberAnchor="numberAnchor";


		internal const string numberAnchorGroupPattern=@"(?<numberAnchor>>>[0-9]+?(?:-(?<secondAnchor>[0-9]+?))?)";


			
		internal const string htmlFontPattern=@"<(?i:font)\s+?(?:(?:(?i:color)=\""(?:(?<colorCode>#?[a-fA-F0-9]{6})|(?<colorName>[a-zA-Z]{1,25}))|(?i:size)=\""(?<size>[+-]?[1-7]))\""\s*?)*?>(?<fontText>.*?)</(?i:font)\s*?>";


		internal const string htmlFont="htmlFont";


		internal const string htmlFontGroupPattern=@"(?<htmlFont><(?i:font)\s+?(?:(?:(?i:color)=\""(?:(?<colorCode>#?[a-fA-F0-9]{6})|(?<colorName>[a-zA-Z]{1,25}))|(?i:size)=\""(?<size>[+-]?[1-7]))\""\s*?)*?>(?<fontText>.*?)</(?i:font)\s*?>)";


			
		internal const string lineBreakPattern=@"\r?\n";


		internal const string lineBreak="lineBreak";


		internal const string lineBreakGroupPattern=@"(?<lineBreak>\r?\n)";


			
		internal const string htmlBreakPattern=@"<(?i:br)\s*?/?>";


		internal const string htmlBreak="htmlBreak";


		internal const string htmlBreakGroupPattern=@"(?<htmlBreak><(?i:br)\s*?/?>)";


			
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


			
		internal const string niconicoTextParsePattern = @"(?:(?<communityId>co\d{1,14})|(?<channelId>ch\d{1,14})|(?<videoId>(?:sm|nm|so|ca|ax|yo|nl|ig|na|cw|z[a-e]|om|sk|yk)\d{1,14})|(?<articleId>ar\d{1,14})|(?<materialId>nc\d{1,14})|(?<marketItemId>(?:dw\d+|az[A-Z0-9]{10}|ys[a-zA-Z0-9-]+_[a-zA-Z0-9-]|ga\d+|ip[\d_]+|gg[a-zA-Z0-9]+-[a-zA-Z0-9-]+))|(?<liveId>lv\d{1,14})|(?<watchPictureId>(?:[sm]g|im)\d{1,14})|(?<PictureId>im\d{1,14})|(?<url>https?://[\w-](?:\.?[\w-]+)+(?:[0-9]*?)?(?:/[\w- ./?%&=]*)?)|(?<numberAnchor>>>[0-9]+?(?:-(?<secondAnchor>[0-9]+?))?)|(?<htmlFont><(?i:font)\s+?(?:(?:(?i:color)=\""(?:(?<colorCode>#?[a-fA-F0-9]{6})|(?<colorName>[a-zA-Z]{1,25}))|(?i:size)=\""(?<size>[+-]?[1-7]))\""\s*?)*?>(?<fontText>.*?)</(?i:font)\s*?>)|(?<lineBreak>\r?\n)|(?<htmlBreak><(?i:br)\s*?/?>)|(?<htmlBold><[bB]\s*?>(?<boldText>.*?)</[bB]\s*?>)|(?<htmlItalic><[iI]\s*?>(?<italicText>.*?)</[iI]\s*?>)|(?<htmlStrike><[sS]\s*?>(?<strikeText>.*?)</[sS]\s*?>)|(?<htmlUnderLine><[uU]\s*?>(?<underLineText>.*?)</[uU]\s*?>)|(?<invalidHtmlElement></?.*?>))";


		internal const int communityIdGroupNumber=1;


				
		internal const int channelIdGroupNumber=2;


				
		internal const int videoIdGroupNumber=3;


				
		internal const int articleIdGroupNumber=4;


				
		internal const int materialIdGroupNumber=5;


				
		internal const int marketItemIdGroupNumber=6;


				
		internal const int liveIdGroupNumber=7;


				
		internal const int watchPictureIdGroupNumber=8;


				
		internal const int PictureIdGroupNumber=9;


				
		internal const int urlGroupNumber=10;


				
		internal const int numberAnchorGroupNumber=11;


				
		internal const int secondAnchorGroupNumber=12;


				
		internal const int htmlFontGroupNumber=13;


				
		internal const int colorCodeGroupNumber=14;


				
		internal const int colorNameGroupNumber=15;


				
		internal const int sizeGroupNumber=16;


				
		internal const int fontTextGroupNumber=17;


				
		internal const int lineBreakGroupNumber=18;


				
		internal const int htmlBreakGroupNumber=19;


				
		internal const int htmlBoldGroupNumber=20;


				
		internal const int boldTextGroupNumber=21;


				
		internal const int htmlItalicGroupNumber=22;


				
		internal const int italicTextGroupNumber=23;


				
		internal const int htmlStrikeGroupNumber=24;


				
		internal const int strikeTextGroupNumber=25;


				
		internal const int htmlUnderLineGroupNumber=26;


				
		internal const int underLineTextGroupNumber=27;


				
		internal const int invalidHtmlElementGroupNumber=28;


				
    }

	internal static class NiconicoWebTextSegmentMatchParser
	{
		
		internal static INiconicoWebTextSegment Parse(Match match)
		{
			
			int matchIndex;
			foreach(Group group in match.Groups)
			{
				if(group.Success)
					break;
				++matchIndex;
			}
			
			switch(matchIndex)
			{
			
				case NiconicoTextPatterns.communityIdGroupNumber:
		return CommunityIdNiconicoWebTextSegment.ParseWebText(match);

				case NiconicoTextPatterns.channelIdGroupNumber:
		return ChannelIdNiconicoWebTextSegment.ParseWebText(match);

				case NiconicoTextPatterns.videoIdGroupNumber:
		return VideoIdNiconicoWebTextSegment.ParseWebText(match);

				case NiconicoTextPatterns.articleIdGroupNumber:
		return ArticleIdNiconicoWebTextSegment.ParseWebText(match);

				case NiconicoTextPatterns.materialIdGroupNumber:
		return MaterialIdNiconicoWebTextSegment.ParseWebText(match);

				case NiconicoTextPatterns.marketItemIdGroupNumber:
		return MarketItemIdNiconicoWebTextSegment.ParseWebText(match);

				case NiconicoTextPatterns.liveIdGroupNumber:
		return LiveIdNiconicoWebTextSegment.ParseWebText(match);

				case NiconicoTextPatterns.watchPictureIdGroupNumber:
		return WatchPictureIdNiconicoWebTextSegment.ParseWebText(match);

				case NiconicoTextPatterns.PictureIdGroupNumber:
		return PictureIdNiconicoWebTextSegment.ParseWebText(match);

				case NiconicoTextPatterns.urlGroupNumber:
		return UrlNiconicoWebTextSegment.ParseWebText(match);

				case NiconicoTextPatterns.numberAnchorGroupNumber:
		return NumberAnchorNiconicoWebTextSegment.ParseWebText(match);

				case NiconicoTextPatterns.htmlFontGroupNumber:
		return HtmlFontNiconicoWebTextSegment.ParseWebText(match);

				case NiconicoTextPatterns.lineBreakGroupNumber:
		return LineBreakNiconicoWebTextSegment.ParseWebText(match);

				case NiconicoTextPatterns.htmlBreakGroupNumber:
		return HtmlBreakNiconicoWebTextSegment.ParseWebText(match);

				case NiconicoTextPatterns.htmlBoldGroupNumber:
		return HtmlBoldNiconicoWebTextSegment.ParseWebText(match);

				case NiconicoTextPatterns.htmlItalicGroupNumber:
		return HtmlItalicNiconicoWebTextSegment.ParseWebText(match);

				case NiconicoTextPatterns.htmlStrikeGroupNumber:
		return HtmlStrikeNiconicoWebTextSegment.ParseWebText(match);

				case NiconicoTextPatterns.htmlUnderLineGroupNumber:
		return HtmlUnderLineNiconicoWebTextSegment.ParseWebText(match);

				case NiconicoTextPatterns.invalidHtmlElementGroupNumber:
		return InvalidHtmlElementNiconicoWebTextSegment.ParseWebText(match);


			default:
					return new PlainNiconicoWebTextSegment(match.Value);
			}
		}

	}

	namespace Comments{

		internal static class NiconicoCommentTextPatterns
		{
			
	
		internal const string htmlAnchorPattern=@"<[aA]\s+?.*?href=\""(?<href>https?://[\w-](?:\.?[\w-]+)+(?:[0-9]*?)?(?:/[\w- ./?%&=]*)?)\""\s*?.*?>(?<anchorText>.*?)</[aA]\s*?>";


		internal const string htmlAnchor="htmlAnchor";


		internal const string htmlAnchorGroupPattern=@"(?<htmlAnchor><[aA]\s+?.*?href=\""(?<href>https?://[\w-](?:\.?[\w-]+)+(?:[0-9]*?)?(?:/[\w- ./?%&=]*)?)\""\s*?.*?>(?<anchorText>.*?)</[aA]\s*?>)";


			
		internal const string attoMarkNamePattern=@"@[^@^\s]+";


		internal const string attoMarkName="attoMarkName";


		internal const string attoMarkNameGroupPattern=@"(?<attoMarkName>@[^@^\s]+)";


			
		internal const string niconicoCommentTextParsePattern = @"(?:(?<htmlAnchor><[aA]\s+?.*?href=\""(?<href>https?://[\w-](?:\.?[\w-]+)+(?:[0-9]*?)?(?:/[\w- ./?%&=]*)?)\""\s*?.*?>(?<anchorText>.*?)</[aA]\s*?>)|(?<attoMarkName>@[^@^\s]+))|(?:(?<communityId>co\d{1,14})|(?<channelId>ch\d{1,14})|(?<videoId>(?:sm|nm|so|ca|ax|yo|nl|ig|na|cw|z[a-e]|om|sk|yk)\d{1,14})|(?<articleId>ar\d{1,14})|(?<materialId>nc\d{1,14})|(?<marketItemId>(?:dw\d+|az[A-Z0-9]{10}|ys[a-zA-Z0-9-]+_[a-zA-Z0-9-]|ga\d+|ip[\d_]+|gg[a-zA-Z0-9]+-[a-zA-Z0-9-]+))|(?<liveId>lv\d{1,14})|(?<watchPictureId>(?:[sm]g|im)\d{1,14})|(?<PictureId>im\d{1,14})|(?<url>https?://[\w-](?:\.?[\w-]+)+(?:[0-9]*?)?(?:/[\w- ./?%&=]*)?)|(?<numberAnchor>>>[0-9]+?(?:-(?<secondAnchor>[0-9]+?))?)|(?<htmlFont><(?i:font)\s+?(?:(?:(?i:color)=\""(?:(?<colorCode>#?[a-fA-F0-9]{6})|(?<colorName>[a-zA-Z]{1,25}))|(?i:size)=\""(?<size>[+-]?[1-7]))\""\s*?)*?>(?<fontText>.*?)</(?i:font)\s*?>)|(?<lineBreak>\r?\n)|(?<htmlBreak><(?i:br)\s*?/?>)|(?<htmlBold><[bB]\s*?>(?<boldText>.*?)</[bB]\s*?>)|(?<htmlItalic><[iI]\s*?>(?<italicText>.*?)</[iI]\s*?>)|(?<htmlStrike><[sS]\s*?>(?<strikeText>.*?)</[sS]\s*?>)|(?<htmlUnderLine><[uU]\s*?>(?<underLineText>.*?)</[uU]\s*?>)|(?<invalidHtmlElement></?.*?>))";


		internal const int htmlAnchorGroupNumber=1;


				
		internal const int hrefGroupNumber=2;


				
		internal const int anchorTextGroupNumber=3;


				
		internal const int attoMarkNameGroupNumber=4;


				
		internal const int communityIdGroupNumber=5;


				
		internal const int channelIdGroupNumber=6;


				
		internal const int videoIdGroupNumber=7;


				
		internal const int articleIdGroupNumber=8;


				
		internal const int materialIdGroupNumber=9;


				
		internal const int marketItemIdGroupNumber=10;


				
		internal const int liveIdGroupNumber=11;


				
		internal const int watchPictureIdGroupNumber=12;


				
		internal const int PictureIdGroupNumber=13;


				
		internal const int urlGroupNumber=14;


				
		internal const int numberAnchorGroupNumber=15;


				
		internal const int secondAnchorGroupNumber=16;


				
		internal const int htmlFontGroupNumber=17;


				
		internal const int colorCodeGroupNumber=18;


				
		internal const int colorNameGroupNumber=19;


				
		internal const int sizeGroupNumber=20;


				
		internal const int fontTextGroupNumber=21;


				
		internal const int lineBreakGroupNumber=22;


				
		internal const int htmlBreakGroupNumber=23;


				
		internal const int htmlBoldGroupNumber=24;


				
		internal const int boldTextGroupNumber=25;


				
		internal const int htmlItalicGroupNumber=26;


				
		internal const int italicTextGroupNumber=27;


				
		internal const int htmlStrikeGroupNumber=28;


				
		internal const int strikeTextGroupNumber=29;


				
		internal const int htmlUnderLineGroupNumber=30;


				
		internal const int underLineTextGroupNumber=31;


				
		internal const int invalidHtmlElementGroupNumber=32;


				
		}
	}
}
