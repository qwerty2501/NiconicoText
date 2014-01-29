using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onds.Niconico.Data.Text
{
    /// <summary>
    /// Niconico Text Segmenter
    /// </summary>
    public static class NiconicoTextSegmenter
    {
        /// <summary>
        /// Divide to web text.
        /// </summary>
        /// <param name="text">text</param>
        /// <returns>divided text segments.</returns>
        public static IReadOnlyCollection<IReadOnlyNiconicoWebTextSegment> DivideToWebTextSegments(string text)
        {
            return NiconicoWebTextSegmenter.DivideToSegments(text);
        }

    }
}
