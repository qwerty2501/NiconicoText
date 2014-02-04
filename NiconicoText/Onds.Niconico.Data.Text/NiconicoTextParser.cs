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
    public static class NiconicoTextParser
    {
        /// <summary>
        /// Parse from web text.
        /// </summary>
        /// <param name="text">Plain Niconico web text.</param>
        /// <returns>Parsed text.</returns>
        public static ReadOnlyNiconicoWebText ParseWebText(string text)
        {
            var segments =  NiconicoWebTextSegmenter.DivideToSegments(text);
            var readOnlyText = new ReadOnlyNiconicoWebText();
            readOnlyText.Segments = segments;
            return readOnlyText;
        }

    }
}
