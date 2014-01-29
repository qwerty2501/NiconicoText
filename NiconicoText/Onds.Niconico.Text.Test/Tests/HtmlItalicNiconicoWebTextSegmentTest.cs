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
    public class HtmlItalicNiconicoWebTextSegmentTest
    {
        [TestMethod]
        public void CreateTest()
        {
            HtmlItalicNiconicoWebTextSegment val = new HtmlItalicNiconicoWebTextSegment( null);
            var segments = new IReadOnlyNiconicoWebTextSegment[] { new PlainNiconicoWebTextSegment("italictest",val) };
            val.Segments = segments;
            

            IReadOnlyNiconicoWebTextSegment segment = val;

            Assert.IsFalse( segment.DecoratedColor);
            Assert.IsFalse(segment.DecoratedBold);
            Assert.IsTrue(segment.DecoratedItalic);
            Assert.IsFalse(segment.DecoratedStrike);
            Assert.IsFalse(segment.DecoratedUnderLine);
            Assert.IsFalse(segment.HasNumberAnchor);
            Assert.IsTrue(segment.HasSegments);
            Assert.IsFalse(segment.HasUrl);
            Assert.AreEqual(new NiconicoTextColor { R = 0, G = 0, B = 0 }, segment.Color);
            Assert.AreEqual(new NiconicoWebTextNumberAnchorRange { StartNumber = 0,EndNumber = 0}, segment.NumberAnchor);
            Assert.AreEqual(null, segment.Parent);
            CollectionAssert.AreEqual(segments.ToArray(), segment.Segments.ToArray());
            Assert.AreEqual(null, segment.Url);
            Assert.AreEqual("<i>italictest</i>", segment.Text);
            Assert.AreEqual(NiconicoWebTextSegmentType.HtmlItalicElement, segment.SegmentType);
            Assert.AreEqual(3, segment.FontElementSize);
            Assert.AreEqual("italictest", segment.FriendlyText);
        }

        [DataTestMethod]
        [DataRow("<i>italictest</i>")]
        public void ParseWebTextTest(string text)
        {
            var regex = new Regex(NiconicoWebTextPatterns.niconicoWebTextParsePattern);
            var segmenter = new NiconicoWebTextSegmenter();
            var match = regex.Match(text);
            Assert.IsTrue(match.Success);
            IReadOnlyNiconicoWebTextSegment segment = HtmlItalicNiconicoWebTextSegment.ParseWebText(match, segmenter,null);
            Assert.AreEqual(NiconicoWebTextSegmentType.HtmlItalicElement, segment.SegmentType);
        }


    }
}