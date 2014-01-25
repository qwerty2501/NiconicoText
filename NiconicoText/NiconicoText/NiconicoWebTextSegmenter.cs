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
        public NiconicoWebTextSegmenter()
        {
           
            this.regex_ = new Regex(NiconicoWebTextPatterns.niconicoWebTextParsePattern);
        }



        internal IReadOnlyList<IReadOnlyNiconicoWebTextSegment> GetSegments(string text)
        {
            var segments = new List<IReadOnlyNiconicoWebTextSegment>();
            int matchIndex = 0;
            foreach(Match match in this.regex_.Matches(text))
            {
                
                if (matchIndex < match.Index)
                {
                    segments.Add(new PlainNiconicoWebTextSegment(text.Substring(matchIndex, match.Index - matchIndex)));
                }

                segments.Add(NiconicoWebTextSegmentMatchParser.Parse(match, this));

                matchIndex = match.Index + match.Length;
               
            }


            if (matchIndex < text.Length)
            {
                segments.Add(new PlainNiconicoWebTextSegment(text.Substring(matchIndex)));
            }

            return segments.ToArray();
        }

        private Regex regex_;


    }
}
