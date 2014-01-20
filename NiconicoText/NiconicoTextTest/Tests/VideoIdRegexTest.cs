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
        [DataRow("testmessagesm22635959", "sm22635959",true)]
        [DataRow("testmessagenm22635959", "nm22635959", true)]
        [DataRow("testmessageso22635959", "so22635959", true)]
        [DataRow("testmessageca22635959", "ca22635959", true)]
        [DataRow("testmessageax22635959", "ax22635959", true)]
        [DataRow("testmessageyo22635959", "yo22635959", true)]
        [DataRow("testmessagenl22635959", "nl22635959", true)]
        [DataRow("testmessageig22635959", "ig22635959", true)]
        [DataRow("testmessagena22635959", "na22635959", true)]
        [DataRow("testmessagecw22635959", "cw22635959", true)]
        [DataRow("testmessageza22635959", "za22635959", true)]
        [DataRow("testmessageze22635959", "ze22635959", true)]
        [DataRow("testmessageom22635959", "om22635959", true)]
        [DataRow("testmessagesk22635959", "sk22635959", true)]
        [DataRow("testmessageyk22635959", "yk22635959", true)]
        [DataRow("testmessagezf22635959","",false)]
        [DataRow("testmessage3322635959","",false)]
        [DataRow("testmessagecy22635959","",false)]
        [DataRow("testmessagenb22635959","",false)]
        public void MatchTest(string text, string value, bool succeed)
        {
            RegexTestHelper.MatchTest(NiconicoWebTextPatterns.videoIdGroupPattern, text, value, 2,succeed);
        }


        [DataTestMethod]
        [DataRow("testmessagesm22635959 , nm22635959", "sm22635959","nm22635959", true)]
        public void MatchsTest(string text, string value1, string value2, bool succeed)
        {
            var videoIdRegex = createRegex();
            var matchs = videoIdRegex.Matches(text);

            Assert.AreEqual(value1, matchs[0].Value);
            Assert.AreEqual(value2, matchs[1].Value);
        }




        private Regex createRegex()
        {
            return  new Regex(NiconicoWebTextPatterns.videoIdGroupPattern);
        }
    }
}
