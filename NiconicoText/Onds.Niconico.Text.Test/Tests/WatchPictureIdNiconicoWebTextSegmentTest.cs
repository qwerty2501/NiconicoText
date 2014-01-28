using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using Onds.Niconico.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace Onds.Niconico.Text.Test.Tests
{
    [TestClass]
    public class WatchPictureIdNiconicoWebTextSegmentTest
    {
        [TestMethod]
        public void CreateTest()
        {
            WatchPictureIdNiconicoWebTextSegment val =  new WatchPictureIdNiconicoWebTextSegment("im222222222",null);

            IReadOnlyNiconicoWebTextSegment segment = val;

            Assert.IsFalse( segment.DecoratedColor);
            Assert.IsFalse(segment.DecoratedBold);
            Assert.IsFalse(segment.DecoratedItalic);
            Assert.IsFalse(segment.DecoratedStrike);
            Assert.IsFalse(segment.DecoratedUnderLine);
            Assert.IsFalse(segment.HasNumberAnchor);
            Assert.IsFalse(segment.HasSegments);
            Assert.IsFalse(segment.HasUrl);
            Assert.AreEqual(new NiconicoWebTextNumberAnchorRange { StartNumber = 0,EndNumber = 0}, segment.NumberAnchor);
            Assert.AreEqual(new NiconicoTextColor { R = 0, G = 0, B = 0 }, segment.Color);
            Assert.AreEqual(null, segment.Parent);
            Assert.AreEqual(null, segment.Segments);
            Assert.AreEqual(null, segment.Url);
            Assert.AreEqual("im222222222", segment.Text);
            Assert.AreEqual(NiconicoWebTextSegmentType.PictureId, segment.SegmentType);
            Assert.AreEqual(3, segment.FontElementSize);
            Assert.AreEqual("im222222222", segment.FriendlyText);
        }

        [DataTestMethod]
        [DataRow("im222222222")]
        public void ParseWebTextTest(string text)
        {
            var regex = new Regex(NiconicoWebTextPatterns.niconicoWebTextParsePattern);
            var segmenter = new NiconicoWebTextSegmenter();
            var match = regex.Match(text);
            Assert.IsTrue(match.Success);
            IReadOnlyNiconicoWebTextSegment segment = WatchPictureIdNiconicoWebTextSegment.ParseWebText(match, segmenter,null);
            Assert.AreEqual(NiconicoWebTextSegmentType.PictureId, segment.SegmentType);
        }


    }
}