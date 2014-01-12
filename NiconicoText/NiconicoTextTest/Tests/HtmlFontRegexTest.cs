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
        [DataRow(@"<font color=""#FFCCDD"">testmessage</font>","testmessage",@"#FFCCDD","")]
        public void MatcheTest(string text,string parsedtext,string color,string size)
        {
            var regex = createRegex();
            var match = regex.Match(text);

            Assert.AreEqual(parsedtext, match.Groups["fontText"].Value);
            Assert.AreEqual(color, match.Groups["color"].Value);
            Assert.AreEqual(size, match.Groups["size"].Value);
            
        }

        private Regex createRegex()
        {
            return new Regex(NiconicoTextPatterns.htmlFontGroupPattern);
        }
    }
}
