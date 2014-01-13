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
    public class CommunityIdRegexTest
    {
        [TestMethod]
        public void CreateTest()
        {
            var regex = createRegex();
        }

        [DataTestMethod]
        [DataRow("oflco28428ccie", "co28428", true)]
        public void MatchTest(string text, string id, bool succeed)
        {
            RegexTestHelper.MatchTest(NiconicoTextPatterns.communityIdGroupPattern, text, id, 2, true);
        }


        private Regex createRegex()
        {
            return new Regex(NiconicoTextPatterns.communityIdGroupPattern);
        }
    }
}
