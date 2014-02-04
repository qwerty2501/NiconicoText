using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Onds.Niconico.Data.Text.Test.Tests
{
    internal static class RegexTestHelper
    {
        internal static Match MatchTest(string pattern, string text, string expected,int groupCount, bool success)
        {

            var regex = new Regex(pattern);
            var match = regex.Match(text);
            Assert.AreEqual(success, match.Success);

            if (success)
            {
                Assert.AreEqual(groupCount, match.Groups.Count);
                Assert.AreEqual(expected, match.Value);
            }

            return match;
        }


        internal static Match IdMatchTest(string pattern, string text, string expected, int groupCount, bool success)
        {

            var regex = new Regex(pattern);
            var match = regex.Match(text);
            Assert.AreEqual(success, match.Success);

            if (success)
            {
                Assert.AreEqual(groupCount, match.Groups.Count);
                Assert.AreEqual(expected, match.Groups[1].Value);
            }

            return match;
        } 
    }
}
