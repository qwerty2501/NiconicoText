using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Onds.Niconico.Data.Text
{
    /// <summary>
    /// A Segment of Niconico web text.
    /// </summary>
    public interface INiconicoWebTextSegment:IReadOnlyNiconicoWebTextSegment,INiconicoTextSegment
    {

        /// <summary>
        /// children segments of this text segment.
        /// </summary>
        new INiconicoWebTextSegmentCollection Segments { get; }

        /// <summary>
        /// Parent of this segment.
        /// </summary>
        new INiconicoWebTextSegment Parent { get; }

        /// <summary>
        /// Root text of this segment.
        /// </summary>
        new INiconicoWebText Root { get; }

        /// <summary>
        /// Imports a text.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <returns>The imported segments</returns>
        IReadOnlyList<INiconicoWebTextSegment> ImportText(string text);

        /// <summary>
        /// Insert a text.Before referenceSegment. 
        /// </summary>
        /// <param name="text">The text.</param>
        /// <param name="referenceSegment">The reference node.</param>
        /// <returns>The Inserted segments.</returns>
        IReadOnlyList<INiconicoWebTextSegment> InsertTextBefore(string text, INiconicoWebTextSegment referenceSegment);

        /// <summary>
        /// Imports a segment from another text to this segment.
        /// </summary>
        /// <param name="newSegment">The segment to be cloned.</param>
        /// <returns>The imported segment.</returns>
        INiconicoWebTextSegment ImportSegment(IReadOnlyNiconicoWebTextSegment newSegment);

        /// <summary>
        /// Inserts a segment from another text to this segment.Before referenceSegment.
        /// </summary>
        /// <param name="newSemgment">The segment to be cloned.</param>
        /// <param name="referenceSegment">The reference node.</param>
        /// <returns>The Inserted segment.</returns>
        INiconicoWebTextSegment InsertSegmentBefore(IReadOnlyNiconicoWebTextSegment newSemgment, INiconicoWebTextSegment referenceSegment);


        /// <summary>
        /// Removes the segment from childlen.
        /// </summary>
        /// <param name="semgent">The to be removed segment.</param>
        /// <returns>The Removed segment.</returns>
        INiconicoWebTextSegment RemoveChildSegment(INiconicoWebTextSegment semgent);
    }
}
