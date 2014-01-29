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
    public class NiconicoTextParsePatternTest
    {
        
        [TestMethod]
        public void CreateTest()
        {
            var regex = createRegex();
        }


        private Regex regex_ = createRegex();


        [TestMethod]
        public void VideoUrlMatchTest()
        {
            var matches = this.regex_.Matches("http://www.nicovideo.jp/watch/sm16423600");

        }

        [TestMethod]
        public void ComplexPatternsTest1()
        {
            var text = @"<font color=""#FFCCDD"">testmessage</font><u>under</u>";

            var matches = this.regex_.Matches(text);

            Assert.AreEqual(2, matches.Count);

            var match1 = matches[0];

            Assert.AreEqual(true, match1.Success);
            Assert.AreEqual(@"<font color=""#FFCCDD"">testmessage</font>", match1.Groups["htmlFont"].Value);
            Assert.AreEqual("testmessage", match1.Groups["fontText"].Value);
            Assert.AreEqual(false, match1.Groups["invalidHtml"].Success);
            Assert.AreEqual(string.Empty, match1.Groups["invalidHtml"].Value);


            var match2 = matches[1];


            Assert.AreEqual(true, match2.Success);
            Assert.AreEqual(@"<u>under</u>", match2.Groups["htmlUnderLine"].Value);
            Assert.AreEqual(@"under", match2.Groups["underLineText"].Value);
            Assert.AreEqual(string.Empty, match2.Groups["invalidHtml"].Value);

        }

        [TestMethod]
        public void HtmlFontMatchTest()
        {
            var text = @"<font color=""#FFCCDD""><i>testmessage</i></font>";

            var matches = this.regex_.Matches(text);

            Assert.AreEqual(1, matches.Count);

            var match = matches[0];

            Assert.AreEqual(true, match.Success);
            Assert.AreEqual(text, match.Groups["htmlFont"].Value);
            Assert.AreEqual("<i>testmessage</i>", match.Groups["fontText"].Value);
            Assert.AreEqual(false, match.Groups["invalidHtml"].Success);
            Assert.AreEqual(string.Empty, match.Groups["invalidHtml"].Value);


        }

        private static Regex createRegex()
        {
            return new Regex(NiconicoWebTextPatterns.niconicoWebTextParsePattern);
        }
    }
}
