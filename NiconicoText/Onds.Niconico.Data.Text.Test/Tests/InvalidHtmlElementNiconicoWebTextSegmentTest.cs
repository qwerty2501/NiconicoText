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
    public class InvalidHtmlElementNiconicoWebTextSegmentTest
    {
        [TestMethod]
        public void CreateTest()
        {
            InvalidHtmlElementNiconicoWebTextSegment<IReadOnlyNiconicoWebTextSegment> val = new InvalidHtmlElementNiconicoWebTextSegment<IReadOnlyNiconicoWebTextSegment>( null);
            var segments = new IReadOnlyNiconicoWebTextSegment[] { new PlainNiconicoWebTextSegment<IReadOnlyNiconicoWebTextSegment>("invalid", val) };
            val.Segments = segments;

            IReadOnlyNiconicoWebTextSegment segment = val;

            Assert.IsFalse( segment.DecoratedColor);
            Assert.IsFalse(segment.DecoratedBold);
            Assert.IsFalse(segment.DecoratedItalic);
            Assert.IsFalse(segment.DecoratedStrike);
            Assert.IsFalse(segment.DecoratedUnderLine);
            Assert.IsFalse(segment.HasNumberAnchor);
            Assert.IsTrue(segment.HasSegments);
            Assert.IsFalse(segment.HasUrl);
            Assert.AreEqual(new NiconicoTextColor { R = 0, G = 0, B = 0 }, segment.Color);
            Assert.AreEqual(new NiconicoWebTextNumberAnchorRange { StartNumber = 0,EndNumber = 0}, segment.NumberAnchor);
            Assert.AreEqual(null, segment.Parent);
            CollectionAssert.AreEqual(segments, segment.Segments.ToArray());
            Assert.AreEqual(null, segment.Url);
            Assert.AreEqual("<invalid>", segment.Text);
            Assert.AreEqual(NiconicoWebTextSegmentType.HtmlInvalidElement, segment.SegmentType);
            Assert.AreEqual(3, segment.FontElementSize);
            Assert.AreEqual("", segment.FriendlyText);
        }

        [DataTestMethod]
        [DataRow("<invalid>")]
        public void ParseWebTextTest(string text)
        {
            var regex = new Regex(NiconicoWebTextPatterns.niconicoWebTextParsePattern);
            var segmenter = new NiconicoWebTextSegmenter();
            var match = regex.Match(text);
            Assert.IsTrue(match.Success);
            IReadOnlyNiconicoWebTextSegment segment = InvalidHtmlElementNiconicoWebTextSegment<IReadOnlyNiconicoWebTextSegment>.ParseWebText(match, segmenter, null);
            Assert.AreEqual(NiconicoWebTextSegmentType.HtmlInvalidElement, segment.SegmentType);
            Assert.AreEqual(text, segment.Text);
        }


    }
}