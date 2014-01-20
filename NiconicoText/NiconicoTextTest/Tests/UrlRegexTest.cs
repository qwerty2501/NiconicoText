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
    public class UrlRegexTest
    {
        [TestMethod]
        public void CreateTest()
        {
            var regex = createRegex();
        }

        [DataTestMethod]
        [DataRow("http://www.nicovideo.jp/watch/1360359142","http://www.nicovideo.jp/watch/1360359142",true)]
        public void MatchTest(string text,string id,bool succeed)
        {
            RegexTestHelper.MatchTest(NiconicoWebTextPatterns.urlGroupPattern, text, id, 2, succeed);
        }

        private Regex createRegex()
        {
            return new Regex(NiconicoWebTextPatterns.urlGroupPattern);
        }
    }
}
