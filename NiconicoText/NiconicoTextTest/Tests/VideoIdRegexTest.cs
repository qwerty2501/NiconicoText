using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using System.Text.RegularExpressions;
using NiconicoText;

namespace NiconicoTextTest.Tests
{
    [TestClass]
    public class VideoIdRegexTest
    {
        [TestMethod]
        public void CreateTest()
        {
            var videoIdRegex = createRegex();
        }


        [DataTestMethod]
        [DataRow("http://www.nicovideo.jp/watch/sm22635959", "sm22635959",true)]
        [DataRow("http://www.nicovideo.jp/watch/nm22635959", "nm22635959", true)]
        [DataRow("http://www.nicovideo.jp/watch/nm22635959", "nm22635959", true)]
        public void MatchTest(string text, string value, bool succeed)
        {
            var videoIdRegex = createRegex();
            var match = videoIdRegex.Match(text);

            Assert.AreEqual(succeed, match.Success);
            Assert.AreEqual(2, match.Groups.Count);

            if (succeed)
            {
                Assert.AreEqual(value, match.Value);
            }
        }

        [DataTestMethod]
        [DataRow("http://www.nicovideo.jp/watch/sm22635959 , nm22635959", "sm22635959","nm22635959", true)]
        public void MatchsTest(string text, string value1, string value2, bool succeed)
        {
            var videoIdRegex = createRegex();
            var matchs = videoIdRegex.Matches(text);


        }




        private Regex createRegex()
        {
            return  new Regex(NiconicoTextPatterns.videoIdGroupPattern);
        }
    }
}
