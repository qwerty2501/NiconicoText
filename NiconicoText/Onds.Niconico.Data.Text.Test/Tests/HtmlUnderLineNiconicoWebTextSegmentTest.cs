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
    public class HtmlUnderLineNiconicoWebTextSegmentTest
    {
        [TestMethod]
        public void CreateTest()
        {

            HtmlUnderLineNiconicoWebTextSegment<IReadOnlyNiconicoWebTextSegment> val = new HtmlUnderLineNiconicoWebTextSegment<IReadOnlyNiconicoWebTextSegment>(null);
            var segmentes = new IReadOnlyNiconicoWebTextSegment[] { new PlainNiconicoWebTextSegment<IReadOnlyNiconicoWebTextSegment>("testText", val) };
            val.Segments = segmentes;
            IReadOnlyNiconicoWebTextSegment segment = val;

            Assert.IsFalse( segment.DecoratedColor);
            Assert.IsFalse(segment.DecoratedBold);
            Assert.IsFalse(segment.DecoratedItalic);
            Assert.IsFalse(segment.DecoratedStrike);
            Assert.IsTrue(segment.DecoratedUnderLine);
            Assert.IsFalse(segment.HasNumberAnchor);
            Assert.IsTrue(segment.HasSegments);
            Assert.IsFalse(segment.HasUrl);
            Assert.AreEqual(new NiconicoTextColor { R = 0, G = 0, B = 0 }, segment.Color);
            Assert.AreEqual(new NiconicoWebTextNumberAnchorRange { StartNumber = 0,EndNumber = 0}, segment.NumberAnchor);
            Assert.AreEqual(null, segment.Parent);
            CollectionAssert.AreEqual(segmentes.ToArray(), segment.Segments.ToArray());
            Assert.AreEqual(null, segment.Url);
            Assert.AreEqual("<u>testText</u>", segment.Text);
            Assert.AreEqual(NiconicoWebTextSegmentType.HtmlUnderLineElement, segment.SegmentType);
            Assert.AreEqual(3, segment.FontElementSize);
            Assert.AreEqual("testText", segment.FriendlyText);
        }

        [DataTestMethod]
        [DataRow("<u>testText</u>")]
        public void ParseWebTextTest(string text)
        {
            var regex = new Regex(NiconicoWebTextPatterns.niconicoWebTextParsePattern);
            var segmenter = new NiconicoWebTextSegmenter();
            var match = regex.Match(text);
            Assert.IsTrue(match.Success);
            IReadOnlyNiconicoWebTextSegment segment = HtmlUnderLineNiconicoWebTextSegment<IReadOnlyNiconicoWebTextSegment>.ParseWebText(match, segmenter, null);
            Assert.AreEqual(NiconicoWebTextSegmentType.HtmlUnderLineElement, segment.SegmentType);
        }


    }
}