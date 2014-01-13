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
    public class HtmlAnchorRegexTest
    {
        [TestMethod]
        public void CreateTest()
        {
            var regex = createRegex();
        }

        [DataTestMethod]
        [DataRow(@"<a href=""http://live.nicovideo.jp/watch/lv165723995?ref=alert_alert"">text</a>", @"<a href=""http://live.nicovideo.jp/watch/lv165723995?ref=alert_alert"">text</a>","http://live.nicovideo.jp/watch/lv165723995?ref=alert_alert","text", true)]
        public void MatchTest(string text, string parsedtext, string href ,string value,bool succeed)
        {
            var match = RegexTestHelper.MatchTest(NiconicoTextPatterns.htmlAnchorGroupPattern, text, parsedtext, 4, true);

            Assert.AreEqual(href, match.Groups["href"].Value);
            Assert.AreEqual(value, match.Groups["anchorText"].Value);
        }

        private Regex createRegex()
        {
            return new Regex(NiconicoTextPatterns.htmlAnchorGroupPattern);
        }
    }
}
