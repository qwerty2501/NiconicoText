using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Onds.Niconico.Data.Text
{
    internal sealed class UserNameNiconicoWebTextSegment<T>:PlainNiconicoWebTextSegmentBase<T>,IReadOnlyNiconicoWebTextSegment,INiconicoTextSegment
        where T:IReadOnlyNiconicoWebTextSegment
    {
        internal UserNameNiconicoWebTextSegment(string userName,T parent) : base(userName,parent) { }

        public override NiconicoWebTextSegmentType SegmentType
        {
            get { return NiconicoWebTextSegmentType.UserName; }
        }
    }
}
