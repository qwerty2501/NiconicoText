﻿using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using NiconicoText;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiconicoTextTest.Tests
{
    [TestClass]
    public class NiconicoWebTextSegmenterTest
    {
        [TestInitialize]
        public void SegmentationTestInitialize()
        {
            this.resultTable_ = new Dictionary<string, INiconicoWebTextSegmentCollection>();
            this.resultTable_.Add("plain1",craeteTestCase( new PlainNiconicoWebTextSegment("plainText")));
            this.resultTable_.Add("url1", craeteTestCase(new PlainNiconicoWebTextSegment("plain"), new UrlNiconicoWebTextSegment(new Uri("http://www.nicovideo.jp/watch/sm21305680")), new PlainNiconicoWebTextSegment(" oooo")));
            this.segmenter_ = new NiconicoWebTextSegmenter();
        }

        private Dictionary<string, INiconicoWebTextSegmentCollection> resultTable_;
        private NiconicoWebTextSegmenter segmenter_;
        [DataTestMethod]
        [DataRow("plainText","plain1")]
        [DataRow("plainhttp://www.nicovideo.jp/watch/sm21305680 oooo", "url1")]
        public void SegmentationTest(string text,string key)
        {
            var segments = segmenter_.GetTokensInternal(text);
            SegmentsAreEqual(segments, this.resultTable_[key]);
        }

        private void SegmentsAreEqual(INiconicoWebTextSegmentCollection expecteds, INiconicoWebTextSegmentCollection actuals)
        {
            Assert.AreEqual(expecteds.Count, actuals.Count);



            for (int index = 0; index < expecteds.Count; index++)
            {
                var expected = expecteds[index];
                var actual = actuals[index];
                Assert.AreEqual(expected.SegmentType, actual.SegmentType);
                Assert.AreEqual(expected.Text, actual.Text);
                Assert.AreEqual(expected.FriendlyText, actual.FriendlyText);

                if (expected.Segments != null)
                {
                    SegmentsAreEqual(expected.Segments, actual.Segments);
                }
                else
                {
                    Assert.IsNull(actual.Segments);
                }
            }
  
            
            
        }


        private INiconicoWebTextSegmentCollection craeteTestCase(params INiconicoWebTextSegment[] segments)
        {
            return new NiconicoWebTextSegmentCollection(segments);
        }
    }
}
