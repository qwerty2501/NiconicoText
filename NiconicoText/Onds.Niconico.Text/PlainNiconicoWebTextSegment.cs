using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onds.Niconico.Text
{
    internal sealed class PlainNiconicoWebTextSegment:PlainNiconicoWebTextSegmentBase,IReadOnlyNiconicoWebTextSegment
    {
        internal PlainNiconicoWebTextSegment(string text, IReadOnlyNiconicoWebTextSegment parent) : base(text,parent) { }

        public override NiconicoWebTextSegmentType SegmentType
        {
            get
            {
                return NiconicoWebTextSegmentType.Plain;
            }
        }
    }
}
