using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;


namespace Onds.Niconico.Data.Text
{
    internal sealed class NumberAnchorNiconicoWebTextSegment<T>:NiconicoWebTextSegmentBase<T>,IReadOnlyNiconicoWebTextSegment,INiconicoTextSegment
        where T:IReadOnlyNiconicoWebTextSegment
    {
        internal NumberAnchorNiconicoWebTextSegment(NiconicoWebTextNumberAnchorRange range, T parent):base(parent)
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

        internal static NumberAnchorNiconicoWebTextSegment<IReadOnlyNiconicoWebTextSegment> ParseWebText(System.Text.RegularExpressions.Match match, NiconicoWebTextSegmenter segmenter, IReadOnlyNiconicoWebTextSegment parent)
        {
            return new NumberAnchorNiconicoWebTextSegment<IReadOnlyNiconicoWebTextSegment>(ParseRange(match), parent);   
        }

        internal static NiconicoWebTextNumberAnchorRange ParseRange(Match match)
        {
            var endGroup = match.Groups[NiconicoWebTextPatternIndexs.endNumberAnchorGroupNumber];
            var startGroup = match.Groups[NiconicoWebTextPatternIndexs.startNumberAnchorGroupNumber];
            if (endGroup.Success)
            {
                return new NiconicoWebTextNumberAnchorRange { StartNumber = int.Parse(startGroup.Value), EndNumber = int.Parse(endGroup.Value) };
            }
            else
            {
                return new NiconicoWebTextNumberAnchorRange { StartNumber = int.Parse(startGroup.Value) };
            }
        }
    }
}
