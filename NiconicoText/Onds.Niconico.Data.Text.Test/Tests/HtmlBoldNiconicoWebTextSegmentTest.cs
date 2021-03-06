﻿using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
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
    public class HtmlBoldNiconicoWebTextSegmentTest
    {
        [TestMethod]
        public void CreateTest()
        {
            HtmlBoldNiconicoWebTextSegment<IReadOnlyNiconicoWebTextSegment> val = new HtmlBoldNiconicoWebTextSegment<IReadOnlyNiconicoWebTextSegment>(null);
            var segments = new IReadOnlyNiconicoWebTextSegment[] { new PlainNiconicoWebTextSegment<IReadOnlyNiconicoWebTextSegment>("boldtest", val) };
            val.Segments = segments;

            IReadOnlyNiconicoWebTextSegment segment = val;

            Assert.IsFalse( segment.DecoratedColor);
            Assert.IsTrue(segment.DecoratedBold);
            Assert.IsFalse(segment.DecoratedItalic);
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
            Assert.AreEqual("<b>boldtest</b>", segment.Text);
            Assert.AreEqual(NiconicoWebTextSegmentType.HtmlBoldElement, segment.SegmentType);
            Assert.AreEqual(3, segment.FontElementSize);
            Assert.AreEqual("boldtest", segment.FriendlyText);
        }

        [DataTestMethod]
        [DataRow("<b>boldtest</b>")]
        public void ParseWebTextTest(string text)
        {
            var regex = new Regex(NiconicoWebTextPatterns.niconicoWebTextParsePattern);
            var segmenter = new NiconicoWebTextSegmenter();
            var match = regex.Match(text);
            Assert.IsTrue(match.Success);
            IReadOnlyNiconicoWebTextSegment segment = HtmlBoldNiconicoWebTextSegment<IReadOnlyNiconicoWebTextSegment>.ParseWebText(match, segmenter, null);
            Assert.AreEqual(NiconicoWebTextSegmentType.HtmlBoldElement, segment.SegmentType);
        }


    }
}