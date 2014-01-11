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
    public class HtmlBoldRegexTest
    {
        [TestMethod]
        public void CreateTest()
        {

        }

        private Regex createRegex()
        {
            return new Regex(NiconicoTextPatterns.htmlBoldGroupPattern);
        }
    }
}
