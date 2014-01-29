using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Onds.Niconico.Data.Text
{
    internal sealed class MaterialIdNiconicoWebTextSegment:IdNiconicoWebTextSegmentBase,IReadOnlyNiconicoWebTextSegment
    {
        internal MaterialIdNiconicoWebTextSegment(string materialId, IReadOnlyNiconicoWebTextSegment parent) : base(materialId,parent) { }

        public override NiconicoWebTextSegmentType SegmentType
        {
            get { return NiconicoWebTextSegmentType.MaterialId; }
        }

        internal static IReadOnlyNiconicoWebTextSegment ParseWebText(System.Text.RegularExpressions.Match match, NiconicoWebTextSegmenter segmenter, IReadOnlyNiconicoWebTextSegment parent)
        {
            return new MaterialIdNiconicoWebTextSegment(match.Groups[NiconicoWebTextPatternIndexs.materialIdGroupNumber].Value,parent);
        }
    }
}
