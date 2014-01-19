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
    public class StillImageIdRegexTest
    {
        [TestMethod]
        public void CreateTest()
        {
            var regex = creteRegex();
        }

        [DataTestMethod]
        [DataRow("ceewim14567522565ccew","im14567522565",true)]
        public void MatchTest(string text,string id,bool succeed)
        {
            RegexTestHelper.MatchTest(NiconicoTextPatterns.watchPictureIdGroupPattern, text, id, 2, succeed);
        }

        private Regex creteRegex()
        {
            return new Regex(NiconicoTextPatterns.watchPictureIdGroupPattern);
        }
    }
}
