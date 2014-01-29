using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Onds.Niconico.Data.Text
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
