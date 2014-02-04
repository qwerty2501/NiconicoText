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
    public class WatchPictureIdRegexTest
    {
        [TestMethod]
        public void CreateTest()
        {
            var regex = createRegex();
        }

        [DataTestMethod]
        [DataRow("sg5548845", "sg5548845", true)]
        [DataRow("sg5548845eed","",false)]
        public void MatchTest(string text,string id,bool succeed)
        {
            RegexTestHelper.IdMatchTest(NiconicoWebTextPatterns.watchPictureIdGroupPattern, text, id, 2, succeed);
        }

        private Regex createRegex()
        {
            return new Regex(NiconicoWebTextPatterns.watchPictureIdGroupPattern);
        }
    }
}
