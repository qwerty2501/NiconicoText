﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiconicoText
{
    internal sealed class HtmlInvalidElementNiconicoWebTextSegment:PlainNiconicoWebTextSegmentBase,INiconicoWebTextSegment,INiconicoTextSegment
    {
        internal HtmlInvalidElementNiconicoWebTextSegment(string text) : base(text) { }


        public new string FriendlyText
        {
            get
            {
                return string.Empty;
            }
        }

        public override NiconicoWebTextSegmentType SegmentType
        {
            get { return NiconicoWebTextSegmentType.HtmlInvalidElement; }
        }
    }
}
