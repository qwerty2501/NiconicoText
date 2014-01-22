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
    public class HtmlAnchorNiconicoWebTextSegmentTest
    {
        [TestMethod]
        public void CreateTest()
        {
            var segments = new NiconicoWebTextSegmentCollection();
            segments.Add(new PlainNiconicoWebTextSegment("htmlanchortest"));
            HtmlAnchorNiconicoWebTextSegment val =  new HtmlAnchorNiconicoWebTextSegment(new Uri("http://www.nicovideo.jp/watch/sm17856110"),segments);

            INiconicoWebTextSegment segment = val;

            Assert.IsFalse( segment.DecoratedColor);
            Assert.IsFalse(segment.DecoratedBold);
            Assert.IsFalse(segment.DecoratedItalic);
            Assert.IsFalse(segment.DecoratedStrike);
            Assert.IsFalse(segment.DecoratedUnderLine);
            Assert.IsFalse(segment.HasNumberAnchor);
            Assert.IsTrue(segment.HasSegments);
            Assert.IsTrue(segment.HasUrl);
            Assert.AreEqual(new NiconicoTextColor { R = 0, G = 0, B = 0 }, segment.Color);
            Assert.AreEqual(new NiconicoWebTextNumberAnchorRange { StartNumber = 0,EndNumber = 0}, segment.NumberAnchor);
            Assert.AreEqual(null, segment.Parent);
            CollectionAssert.AreEqual(segments.ToArray(), segment.Segments.ToArray());
            Assert.AreEqual(new Uri("http://www.nicovideo.jp/watch/sm17856110"), segment.Url);
            Assert.AreEqual(@"<a href=""http://www.nicovideo.jp/watch/sm17856110"">htmlanchortest</a>", segment.Text);
            Assert.AreEqual(NiconicoWebTextSegmentType.HtmlAnchorElement, segment.SegmentType);
            Assert.AreEqual(3, segment.FontElementSize);
            Assert.AreEqual("htmlanchortest", segment.FriendlyText);
        }

        



    }
}