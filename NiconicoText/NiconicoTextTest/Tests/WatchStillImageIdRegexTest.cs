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
    public class WatchStillImageIdRegexTest
    {
        [TestMethod]
        public void CreateTest()
        {
            var regex = createRegex();
        }

        [DataTestMethod]
        [DataRow("aacsg5548845eed","sg5548845",true)]
        public void MatchTest(string text,string id,bool succeed)
        {
            RegexTestHelper.MatchTest(NiconicoTextPatterns.watchStillImageIdGroupPattern, text, id, 2, succeed);
        }

        private Regex createRegex()
        {
            return new Regex(NiconicoTextPatterns.watchStillImageIdGroupPattern);
        }
    }
}
