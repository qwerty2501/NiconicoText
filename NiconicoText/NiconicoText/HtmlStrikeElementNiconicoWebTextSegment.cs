﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiconicoText
{
    internal sealed class HtmlStrikeElementNiconicoWebTextSegment:SegmentsProsessionNiconicoWebTextSegmentBase,INiconicoWebTextSegment,INiconicoTextSegment
    {
        internal HtmlStrikeElementNiconicoWebTextSegment(INiconicoWebTextSegmentCollection segments) : base(segments) { }

        public new bool AssociatedStrike
        {
            get { return true; }
        }

        public override string Text
        {
            get
            {
                return string.Concat("<s>", base.Text, "</s>");
            }
        }

        public override NiconicoWebTextSegmentType SegmentType
        {
            get { return NiconicoWebTextSegmentType.HtmlStrikeElement; }
        }
    }
}
