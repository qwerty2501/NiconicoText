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
    public class NumberAnchorNiconicoWebTextSegmentTest
    {
        [TestMethod]
        public void CreateTest()
        {

            var numberAnchorRange = new NiconicoWebTextNumberAnchorRange { StartNumber = 5, EndNumber = 8 };
            NumberAnchorNiconicoWebTextSegment val = new NumberAnchorNiconicoWebTextSegment(numberAnchorRange);

            INiconicoWebTextSegment segment = val;

            Assert.IsFalse( segment.DecoratedColor);
            Assert.IsFalse(segment.DecoratedBold);
            Assert.IsFalse(segment.DecoratedItalic);
            Assert.IsFalse(segment.DecoratedStrike);
            Assert.IsFalse(segment.DecoratedUnderLine);
            Assert.IsTrue(segment.HasNumberAnchor);
            Assert.IsFalse(segment.HasSegments);
            Assert.IsFalse(segment.HasUrl);
            Assert.AreEqual(new NiconicoWebTextNumberAnchorRange { StartNumber = 5,EndNumber = 8}, segment.NumberAnchor);
            Assert.AreEqual(null, segment.Parent);
            Assert.AreEqual(null, segment.Segments);
            Assert.AreEqual(null, segment.Url);
            Assert.AreEqual(">>5-8", segment.Text);
            Assert.AreEqual(NiconicoWebTextSegmentType.NumberAnchor, segment.SegmentType);
            Assert.AreEqual(3, segment.FontElementSize);
            Assert.AreEqual(">>5-8", segment.FriendlyText);
        }

        [DataTestMethod]
        [DataRow(">>5-8")]
        public void ParseWebTextTest(string text)
        {
            var regex = new Regex(NiconicoWebTextPatterns.niconicoWebTextParsePattern);
            var segmenter = new NiconicoWebTextSegmenter();
            var match = regex.Match(text);
            Assert.IsTrue(match.Success);
            INiconicoWebTextSegment segment = NumberAnchorNiconicoWebTextSegment.ParseWebText(match, segmenter);
            Assert.AreEqual(NiconicoWebTextSegmentType.NumberAnchor, segment.SegmentType);
        }


    }
}