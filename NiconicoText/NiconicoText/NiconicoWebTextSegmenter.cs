using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace NiconicoText
{
    /// <summary>
    /// Niconico web text parser.
    /// </summary>
    internal sealed class NiconicoWebTextSegmenter
    {
        
        /// <summary>
        /// Constructor
        /// </summary>
        internal NiconicoWebTextSegmenter()
        {
           
            this.regex_ = new Regex(NiconicoTextPatterns.niconicoTextParsePattern);
        }

        private Regex regex_;
    }
}
