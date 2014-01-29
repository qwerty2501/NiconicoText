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
            RegexTestHelper.MatchTest(NiconicoWebTextPatterns.marketItemIdGroupPattern, text, id, 2, succeed);
        }


        private Regex createRegex()
        {
            return new Regex(NiconicoWebTextPatterns.marketItemIdGroupPattern);
        }
    }
}
