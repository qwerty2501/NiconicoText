using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Onds.Niconico.Data.Text
{
    internal sealed class PlainNiconicoWebTextSegment<T>:PlainNiconicoWebTextSegmentBase<T>,IReadOnlyNiconicoWebTextSegment
        where T:IReadOnlyNiconicoWebTextSegment
    {
        internal PlainNiconicoWebTextSegment(string text, T parent) : base(text,parent) { }

        public override NiconicoWebTextSegmentType SegmentType
        {
            get
            {
                return NiconicoWebTextSegmentType.Plain;
            }
        }
    }
}
