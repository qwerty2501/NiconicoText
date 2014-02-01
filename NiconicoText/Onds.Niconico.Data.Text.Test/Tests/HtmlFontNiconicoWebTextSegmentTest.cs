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
    public class HtmlFontNiconicoWebTextSegmentTest
    {
        [TestMethod]
        public void CreateTest()
        {
            HtmlFontNiconicoWebTextSegment<IReadOnlyNiconicoWebTextSegment> val = new HtmlFontNiconicoWebTextSegment<IReadOnlyNiconicoWebTextSegment>(new FontElementSize(4), new NiconicoTextColor { R = 0xFF, G = 0xCC, B = 0xBB }, null);
            var segments = new IReadOnlyNiconicoWebTextSegment[] { new PlainNiconicoWebTextSegment<IReadOnlyNiconicoWebTextSegment>("fonttest", val) };
            val.Segments = segments;

            IReadOnlyNiconicoWebTextSegment segment = val;

            Assert.IsTrue( segment.DecoratedColor);
            Assert.IsFalse(segment.DecoratedBold);
            Assert.IsFalse(segment.DecoratedItalic);
            Assert.IsFalse(segment.DecoratedStrike);
            Assert.IsFalse(segment.DecoratedUnderLine);
            Assert.IsFalse(segment.HasNumberAnchor);
            Assert.IsTrue(segment.HasSegments);
            Assert.IsFalse(segment.HasUrl);
            Assert.AreEqual(new NiconicoTextColor { R = 0xFF, G = 0xCC, B = 0xBB }, segment.Color);
            Assert.AreEqual(new NiconicoWebTextNumberAnchorRange { StartNumber = 0,EndNumber = 0}, segment.NumberAnchor);
            Assert.AreEqual(null, segment.Parent);
            CollectionAssert.AreEqual(segments.ToArray(), segment.Segments.ToArray());
            Assert.AreEqual(null, segment.Url);
            Assert.AreEqual("<font color=\"#FFCCBB\" size=\"4\">fonttest</font>", segment.Text);
            Assert.AreEqual(NiconicoWebTextSegmentType.HtmlFontElement, segment.SegmentType);
            Assert.AreEqual(4, segment.FontElementSize);
            Assert.AreEqual("fonttest", segment.FriendlyText);
        }

        [DataTestMethod]
        [DataRow("<font color=\"#FFCCBB\" size=\"4\">fonttest</font>")]
        public void ParseWebTextTest(string text)
        {
            var regex = new Regex(NiconicoWebTextPatterns.niconicoWebTextParsePattern);
            var segmenter = new NiconicoWebTextSegmenter();
            var match = regex.Match(text);
            Assert.IsTrue(match.Success);
            IReadOnlyNiconicoWebTextSegment segment = HtmlFontNiconicoWebTextSegment<IReadOnlyNiconicoWebTextSegment>.ParseWebText(match, segmenter, null);
            Assert.AreEqual(NiconicoWebTextSegmentType.HtmlFontElement, segment.SegmentType);
        }


    }
}