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
    public class LineBreakRegexTest
    {
        [TestMethod]
        public void CraeteTest()
        {
            var regex = createRegex();
        }

        [DataTestMethod]
        [DataRow("<br>","<br>",true)]
        public void MatchTest(string text,string parsedText,bool succeed)
        {
            RegexTestHelper.MatchTest(NiconicoTextPatterns.lineBreakGroupPattern,text,parsedText,2,succeed);
        }

        private Regex createRegex()
        {
            return new Regex(NiconicoTextPatterns.lineBreakGroupPattern);
        }
    }
}
