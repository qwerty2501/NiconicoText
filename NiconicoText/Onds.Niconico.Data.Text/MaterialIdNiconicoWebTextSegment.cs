using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Onds.Niconico.Data.Text
{
    internal sealed class MaterialIdNiconicoWebTextSegment<T>:IdNiconicoWebTextSegmentBase<T>,IReadOnlyNiconicoWebTextSegment
        where T : IReadOnlyNiconicoWebTextSegment
    {
        internal MaterialIdNiconicoWebTextSegment(string materialId, T parent) : base(materialId,parent) { }

        public override NiconicoWebTextSegmentType SegmentType
        {
            get { return NiconicoWebTextSegmentType.MaterialId; }
        }

        internal static IReadOnlyNiconicoWebTextSegment ParseWebText(System.Text.RegularExpressions.Match match, NiconicoWebTextSegmenter segmenter, T parent)
        {
            return new MaterialIdNiconicoWebTextSegment<T>(match.Groups[NiconicoWebTextPatternIndexs.materialIdGroupNumber].Value,parent);
        }
    }
}
