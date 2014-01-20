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
    public class LiveIdRegexTest
    {
        [TestMethod]
        public void CreateTest()
        {
            var regex = createRegex();

        }

        [DataTestMethod]
        [DataRow("cccclv162882011?zrou", "lv162882011",true)]
        [DataRow("ccccev162882011?zrou", "", false)]
        public void MatchTest(string text,string id,bool succeed)
        {
            RegexTestHelper.MatchTest(NiconicoWebTextPatterns.liveIdGroupPattern, text, id, 2, succeed);
        }

        [DataTestMethod]
        [DataRow("cccclv162882011?zrou_lv162882011", "lv162882011", "lv162882011")]
        public void MatchesTest(string text,string id1,string id2)
        {
            var regex = createRegex();
            var mathes = regex.Matches(text);
            Assert.AreEqual(2, mathes.Count);
            Assert.AreEqual(id1, mathes[0].Value);
            Assert.AreEqual(id2, mathes[1].Value);
            
        }

        private Regex createRegex()
        {
            return new Regex(NiconicoWebTextPatterns.liveIdGroupPattern);
        }
    }
}
