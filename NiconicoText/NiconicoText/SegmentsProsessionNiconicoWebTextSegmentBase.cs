﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiconicoText
{
    internal abstract class SegmentsProsessionNiconicoWebTextSegmentBase:NiconicoWebTextSegmentBase,IReadOnlyNiconicoWebTextSegment,INiconicoTextSegment
    {
        internal SegmentsProsessionNiconicoWebTextSegmentBase(IReadOnlyList<IReadOnlyNiconicoWebTextSegment> segments, IReadOnlyNiconicoWebTextSegment parent):base(parent)
        {
            this.Segments = segments;
        }

        public new bool HasSegments
        {
            get
            {
                return true;
            }
        }


        public new IReadOnlyList<IReadOnlyNiconicoWebTextSegment> Segments
        {
            get;
            private set;
        }

        public override string Text
        {
            get
            {
                return this.Segments.ToText();
            }
        }

        public new string FriendlyText
        {
            get
            {
                return this.Segments.ToFriendlyText();
            }
        }



    }
}
