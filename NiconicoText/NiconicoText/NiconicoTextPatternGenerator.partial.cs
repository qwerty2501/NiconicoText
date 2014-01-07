using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiconicoText
{
    partial class  NiconicoTextPatternGenerator2
    {
        internal NiconicoTextPatternGenerator(string patternName, string pattern)
        {
            this.PatternName = patternName;
            this.Pattern = pattern;
        }

        internal string PatternName { get; private set; }

        internal string Pattern { get; private set; }
    }
}
