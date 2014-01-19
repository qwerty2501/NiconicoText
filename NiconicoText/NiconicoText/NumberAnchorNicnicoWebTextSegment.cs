using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiconicoText
{
    internal sealed class NumberAnchorNicnicoWebTextSegment:NiconicoWebTextSegmentBase,INiconicoWebTextSegment,INiconicoTextSegment
    {
        internal NumberAnchorNicnicoWebTextSegment(NiconicoWebTextNumberAnchorRange range)
        {
            this.range_ = range;
            this.rangeCash_ = null;
        }

        public override NiconicoWebTextSegmentType SegmentType
        {
            get { return NiconicoWebTextSegmentType.NumberAnchor; }
        }

        public override string Text
        {
            get 
            {
                if (this.rangeCash_ == null)
                {
                    this.rangeCash_ = this.ToString();
                }

                return this.rangeCash_;


            }
        }

        public override string ToString()
        {
            if (this.range_.EndNumber > 0)
            {
                return string.Concat(">>", this.range_.StartNumber, "-", this.range_.EndNumber);
            }
            else
            {
                return string.Concat(">>", this.range_.StartNumber);
            }
        }

        private NiconicoWebTextNumberAnchorRange range_;

        private string rangeCash_;
    }
}
