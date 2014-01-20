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
    public class HtmlStrikeRegexTest
    {
        [TestMethod]
        public void CreateTest()
        {
            var regex = createRegex();
        }

        [DataTestMethod]
        [DataRow("<s>strikeText</s>","<s>strikeText</s>","strikeText",true)]
        public void MatchTest(string text,string parsedText,string strikeText,bool succeed)
        {
            var match = RegexTestHelper.MatchTest(NiconicoWebTextPatterns.htmlStrikeGroupPattern, text, parsedText, 3, succeed);

            if (succeed)
            {
                Assert.AreEqual(strikeText, match.Groups["strikeText"].Value);
            }
        }

        private Regex createRegex()
        {
            return new Regex(NiconicoWebTextPatterns.htmlStrikeGroupPattern);
        }
    }
}
