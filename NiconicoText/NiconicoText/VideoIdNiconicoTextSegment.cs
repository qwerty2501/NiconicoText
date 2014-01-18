using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiconicoText
{
    internal sealed class VideoIdNiconicoTextSegment:IdNiconicoWebTextSegmentBase,INiconicoWebTextSegment
    {
        protected internal override Uri OnCreateUrlAssosiatedId()
        {
            throw new NotImplementedException();
        }
    }
}
