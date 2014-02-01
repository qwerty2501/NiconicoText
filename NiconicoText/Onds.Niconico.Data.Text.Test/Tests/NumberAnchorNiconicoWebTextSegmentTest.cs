using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using Onds.Niconico.Data.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace Onds.Niconico.Data.Text.Test.Tests
{
    [TestClass]
    public class NumberAnchorNiconicoWebTextSegmentTest
    {
        [TestMethod]
        public void CreateTest()
        {

            var numberAnchorRange = new NiconicoWebTextNumberAnchorRange { StartNumber = 5, EndNumber = 8 };
            NumberAnchorNiconicoWebTextSegment<IReadOnlyNiconicoWebTextSegment> val = new NumberAnchorNiconicoWebTextSegment<IReadOnlyNiconicoWebTextSegment>(numberAnchorRange, null);

            IReadOnlyNiconicoWebTextSegment segment = val;

            Assert.IsFalse( segment.DecoratedColor);
            Assert.IsFalse(segment.DecoratedBold);
            Assert.IsFalse(segment.DecoratedItalic);
            Assert.IsFalse(segment.DecoratedStrike);
            Assert.IsFalse(segment.DecoratedUnderLine);
            Assert.IsTrue(segment.HasNumberAnchor);
            Assert.IsFalse(segment.HasSegments);
            Assert.IsFalse(segment.HasUrl);
            Assert.AreEqual(new NiconicoTextColor { R = 0, G = 0, B = 0 }, segment.Color);
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
            IReadOnlyNiconicoWebTextSegment segment = NumberAnchorNiconicoWebTextSegment<IReadOnlyNiconicoWebTextSegment>.ParseWebText(match, segmenter, null);
            Assert.AreEqual(NiconicoWebTextSegmentType.NumberAnchor, segment.SegmentType);
        }


    }
}