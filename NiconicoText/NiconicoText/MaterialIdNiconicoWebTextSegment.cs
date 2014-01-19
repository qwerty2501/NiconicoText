using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiconicoText
{
    internal sealed class MaterialIdNiconicoWebTextSegment:IdNiconicoWebTextSegmentBase,INiconicoWebTextSegment
    {
        internal MaterialIdNiconicoWebTextSegment(string materialId) : base(materialId) { }

        public override NiconicoWebTextSegmentType SegmentType
        {
            get { return NiconicoWebTextSegmentType.MaterialId; }
        }
    }
}
