using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiconicoText
{
    internal sealed class UserNameNiconicoWebTextSegment:PlainNiconicoWebTextSegmentBase,IReadOnlyNiconicoWebTextSegment,INiconicoTextSegment
    {
        internal UserNameNiconicoWebTextSegment(string userName,IReadOnlyNiconicoWebTextSegment parent) : base(userName,parent) { }

        public override NiconicoWebTextSegmentType SegmentType
        {
            get { return NiconicoWebTextSegmentType.UserName; }
        }
    }
}
