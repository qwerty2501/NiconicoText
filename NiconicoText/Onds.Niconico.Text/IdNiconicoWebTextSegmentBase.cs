using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onds.Niconico.Text
{
    internal abstract class IdNiconicoWebTextSegmentBase:PlainNiconicoWebTextSegmentBase
    {
        internal IdNiconicoWebTextSegmentBase(string id,IReadOnlyNiconicoWebTextSegment parent): base(id,parent) { }



    }
}
