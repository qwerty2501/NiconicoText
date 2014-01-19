using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiconicoText
{
    internal sealed class NumberAnchorNiconicoWebTextSegment:NiconicoWebTextSegmentBase,INiconicoWebTextSegment,INiconicoTextSegment
    {
        internal NumberAnchorNiconicoWebTextSegment(NiconicoWebTextNumberAnchorRange range)
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

        internal static INiconicoWebTextSegment ParseWebText(System.Text.RegularExpressions.Match match, NiconicoWebTextSegmenter segmenter)
        {
            var secondGroup = match.Groups[NiconicoWebTextPatterns.secondAnchorGroupNumber];

            if(secondGroup.Success)
            {
                return new NumberAnchorNiconicoWebTextSegment(new NiconicoWebTextNumberAnchorRange { StartNumber = int.Parse(match.Groups[NiconicoWebTextPatterns.firstAnchorGroupNumber].Value), EndNumber = int.Parse(secondGroup.Value) });
            }
            else
            {
                return new NumberAnchorNiconicoWebTextSegment(new NiconicoWebTextNumberAnchorRange { StartNumber = int.Parse(match.Groups[NiconicoWebTextPatterns.firstAnchorGroupNumber].Value) });
            }

            
        }
    }
}
