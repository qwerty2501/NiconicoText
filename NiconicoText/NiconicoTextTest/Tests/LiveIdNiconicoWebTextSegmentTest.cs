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
    public class LiveIdNiconicoWebTextSegmentTest
    {
        [TestMethod]
        public void CreateTest()
        {
            LiveIdNiconicoWebTextSegment val =  new LiveIdNiconicoWebTextSegment("lv333333");

            INiconicoWebTextSegment segment = val;

            Assert.IsFalse( segment.DecoratedColor);
            Assert.IsFalse(segment.DecoratedBold);
            Assert.IsFalse(segment.DecoratedItalic);
            Assert.IsFalse(segment.DecoratedStrike);
            Assert.IsFalse(segment.DecoratedUnderLine);
            Assert.IsFalse(segment.HasNumberAnchor);
            Assert.IsFalse(segment.HasSegments);
            Assert.IsFalse(segment.HasUrl);
            Assert.AreEqual(new NiconicoWebTextNumberAnchorRange { StartNumber = 0,EndNumber = 0}, segment.NumberAnchor);
            Assert.AreEqual(null, segment.Parent);
            Assert.AreEqual(null, segment.Segments);
            Assert.AreEqual(null, segment.Url);
            Assert.AreEqual("lv333333", segment.Text);
            Assert.AreEqual(NiconicoWebTextSegmentType.LiveId, segment.SegmentType);
            Assert.AreEqual(3, segment.FontElementSize);
            Assert.AreEqual("lv333333", segment.FriendlyText);
        }

        [DataTestMethod]
        [DataRow("lv333333")]
        public void ParseWebTextTest(string text)
        {
            var regex = new Regex(NiconicoWebTextPatterns.niconicoWebTextParsePattern);
            var segmenter = new NiconicoWebTextSegmenter();
            var match = regex.Match(text);
            Assert.IsTrue(match.Success);
            INiconicoWebTextSegment segment = LiveIdNiconicoWebTextSegment.ParseWebText(match, segmenter);
            Assert.AreEqual(NiconicoWebTextSegmentType.LiveId, segment.SegmentType);
        }


    }
}