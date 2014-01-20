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
    public class InvalidHtmlRegexPatterns
    {
        [TestMethod]
        public void CreateTest()
        {
            var regex = createRegex();
        }

        [DataTestMethod]
        [DataRow("<invalidhtml>","<invalidhtml>",true)]
        public void MatchTest(string text,string value,bool succeed)
        {
            RegexTestHelper.MatchTest(NiconicoWebTextPatterns.invalidHtmlElementGroupPattern, text, value, 2, succeed);
        }

        private Regex createRegex()
        {
            return new Regex(NiconicoWebTextPatterns.invalidHtmlElementGroupPattern);
        }
    }
}
