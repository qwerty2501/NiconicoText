using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Onds.Niconico.Data.Text
{
    internal abstract class IdNiconicoWebTextSegmentBase<T>:PlainNiconicoWebTextSegmentBase<T>
        where T : IReadOnlyNiconicoWebTextSegment
    {
        internal IdNiconicoWebTextSegmentBase(string id,T parent): base(id,parent) { }



    }
}
