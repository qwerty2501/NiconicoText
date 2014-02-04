using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using System.Text.RegularExpressions;
using Onds.Niconico.Data.Text;

namespace Onds.Niconico.Data.Text.Test.Tests
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
        [DataRow("テストsm22635959", "sm22635959",true)]
        [DataRow("テストnm22635959", "nm22635959", true)]
        [DataRow("テストso22635959", "so22635959", true)]
        [DataRow("テストca22635959", "ca22635959", true)]
        [DataRow("テストax22635959", "ax22635959", true)]
        [DataRow("テストyo22635959", "yo22635959", true)]
        [DataRow("テストnl22635959", "nl22635959", true)]
        [DataRow("テストig22635959", "ig22635959", true)]
        [DataRow("テストna22635959", "na22635959", true)]
        [DataRow("テストcw22635959", "cw22635959", true)]
        [DataRow("テストza22635959", "za22635959", true)]
        [DataRow("テストze22635959", "ze22635959", true)]
        [DataRow("テストom22635959", "om22635959", true)]
        [DataRow("テストsk22635959", "sk22635959", true)]
        [DataRow("テストyk22635959", "yk22635959", true)]
        [DataRow("テストzf22635959", "", false)]
        [DataRow("テストge3322635959", "", false)]
        [DataRow("テストcy22635959", "", false)]
        [DataRow("テストnb22635959", "", false)]
        public void MatchTest(string text, string value, bool succeed)
        {
            RegexTestHelper.IdMatchTest(NiconicoWebTextPatterns.videoIdGroupPattern, text, value, 2, succeed);
        }


        [DataTestMethod]
        [DataRow("これはってsm22635959 , nm22635959", "sm22635959","nm22635959", true)]
        public void MatchesTest(string text, string value1, string value2, bool succeed)
        {
            var videoIdRegex = createRegex();
            var matchs = videoIdRegex.Matches(text);

            Assert.AreEqual(value1, matchs[0].Groups[1].Value);
            Assert.AreEqual(value2, matchs[1].Groups[1].Value);
        }




        private Regex createRegex()
        {
            return  new Regex(NiconicoWebTextPatterns.videoIdGroupPattern);
        }
    }
}
