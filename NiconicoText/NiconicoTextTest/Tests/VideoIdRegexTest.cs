using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using System.Text.RegularExpressions;
using NiconicoText;

namespace NiconicoTextTest.Tests
{
    [TestClass]
    public class VideoIdRegexTest
    {
        [TestMethod]
        public void CreateTest()
        {
            var videoIdRegex = new Regex(NiconicoTextPatterns.videoIdGroupPattern);
        }
    }
}
