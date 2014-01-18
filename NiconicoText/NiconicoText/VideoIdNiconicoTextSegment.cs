using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiconicoText
{
    internal sealed class VideoIdNiconicoTextSegment:IdNiconicoWebTextSegmentBase,INiconicoWebTextSegment
    {
        internal VideoIdNiconicoTextSegment(string id) : base(id) { }

        protected internal override Uri OnCreateUrl()
        {
            throw new NotImplementedException();
        }
    }
}
