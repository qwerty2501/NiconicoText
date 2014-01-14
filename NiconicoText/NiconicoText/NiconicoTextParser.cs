using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace NiconicoText
{
    public sealed class NiconicoTextParser
    {
        

        public NiconicoTextParser()
        {
           
            this.regex_ = new Regex(NiconicoTextPatterns.niconicoTextParsePattern);
        }

        private Regex regex_;
    }
}
