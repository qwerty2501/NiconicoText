﻿
namespace Onds.Niconico.Data.Text
{
	using System.Text.RegularExpressions;
	using System.Linq;

    internal static partial class NiconicoWebTextPatterns
    {

		

        

		
		 //internal const string communityIdPattern=@"co\d{1,14}";


		//internal const string communityId="communityId";

 
		internal const string communityIdGroupPattern=@"(?:(?:[^a-z]|\b)(?<communityId>co\d{1,14})(?:[^A-Za-z\d]|\b))";


			
		 //internal const string channelIdPattern=@"ch\d{1,14}";


		//internal const string channelId="channelId";

 
		internal const string channelIdGroupPattern=@"(?:(?:[^a-z]|\b)(?<channelId>ch\d{1,14})(?:[^A-Za-z\d]|\b))";


			
		 //internal const string videoIdPattern=@"(?:sm|nm|so|ca|ax|yo|nl|ig|na|cw|z[a-e]|om|sk|yk)\d{1,14}";


		//internal const string videoId="videoId";

 
		internal const string videoIdGroupPattern=@"(?:(?:[^a-z]|\b)(?<videoId>(?:sm|nm|so|ca|ax|yo|nl|ig|na|cw|z[a-e]|om|sk|yk)\d{1,14})(?:[^A-Za-z\d]|\b))";


			
		 //internal const string articleIdPattern=@"ar\d{1,14}";


		//internal const string articleId="articleId";

 
		internal const string articleIdGroupPattern=@"(?:(?:[^a-z]|\b)(?<articleId>ar\d{1,14})(?:[^A-Za-z\d]|\b))";


			
		 //internal const string materialIdPattern=@"nc\d{1,14}";


		//internal const string materialId="materialId";

 
		internal const string materialIdGroupPattern=@"(?:(?:[^a-z]|\b)(?<materialId>nc\d{1,14})(?:[^A-Za-z\d]|\b))";


			
		 //internal const string marketItemIdPattern=@"(?:dw\d+|az[A-Z0-9]{10}|ys[a-zA-Z0-9-]+_[a-zA-Z0-9-]|ga\d+|ip[\d_]+|gg[a-zA-Z0-9]+-[a-zA-Z0-9-]+)";


		//internal const string marketItemId="marketItemId";

 
		internal const string marketItemIdGroupPattern=@"(?:(?:[^a-z]|\b)(?<marketItemId>(?:dw\d+|az[A-Z0-9]{10}|ys[a-zA-Z0-9-]+_[a-zA-Z0-9-]|ga\d+|ip[\d_]+|gg[a-zA-Z0-9]+-[a-zA-Z0-9-]+))(?:[^A-Za-z\d]|\b))";


			
		 //internal const string liveIdPattern=@"lv\d{1,14}";


		//internal const string liveId="liveId";

 
		internal const string liveIdGroupPattern=@"(?:(?:[^a-z]|\b)(?<liveId>lv\d{1,14})(?:[^A-Za-z\d]|\b))";


			
		 //internal const string watchPictureIdPattern=@"(?:[sm]g|im)\d{1,14}";


		//internal const string watchPictureId="watchPictureId";

 
		internal const string watchPictureIdGroupPattern=@"(?:(?:[^a-z]|\b)(?<watchPictureId>(?:[sm]g|im)\d{1,14})(?:[^A-Za-z\d]|\b))";


			
		 //internal const string pictureIdPattern=@"im\d{1,14}";


		//internal const string PictureId="PictureId";

 
		internal const string PictureIdGroupPattern=@"(?:(?:[^a-z]|\b)(?<PictureId>im\d{1,14})(?:[^A-Za-z\d]|\b))";


			
		 //internal const string urlPattern=@"https?://[\w-](?:\.?[\w-]+)+(?:[0-9]*?)?(?:/[\w-./?%&=]*)?";


		//internal const string url="url";

 
		internal const string urlGroupPattern=@"(?<url>https?://[\w-](?:\.?[\w-]+)+(?:[0-9]*?)?(?:/[\w-./?%&=]*)?)";


			
		 //internal const string numberAnchorPattern=@">>(?<startNumberAnchor>[0-9]+?)(?:-(?<endNumberAnchor>[0-9]+?))?";


		//internal const string numberAnchor="numberAnchor";

 
		internal const string numberAnchorGroupPattern=@"(?<numberAnchor>>>(?<startNumberAnchor>[0-9]+?)(?:-(?<endNumberAnchor>[0-9]+?))?)";


			
		 //internal const string htmlFontPattern=@"<(?i:font)\s+?(?:[^>]*?(?:(?i:color)=\""(?:(?<colorCode>#?[a-fA-F0-9]{6})|(?<colorName>[a-zA-Z]{1,25}))|(?i:size)=\""(?<size>[+-]?[1-7]))\""\s*?){1,2}[^>]*?>(?<fontText>.*?)</(?i:font)\s*?>";


		//internal const string htmlFont="htmlFont";

 
		internal const string htmlFontGroupPattern=@"(?<htmlFont><(?i:font)\s+?(?:[^>]*?(?:(?i:color)=\""(?:(?<colorCode>#?[a-fA-F0-9]{6})|(?<colorName>[a-zA-Z]{1,25}))|(?i:size)=\""(?<size>[+-]?[1-7]))\""\s*?){1,2}[^>]*?>(?<fontText>.*?)</(?i:font)\s*?>)";


			
		 //internal const string lineBreakPattern=@"\r?\n";


		//internal const string lineBreak="lineBreak";

 
		internal const string lineBreakGroupPattern=@"(?<lineBreak>\r?\n)";


			
		 //internal const string htmlBreakPattern=@"<(?i:br)\s*?/?>";


		//internal const string htmlBreak="htmlBreak";

 
		internal const string htmlBreakGroupPattern=@"(?<htmlBreak><(?i:br)\s*?/?>)";


			
		 //internal const string htmlBoldPattern=@"<[bB]\s*?>(?<boldText>.*?)</[bB]\s*?>";


		//internal const string htmlBold="htmlBold";

 
		internal const string htmlBoldGroupPattern=@"(?<htmlBold><[bB]\s*?>(?<boldText>.*?)</[bB]\s*?>)";


			
		 //internal const string htmlItalicPattern=@"<[iI]\s*?>(?<italicText>.*?)</[iI]\s*?>";


		//internal const string htmlItalic="htmlItalic";

 
		internal const string htmlItalicGroupPattern=@"(?<htmlItalic><[iI]\s*?>(?<italicText>.*?)</[iI]\s*?>)";


			
		 //internal const string htmlStrikePattern=@"<[sS]\s*?>(?<strikeText>.*?)</[sS]\s*?>";


		//internal const string htmlStrike="htmlStrike";

 
		internal const string htmlStrikeGroupPattern=@"(?<htmlStrike><[sS]\s*?>(?<strikeText>.*?)</[sS]\s*?>)";


			
		 //internal const string htmlUnderLinePattern=@"<[uU]\s*?>(?<underLineText>.*?)</[uU]\s*?>";


		//internal const string htmlUnderLine="htmlUnderLine";

 
		internal const string htmlUnderLineGroupPattern=@"(?<htmlUnderLine><[uU]\s*?>(?<underLineText>.*?)</[uU]\s*?>)";


			
		 //internal const string htmlInvalidElementPattern=@"</?.*?>";


		//internal const string htmlInvalidElement="htmlInvalidElement";

 
		internal const string htmlInvalidElementGroupPattern=@"(?<htmlInvalidElement></?.*?>)";


			
		internal const string niconicoWebTextParsePattern = @"(?:(?:(?:[^a-z]|\b)(?<communityId>co\d{1,14})(?:[^A-Za-z\d]|\b))|(?:(?:[^a-z]|\b)(?<channelId>ch\d{1,14})(?:[^A-Za-z\d]|\b))|(?:(?:[^a-z]|\b)(?<videoId>(?:sm|nm|so|ca|ax|yo|nl|ig|na|cw|z[a-e]|om|sk|yk)\d{1,14})(?:[^A-Za-z\d]|\b))|(?:(?:[^a-z]|\b)(?<articleId>ar\d{1,14})(?:[^A-Za-z\d]|\b))|(?:(?:[^a-z]|\b)(?<materialId>nc\d{1,14})(?:[^A-Za-z\d]|\b))|(?:(?:[^a-z]|\b)(?<marketItemId>(?:dw\d+|az[A-Z0-9]{10}|ys[a-zA-Z0-9-]+_[a-zA-Z0-9-]|ga\d+|ip[\d_]+|gg[a-zA-Z0-9]+-[a-zA-Z0-9-]+))(?:[^A-Za-z\d]|\b))|(?:(?:[^a-z]|\b)(?<liveId>lv\d{1,14})(?:[^A-Za-z\d]|\b))|(?:(?:[^a-z]|\b)(?<watchPictureId>(?:[sm]g|im)\d{1,14})(?:[^A-Za-z\d]|\b))|(?:(?:[^a-z]|\b)(?<PictureId>im\d{1,14})(?:[^A-Za-z\d]|\b))|(?<url>https?://[\w-](?:\.?[\w-]+)+(?:[0-9]*?)?(?:/[\w-./?%&=]*)?)|(?<numberAnchor>>>(?<startNumberAnchor>[0-9]+?)(?:-(?<endNumberAnchor>[0-9]+?))?)|(?<htmlFont><(?i:font)\s+?(?:[^>]*?(?:(?i:color)=\""(?:(?<colorCode>#?[a-fA-F0-9]{6})|(?<colorName>[a-zA-Z]{1,25}))|(?i:size)=\""(?<size>[+-]?[1-7]))\""\s*?){1,2}[^>]*?>(?<fontText>.*?)</(?i:font)\s*?>)|(?<lineBreak>\r?\n)|(?<htmlBreak><(?i:br)\s*?/?>)|(?<htmlBold><[bB]\s*?>(?<boldText>.*?)</[bB]\s*?>)|(?<htmlItalic><[iI]\s*?>(?<italicText>.*?)</[iI]\s*?>)|(?<htmlStrike><[sS]\s*?>(?<strikeText>.*?)</[sS]\s*?>)|(?<htmlUnderLine><[uU]\s*?>(?<underLineText>.*?)</[uU]\s*?>)|(?<htmlInvalidElement></?.*?>))";



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


				
		internal const int htmlInvalidElementGroupNumber=29;


					}


	internal static class NiconicoWebTextSegmentMatchParser
	{
		
		internal static IReadOnlyNiconicoWebTextSegment Parse<T>(Match match,NiconicoWebTextSegmenter segmenter,T parent)
			where T:IReadOnlyNiconicoWebTextSegment
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
				return CommunityIdNiconicoWebTextSegment<T>.ParseWebText(match,segmenter,parent);

				case NiconicoWebTextPatternIndexs.channelIdGroupNumber:
				return ChannelIdNiconicoWebTextSegment<T>.ParseWebText(match,segmenter,parent);

				case NiconicoWebTextPatternIndexs.videoIdGroupNumber:
				return VideoIdNiconicoWebTextSegment<T>.ParseWebText(match,segmenter,parent);

				case NiconicoWebTextPatternIndexs.articleIdGroupNumber:
				return ArticleIdNiconicoWebTextSegment<T>.ParseWebText(match,segmenter,parent);

				case NiconicoWebTextPatternIndexs.materialIdGroupNumber:
				return MaterialIdNiconicoWebTextSegment<T>.ParseWebText(match,segmenter,parent);

				case NiconicoWebTextPatternIndexs.marketItemIdGroupNumber:
				return MarketItemIdNiconicoWebTextSegment<T>.ParseWebText(match,segmenter,parent);

				case NiconicoWebTextPatternIndexs.liveIdGroupNumber:
				return LiveIdNiconicoWebTextSegment<T>.ParseWebText(match,segmenter,parent);

				case NiconicoWebTextPatternIndexs.watchPictureIdGroupNumber:
				return WatchPictureIdNiconicoWebTextSegment<T>.ParseWebText(match,segmenter,parent);

				case NiconicoWebTextPatternIndexs.PictureIdGroupNumber:
				return PictureIdNiconicoWebTextSegment<T>.ParseWebText(match,segmenter,parent);

				case NiconicoWebTextPatternIndexs.urlGroupNumber:
				return UrlNiconicoWebTextSegment<T>.ParseWebText(match,segmenter,parent);

				case NiconicoWebTextPatternIndexs.numberAnchorGroupNumber:
				return NumberAnchorNiconicoWebTextSegment<T>.ParseWebText(match,segmenter,parent);

				case NiconicoWebTextPatternIndexs.htmlFontGroupNumber:
				return HtmlFontNiconicoWebTextSegment<T>.ParseWebText(match,segmenter,parent);

				case NiconicoWebTextPatternIndexs.lineBreakGroupNumber:
				return LineBreakNiconicoWebTextSegment<T>.ParseWebText(match,segmenter,parent);

				case NiconicoWebTextPatternIndexs.htmlBreakGroupNumber:
				return HtmlBreakNiconicoWebTextSegment<T>.ParseWebText(match,segmenter,parent);

				case NiconicoWebTextPatternIndexs.htmlBoldGroupNumber:
				return HtmlBoldNiconicoWebTextSegment<T>.ParseWebText(match,segmenter,parent);

				case NiconicoWebTextPatternIndexs.htmlItalicGroupNumber:
				return HtmlItalicNiconicoWebTextSegment<T>.ParseWebText(match,segmenter,parent);

				case NiconicoWebTextPatternIndexs.htmlStrikeGroupNumber:
				return HtmlStrikeNiconicoWebTextSegment<T>.ParseWebText(match,segmenter,parent);

				case NiconicoWebTextPatternIndexs.htmlUnderLineGroupNumber:
				return HtmlUnderLineNiconicoWebTextSegment<T>.ParseWebText(match,segmenter,parent);

				case NiconicoWebTextPatternIndexs.htmlInvalidElementGroupNumber:
				return HtmlInvalidElementNiconicoWebTextSegment<T>.ParseWebText(match,segmenter,parent);


			default:
					return new PlainNiconicoWebTextSegment<T>(match.Value,parent);
			}
		}

	}

	internal static class WriteableNiconicoWebTextSegmentMatchParser
	{
        internal static INiconicoWebTextSegment Parse<T>(Match match, NiconicoWebTextSegmenter segmenter, T parent)
			where T:INiconicoWebTextSegment
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
				return WriteableNiconicoWebTextSegment.ParseCommunityIdWebText(match,segmenter,parent);

				
			case NiconicoWebTextPatternIndexs.channelIdGroupNumber:
				return WriteableNiconicoWebTextSegment.ParseChannelIdWebText(match,segmenter,parent);

				
			case NiconicoWebTextPatternIndexs.videoIdGroupNumber:
				return WriteableNiconicoWebTextSegment.ParseVideoIdWebText(match,segmenter,parent);

				
			case NiconicoWebTextPatternIndexs.articleIdGroupNumber:
				return WriteableNiconicoWebTextSegment.ParseArticleIdWebText(match,segmenter,parent);

				
			case NiconicoWebTextPatternIndexs.materialIdGroupNumber:
				return WriteableNiconicoWebTextSegment.ParseMaterialIdWebText(match,segmenter,parent);

				
			case NiconicoWebTextPatternIndexs.marketItemIdGroupNumber:
				return WriteableNiconicoWebTextSegment.ParseMarketItemIdWebText(match,segmenter,parent);

				
			case NiconicoWebTextPatternIndexs.liveIdGroupNumber:
				return WriteableNiconicoWebTextSegment.ParseLiveIdWebText(match,segmenter,parent);

				
			case NiconicoWebTextPatternIndexs.watchPictureIdGroupNumber:
				return WriteableNiconicoWebTextSegment.ParseWatchPictureIdWebText(match,segmenter,parent);

				
			case NiconicoWebTextPatternIndexs.PictureIdGroupNumber:
				return WriteableNiconicoWebTextSegment.ParsePictureIdWebText(match,segmenter,parent);

				
			case NiconicoWebTextPatternIndexs.urlGroupNumber:
				return WriteableNiconicoWebTextSegment.ParseUrlWebText(match,segmenter,parent);

				
			case NiconicoWebTextPatternIndexs.numberAnchorGroupNumber:
				return WriteableNiconicoWebTextSegment.ParseNumberAnchorWebText(match,segmenter,parent);

				
			case NiconicoWebTextPatternIndexs.htmlFontGroupNumber:
				return WriteableNiconicoWebTextSegment.ParseHtmlFontWebText(match,segmenter,parent);

				
			case NiconicoWebTextPatternIndexs.lineBreakGroupNumber:
				return WriteableNiconicoWebTextSegment.ParseLineBreakWebText(match,segmenter,parent);

				
			case NiconicoWebTextPatternIndexs.htmlBreakGroupNumber:
				return WriteableNiconicoWebTextSegment.ParseHtmlBreakWebText(match,segmenter,parent);

				
			case NiconicoWebTextPatternIndexs.htmlBoldGroupNumber:
				return WriteableNiconicoWebTextSegment.ParseHtmlBoldWebText(match,segmenter,parent);

				
			case NiconicoWebTextPatternIndexs.htmlItalicGroupNumber:
				return WriteableNiconicoWebTextSegment.ParseHtmlItalicWebText(match,segmenter,parent);

				
			case NiconicoWebTextPatternIndexs.htmlStrikeGroupNumber:
				return WriteableNiconicoWebTextSegment.ParseHtmlStrikeWebText(match,segmenter,parent);

				
			case NiconicoWebTextPatternIndexs.htmlUnderLineGroupNumber:
				return WriteableNiconicoWebTextSegment.ParseHtmlUnderLineWebText(match,segmenter,parent);

				
			case NiconicoWebTextPatternIndexs.htmlInvalidElementGroupNumber:
				return WriteableNiconicoWebTextSegment.ParseHtmlInvalidElementWebText(match,segmenter,parent);

				
			default:
					return WriteableNiconicoWebTextSegment.CreatePlainText(match.Value,parent);
			}
		}
	}

	namespace Comments{

		internal static class NiconicoCommentTextPatterns
		{
			
	
		 //internal const string htmlAnchorPattern=@"<[aA]\s+?[^>]*?href=\""(?<href>https?://[\w-](?:\.?[\w-]+)+(?:[0-9]*?)?(?:/[\w-./?%&=]*)?)\""\s?[^>]*?>(?<anchorText>.*?)</[aA]\s*?>";


		//internal const string htmlAnchor="htmlAnchor";

 
		internal const string htmlAnchorGroupPattern=@"(?<htmlAnchor><[aA]\s+?[^>]*?href=\""(?<href>https?://[\w-](?:\.?[\w-]+)+(?:[0-9]*?)?(?:/[\w-./?%&=]*)?)\""\s?[^>]*?>(?<anchorText>.*?)</[aA]\s*?>)";


			
		 //internal const string attoMarkNamePattern=@"@[^@^\s]+";


		//internal const string attoMarkName="attoMarkName";

 
		internal const string attoMarkNameGroupPattern=@"(?<attoMarkName>@[^@^\s]+)";


			
		internal const string niconicoCommentTextParsePattern = @"(?:(?<htmlAnchor><[aA]\s+?[^>]*?href=\""(?<href>https?://[\w-](?:\.?[\w-]+)+(?:[0-9]*?)?(?:/[\w-./?%&=]*)?)\""\s?[^>]*?>(?<anchorText>.*?)</[aA]\s*?>)|(?<attoMarkName>@[^@^\s]+))|(?:(?:(?:[^a-z]|\b)(?<communityId>co\d{1,14})(?:[^A-Za-z\d]|\b))|(?:(?:[^a-z]|\b)(?<channelId>ch\d{1,14})(?:[^A-Za-z\d]|\b))|(?:(?:[^a-z]|\b)(?<videoId>(?:sm|nm|so|ca|ax|yo|nl|ig|na|cw|z[a-e]|om|sk|yk)\d{1,14})(?:[^A-Za-z\d]|\b))|(?:(?:[^a-z]|\b)(?<articleId>ar\d{1,14})(?:[^A-Za-z\d]|\b))|(?:(?:[^a-z]|\b)(?<materialId>nc\d{1,14})(?:[^A-Za-z\d]|\b))|(?:(?:[^a-z]|\b)(?<marketItemId>(?:dw\d+|az[A-Z0-9]{10}|ys[a-zA-Z0-9-]+_[a-zA-Z0-9-]|ga\d+|ip[\d_]+|gg[a-zA-Z0-9]+-[a-zA-Z0-9-]+))(?:[^A-Za-z\d]|\b))|(?:(?:[^a-z]|\b)(?<liveId>lv\d{1,14})(?:[^A-Za-z\d]|\b))|(?:(?:[^a-z]|\b)(?<watchPictureId>(?:[sm]g|im)\d{1,14})(?:[^A-Za-z\d]|\b))|(?:(?:[^a-z]|\b)(?<PictureId>im\d{1,14})(?:[^A-Za-z\d]|\b))|(?<url>https?://[\w-](?:\.?[\w-]+)+(?:[0-9]*?)?(?:/[\w-./?%&=]*)?)|(?<numberAnchor>>>(?<startNumberAnchor>[0-9]+?)(?:-(?<endNumberAnchor>[0-9]+?))?)|(?<htmlFont><(?i:font)\s+?(?:[^>]*?(?:(?i:color)=\""(?:(?<colorCode>#?[a-fA-F0-9]{6})|(?<colorName>[a-zA-Z]{1,25}))|(?i:size)=\""(?<size>[+-]?[1-7]))\""\s*?){1,2}[^>]*?>(?<fontText>.*?)</(?i:font)\s*?>)|(?<lineBreak>\r?\n)|(?<htmlBreak><(?i:br)\s*?/?>)|(?<htmlBold><[bB]\s*?>(?<boldText>.*?)</[bB]\s*?>)|(?<htmlItalic><[iI]\s*?>(?<italicText>.*?)</[iI]\s*?>)|(?<htmlStrike><[sS]\s*?>(?<strikeText>.*?)</[sS]\s*?>)|(?<htmlUnderLine><[uU]\s*?>(?<underLineText>.*?)</[uU]\s*?>)|(?<htmlInvalidElement></?.*?>))";



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


				
		internal const int htmlInvalidElementGroupNumber=33;


				
		}
	}
}
