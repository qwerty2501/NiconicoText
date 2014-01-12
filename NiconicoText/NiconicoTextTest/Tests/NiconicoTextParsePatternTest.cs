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
        public void HtmlFontMatchTest()
        {
            var text = @"<font color=""#FFCCDD"">testmessage</font>";

            var matches = this.regex_.Matches(text);

            Assert.AreEqual(1, matches.Count);

            var match = matches[0];

            Assert.AreEqual(true, match.Success);

            Assert.AreEqual(text, match.Groups["htmlFont"].Value);

            Assert.AreEqual(false, match.Groups["invalidHtml"].Success);
            Assert.AreEqual(string.Empty, match.Groups["invalidHtml"].Value);


        }

        private static Regex createRegex()
        {
            return new Regex(NiconicoTextPatterns.niconicoTextParsePattern);
        }
    }
}
