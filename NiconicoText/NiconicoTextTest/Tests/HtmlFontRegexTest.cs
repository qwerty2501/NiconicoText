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
    public class HtmlFontRegexTest
    {
        [TestMethod]
        public void CreateTest()
        {
            var regex = createRegex();
        }

        [DataTestMethod]
        [DataRow(@"<font color=""#FFCCDD"">testmessage</font>","testmessage",@"#FFCCDD","",true)]
        public void MatchTest(string text,string parsedtext,string color,string size,bool succeed)
        {
            var match = RegexTestHelper.MatchTest(NiconicoWebTextPatterns.htmlFontGroupPattern, text, text, 6, succeed);
            
            Assert.AreEqual(parsedtext, match.Groups["fontText"].Value);
            Assert.AreEqual(color, match.Groups["colorCode"].Value);
            Assert.AreEqual(size, match.Groups["size"].Value);
            
        }

        private Regex createRegex()
        {
            return new Regex(NiconicoWebTextPatterns.htmlFontGroupPattern);
        }
    }
}
