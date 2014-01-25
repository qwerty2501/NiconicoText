using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
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
            this.resultTable_ = new Dictionary<string, IReadOnlyList<IReadOnlyNiconicoWebTextSegment>>();
            this.resultTable_.Add("plain1",craeteTestCase( new PlainNiconicoWebTextSegment("plainText",null)));
            this.resultTable_.Add("url1", craeteTestCase(new PlainNiconicoWebTextSegment("plain",null), 
                                                        new UrlNiconicoWebTextSegment(new Uri("http://www.nicovideo.jp/watch/sm21305680"),null), 
                                                        new PlainNiconicoWebTextSegment(" oooo",null))
                                                        );
            this.resultTable_.Add("various1", craeteTestCase(new PlainNiconicoWebTextSegment("plain",null),
                                             new HtmlBoldNiconicoWebTextSegment(
                                                 craeteTestCase(
                                                    new PlainNiconicoWebTextSegment("plain2",null),
                                                    new HtmlUnderLineNiconicoWebTextSegment
                                                        (
                                                            craeteTestCase(new PlainNiconicoWebTextSegment("underline",null)),
                                                            null
                                                        )
                                                    ),
                                                    null),
                                                    new HtmlBreakNiconicoWebTextSegment(null),
                                                    new PlainNiconicoWebTextSegment("test",null)
                                                    
                                                 ));

            this.segmenter_ = new NiconicoWebTextSegmenter();
        }

        private Dictionary<string, IReadOnlyList<IReadOnlyNiconicoWebTextSegment>> resultTable_;
        private NiconicoWebTextSegmenter segmenter_;
        [DataTestMethod]
        [DataRow("plainText","plain1")]
        [DataRow("plainhttp://www.nicovideo.jp/watch/sm21305680 oooo", "url1")]
        [DataRow("plain<b>plain2<u>underline</u></b><br>test", "various1")]
        public void SegmentationTest(string text,string key)
        {
            var segments = segmenter_.Divide(text);
            SegmentsAreEqual(segments, this.resultTable_[key]);
        }

        private void SegmentsAreEqual(IReadOnlyList<IReadOnlyNiconicoWebTextSegment> expecteds, IReadOnlyList<IReadOnlyNiconicoWebTextSegment> actuals)
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


        private IReadOnlyList<IReadOnlyNiconicoWebTextSegment> craeteTestCase(params IReadOnlyNiconicoWebTextSegment[] segments)
        {
            return new List<IReadOnlyNiconicoWebTextSegment>(segments);
        }
    }
}
