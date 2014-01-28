using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;



namespace Onds.Niconico.Text
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
           
            this.regex_ = new Regex(NiconicoWebTextPatterns.niconicoWebTextParsePattern);
        }

        public static IReadOnlyList<IReadOnlyNiconicoWebTextSegment> DivideToSegments(string text)
        {
            return segmenter.Divide(text);
        }

        internal IReadOnlyList<IReadOnlyNiconicoWebTextSegment> Divide(string text)
        {
            return this.PartialDivide(text, null);
        }

        internal IReadOnlyList<IReadOnlyNiconicoWebTextSegment> PartialDivide(string text,IReadOnlyNiconicoWebTextSegment parent)
        {
            var segments = new List<IReadOnlyNiconicoWebTextSegment>();
            int matchIndex = 0;
            foreach(Match match in this.regex_.Matches(text))
            {
                
                if (matchIndex < match.Index)
                {
                    segments.Add(new PlainNiconicoWebTextSegment(text.Substring(matchIndex, match.Index - matchIndex),parent));
                }

                segments.Add(NiconicoWebTextSegmentMatchParser.Parse(match, this,parent));

                matchIndex = match.Index + match.Length;
               
            }


            if (matchIndex < text.Length)
            {
                segments.Add(new PlainNiconicoWebTextSegment(text.Substring(matchIndex),parent));
            }

            return segments.ToArray();
        }

        private Regex regex_;

        private static NiconicoWebTextSegmenter segmenter = new NiconicoWebTextSegmenter();

    }
}
