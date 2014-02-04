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
    public class PictureIdRegexTest
    {
        [TestMethod]
        public void CreateTest()
        {
            var regex = creteRegex();
        }

        [DataTestMethod]
        [DataRow("/im14567522565/", "im14567522565", true)]
        [DataRow("ceewim14567522565ccew","",false)]
        public void MatchTest(string text,string id,bool succeed)
        {
            RegexTestHelper.IdMatchTest(NiconicoWebTextPatterns.watchPictureIdGroupPattern, text, id, 2, succeed);
        }

        private Regex creteRegex()
        {
            return new Regex(NiconicoWebTextPatterns.watchPictureIdGroupPattern);
        }
    }
}
