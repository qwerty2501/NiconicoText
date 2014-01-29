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
    public class LineBreakRegexTest
    {
        [TestMethod]
        public void CraeteTest()
        {
            var regex = createRegex();
        }

        [DataTestMethod]
        [DataRow("\r\n","\r\n",true)]
        public void MatchTest(string text,string parsedText,bool succeed)
        {
            RegexTestHelper.MatchTest(NiconicoWebTextPatterns.lineBreakGroupPattern,text,parsedText,2,succeed);
        }

        private Regex createRegex()
        {
            return new Regex(NiconicoWebTextPatterns.lineBreakGroupPattern);
        }
    }
}
