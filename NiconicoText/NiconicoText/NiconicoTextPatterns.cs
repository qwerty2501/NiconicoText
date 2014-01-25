
namespace NiconicoText
{
	using System.Text.RegularExpressions;
	using System.Linq;

    internal static partial class NiconicoWebTextPatterns
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


			
		internal const string urlPattern=@"https?://[\w-](?:\.?[\w-]+)+(?:[0-9]*?)?(?:/[\w-./?%&=]*)?";


		internal const string url="url";


		internal const string urlGroupPattern=@"(?<url>https?://[\w-](?:\.?[\w-]+)+(?:[0-9]*?)?(?:/[\w-./?%&=]*)?)";


			
		internal const string numberAnchorPattern=@">>(?<startNumberAnchor>[0-9]+?)(?:-(?<endNumberAnchor>[0-9]+?))?";


		internal const string numberAnchor="numberAnchor";


		internal const string numberAnchorGroupPattern=@"(?<numberAnchor>>>(?<startNumberAnchor>[0-9]+?)(?:-(?<endNumberAnchor>[0-9]+?))?)";


			
		internal const string htmlFontPattern=@"<(?i:font)\s+?(?:.*?(?:(?i:color)=\""(?:(?<colorCode>#?[a-fA-F0-9]{6})|(?<colorName>[a-zA-Z]{1,25}))|(?i:size)=\""(?<size>[+-]?[1-7]))\""\s*?){1,2}.*?>(?<fontText>.*?)</(?i:font)\s*?>";


		internal const string htmlFont="htmlFont";


		internal const string htmlFontGroupPattern=@"(?<htmlFont><(?i:font)\s+?(?:.*?(?:(?i:color)=\""(?:(?<colorCode>#?[a-fA-F0-9]{6})|(?<colorName>[a-zA-Z]{1,25}))|(?i:size)=\""(?<size>[+-]?[1-7]))\""\s*?){1,2}.*?>(?<fontText>.*?)</(?i:font)\s*?>)";


			
		internal const string lineBreakPattern=@"\r?\n";


		internal const string lineBreak="lineBreak";


		internal const string lineBreakGroupPattern=@"(?<lineBreak>\r?\n)";


			
		internal const string htmlBreakPattern=@"<(?i:br)\s*?/?>";


		internal const string htmlBreak="htmlBreak";


		internal const string htmlBreakGroupPattern=@"(?<htmlBreak><(?i:br)\s*?/?>)";


			
		internal const string htmlBoldPattern=@"<[bB]\s*?.*?>(?<boldText>.*?)</[bB]\s*?>";


		internal const string htmlBold="htmlBold";


		internal const string htmlBoldGroupPattern=@"(?<htmlBold><[bB]\s*?.*?>(?<boldText>.*?)</[bB]\s*?>)";


			
		internal const string htmlItalicPattern=@"<[iI]\s*?.*?>(?<italicText>.*?)</[iI]\s*?>";


		internal const string htmlItalic="htmlItalic";


		internal const string htmlItalicGroupPattern=@"(?<htmlItalic><[iI]\s*?.*?>(?<italicText>.*?)</[iI]\s*?>)";


			
		internal const string htmlStrikePattern=@"<[sS]\s*?.*?>(?<strikeText>.*?)</[sS]\s*?>";


		internal const string htmlStrike="htmlStrike";


		internal const string htmlStrikeGroupPattern=@"(?<htmlStrike><[sS]\s*?.*?>(?<strikeText>.*?)</[sS]\s*?>)";


			
		internal const string htmlUnderLinePattern=@"<[uU]\s*?.*?>(?<underLineText>.*?)</[uU]\s*?>";


		internal const string htmlUnderLine="htmlUnderLine";


		internal const string htmlUnderLineGroupPattern=@"(?<htmlUnderLine><[uU]\s*?.*?>(?<underLineText>.*?)</[uU]\s*?>)";


			
		internal const string invalidHtmlElementPattern=@"</?.*?>";


		internal const string invalidHtmlElement="invalidHtmlElement";


		internal const string invalidHtmlElementGroupPattern=@"(?<invalidHtmlElement></?.*?>)";


			
		internal const string niconicoWebTextParsePattern = @"(?:(?<communityId>co\d{1,14})|(?<channelId>ch\d{1,14})|(?<videoId>(?:sm|nm|so|ca|ax|yo|nl|ig|na|cw|z[a-e]|om|sk|yk)\d{1,14})|(?<articleId>ar\d{1,14})|(?<materialId>nc\d{1,14})|(?<marketItemId>(?:dw\d+|az[A-Z0-9]{10}|ys[a-zA-Z0-9-]+_[a-zA-Z0-9-]|ga\d+|ip[\d_]+|gg[a-zA-Z0-9]+-[a-zA-Z0-9-]+))|(?<liveId>lv\d{1,14})|(?<watchPictureId>(?:[sm]g|im)\d{1,14})|(?<PictureId>im\d{1,14})|(?<url>https?://[\w-](?:\.?[\w-]+)+(?:[0-9]*?)?(?:/[\w-./?%&=]*)?)|(?<numberAnchor>>>(?<startNumberAnchor>[0-9]+?)(?:-(?<endNumberAnchor>[0-9]+?))?)|(?<htmlFont><(?i:font)\s+?(?:.*?(?:(?i:color)=\""(?:(?<colorCode>#?[a-fA-F0-9]{6})|(?<colorName>[a-zA-Z]{1,25}))|(?i:size)=\""(?<size>[+-]?[1-7]))\""\s*?){1,2}.*?>(?<fontText>.*?)</(?i:font)\s*?>)|(?<lineBreak>\r?\n)|(?<htmlBreak><(?i:br)\s*?/?>)|(?<htmlBold><[bB]\s*?.*?>(?<boldText>.*?)</[bB]\s*?>)|(?<htmlItalic><[iI]\s*?.*?>(?<italicText>.*?)</[iI]\s*?>)|(?<htmlStrike><[sS]\s*?.*?>(?<strikeText>.*?)</[sS]\s*?>)|(?<htmlUnderLine><[uU]\s*?.*?>(?<underLineText>.*?)</[uU]\s*?>)|(?<invalidHtmlElement></?.*?>))";



    }

	internal static class NiconicoWebTextPatternIndexs
	{


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


				
		internal const int startNumberAnchorGroupNumber=12;


				
		internal const int endNumberAnchorGroupNumber=13;


				
		internal const int htmlFontGroupNumber=14;


				
		internal const int colorCodeGroupNumber=15;


				
		internal const int colorNameGroupNumber=16;


				
		internal const int sizeGroupNumber=17;


				
		internal const int fontTextGroupNumber=18;


				
		internal const int lineBreakGroupNumber=19;


				
		internal const int htmlBreakGroupNumber=20;


				
		internal const int htmlBoldGroupNumber=21;


				
		internal const int boldTextGroupNumber=22;


				
		internal const int htmlItalicGroupNumber=23;


				
		internal const int italicTextGroupNumber=24;


				
		internal const int htmlStrikeGroupNumber=25;


				
		internal const int strikeTextGroupNumber=26;


				
		internal const int htmlUnderLineGroupNumber=27;


				
		internal const int underLineTextGroupNumber=28;


				
		internal const int invalidHtmlElementGroupNumber=29;


					}


	internal static class NiconicoWebTextSegmentMatchParser
	{
		
		internal static IReadOnlyNiconicoWebTextSegment Parse(Match match,NiconicoWebTextSegmenter segmenter,IReadOnlyNiconicoWebTextSegment parent)
		{
			
			int matchIndex = 0;
			foreach(Group group in match.Groups)
			{
				if(group.Success && matchIndex > 0)
					break;
				++matchIndex;
			}
			
			switch(matchIndex)
			{
			
				case NiconicoWebTextPatternIndexs.communityIdGroupNumber:
		return CommunityIdNiconicoWebTextSegment.ParseWebText(match,segmenter,parent);

				case NiconicoWebTextPatternIndexs.channelIdGroupNumber:
		return ChannelIdNiconicoWebTextSegment.ParseWebText(match,segmenter,parent);

				case NiconicoWebTextPatternIndexs.videoIdGroupNumber:
		return VideoIdNiconicoWebTextSegment.ParseWebText(match,segmenter,parent);

				case NiconicoWebTextPatternIndexs.articleIdGroupNumber:
		return ArticleIdNiconicoWebTextSegment.ParseWebText(match,segmenter,parent);

				case NiconicoWebTextPatternIndexs.materialIdGroupNumber:
		return MaterialIdNiconicoWebTextSegment.ParseWebText(match,segmenter,parent);

				case NiconicoWebTextPatternIndexs.marketItemIdGroupNumber:
		return MarketItemIdNiconicoWebTextSegment.ParseWebText(match,segmenter,parent);

				case NiconicoWebTextPatternIndexs.liveIdGroupNumber:
		return LiveIdNiconicoWebTextSegment.ParseWebText(match,segmenter,parent);

				case NiconicoWebTextPatternIndexs.watchPictureIdGroupNumber:
		return WatchPictureIdNiconicoWebTextSegment.ParseWebText(match,segmenter,parent);

				case NiconicoWebTextPatternIndexs.PictureIdGroupNumber:
		return PictureIdNiconicoWebTextSegment.ParseWebText(match,segmenter,parent);

				case NiconicoWebTextPatternIndexs.urlGroupNumber:
		return UrlNiconicoWebTextSegment.ParseWebText(match,segmenter,parent);

				case NiconicoWebTextPatternIndexs.numberAnchorGroupNumber:
		return NumberAnchorNiconicoWebTextSegment.ParseWebText(match,segmenter,parent);

				case NiconicoWebTextPatternIndexs.htmlFontGroupNumber:
		return HtmlFontNiconicoWebTextSegment.ParseWebText(match,segmenter,parent);

				case NiconicoWebTextPatternIndexs.lineBreakGroupNumber:
		return LineBreakNiconicoWebTextSegment.ParseWebText(match,segmenter,parent);

				case NiconicoWebTextPatternIndexs.htmlBreakGroupNumber:
		return HtmlBreakNiconicoWebTextSegment.ParseWebText(match,segmenter,parent);

				case NiconicoWebTextPatternIndexs.htmlBoldGroupNumber:
		return HtmlBoldNiconicoWebTextSegment.ParseWebText(match,segmenter,parent);

				case NiconicoWebTextPatternIndexs.htmlItalicGroupNumber:
		return HtmlItalicNiconicoWebTextSegment.ParseWebText(match,segmenter,parent);

				case NiconicoWebTextPatternIndexs.htmlStrikeGroupNumber:
		return HtmlStrikeNiconicoWebTextSegment.ParseWebText(match,segmenter,parent);

				case NiconicoWebTextPatternIndexs.htmlUnderLineGroupNumber:
		return HtmlUnderLineNiconicoWebTextSegment.ParseWebText(match,segmenter,parent);

				case NiconicoWebTextPatternIndexs.invalidHtmlElementGroupNumber:
		return InvalidHtmlElementNiconicoWebTextSegment.ParseWebText(match,segmenter,parent);


			default:
					return new PlainNiconicoWebTextSegment(match.Value,parent);
			}
		}

	}

	namespace Comments{

		internal static class NiconicoCommentTextPatterns
		{
			
	
		internal const string htmlAnchorPattern=@"<[aA]\s+?.*?href=\""(?<href>https?://[\w-](?:\.?[\w-]+)+(?:[0-9]*?)?(?:/[\w-./?%&=]*)?)\""\s?.*?>(?<anchorText>.*?)</[aA]\s*?>";


		internal const string htmlAnchor="htmlAnchor";


		internal const string htmlAnchorGroupPattern=@"(?<htmlAnchor><[aA]\s+?.*?href=\""(?<href>https?://[\w-](?:\.?[\w-]+)+(?:[0-9]*?)?(?:/[\w-./?%&=]*)?)\""\s?.*?>(?<anchorText>.*?)</[aA]\s*?>)";


			
		internal const string attoMarkNamePattern=@"@[^@^\s]+";


		internal const string attoMarkName="attoMarkName";


		internal const string attoMarkNameGroupPattern=@"(?<attoMarkName>@[^@^\s]+)";


			
		internal const string niconicoCommentTextParsePattern = @"(?:(?<htmlAnchor><[aA]\s+?.*?href=\""(?<href>https?://[\w-](?:\.?[\w-]+)+(?:[0-9]*?)?(?:/[\w-./?%&=]*)?)\""\s?.*?>(?<anchorText>.*?)</[aA]\s*?>)|(?<attoMarkName>@[^@^\s]+))|(?:(?<communityId>co\d{1,14})|(?<channelId>ch\d{1,14})|(?<videoId>(?:sm|nm|so|ca|ax|yo|nl|ig|na|cw|z[a-e]|om|sk|yk)\d{1,14})|(?<articleId>ar\d{1,14})|(?<materialId>nc\d{1,14})|(?<marketItemId>(?:dw\d+|az[A-Z0-9]{10}|ys[a-zA-Z0-9-]+_[a-zA-Z0-9-]|ga\d+|ip[\d_]+|gg[a-zA-Z0-9]+-[a-zA-Z0-9-]+))|(?<liveId>lv\d{1,14})|(?<watchPictureId>(?:[sm]g|im)\d{1,14})|(?<PictureId>im\d{1,14})|(?<url>https?://[\w-](?:\.?[\w-]+)+(?:[0-9]*?)?(?:/[\w-./?%&=]*)?)|(?<numberAnchor>>>(?<startNumberAnchor>[0-9]+?)(?:-(?<endNumberAnchor>[0-9]+?))?)|(?<htmlFont><(?i:font)\s+?(?:.*?(?:(?i:color)=\""(?:(?<colorCode>#?[a-fA-F0-9]{6})|(?<colorName>[a-zA-Z]{1,25}))|(?i:size)=\""(?<size>[+-]?[1-7]))\""\s*?){1,2}.*?>(?<fontText>.*?)</(?i:font)\s*?>)|(?<lineBreak>\r?\n)|(?<htmlBreak><(?i:br)\s*?/?>)|(?<htmlBold><[bB]\s*?.*?>(?<boldText>.*?)</[bB]\s*?>)|(?<htmlItalic><[iI]\s*?.*?>(?<italicText>.*?)</[iI]\s*?>)|(?<htmlStrike><[sS]\s*?.*?>(?<strikeText>.*?)</[sS]\s*?>)|(?<htmlUnderLine><[uU]\s*?.*?>(?<underLineText>.*?)</[uU]\s*?>)|(?<invalidHtmlElement></?.*?>))";



		}

		internal static class NiconicoCommentTextPatternIndexs
		{


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


				
		internal const int startNumberAnchorGroupNumber=16;


				
		internal const int endNumberAnchorGroupNumber=17;


				
		internal const int htmlFontGroupNumber=18;


				
		internal const int colorCodeGroupNumber=19;


				
		internal const int colorNameGroupNumber=20;


				
		internal const int sizeGroupNumber=21;


				
		internal const int fontTextGroupNumber=22;


				
		internal const int lineBreakGroupNumber=23;


				
		internal const int htmlBreakGroupNumber=24;


				
		internal const int htmlBoldGroupNumber=25;


				
		internal const int boldTextGroupNumber=26;


				
		internal const int htmlItalicGroupNumber=27;


				
		internal const int italicTextGroupNumber=28;


				
		internal const int htmlStrikeGroupNumber=29;


				
		internal const int strikeTextGroupNumber=30;


				
		internal const int htmlUnderLineGroupNumber=31;


				
		internal const int underLineTextGroupNumber=32;


				
		internal const int invalidHtmlElementGroupNumber=33;


				
		}
	}
}
