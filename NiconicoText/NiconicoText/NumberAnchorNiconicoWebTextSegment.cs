using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiconicoText
{
    internal sealed class NumberAnchorNiconicoWebTextSegment:NiconicoWebTextSegmentBase,IReadOnlyNiconicoWebTextSegment,INiconicoTextSegment
    {
        internal NumberAnchorNiconicoWebTextSegment(NiconicoWebTextNumberAnchorRange range)
        {
            this.NumberAnchor = range;
            this.rangeCash_ = null;
        }

        public new bool HasNumberAnchor
        {
            get
            {
                return true;
            }
        }

        public new NiconicoWebTextNumberAnchorRange NumberAnchor
        {
            get;
            private set;
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
                    if (this.NumberAnchor.EndNumber > 0)
                    {
                        this.rangeCash_ = string.Concat(">>", this.NumberAnchor.StartNumber, "-", this.NumberAnchor.EndNumber);
                    }
                    else
                    {
                        this.rangeCash_ = string.Concat(">>", this.NumberAnchor.StartNumber);
                    }
                }

                return this.rangeCash_;


            }
        }


        private string rangeCash_;

        internal static IReadOnlyNiconicoWebTextSegment ParseWebText(System.Text.RegularExpressions.Match match, NiconicoWebTextSegmenter segmenter)
        {
            var secondGroup = match.Groups[NiconicoWebTextPatternIndexs.endNumberAnchorGroupNumber];

            if(secondGroup.Success)
            {
                return new NumberAnchorNiconicoWebTextSegment(new NiconicoWebTextNumberAnchorRange { StartNumber = int.Parse(match.Groups[NiconicoWebTextPatternIndexs.startNumberAnchorGroupNumber].Value), EndNumber = int.Parse(secondGroup.Value) });
            }
            else
            {
                return new NumberAnchorNiconicoWebTextSegment(new NiconicoWebTextNumberAnchorRange { StartNumber = int.Parse(match.Groups[NiconicoWebTextPatternIndexs.startNumberAnchorGroupNumber].Value) });
            }

            
        }
    }
}
