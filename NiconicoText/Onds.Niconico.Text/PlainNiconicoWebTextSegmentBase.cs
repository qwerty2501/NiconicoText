﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Onds.Niconico.Text
{
    internal abstract class PlainNiconicoWebTextSegmentBase : NiconicoWebTextSegmentBase, IReadOnlyNiconicoWebTextSegment, INiconicoTextSegment
    {
        internal PlainNiconicoWebTextSegmentBase(string text,IReadOnlyNiconicoWebTextSegment parent):base(parent)
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

        public override string ToString()
        {
            return this.text_;
        }
    }
}