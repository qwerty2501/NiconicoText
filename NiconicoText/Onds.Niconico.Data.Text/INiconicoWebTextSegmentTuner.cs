using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onds.Niconico.Data.Text
{
    internal interface INiconicoWebTextSegmentTuner:INiconicoWebTextSegment,IReadOnlyNiconicoWebTextSegment,INiconicoTextSegment
    {
        new NiconicoWebTextSegmentCollection Segments { get; set; }


    }
}
