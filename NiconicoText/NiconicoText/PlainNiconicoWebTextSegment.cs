using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiconicoText
{
    internal sealed class PlainNiconicoWebTextSegment:PlainNiconicoWebTextSegmentBase,INiconicoWebTextSegment
    {
        internal PlainNiconicoWebTextSegment(string text) : base(text) { }

        public override NiconicoWebTextSegmentType SegmentType
        {
            get
            {
                return NiconicoWebTextSegmentType.Plain;
            }
        }
    }
}
