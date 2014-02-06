using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;



namespace Onds.Niconico.Data.Text
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

        public static IReadOnlyList<IReadOnlyNiconicoWebTextSegment> DivideToSegments(string text)
        {
            return segmenter.Divide(text);
        }

        internal static List<INiconicoWebTextSegment> DivideToWritableSegments(string text,INiconicoWebTextSegment parent)
        {
            return segmenter.WritablePartialDivide(text, parent);
        }

        internal IReadOnlyList<IReadOnlyNiconicoWebTextSegment> Divide(string text)
        {
            return this.PartialDivide(text, default(IReadOnlyNiconicoWebTextSegment));
        }

        internal IReadOnlyList<IReadOnlyNiconicoWebTextSegment> PartialDivide(string text, IReadOnlyNiconicoWebTextSegment parent)
        {
            var segments = new List<IReadOnlyNiconicoWebTextSegment>();

            generalDivide(segments, text, parent);
            return segments.ToArray();
        }

        internal List<INiconicoWebTextSegment> WritablePartialDivide( string text, IReadOnlyNiconicoWebTextSegment parent)
        {
            var segments = new List<INiconicoWebTextSegment>();

            generalDivide(segments, text, parent);
            return segments;
        }

        private void generalDivide<T,L>(L segments, string text, T parent)
            where T:IReadOnlyNiconicoWebTextSegment
            where L:IList
        {
            var matchIndex = 0;
            foreach (Match match in this.regex_.Matches(text))
            {
                
                if (matchIndex < match.Index)
                {
                    segments.Add(new PlainNiconicoWebTextSegment<T>(text.Substring(matchIndex, match.Index - matchIndex), parent));
                }

                segments.Add(NiconicoWebTextSegmentMatchParser.Parse<T>(match, this, parent));

                matchIndex = match.Index + match.Length;

            }


            if (matchIndex < text.Length)
            {
                segments.Add(new PlainNiconicoWebTextSegment<T>(text.Substring(matchIndex), parent));
            }
        }


        private Regex regex_;

        private readonly static NiconicoWebTextSegmenter segmenter = new NiconicoWebTextSegmenter();

    }
}
