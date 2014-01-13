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
    public class MarketItemIdRegexTest
    {
        [TestMethod]
        public void CreateTest()
        {
            var regex = createRegex();
        }

        [DataTestMethod]
        [DataRow("ofxazB00HS2GTHQccw","azB00HS2GTHQ",true)]
        public void MatchTest(string text,string id,bool succeed)
        {
            RegexTestHelper.MatchTest(NiconicoTextPatterns.marketItemIdGroupPattern, text, id, 2, succeed);
        }


        private Regex createRegex()
        {
            return new Regex(NiconicoTextPatterns.marketItemIdGroupPattern);
        }
    }
}
