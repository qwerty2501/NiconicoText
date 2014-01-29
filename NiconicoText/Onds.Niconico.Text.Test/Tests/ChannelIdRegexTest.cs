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
    public class ChannelIdRegexTest
    {
        [TestMethod]
        public void CreateTest()
        {
            var regex = createRegex();
        }

        [DataTestMethod]
        [DataRow("oflch407000ccie","ch407000",true)]
        public void MatchTest(string text,string id,bool succeed)
        {
            RegexTestHelper.MatchTest(NiconicoWebTextPatterns.channelIdGroupPattern, text, id, 2, true);
        }

        private Regex createRegex()
        {
            return new Regex(NiconicoWebTextPatterns.channelIdGroupPattern);
        }
    }
}
