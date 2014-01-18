using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiconicoText
{
    internal abstract class PlainNiconicoWebTextSegmentBase : NiconicoWebTextSegmentBase, INiconicoWebTextSegment
    {
        internal PlainNiconicoWebTextSegmentBase(string text)
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

        public new string FriendlyText
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
