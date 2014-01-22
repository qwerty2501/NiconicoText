using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using NiconicoText;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace NiconicoTextTest.Tests
{
    [TestClass]
    public class UrlNiconicoWebTextSegmentTest
    {
        [TestMethod]
        public void CreateTest()
        {
            UrlNiconicoWebTextSegment val =  new UrlNiconicoWebTextSegment(new Uri("http://www.nicovideo.jp/watch/sm20884708"));

            INiconicoWebTextSegment segment = val;

            Assert.IsFalse( segment.DecoratedColor);
            Assert.IsFalse(segment.DecoratedBold);
            Assert.IsFalse(segment.DecoratedItalic);
            Assert.IsFalse(segment.DecoratedStrike);
            Assert.IsFalse(segment.DecoratedUnderLine);
            Assert.IsFalse(segment.HasNumberAnchor);
            Assert.IsFalse(segment.HasSegments);
            Assert.IsTrue(segment.HasUrl);
            Assert.AreEqual(new NiconicoTextColor { R = 0, G = 0, B = 0 }, segment.Color);
            Assert.AreEqual(new NiconicoWebTextNumberAnchorRange { StartNumber = 0,EndNumber = 0}, segment.NumberAnchor);
            Assert.AreEqual(null, segment.Parent);
            Assert.AreEqual(null, segment.Segments);
            Assert.AreEqual(new Uri("http://www.nicovideo.jp/watch/sm20884708"), segment.Url);
            Assert.AreEqual("http://www.nicovideo.jp/watch/sm20884708", segment.Text);
            Assert.AreEqual(NiconicoWebTextSegmentType.Url, segment.SegmentType);
            Assert.AreEqual(3, segment.FontElementSize);
            Assert.AreEqual("http://www.nicovideo.jp/watch/sm20884708", segment.FriendlyText);
        }

        [DataTestMethod]
        [DataRow("http://www.nicovideo.jp/watch/sm20884708")]
        public void ParseWebTextTest(string text)
        {
            var regex = new Regex(NiconicoWebTextPatterns.niconicoWebTextParsePattern);
            var segmenter = new NiconicoWebTextSegmenter();
            var match = regex.Match(text);
            Assert.IsTrue(match.Success);
            INiconicoWebTextSegment segment = UrlNiconicoWebTextSegment.ParseWebText(match, segmenter);
            Assert.AreEqual(NiconicoWebTextSegmentType.Url, segment.SegmentType);
        }


    }
}