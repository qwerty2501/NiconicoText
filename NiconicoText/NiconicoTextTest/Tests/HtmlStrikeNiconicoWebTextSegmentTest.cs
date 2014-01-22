﻿using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
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
    public class HtmlStrikeNiconicoWebTextSegmentTest
    {
        [TestMethod]
        public void CreateTest()
        {
            var segments = new NiconicoWebTextSegmentCollection();
            segments.Add(new PlainNiconicoWebTextSegment("test"));
            HtmlStrikeNiconicoWebTextSegment val =  new HtmlStrikeNiconicoWebTextSegment(segments);

            INiconicoWebTextSegment segment = val;

            Assert.IsFalse( segment.DecoratedColor);
            Assert.IsFalse(segment.DecoratedBold);
            Assert.IsFalse(segment.DecoratedItalic);
            Assert.IsTrue(segment.DecoratedStrike);
            Assert.IsFalse(segment.DecoratedUnderLine);
            Assert.IsFalse(segment.HasNumberAnchor);
            Assert.IsTrue(segment.HasSegments);
            Assert.IsFalse(segment.HasUrl);
            Assert.AreEqual(new NiconicoTextColor { R = 0, G = 0, B = 0 }, segment.Color);
            Assert.AreEqual(new NiconicoWebTextNumberAnchorRange { StartNumber = 0,EndNumber = 0}, segment.NumberAnchor);
            Assert.AreEqual(null, segment.Parent);
            Assert.AreEqual(segments, segment.Segments);
            Assert.AreEqual(null, segment.Url);
            Assert.AreEqual("<s>test</s>", segment.Text);
            Assert.AreEqual(NiconicoWebTextSegmentType.HtmlStrikeElement, segment.SegmentType);
            Assert.AreEqual(3, segment.FontElementSize);
            Assert.AreEqual("test", segment.FriendlyText);
        }

        [DataTestMethod]
        [DataRow("<s>test</s>")]
        public void ParseWebTextTest(string text)
        {
            var regex = new Regex(NiconicoWebTextPatterns.niconicoWebTextParsePattern);
            var segmenter = new NiconicoWebTextSegmenter();
            var match = regex.Match(text);
            Assert.IsTrue(match.Success);
            INiconicoWebTextSegment segment = HtmlStrikeNiconicoWebTextSegment.ParseWebText(match, segmenter);
            Assert.AreEqual(NiconicoWebTextSegmentType.HtmlStrikeElement, segment.SegmentType);
        }


    }
}