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
    public class StillImageIdRegexTest
    {
        [TestMethod]
        public void CreateTest()
        {
            var regex = creteRegex();
        }

        private Regex creteRegex()
        {
            return new Regex(NiconicoTextPatterns.stillImageIdGroupPattern);
        }
    }
}