using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiconicoText
{
    internal abstract class PlainNiconicoWebTextSegmentBase : NiconicoWebTextSegmentBase,INiconicoWebTextSegment
    {
        internal PlainNiconicoWebTextSegmentBase(string text)
        {
            this.text_ = text;
        }

        private string text_;

        public new string Text
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
    }
}
