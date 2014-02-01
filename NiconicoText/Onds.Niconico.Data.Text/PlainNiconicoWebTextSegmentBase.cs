using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Onds.Niconico.Data.Text
{
    internal abstract class PlainNiconicoWebTextSegmentBase<T> : NiconicoWebTextSegmentBase<T>, IReadOnlyNiconicoWebTextSegment, INiconicoTextSegment
        where T : IReadOnlyNiconicoWebTextSegment
    {
        internal PlainNiconicoWebTextSegmentBase(string text,T parent):base(parent)
        {
            this.text_ = text;
        }

        internal protected string text_;

        public override string Text
        {
            get
            {
                return this.text_;
            }
        }

        public override string ToString()
        {
            return this.text_;
        }
    }
}
