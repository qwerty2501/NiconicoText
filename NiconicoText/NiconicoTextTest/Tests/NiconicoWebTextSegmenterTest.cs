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
                                                createSegmentsContainerCase(
                                                    new HtmlBoldNiconicoWebTextSegment(null),
                                                    new PlainNiconicoWebTextSegment("plain2", null),

                                                    createSegmentsContainerCase(new HtmlUnderLineNiconicoWebTextSegment(null),
                                                        new PlainNiconicoWebTextSegment("underline", null)
                                                    )
                                                ),
                                                new HtmlBreakNiconicoWebTextSegment(null),
                                                new PlainNiconicoWebTextSegment("test",null)
                                                    
                                                )
                                               );

            this.resultTable_.Add
            ("font1", craeteTestCase
                (
                    createSegmentsContainerCase(new HtmlFontNiconicoWebTextSegment(4, new NiconicoTextColor { R = 0xFF, G = 0x00, B = 0x00 }, null),
                        new PlainNiconicoWebTextSegment("text",null)
                    )
                )
            );

            this.resultTable_.Add("font2",this.resultTable_["font1"]);


            this.segmenter_ = new NiconicoWebTextSegmenter();
        }

        private Dictionary<string, IReadOnlyList<IReadOnlyNiconicoWebTextSegment>> resultTable_;
        private NiconicoWebTextSegmenter segmenter_;
        [DataTestMethod]
        [DataRow("plainText","plain1")]
        [DataRow("plainhttp://www.nicovideo.jp/watch/sm21305680 oooo", "url1")]
        [DataRow("plain<b>plain2<u>underline</u></b><br>test", "various1")]
        [DataRow(@"<font color=""red"" size=""4"">text</font>","font1")]
        [DataRow(@"<font color=""red"" size=""4"" color=""blue"" size=""1"">text</font>", "font2")]

        public void DivideTest(string text,string key)
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
                Assert.AreEqual(expected.Color, actual.Color);
                Assert.AreEqual(expected.FontElementSize, actual.FontElementSize);
                Assert.AreEqual(expected.DecoratedBold, actual.DecoratedBold);
                Assert.AreEqual(expected.DecoratedColor, actual.DecoratedColor);
                Assert.AreEqual(expected.DecoratedItalic, actual.DecoratedItalic);
                Assert.AreEqual(expected.DecoratedStrike, actual.DecoratedStrike);
                Assert.AreEqual(expected.DecoratedUnderLine, actual.DecoratedUnderLine);
                Assert.AreEqual(expected.HasNumberAnchor, actual.HasNumberAnchor);
                Assert.AreEqual(expected.HasUrl, actual.HasUrl);
                Assert.AreEqual(expected.NumberAnchor, actual.NumberAnchor);
                Assert.AreEqual(expected.Url, actual.Url);
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

        private NiconicoWebTextSegmentBase createSegmentsContainerCase(SegmentsProsessionNiconicoWebTextSegmentBase parent, params NiconicoWebTextSegmentBase[] segments)
        {
            foreach (var segment in segments)
            {
                segment.Parent = parent;
            }
            
            parent.Segments = segments;

            return parent;
        }

        private IReadOnlyList<IReadOnlyNiconicoWebTextSegment> craeteTestCase(params IReadOnlyNiconicoWebTextSegment[] segments)
        {
            return new List<IReadOnlyNiconicoWebTextSegment>(segments);
        }
    }
}
