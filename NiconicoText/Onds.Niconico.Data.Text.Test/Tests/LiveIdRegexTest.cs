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
    public class LiveIdRegexTest
    {
        [TestMethod]
        public void CreateTest()
        {
            var regex = createRegex();

        }

        [DataTestMethod]
        [DataRow("テストlv162882011?zrou", "lv162882011",true)]
        [DataRow("ccccelv162882011?zrou", "", false)]
        public void MatchTest(string text,string id,bool succeed)
        {
            RegexTestHelper.IdMatchTest(NiconicoWebTextPatterns.liveIdGroupPattern, text, id, 2, succeed);
        }

        [DataTestMethod]
        [DataRow("テストlv162882011?zrou_lv162882011", "lv162882011", "lv162882011")]
        public void MatchesTest(string text,string id1,string id2)
        {
            var regex = createRegex();
            var mathes = regex.Matches(text);
            Assert.AreEqual(2, mathes.Count);

            var match1 = mathes[0];
            var match2 = mathes[1];
            Assert.AreEqual(id1, match1.Groups[1].Value);
            Assert.AreEqual(id2, match2.Groups[1].Value);
            
        }

        private Regex createRegex()
        {
            return new Regex(NiconicoWebTextPatterns.liveIdGroupPattern);
        }
    }
}
