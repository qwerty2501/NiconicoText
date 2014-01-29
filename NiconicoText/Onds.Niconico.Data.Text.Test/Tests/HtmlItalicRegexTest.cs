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
    public class HtmlItalicRegexTest
    {
        [TestMethod]
        public void CreateTest()
        {
            var regex = createRegex();
        }


        [DataTestMethod]
        [DataRow("<i>italicText</i>","<i>italicText</i>","italicText",true)]
        public void MatchTest(string text,string formatedText,string italicText,bool succeed)
        {
            var match = RegexTestHelper.MatchTest(NiconicoWebTextPatterns.htmlItalicGroupPattern, text, formatedText, 3, succeed);

            if (succeed)
            {
                Assert.AreEqual(italicText, match.Groups["italicText"].Value);
            }
        }



        private Regex createRegex()
        {
            return new Regex(NiconicoWebTextPatterns.htmlItalicGroupPattern);
        }
    }
}
