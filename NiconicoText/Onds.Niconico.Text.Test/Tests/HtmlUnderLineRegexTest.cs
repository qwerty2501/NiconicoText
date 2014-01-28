using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using Onds.Niconico.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Onds.Niconico.Text.Test.Tests
{
    [TestClass]
    public class HtmlUnderLineRegexTest
    {
        [TestMethod]
        public void CreateTest()
        {
            var regex = createRegex();
        }

        [DataTestMethod]
        [DataRow("<u>underLineText</u>","<u>underLineText</u>","underLineText",true)]
        public void MatchTest(string text,string patterndText,string underLineText,bool succeed)
        {
            var match = RegexTestHelper.MatchTest(NiconicoWebTextPatterns.htmlUnderLineGroupPattern, text, patterndText, 3, succeed);

            if (succeed)
            {
                Assert.AreEqual(underLineText, match.Groups["underLineText"].Value);
            }
        }

        private Regex createRegex()
        {
            return new Regex(NiconicoWebTextPatterns.htmlUnderLineGroupPattern);
        }
    }
}
