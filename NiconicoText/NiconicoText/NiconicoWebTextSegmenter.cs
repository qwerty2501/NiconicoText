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
    public sealed class NiconicoWebTextSegmenter
    {
        
        /// <summary>
        /// Constructor
        /// </summary>
        public NiconicoWebTextSegmenter()
        {
           
            this.regex_ = new Regex(NiconicoWebTextPatterns.niconicoTextParsePattern);
        }

        public INiconicoWebTextSegmentCollection GetTokens(string text)
        {
            return this.GetTokensInternal(text);
        }

        internal NiconicoWebTextSegmentCollection GetTokensInternal(string text)
        {
            var segments = new NiconicoWebTextSegmentCollection();



            return segments;
        }

        private Regex regex_;


    }
}
