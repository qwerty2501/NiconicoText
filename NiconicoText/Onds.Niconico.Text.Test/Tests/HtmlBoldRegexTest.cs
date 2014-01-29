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
    public class HtmlBoldRegexTest
    {
        [TestMethod]
        public void CreateTest()
        {

        }

        [DataTestMethod]
        [DataRow("<b>bold</b>","<b>bold</b>","bold",true)]
        public void MatchTest(string text,string parsedText,string value,bool succeed)
        {
            var match = RegexTestHelper.MatchTest(NiconicoWebTextPatterns.htmlBoldGroupPattern, text, parsedText, 3, succeed);

            Assert.AreEqual(value, match.Groups["boldText"].Value);

        }

        private Regex createRegex()
        {
            return new Regex(NiconicoWebTextPatterns.htmlBoldGroupPattern);
        }
    }
}
