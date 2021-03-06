﻿using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
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
    public class ArticleIdRegexTest
    {
        [TestMethod]
        public void CreateTest()
        {
            var regex = createRegex();
        }

        [DataTestMethod]
        [DataRow("ar407000","ar407000",true)]
        [DataRow("ofler407000ccie", "", false)]
        public void MatchTest(string text,string id,bool succeed)
        {
            RegexTestHelper.IdMatchTest(NiconicoWebTextPatterns.articleIdGroupPattern, text, id, 2, succeed);

        }


        

        private Regex createRegex()
        {
            return new Regex(NiconicoWebTextPatterns.articleIdGroupPattern);
        }
    }
}
