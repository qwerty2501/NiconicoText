﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NiconicoText
{
    internal sealed class HtmlBoldNiconicoWebTextSegment:SegmentsProsessionNiconicoWebTextSegmentBase,INiconicoWebTextSegment,INiconicoTextSegment
    {
        internal HtmlBoldNiconicoWebTextSegment(INiconicoWebTextSegmentCollection segments) : base(segments) { }

        public new bool DecoratedBold
        {
            get
            {
                return true;
            }
        }

        public override string Text
        {
            get
            {
                return string.Concat("<b>", base.Text, "</b>");
            }
        }

        public override NiconicoWebTextSegmentType SegmentType
        {
            get { return NiconicoWebTextSegmentType.HtmlBoldElement; }
        }
    }
}
