using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Onds.Niconico.Data.Text
{
    internal abstract class IdNiconicoWebTextSegmentBase:PlainNiconicoWebTextSegmentBase
    {
        internal IdNiconicoWebTextSegmentBase(string id,IReadOnlyNiconicoWebTextSegment parent): base(id,parent) { }



    }
}
