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
    public class MaterialIdNiconicoWebTextSegmentTest
    {
        [TestMethod]
        public void CreateTest()
        {
            MaterialIdNiconicoWebTextSegment val =  new MaterialIdNiconicoWebTextSegment("nc55555555",null);

            IReadOnlyNiconicoWebTextSegment segment = val;

            Assert.IsFalse( segment.DecoratedColor);
            Assert.IsFalse(segment.DecoratedBold);
            Assert.IsFalse(segment.DecoratedItalic);
            Assert.IsFalse(segment.DecoratedStrike);
            Assert.IsFalse(segment.DecoratedUnderLine);
            Assert.IsFalse(segment.HasNumberAnchor);
            Assert.IsFalse(segment.HasSegments);
            Assert.IsFalse(segment.HasUrl);
            Assert.AreEqual(new NiconicoTextColor { R = 0, G = 0, B = 0 }, segment.Color);
            Assert.AreEqual(new NiconicoWebTextNumberAnchorRange { StartNumber = 0,EndNumber = 0}, segment.NumberAnchor);
            Assert.AreEqual(null, segment.Parent);
            Assert.AreEqual(null, segment.Segments);
            Assert.AreEqual(null, segment.Url);
            Assert.AreEqual("nc55555555", segment.Text);
            Assert.AreEqual(NiconicoWebTextSegmentType.MaterialId, segment.SegmentType);
            Assert.AreEqual(3, segment.FontElementSize);
            Assert.AreEqual("nc55555555", segment.FriendlyText);
        }

        [DataTestMethod]
        [DataRow("nc55555555")]
        public void ParseWebTextTest(string text)
        {
            var regex = new Regex(NiconicoWebTextPatterns.niconicoWebTextParsePattern);
            var segmenter = new NiconicoWebTextSegmenter();
            var match = regex.Match(text);
            Assert.IsTrue(match.Success);
            IReadOnlyNiconicoWebTextSegment segment = MaterialIdNiconicoWebTextSegment.ParseWebText(match, segmenter,null);
            Assert.AreEqual(NiconicoWebTextSegmentType.MaterialId, segment.SegmentType);
        }


    }
}