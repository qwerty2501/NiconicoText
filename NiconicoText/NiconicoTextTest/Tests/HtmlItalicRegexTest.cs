﻿using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
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
    public class HtmlItalicRegexTest
    {
        [TestMethod]
        public void CreateTest()
        {
            var regex = createRegex();
        }

        
        public void MatchTest()
        {
            var regex = createRegex();


        }

        private Regex createRegex()
        {
            return new Regex(NiconicoTextPatterns.htmlItalicGroupPattern);
        }
    }
}
